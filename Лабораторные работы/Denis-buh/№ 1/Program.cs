



class Complex{
    protected double modl; // модуль (длина вектора)
    // modl = (x^2 + y^2) ^ 0.5
    // modl^2 = x^2 + y^2
    protected double org; // аргумент (угол к оси x)
    // cos(org) = x / modl // x - дейст. часть = cos(org) * modl
    // sin(org) = y / modl // y - мним. часть = sin(org) * modl


    public void input(){
        Console.WriteLine("Введите информацию");
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



class Program{
    public static void Main(){
        Complex obj = new Complex();

        // Оформим ввод
        obj.input();

        // Вывод
        Console.WriteLine($"Действительная часть = {obj.get_x()}");
        Console.WriteLine($"Мнимая часть = {obj.get_y()}");
        Console.WriteLine($"Общий вид = {obj.get()}");
    }
}