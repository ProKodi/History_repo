



// Делегат
delegate string Fun(Patient_Polyclinics self);


// Пациент поликлиники
class Patient_Polyclinics: Human{
    protected DateOnly date_hospital; // дата прохождения диспансеризации
    public DateOnly Date_hospital{get{return this.date_hospital;}}
    protected bool registration = false; // диспансерный учет (да, нет)
    public bool Registration{get{return this.registration;}}

    // Событие для класса
    public event Fun get_inf = (Patient_Polyclinics self) => {return self.ToString();};

    public event Fun Inform{
        add{this.get_inf = value;}
        remove{ this.get_inf = (Patient_Polyclinics self) => {return self.ToString();}; }
    }
    

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
    public override object Clone(){
        return new Patient_Polyclinics(this); 
    }

    public override string ToString(){
        return base.ToString() + $" Дата прохождения диспансеризации: {this.date_hospital}, " +
            $"Диспансерный учет: {this.registration}"; 
    }

    public string get_inform(){
        if(this.get_inf is not Fun){
            throw new ArgumentException(); 
        }
        return this.get_inf(this);
    }
}


class NewClass{
    public static string GetSN(Patient_Polyclinics self){
        return  $"{{Фамилия: {self.Surname}, Имя: {self.Name}}}";
    }

    public static string GetSNR(Patient_Polyclinics self){
        return  $"{{Фамилия: {self.Surname}, Имя: {self.Name}, Диспансерный учет: {self.Registration}}}";
    }
}