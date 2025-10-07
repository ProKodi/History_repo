



class Second_Chart{
    protected double a = 1; 
    public double A{set{this.a = value;}}

    public Second_Chart(double a){this.a = a;}

    public double function(double x){
        double temp = x / this.a;
        return (this.a / 2) * (Math.Pow(Math.E, temp) + Math.Pow(Math.E, -temp)); 
    }
}