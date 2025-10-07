



class Student{
    /// <summary>ФИО</summary>
    protected string name = "";
    public string Name{
        get{return this.name;}
        set{
            if(value == ""){throw new ArgumentException();}
            this.name = value;
        }
    }

    /// <summary>Количество лет</summary>
    protected int age;
    public int Age{
        get{return this.age;}
        set{
            if(value <= 0){throw new ArgumentException();}
            this.age = value;
        }
    }

    /// <summary>Номер курса</summary>
    protected int number_cout;
    public int Number_cout{
        get{return this.number_cout;}
        set{
            if(value < 1){throw new ArgumentException();}
            this.number_cout = value;
        }
    }

    /// <summary>Номер группы</summary>
    protected string name_group = "";
    public string Name_group{
        get{return this.name_group;}
        set{
            if(value == ""){throw new ArgumentException();}
            this.name_group = value;
        }
    }

    /// <summary>Процент hp</summary>
    protected int hp;
    public int Hp{
        get{return this.hp;}
        set{this.hp = value;}
    }

    public Student(string name, int age, int number_cout, string name_group, int hp){
        this.Name = name;
        this.Age = age;
        this.Number_cout = number_cout;
        this.Name_group = name_group;
        this.Hp = hp;
    }

    public override string ToString(){
        return $"{{Name: {this.name}, Age: {this.age}, Number_cout: {this.number_cout}, " + 
            $"Name_group: {this.name_group}, Hp: {this.hp}}}";
    }

    public override int GetHashCode(){
        return this.name.GetHashCode() ^ this.age.GetHashCode() ^ this.number_cout.GetHashCode() 
            ^ this.name_group.GetHashCode() ^ this.hp.GetHashCode();
    }

    public static bool operator==(Student self, Student oth){
        if(self.GetHashCode() != oth.GetHashCode()){return false;}
        if(self.Name != oth.Name || self.Age != oth.Age || self.Number_cout == oth.Number_cout ||  
            self.Name_group == oth.Name_group || self.Hp == oth.Hp
        ){return false;}
        return true;
    }

    public static bool operator!=(Student self, Student oth){
        if(self.GetHashCode() != oth.GetHashCode()){return true;}
        if(self.Name != oth.Name || self.Age != oth.Age || self.Number_cout != oth.Number_cout ||  
            self.Name_group != oth.Name_group || self.Hp != oth.Hp
        ){return true;}
        return false;
    }

    public override bool Equals(object? other){
        if(other is not Student) {return false;}
        return this == (Student)other;
    }
}