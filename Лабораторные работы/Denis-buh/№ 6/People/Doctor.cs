



// Врач
class Doctor: Human, ICloneable, IComparable<Doctor>{
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

    public Doctor(in Doctor obj): base(obj){
        this.speciality = obj.speciality; 
        this.post = obj.post; 
    }


    // Перегружаем метод копирования
    public object Clone(){
        return new Doctor(this); 
    }

    public int CompareTo(Doctor? other){
        // Проверки
        if (other == null){throw new ArgumentException("Некорректное значение параметра");}
        // Здесь идет сравнение по полю surname
        return this.surname.CompareTo(other.surname);
    }


    public override string ToString(){
        return base.ToString() + $" Специальность: {this.speciality}, " +
            $"Должность: {this.post}"; 
    }
}