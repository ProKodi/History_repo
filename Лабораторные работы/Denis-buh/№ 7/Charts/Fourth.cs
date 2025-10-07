



class Fourth_Chart{
    protected double r = 1; 
    public double R{set{this.r = value;}}

    public Fourth_Chart(double r){this.r = r;}

    public (double, double) function(double x){
        double temp = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)); 
        return (-temp, temp); 
    }
}