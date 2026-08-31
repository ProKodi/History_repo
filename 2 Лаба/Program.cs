




using System.Data;

[Flags]
enum Tasks{
    Task1 = 0b0001,
    Task2 = 0b0010,
    Task3 = 0b0100,
    Task4 = 0b1000,
}


class Program{
    public static (double, double) Task1(){
        (double, double) res = (0, 0);

        /// символы алфавита встречаются с равными вероятностями;
        {
            const int N = 5;
            /// Используем форму Харли
            res.Item1 = Math.Log2(N);
        }

        /*
        символы алфавита встречаются с вероятностями 
            р1 = 0.8; 
            р2 = 0.15; 
            р3 = 0.03; 
            р4 = 0.015; 
            р5 = 0.005.
        */
        {
            /// Веротности (из ТЗ)
            double[] probls = [0.8, 0.15, 0.03, 0.015, 0.005];

            /// Реализуем формулу Шенона
            foreach (var p_i in probls){
                if(p_i <= 0){ continue; }
                res.Item2 -= p_i * Math.Log2(p_i); 
            }
        }
        return res;
    }


    public static double Task2(){
        /// Веротности (из ТЗ)
        double[] probls = [0.1, 0.3, 0.4, 0.2];

        /// канальная матрица р(а|b)
        double[][] matr_p_a_or_b = [
            [0.99, 0.02, 0,    0],
            [0.01, 0.98, 0.01, 0.01],
            [0,    0,    0.98, 0.02],
            [0,    0,    0.01, 0.97]
        ];

        /// Вероятности источника
        double[] prodls_a = [0, 0, 0, 0];

        for(int a = 0; a < matr_p_a_or_b.Length; a += 1){
            double[] matr_str = matr_p_a_or_b[a];

            if(matr_str.Length != probls.Length){
                throw new DataException($"Длина строки матрицы ({matr_str.Length}) не совпадает с количесвом вероятностей: {probls.Length}");
            }
            for(int i = 0; i < probls.Length; i += 1){
                prodls_a[a] += probls[i] * matr_str[i]; 
            }
        }

        double res = 0;
        /// Энтропия и сточника
        foreach (var pai in prodls_a){
            res -= pai * Math.Log2(pai);
        }

        return res;
    }


    public static double[] Task3(){
        /// матрица совместных вероятностей р(A, B)
        double[][] matr_p_a_or_b = [
            [0.2, 0,   0  ],
            [0.1, 0.2, 0  ],
            [0,   0.1, 0.4],
        ];

        double[] res = new double[matr_p_a_or_b.Length];

        for(int i = 0; i < matr_p_a_or_b.Length; i += 1){
            double sum_i = 0;
            foreach (var j in matr_p_a_or_b[i]){ sum_i += j; }

            res[i] = 0;

            foreach (var j in matr_p_a_or_b[i]){
                double temp = j / sum_i;
                if(temp <= 0){ continue; }
                res[i] -= temp * Math.Log2(temp);
            }

        }

        return res;
    }



    public static (double[], double) Task4(){
        /// Канальная матрица
        double[][] matr = [
            [0.85, 0.1,  0.05],
            [0.09, 0.91, 0   ],
            [0,    0.08, 0.92]
        ];

        double[] res = new double[matr.Length];
        double all = 0;

        for(int i = 0; i < matr.Length; i += 1){
            foreach (var j in matr[i]){
                if(j <= 0){ continue; }
                res[i] -= j * Math.Log2(j);
            }
            all += (1 / (double)matr.Length) * res[i]; 
        }

        return (res, all);
    }

    public static void Main(){
        Tasks select_task = Tasks.Task1 | Tasks.Task2 | Tasks.Task3 | Tasks.Task4;

        if ((select_task & Tasks.Task1) == Tasks.Task1){
            (double answ_a, double answ_b) = Task1();
            Console.WriteLine($"Количество информации на символ сообщения (равные вероятности): {answ_a}"); 
            Console.WriteLine($"Количество информации на символ сообщения (разные вероятности): {answ_b}"); 

            bool r1 = answ_a == 2.321928094887362; 
            bool r2 = answ_b == 0.9489568119911049; 


            Console.WriteLine($"Test: {r1}, {r2}. \nRes: {r1 && r2}");
        }
        Console.WriteLine();


        if ((select_task & Tasks.Task2) == Tasks.Task2){
            double res = Task2();
            Console.WriteLine($"Энтропия источника: {res}"); 

            Console.WriteLine($"Test: {res == 1.8546311502751858}");
        }
        Console.WriteLine();

        if ((select_task & Tasks.Task3) == Tasks.Task3){
            double[] res = Task3();

            Console.WriteLine("Частная условная энтропия");
            Console.WriteLine($"\t H(B|A=1) = {res[0]}");
            Console.WriteLine($"\t H(B|A=2) = {res[1]}");
            Console.WriteLine($"\t H(B|A=3) = {res[2]}");

            bool r1 = Math.Round(res[0], 4) == 0.0000;
            bool r2 = Math.Round(res[1], 4) == 0.9183;
            bool r3 = Math.Round(res[2], 4) == 0.7219;

            Console.WriteLine($"Test: r1={r1}, r2={r2}, r3={r3} Res: {r1 && r2 && r3}");
        }

        Console.WriteLine();

        if ((select_task & Tasks.Task4) == Tasks.Task4){
            (double[] res, double all) = Task4();
            Console.WriteLine("Частная условная энтропия:");
            Console.WriteLine($"\t H(B|A=1) = {res[0]}");
            Console.WriteLine($"\t H(B|A=2) = {res[1]}");
            Console.WriteLine($"\t H(B|A=3) = {res[2]}");
            
            Console.WriteLine("Общая условная энтропия:");
            Console.WriteLine($"\t H(B|A) = {all}");

            bool r1 = Math.Round(res[0], 4) == 0.7476;
            bool r2 = Math.Round(res[1], 4) == 0.4365;
            bool r3 = Math.Round(res[2], 4) == 0.4022;
            bool r4 = Math.Round(all, 4) == 0.5287;

            Console.WriteLine($"Test: r1={r1}, r2={r2}, r3={r3}, r4={r4} Res: {r1 && r2 && r3 && r4}");

            /*
                H(B|A1): 0,7476
                H(B|A2): 0,4365
                H(B|A3): 0,4022
                All H(B|A): 0,5287
            */
        }



    }
}


