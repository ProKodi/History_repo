



class Third_Chart{
    protected double k = 1; 
    public double K{set{this.k = value;}}

    protected double b = 1; 
    public double B{set{this.b = value;}}

    public Third_Chart(double k, double b){this.k = k; this.b = b;}

    public double function(double x){
        return (k * x) + b; 
    }
}