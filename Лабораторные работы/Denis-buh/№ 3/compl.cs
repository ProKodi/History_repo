



class Complex{
    protected double modl = 0; // модуль (длина вектора)
    public double Modl{
        set{this.modl = value;}
        get{return this.modl;}
    }

    protected double org = 0; // аргумент (угол к оси x)
    public double Org{
        set{this.org = value;}
        get{return this.org;}
    }

    public Complex(){}

    public Complex(double modl){
        this.modl = modl; 
    }

    public Complex(double modl, double org){
        this.modl = modl; 
        this.org = org; 
    }


    public void input(){
        Console.Write("Введите модуль");
        modl = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Введите аргумент");
        org = Convert.ToDouble(Console.ReadLine()); 
    }

    // Гетер для действительной части
    public double get_x(){
        double res = Math.Cos((this.org * Math.PI) / 180) * modl; 
        if (Math.Abs(res) < 0.000000001){
            return 0;
        }
        return res;
    }

    // Гетер для мнимой части
    public double get_y(){ 
        double res = Math.Sin((this.org * Math.PI) / 180) * modl; 
        if (Math.Abs(res)  < 0.000000001){
            return 0;
        }
        return res;
    }

    // Вывод в общем виде
    public string get(){
        return $"{this.get_x()} + {this.get_y()} * i"; 
    }
}

/*

class Program{
    public static void Main(){
        Complex obj = new Complex();

        Console.Write("Введите модуль");
        obj.Modl = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Введите аргумент");
        obj.Org = Convert.ToDouble(Console.ReadLine()); 
        
        // Вывод
        Console.WriteLine($"Действительная часть = {obj.get_x()}");
        Console.WriteLine($"Мнимая часть = {obj.get_y()}");
        Console.WriteLine($"Общий вид = {obj.get()}");
    }
}

*/