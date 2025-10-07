



// Пациент поликлиники
class Patient_Polyclinics: Human, ICloneable, IComparable<Patient_Polyclinics>{
    protected DateOnly date_hospital; // дата прохождения диспансеризации
    public DateOnly Date_hospital{get{return this.date_hospital;}}
    protected bool registration = false; // диспансерный учет (да, нет)
    public bool Registration{get{return this.registration;}}

    public Patient_Polyclinics(DateOnly date_birth, string gender, 
        string surname, string name, DateOnly date_hospital, 
        bool registration): base(date_birth, gender, surname, name){
        this.date_hospital = date_hospital; 
        this.registration = registration; 
    }

    public Patient_Polyclinics(Human obj, 
        DateOnly date_hospital, bool registration): base(obj){
        this.date_hospital = date_hospital; 
        this.registration = registration; 
    }

    public Patient_Polyclinics(in Patient_Polyclinics obj): base(obj){
        this.date_hospital = obj.date_hospital; 
        this.registration = obj.registration; 
    }

    // Перегружаем метод копирования
    public object Clone(){
        return new Patient_Polyclinics(this); 
    }

    public int CompareTo(Patient_Polyclinics? other){
        // Проверки
        if (other == null){throw new ArgumentException("Некорректное значение параметра");}
        // Здесь идет сравнение по полю surname
        return this.surname.CompareTo(other.surname);
    }


    public override string ToString(){
        return base.ToString() + $" Дата прохождения диспансеризации: {this.date_hospital}, " +
            $"Диспансерный учет: {this.registration}"; 
    }
}