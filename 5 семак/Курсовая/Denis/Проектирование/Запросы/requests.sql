



/* --------- 1 ------------- */
SELECT
    name, address, time_monday, time_tuesday,
    time_wednesday, time_thursday, time_friday,
    time_saturday, time_sunday
FROM restaurants
    JOIN schedule 
    ON restaurants.id_schedule = schedule.id;


/* --------- 2 ------------- */
SELECT 
    range_dishes.name, `describe`, for_children,
    cost, weight, in_stock
FROM menu_item
    JOIN range_dishes
    ON range_dishes.id = id_range_dishes
    JOIN restaurants 
    ON restaurants.id = menu_item.id_restaurants
    WHERE restaurants.id = @NameRestorant AND in_stock;


/* --------- 3 ------------- */
SELECT 
    orders.name, state, date
FROM orders
    JOIN clients
    ON orders.id_clients = clients.id
    WHERE clients.email = @ClientEmail;


/* --------- 4 ------------- */
SELECT range_dishes.name, COUNT(*) AS count_ord FROM order_dish
    JOIN menu_item
    ON id_menu_item = menu_item.id
    JOIN range_dishes
    ON id_range_dishes = range_dishes.id
    GROUP BY range_dishes.name
    ORDER BY count_ord DESC;


/* --------- 5 ------------- */
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


/* --------- 6 ------------- */
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
    );


/* --------- 7 ------------- */
SELECT name, date FROM orders 
    WHERE NOT state;


/* --------- 8 ------------- */
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

/* --------- 8.1 ------------- */
INSERT INTO range_dishes (name, `describe`, for_children)
VALUES (@Name, @Describe, @ForChildren);



/* --------- 9 ------------- */
UPDATE orders
    SET state = @NewState
    WHERE name = @OrderName;


/* --------- 10 ------------- */
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


/* --------- 11 ------------- */
SELECT restaurants.name, AVG(cost) FROM order_dish
    JOIN menu_item
    ON menu_item.id = order_dish.id_menu_item
    JOIN restaurants  
    ON menu_item.id_restaurants = restaurants.id
    GROUP BY restaurants.name;


/* --------- 12 ------------- */
SELECT clients.name, COUNT(*) AS cnt_rd FROM orders
    JOIN clients 
    ON orders.id_clients = clients.id
    GROUP BY id_clients
    ORDER BY cnt_rd DESC, clients.name;


/* --------- 14 ------------- */
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


/* --------- 15 ------------- */
SELECT
    name, `describe`, salary, birthday_date 
FROM workers
    WHERE salary >= (
        SELECT AVG(salary) FROM workers AS avg_sal
            WHERE avg_sal.id_restaurants =  workers.id_restaurants
            GROUP BY avg_sal.id_restaurants
    );


/* --------- 16 ------------- */
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

/* --------- 17 ------------- */
SELECT orders.name, COUNT(*) AS CnOr  FROM order_dish
    JOIN orders 
    ON order_dish.id_orders = orders.id
    GROUP BY id_orders
    HAVING CnOr > @CountOrders
    ORDER BY CnOr DESC;


/* --------- 18 ------------- */
SELECT orders.name, SUM(menu_item.cost) AS sm FROM orders
    JOIN order_dish 
    ON order_dish.id_orders = orders.id
    JOIN menu_item 
    ON order_dish.id_menu_item = menu_item.id
    GROUP BY orders.id
    ORDER BY sm DESC;