



// Врач
class Doctor: Human{
    protected string speciality; // специальность
    public string Speciality{get{return this.speciality;}}
    protected string post; // должность
    public string Post{get{return this.post;}}

    public Doctor(DateOnly date_birth, string gender, 
        string surname, string name, string speciality, 
        string post): base(date_birth, gender, surname, name){
        this.speciality = speciality; 
        this.post = post; 
    }

    public Doctor(Human obj, string speciality, string post): base(obj){
        this.speciality = speciality; 
        this.post = post; 
    }

    public override string toStr(){return this.ToString(); }

    // Преобразование в строку + Вывод на экран
    public override string Inform(){
        return base.Inform() + $" Специальность: {this.speciality}, " +
            $"Должность: {this.post}"; 
    }
}