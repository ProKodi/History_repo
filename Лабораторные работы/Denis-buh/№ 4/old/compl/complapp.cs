



class ComplexApp : Complex
{

    public ComplexApp(double modl, double org) : base(modl, org) { }
    protected ComplexApp() : base() { }

    // ++ -- (для мнимой части)

    public static ComplexApp operator ++(ComplexApp self){
        ComplexApp temp = new ComplexApp();
        temp.x = self.X;
        temp.y = self.X + 1;
        return temp;
    }

    public static ComplexApp operator --(ComplexApp self)
    {
        ComplexApp temp = new ComplexApp();
        temp.x = self.X;
        temp.y = self.X - 1;
        return temp;
    }

    public static ComplexApp operator *(ComplexApp self, Complex other){
        ComplexApp temp = new ComplexApp();
        temp.x = (self.X * other.X) - (self.Y * other.Y);
        temp.y = (self.X * other.Y) - (self.Y * other.X);
        return temp; 
    }

    public static ComplexApp operator /(ComplexApp self, Complex other)
    {
        ComplexApp temp = new ComplexApp();
        temp.x = ((self.X * other.X) + (self.Y * other.Y)) / 
            ((other.X * other.X ) + (other.Y * other.Y));
        temp.y = ((self.Y * other.X) + (self.X * other.Y)) /
            ((other.X * other.X) + (other.Y * other.Y));
        return temp;
    }

    public static bool operator ==(ComplexApp self, Complex other){
        if ((self.X == other.X) && (self.Y == other.Y)) { return true; }
        return false;
    }

    public static bool operator !=(ComplexApp self, Complex other)
    {
        if ((self.X != other.X) || (self.Y != other.Y)) { return true; }
        return false;
    }

}

