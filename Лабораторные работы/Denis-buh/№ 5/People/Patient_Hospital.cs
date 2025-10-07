



// Пациент больницы
class Patient_Hospital: Human{
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

    public override string toStr(){return this.ToString(); }

    // Преобразование в строку + Вывод на экран
    public override string Inform(){
        return base.Inform() + $" Шифр болезни: {this.code_problem}, " +
            $"Дата госпитализации: {this.date_hospital}"; 
    }
}
