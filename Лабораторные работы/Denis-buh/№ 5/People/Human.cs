



// абстрактный класс Человек
abstract class Human{
    protected DateOnly date_birth; // год рождения
    public DateOnly Date_birth{get{return this.date_birth;}}

    protected string gender = ""; // пол
    public string Gender{get{return this.gender;}}

    protected string surname = ""; // фамилия
    public string Surname{get{return this.surname;}}

    protected string name = ""; // имя
    public string Name{get{return this.name;}}

    public Human(DateOnly date_birth, string gender, 
        string surname, string name){
        this.date_birth = date_birth;
        this.gender = gender;
        this.surname = surname; 
        this.name = name;
    }

    public Human(Human obj){
        this.date_birth = obj.date_birth;
        this.gender = obj.gender;
        this.surname = obj.surname; 
        this.name = obj.name;
    }

    // вычисления возраста
    public virtual uint get_age(){
        // Получение сегодняшней даты + Конвертация ее в DateOnly
        DateOnly now_date = DateOnly.FromDateTime(DateTime.Today);
        // Из седняжней даты вычетаем дату рождения. Получаем разницу в годах
        uint year = (uint)(now_date.Year - date_birth.Year);

        // Если не было достигнуто месяца рождения 
        if (now_date.Month < date_birth.Month){year -= 1;}

        // Если был достигнут месяц рождения но не был достигнут день рождения
        else if ((now_date.Month == date_birth.Month) 
            && (now_date.Day < date_birth.Day)
        ){year -= 1;}

        return year; 
    }

    public abstract string toStr();

    public override string ToString(){return this.Inform();}

    // Преобразование в строку + Вывод на экран
    public virtual string Inform(){
        return  $"Дата рождения: {this.date_birth}, пол: {this.gender}"
            + $" Фамилия: {this.surname}, Имя: {this.name}, возраст (в годах): {this.get_age()}";
    }
}