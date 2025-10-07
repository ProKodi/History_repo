



struct Point{
    private int x = 0; 
    public int X{get{return this.x;}}
    private int y = 0; 
    public int Y{get{return this.y;}}
    public Point(int x, int y){
        this.x = x;
        this.y = y;
    }

    public static Point operator*(Point self, int number){
        return new Point(self.x * number, self.y * number); 
    }
}

struct FPoint{
    private double x = 0; 
    public double X{get{return this.x;}}
    private double y = 0; 
    public double Y{get{return this.y;}}
    public FPoint(double x, double y){
        this.x = x;
        this.y = y;
    }

    public static FPoint operator*(FPoint self, int number){
        return new FPoint(self.x * number, self.y * number); 
    }
}

