



// Пациент больницы
class Patient_Hospital: Human, ICloneable, IComparable<Patient_Hospital>{
    protected string code_problem; // шифр заболевания
    public string Code{get{return this.code_problem;}}
    protected DateOnly date_hospital; // даты госпитализации
    public DateOnly Date_hospital{get{return this.date_hospital;}}

    public Patient_Hospital(DateOnly date_birth, string gender, 
        string surname, string name, string code_problem, 
        DateOnly date_hospital): base(date_birth, gender, surname, name){
        this.code_problem = code_problem; 
        this.date_hospital = date_hospital; 
    }

    public Patient_Hospital(Human obj, string code_problem, 
        DateOnly date_hospital): base(obj){
        this.code_problem = code_problem; 
        this.date_hospital = date_hospital; 
    }

    public Patient_Hospital(in Patient_Hospital obj): base(obj){
        this.code_problem = obj.code_problem; 
        this.date_hospital = obj.date_hospital; 
    }


    // Перегружаем метод копирования
    public object Clone(){
        return new Patient_Hospital(this); 
    }

    public int CompareTo(Patient_Hospital? other){
        // Проверки
        if (other == null){throw new ArgumentException("Некорректное значение параметра");}
        // Здесь идет сравнение по полю surname
        return this.surname.CompareTo(other.surname);
    }

    public override string ToString(){
        return base.ToString() + $" Шифр болезни: {this.code_problem}, " +
            $"Дата госпитализации: {this.date_hospital}"; 
    }
}
