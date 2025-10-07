



// Пациент поликлиники
class Patient_Polyclinics: Human{
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

    public override string toStr(){return this.ToString(); }

    // Преобразование в строку + Вывод на экран
    public override string Inform(){
        return base.Inform() + $" Дата прохождения диспансеризации: {this.date_hospital}, " +
            $"Диспансерный учет: {this.registration}"; 
    }
}