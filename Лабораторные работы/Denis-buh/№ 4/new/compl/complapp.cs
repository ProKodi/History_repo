



class ComplexApp : Complex{
    public ComplexApp(double modl, double org) : base(modl, org) { }
    public ComplexApp():base(){}

    public static ComplexApp operator ++(ComplexApp self){
        self.y += 1;
        ComplexApp temp = new ComplexApp();
        temp.x = self.x;
        temp.y = self.y;
        return temp;
    }

    public static ComplexApp operator --(ComplexApp self){
        self.y -= 1;
        ComplexApp temp = new ComplexApp();
        temp.x = self.x;
        temp.y = self.y;
        return temp;
    }

    public static ComplexApp operator *(ComplexApp self, Complex other){
        ComplexApp temp = new ComplexApp();
        temp.x = (self.X * other.X) - (self.Y * other.Y);
        temp.y = (self.X * other.Y) - (self.Y * other.X);
        return temp; 
    }

    public static ComplexApp operator /(ComplexApp self, Complex other){
        ComplexApp temp = new ComplexApp();
        temp.x = ((self.X * other.X) + (self.Y * other.Y)) / 
            ((other.X * other.X ) + (other.Y * other.Y));
        temp.y = ((self.Y * other.X) + (self.X * other.Y)) /
            ((other.X * other.X) + (other.Y * other.Y));
        return temp;
    }

    // Хеширование объектов
    public override int GetHashCode(){
        return this.x.GetHashCode() ^ this.y.GetHashCode(); 
    }

    // Операция Equals
    public override bool Equals(object? obj){
        // Если объект ссылается на пустое значение
        if (obj == null){return false;}
        // Если обьект не является нужным нам типом
        if (obj is not Complex){return false;}
        // Если у обьектов не совпадают хеш коды
        if (this.GetHashCode() != obj.GetHashCode()){return false;}
        // Приводим сравниваемый экземпляр к нужному типу данных 
        ComplexApp temp = (ComplexApp)obj; 
        // Если все проверки пройдены, то начинаем проверять поля на равенство
        if (this == temp){return true;}
        // Если последняя проверка по полям не была пройдена
        return false;
    }

    public static bool operator ==(ComplexApp self, Complex other){
        if ((self.x == other.X) && (self.y == other.Y)) {return true;}
        return false;
    }

    public static bool operator !=(ComplexApp self, Complex other){
        if ((self.x != other.X) || (self.y!= other.Y)){return true;}
        return false;
    }
}

