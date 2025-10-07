



class Complex
{
    protected double x = 0; // Действительная часть
    public double X{get{ return this.x;}}

    protected double y = 0; // Мнимая часть
    public double Y{get { return this.y; }}

    public Complex(double modl, double org){
        this.set_x(modl, org);
        this.set_y(modl, org);
    }

    protected Complex(){}


    // Сетер для действительной части
    protected void set_x(double modl, double org){
        double res = Math.Cos((org * Math.PI) / 180) * modl;
        if (Math.Abs(res) < 0.000000001) { this.x = 0; }
        else { this.x = res; }
    }

    // Сетер для мнимой части
    protected void set_y(double modl, double org)
    {
        double res = Math.Sin((org * Math.PI) / 180) * modl;
        if (Math.Abs(res) < 0.000000001) { this.y = 0; }
        else{this.y = res;}
    }

    // Вывод в общем виде
    public override string ToString(){
        return $"{this.x} + {this.y} * i";
    }
}

