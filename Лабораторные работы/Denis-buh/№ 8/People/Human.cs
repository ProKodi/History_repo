



// Интерфейс IHuman
interface IHuman: ICloneable, IComparable{
    public DateOnly Date_birth{get;}
    public string Gender{get;}
    public string Surname{get;}
    public string Name{get;}
    public uint get_age();

}



// абстрактный класс Человек
abstract class Human: IHuman{
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

    public abstract object Clone(); 

    public int CompareTo(object? other){
        // Проверки
        if (other is not Human){throw new ArgumentException("Некорректное значение параметра");}
        Human self = (Human)other;
        // Здесь идет сравнение по полю surname
        return this.surname.CompareTo(self.surname);
    }

    // вычесления возраста
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

    public override string ToString(){
        return  $" Фамилия: {this.surname}, Имя: {this.name}, "
            + $"возраст (в годах): {this.get_age()}, " + 
            $"Дата рождения: {this.date_birth}, пол: {this.gender}";
    }
}