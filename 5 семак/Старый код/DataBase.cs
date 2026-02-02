



// dotnet add package MySql.Data
using MySql.Data.MySqlClient;

using System.Text.RegularExpressions;


class DataBase: IDisposable{
    /// Одиночка для работы с БД
    public static DataBase SinglDataBase;

    /// <summary> Создание одиночки </summary>
    static DataBase()
    {
        /*
        ApplicationConfiguration.Initialize();

        var input_form = new LoginForm();
        Application.Run(input_form);

        if (input_form.login == null || input_form.password == null){
            MessageBox.Show("Вы не ввели логин или пароль", "Вы не ввели данные");
            Environment.Exit(0);
        }
        SinglDataBase = new DataBase(input_form.login, input_form.password); 
        */
        SinglDataBase = new DataBase("root", "123oihoihtfr43fe"); 
    }

    /// <summary> Подключение к БД </summary>
    public MySqlConnection connection; 

    /// <summary> Подключаемся к БД и проверяем что есть БД Lily </summary>
    protected DataBase(string user, string password){
        // Сервер с БД
        string server = "localhost";
        // Название БД
        string student = "restaurants";
        try{
            this.connection = new MySqlConnection($"Server={server};Database={student};User ID={user};Password={password};");
            // Открываем подключение к БД
            this.connection.Open();
        }
        catch{
            MessageBox.Show("Не удалось подключится к БД", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }

    /// <summary> Проверка на наличии SQL инъекций </summary>
    /// <param name="check_string"> Строка для проверки </param>
    public static void SheckSQLIniection(params string?[] strings){
        /*
            Данные для проверки:
            авааа
            ihoho
            fejiршгрр98ihoih
            myemail@gmail.com
            Заказ №1002

            ihoho;
            mye@mail@gmail.com
            (ihoho)
            ihoho or 1=1;
            ihoho--
            ihoho/*
            //ihoho

            Регулярка:
            [\w\sа-я\.№]* 
            [@]{0,1}
            [\w\sа-я\.№]*

            ^([\w\sа-я\.№]*[@]{0,1}[\w\sа-я\.№]*)$
        */

        string pattern = @"^([\w\sа-я\.№]*[@]{0,1}[\w\sа-я\.№]*)$"; 
        bool flag = false;

        Parallel.ForEach(strings, (chec_str, pls) => {
            if(chec_str == null){ return; }

            if(Regex.IsMatch(chec_str.ToLower(), pattern)){ return; }
            pls.Stop();
            flag = true;
        });

        if (flag){ throw new SQLInjection(); }
    }

    /// <summary> 1) Список ресторанов с их адресами и временем работы </summary>
    public async Task<List<RestarantsWithSchedule>> GetRestarantsWithSchedule(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT
                    name, address, time_monday, time_tuesday,
                    time_wednesday, time_thursday, time_friday,
                    time_saturday, time_sunday
                FROM restaurants
                    JOIN schedule 
                    ON restaurants.id_schedule = schedule.id
                    LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<RestarantsWithSchedule> res = [];

        while (reader.Read()){
            res.Add( new RestarantsWithSchedule(){
                Name = (string)reader["name"], 
                Address = (string)reader["address"], 
                
                TimeMonday = reader.GetStringNull("time_monday"),
                TimeTuesday = reader.GetStringNull("time_tuesday"), 
                TimeWednesday = reader.GetStringNull("time_wednesday"),
                TimeThursday = reader.GetStringNull("time_thursday"), 
                TimeFriday = reader.GetStringNull("time_friday"), 
                TimeSaturday = reader.GetStringNull("time_saturday"),
                TimeSunday = reader.GetStringNull("time_sunday")
            });
        }
        return res;
    }

    /// <summary> 2) Список доступных блюд в ресторане </summary>
    public async Task<List<DishInRestarant>> GetDishesFromRestorant(ulong id_restaurant, ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{

            using var command = new MySqlCommand("""
                SELECT 
                    range_dishes.name, `describe`, for_children,
                    cost, weight, in_stock

                FROM menu_item
                    JOIN range_dishes
                    ON range_dishes.id = id_range_dishes

                    JOIN restaurants 
                    ON restaurants.id = menu_item.id_restaurants

                    WHERE restaurants.id = @NameRestorant AND in_stock

                    LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NameRestorant", id_restaurant);
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<DishInRestarant> res = [];

        while (reader.Read()){
            res.Add( new DishInRestarant(){
                Name = reader.GetString("name"), 
                Describe = reader.GetStringNull("describe"), 
                ForChildren = reader.GetBoolNull("for_children"), 

                Cost = reader.GetInt32("cost"),
                Weight = reader.GetInt32Null("weight"), 
                InStock = reader.GetBoolNull("in_stock") 
            });
        }
        return res;
    }

    /// <summary> 3) Список заказов клиента </summary>
    public async Task<List<ClientsOrders>> GetClientsOrders(string client_email, ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            SheckSQLIniection(client_email);

            using var command = new MySqlCommand("""
                SELECT 
                    orders.name, state, date
                FROM orders
                    JOIN clients
                    ON orders.id_clients = clients.id

                    WHERE clients.email = @ClientEmail

                    LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@ClientEmail", client_email);
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<ClientsOrders> res = [];

        while (reader.Read()){
            res.Add( new ClientsOrders(){
                Name = reader.GetStringNull("name"),
                State = reader.GetBoolNull("state"),
                Date = reader.GetDateOnly("date")
            });
        }
        return res;
    }

    /// <summary> 4) Список популярных блюд </summary>
    public async Task<List<(string, long)>> GetPopularDishes(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT range_dishes.name, COUNT(*) AS count_ord FROM order_dish
                    JOIN menu_item
                    ON id_menu_item = menu_item.id

                    JOIN range_dishes
                    ON id_range_dishes = range_dishes.id

                    GROUP BY range_dishes.name
                    ORDER BY count_ord DESC
                    LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string, long)> res = [];

        while (reader.Read()){
            res.Add(( reader.GetString("name"), reader.GetInt64("count_ord") ));
        }
        return res;
    }

    /// <summary> 5) Общая выручка за поледнию неделю </summary>
    public async Task<long?> GetProfit(string restaurant_name){
        Task<MySqlDataReader> command = Task.Run(() =>{
            SheckSQLIniection(restaurant_name);
            using var command = new MySqlCommand("""
                SELECT SUM(cost) FROM order_dish
                    JOIN menu_item  
                    ON order_dish.id_menu_item = menu_item.id

                    JOIN orders 
                    ON order_dish.id_orders = orders.id  

                    JOIN restaurants 
                    ON menu_item.id_restaurants = restaurants.id

                    WHERE 
                        date >= DATE_SUB(CURDATE(), INTERVAL 1 WEEK) 
                    AND 
                        restaurants.name = @RestaurantName
                """, this.connection
            );
            command.Parameters.AddWithValue("@RestaurantName", restaurant_name);
            return command.ExecuteReader();
        });
        using var reader = await command;
        reader.Read();

        return reader.GetInt64Null("SUM(cost)");
    }

    /// <summary> 6) Найти официантов которые работают в Уголок вкуса </summary>
    public async Task<List<WorkersInRestaurant>> GetWorkersInRestaurant(
        string restaurant_name = "Уголок вкуса", string position_name = "Официант", 
        ulong NimberFirstRecord = 0, ulong CountRecord = 100
    ){
        Task<MySqlDataReader> command = Task.Run(() =>{
            SheckSQLIniection(restaurant_name, position_name);

            using var command = new MySqlCommand("""
                SELECT 
                    workers.name, `describe`, 
                    salary, birthday_date 
                FROM workers
                    JOIN restaurants
                    ON workers.id_restaurants = restaurants.id

                    JOIN positions
                    ON workers.id_positions = positions.id

                    WHERE (
                        restaurants.name = @NameRestorant 
                        AND
                        positions.title = @NamePositions
                    )
                    LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NameRestorant", restaurant_name);
            command.Parameters.AddWithValue("@NamePositions", position_name);
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<WorkersInRestaurant> res = [];

        while (reader.Read()){
            res.Add( new WorkersInRestaurant(){
                Name = reader.GetString("name"), 
                Describe = reader.GetStringNull("describe"),
                Salary = reader.GetInt32Null("salary"),
                BirthdayDate = reader.GetDateOnlyNull("birthday_date")
            });
        }
        return res;
    }

    /// <summary> 7) Найти недоставленные заказы </summary>
    public async Task<List<(string?, DateOnly)>> GetDontReadyOrders(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT name, date FROM orders 
                    WHERE NOT state
                    LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string?, DateOnly)> res = [];

        while (reader.Read()){
            res.Add((
                reader.GetStringNull("name"), 
                reader.GetDateOnly("date")
            ));
        }
        return res;
    }

    /// <summary> 8) Добавить новое блюдо в позицию (меню) </summary>
    public async Task AppendPositionMenu(
        string name_range_dishes, string name_restaurants, int cost, int? weight = null
    ){
        await Task.Run(() =>{
            SheckSQLIniection(name_range_dishes, name_restaurants);
            using var command = new MySqlCommand("""
                INSERT INTO menu_item (id_range_dishes, cost, weight, id_restaurants)
                VALUES( 
                    (
                        SELECT id FROM range_dishes
                            WHERE name = @NameRangeDishes
                            LIMIT 0, 1
                    ), 
                    @Cost, @Weight, 
                    (
                        SELECT id FROM restaurants
                            WHERE name = @NameRestaurants 
                            LIMIT 0, 1
                    )
                );
                """, this.connection
            );
            command.Parameters.AddWithValue("@NameRangeDishes", name_range_dishes);
            command.Parameters.AddWithValue("@Cost", cost);
            command.Parameters.AddWithValue("@Weight", weight);
            command.Parameters.AddWithValue("@NameRestaurants", name_restaurants);
            using var reader = command.ExecuteReader();
        });

    }

    /// <summary> 8.1) Добавить новое блюдо в позицию (диапазон блюд) </summary>
    public async Task AppendNewDishes(string name, string? describe, bool? for_children){
        await Task.Run(() =>{
            SheckSQLIniection(name, describe);
            using var command = new MySqlCommand("""
                INSERT INTO range_dishes (name, `describe`, for_children)
                VALUES (@Name, @Describe, @ForChildren);
                """, this.connection
            );
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Describe", describe);
            command.Parameters.AddWithValue("@ForChildren", for_children);
            using var reader = command.ExecuteReader();
        });
    }

    /// <summary> 9) Обновление статуса заказа </summary>
    public async Task ChangeState(string order_name, bool new_state = true){
        await Task.Run(() =>{
            SheckSQLIniection(order_name);
            using var command = new MySqlCommand("""
                UPDATE orders
                    SET state = @NewState
                    WHERE name = @OrderName;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NewState", new_state);
            command.Parameters.AddWithValue("@OrderName", order_name);
            using var reader =  command.ExecuteReader();
        });
    }

    /// <summary> 10) Удаелние блюда </summary>
    public async Task ChangeInStock(
        string name_range_dishe, string name_restaurant, bool in_stock = false
    ){
        await Task.Run(() =>{
            SheckSQLIniection(name_range_dishe, name_restaurant);
            using var command = new MySqlCommand("""
                UPDATE menu_item
                    SET in_stock = @InStock

                    WHERE id_range_dishes in (
                        SELECT id FROM range_dishes
                            WHERE name = @NameRangeDishes
                    )
                    AND id_restaurants in (
                        SELECT id FROM restaurants
                            WHERE name = @NameRestaurants
                    );
                """, this.connection
            );
            command.Parameters.AddWithValue("@InStock", in_stock);
            command.Parameters.AddWithValue("@NameRangeDishes", name_range_dishe);
            command.Parameters.AddWithValue("@NameRestaurants", name_restaurant);
            using var reader = command.ExecuteReader();
        });
    }

    /// <summary> 11) Средний чек заказов по ресторанам </summary>
    public async Task<List<(string, double)>> GetAVGReceipt(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT restaurants.name, AVG(cost) FROM order_dish
                    JOIN menu_item
                    ON menu_item.id = order_dish.id_menu_item
                    JOIN restaurants  
                    ON menu_item.id_restaurants = restaurants.id

                    GROUP BY restaurants.name
                LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string, double)> res = [];

        while (reader.Read()){
            res.Add((
                reader.GetString("name"), 
                reader.GetDouble("AVG(cost)")
            ));
        }
        return res;
    }

    /// <summary> 12) Сколько заказов сделал каждый клиент </summary>
    public async Task<List<(string, long)>> GetCounterOrder(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT clients.name, COUNT(*) AS cnt_rd FROM orders
                    JOIN clients 
                    ON orders.id_clients = clients.id

                    GROUP BY id_clients

                    ORDER BY cnt_rd DESC, clients.name
                LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string, long)> res = [];

        while (reader.Read()){
            res.Add((
                reader.GetString("name"), 
                reader.GetInt64("cnt_rd")
            ));
        }
        return res;
    }

    /// <summary> 14) Сколько заказов сделал каждый клиент </summary>
    public async Task<List<(string, long)>> GetTopOrders(ulong NimberFirstRecord = 0, ulong CountRecord = 3){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT clients.name, SUM(menu_item.cost) AS sum_cst  FROM order_dish
                    JOIN orders 
                    ON order_dish.id_orders = orders.id
                
                    JOIN clients 
                    ON orders.id_clients = clients.id
                
                    JOIN menu_item 
                    ON order_dish.id_menu_item = menu_item.id
                
                    GROUP BY clients.id
                    ORDER BY sum_cst DESC
                LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string, long)> res = [];

        while (reader.Read()){
            res.Add((
                reader.GetString("name"), 
                reader.GetInt64("sum_cst")
            ));
        }
        return res;
    }

    /// <summary> 15) Сколько заказов сделал каждый клиент </summary>
    public async Task<List<WorkersInRestaurant>> GetWorkersWithUpperSalary(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT
                    name, `describe`, salary, birthday_date 
                FROM workers
                    WHERE salary >= (
                        SELECT AVG(salary) FROM workers AS avg_sal
                            WHERE avg_sal.id_restaurants =  workers.id_restaurants
                            GROUP BY avg_sal.id_restaurants
                    )
                LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);
            return command.ExecuteReader();
        });
        using var reader = await command;
        List<WorkersInRestaurant> res = [];

        while (reader.Read()){
            res.Add(new WorkersInRestaurant(){
                Name = reader.GetString("name"), 
                Describe = reader.GetStringNull("describe"),
                Salary = reader.GetInt32Null("salary"),
                BirthdayDate = reader.GetDateOnlyNull("birthday_date")
            });
        }
        return res;
    }

    /// <summary> 16) Количество заказов по дням недели </summary>
    public async Task<(string, long)[]> GetOrdersOnWeek(){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT 
                    CASE
                        WHEN WEEKDAY(date) = 0 THEN 'Понедельник'
                        WHEN WEEKDAY(date) = 1 THEN 'Вторник'
                        WHEN WEEKDAY(date) = 2 THEN 'Среда'
                        WHEN WEEKDAY(date) = 3 THEN 'Четверг'
                        WHEN WEEKDAY(date) = 4 THEN 'Пятница'
                        WHEN WEEKDAY(date) = 5 THEN 'Суббота'
                        WHEN WEEKDAY(date) = 6 THEN 'Воскресенье'
                    END AS NameDay,
                    COUNT(*) AS cnt
                FROM orders
                    GROUP BY NameDay
                    ORDER BY cnt DESC;
                """, this.connection
            );

            return command.ExecuteReader();
        });
        using var reader = await command;
        (string, long)[] res = new (string, long)[7];

        for(short i = 0; i < 7; i += 1){
            reader.Read();
            res[i] = (reader.GetString("NameDay"), reader.GetInt64("cnt"));
        }
        return res;
    }

    /// <summary> 17) Количество заказов по дням недели </summary>
    public async Task<List<(string, long)>> GetOrdersWithManyPosition(long count_orders = 3, ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT orders.name, COUNT(*) AS CnOr  FROM order_dish
                    JOIN orders 
                    ON order_dish.id_orders = orders.id

                    GROUP BY id_orders
                    HAVING CnOr > @CountOrders
                    ORDER BY CnOr DESC
                LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@CountOrders", count_orders);
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);

            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string, long)> res = [];

        while (reader.Read()){
            res.Add((
                reader.GetString("name"), 
                reader.GetInt64("CnOr")
            ));
        }
        return res;
    }

    /// <summary> 18) Общая сумма заказа </summary>
    public async Task<List<(string?, double)>> GetOrdersSum(ulong NimberFirstRecord = 0, ulong CountRecord = 100){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT orders.name, SUM(menu_item.cost) AS sm FROM orders
                    JOIN order_dish 
                    ON order_dish.id_orders = orders.id

                    JOIN menu_item 
                    ON order_dish.id_menu_item = menu_item.id

                    GROUP BY orders.id
                    ORDER BY sm DESC
                LIMIT @NimberFirstRecord, @CountRecord;
                """, this.connection
            );
            command.Parameters.AddWithValue("@NimberFirstRecord", NimberFirstRecord);
            command.Parameters.AddWithValue("@CountRecord", CountRecord);

            return command.ExecuteReader();
        });
        using var reader = await command;
        List<(string?, double)> res = [];

        while (reader.Read()){
            res.Add((
                reader.GetStringNull("name"), 
                reader.GetDouble("sm")
            ));
        }
        return res;
    }


    public void Dispose() {
        this.connection.Close();
        this.connection.Dispose();
        Console.WriteLine("- DataBase");
    }
}