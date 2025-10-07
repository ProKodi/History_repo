




abstract class IPoint{
    protected double x = 0; 
    protected double y = 0; 

    public double X{get{return this.x;}}
    public double Y{get{return this.y;}}

    public IPoint(double x, double y){this.x = x; this.y = y;}

    public static bool operator<(IPoint self, IPoint other){
        return (self.x < other.x) || (self.y < other.y); 
    }

    public static bool operator<=(IPoint self, IPoint other){
        return (self.x <= other.x) || (self.y <= other.y); 
    }

    public static bool operator>(IPoint self, IPoint other){
        return (self.x > other.x) || (self.y > other.y); 
    }

    public static bool operator>=(IPoint self, IPoint other){
        return (self.x >= other.x) || (self.y >= other.y); 
    }
    
}


/// <summary>Целочисленная точка. Используется при рисовании поля графика</summary>
class Point: IPoint{
    public new int X{get{return (int)this.x;}}
    public new int Y{get{return (int)this.y;}}

    public Point(int x, int y): base(x, y){}

    public static Point operator*(Point self, int number){
        return new Point((int)(self.x * number), (int)(self.y * number)); 
    }

    public static Point operator+(Point self, IPoint other){
        return new Point((int)(self.x + other.X), (int)(self.y + other.Y)); 
    }
}

/// <summary>Дробная точка. Используется при рисовании графика</summary>
class FPoint: IPoint{
    public FPoint(double x, double y): base(x, y){}

    public static FPoint operator*(FPoint self, int number){
        return new FPoint(self.x * number, self.y * number); 
    }

    public static FPoint operator+(FPoint self, IPoint other){
        return new FPoint(self.x + other.X, - self.y + other.Y); 
    }
}

