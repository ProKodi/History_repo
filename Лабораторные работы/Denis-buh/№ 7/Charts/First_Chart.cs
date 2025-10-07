



class First_Chart{
    protected double g = 0; 
    public double G{set{this.g = value;}}

    public First_Chart(double g){this.g = g;}

    public (double, double) function(double x){
        double temp = Math.Sqrt(Math.Pow(x, 3) * (x - g)); 
        return (-temp, temp); 
    }
}