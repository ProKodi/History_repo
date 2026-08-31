



import math


def Task1() -> (float, float):
    # символы алфавита встречаются с равными вероятностями
    N = 5
    # Используем форму Харли
    res_a = math.log2(N)


    temp = 0
    '''
    символы алфавита встречаются с вероятностями 
        р1 = 0.8; 
        р2 = 0.15; 
        р3 = 0.03; 
        р4 = 0.015; 
        р5 = 0.005.
    '''
    # Веротности (из ТЗ)
    probls = [0.8, 0.15, 0.03, 0.015, 0.005]
    # Реализуем формулу Шенона
    for p_i in probls:
        if(p_i <= 0):  continue 
        
        temp -= p_i * math.log2(p_i) 

    return (res_a, temp)


def Task2() -> float:
    # Веротности (из ТЗ)
    probls = [0.1, 0.3, 0.4, 0.2]

    # канальная матрица р(а|b)
    matr_p_a_or_b = [
        [0.99, 0.02, 0,    0],
        [0.01, 0.98, 0.01, 0.01],
        [0,    0,    0.98, 0.02],
        [0,    0,    0.01, 0.97]
    ]

    # Вероятности источника
    prodls_a = [0, 0, 0, 0]

    for a in range(0, len(matr_p_a_or_b)):
        matr_str = matr_p_a_or_b[a]

        if(len(matr_str) != len(probls)):
            raise ValueError(f"Длина строки матрицы ({len(matr_str)}) не совпадает с количесвом вероятностей: {len(probls.Length)}")

        for i in range(0, len(probls)):
            prodls_a[a] += probls[i] * matr_str[i] 
    
    print(f"Вероятности источника: {prodls_a}")

    res = 0

    # Энтропия источника
    for pai in prodls_a:
        res -= pai * math.log2(pai)
    
    return res



def Task3() -> [float]:
    # матрица совместных вероятностей р(A, B)
    matr_p_a_or_b = [
        [0.2, 0,   0  ],
        [0.1, 0.2, 0  ],
        [0,   0.1, 0.4],
    ]

    res = [0 for i in range(len(matr_p_a_or_b))]

    for i in range(0, len(matr_p_a_or_b)):
        sum_i = 0
        for j in matr_p_a_or_b[i]: sum_i += j

        for j in matr_p_a_or_b[i]:
            temp = j / sum_i
            if(temp <= 0): continue
            res[i] -= temp * math.log2(temp)

    return res

def Task4() -> ([float], float):
    matr = [
        [0.85, 0.1,  0.05],
        [0.09, 0.91, 0   ],
        [0,    0.08, 0.92]
    ]

    res = [0 for i in range(len(matr))]

    all = 0

    for i in range(0, len(matr)):
        for j in matr[i]:
            if(j <= 0): continue
            res[i] -= j * math.log2(j)
        
        all += (1 / len(matr)) * res[i]

    return (res, all)



def main():
    answ_a, answ_b = Task1();
    print(f"Количество информации на символ сообщения (равные вероятности): {answ_a}"); 
    print(f"Количество информации на символ сообщения (разные вероятности): {answ_b}"); 

    r1 = answ_a == 2.321928094887362; 
    r2 = answ_b == 0.9489568119911049; 

    print(f"Test: {r1}, {r2}. \nRes: {r1 and r2}")

    ...
    print()

    res = Task2();
    print(f"Энтропия источника: {res}"); 

    print(f"Test: {res == 1.8546311502751858}");

    ...
    print()


    res = Task3();

    print(f"Частная условная энтропия");
    print(f"\t H(B|A=1) = {res[0]}");
    print(f"\t H(B|A=2) = {res[1]}");
    print(f"\t H(B|A=3) = {res[2]}");

    r1 = round(res[0], 4) == 0.0000;
    r2 = round(res[1], 4) == 0.9183;
    r3 = round(res[2], 4) == 0.7219;

    print(f"Test: r1={r1}, r2={r2}, r3={r3} Res: {r1 and r2 and r3}");

    ...
    print()


    res, all = Task4();
    print("Частная условная энтропия:");
    print(f"\t H(B|A=1) = {res[0]}");
    print(f"\t H(B|A=2) = {res[1]}");
    print(f"\t H(B|A=3) = {res[2]}");
    
    print("Общая условная энтропия:");
    print(f"\t H(B|A) = {all}");

    r1 = round(res[0], 4) == 0.7476;
    r2 = round(res[1], 4) == 0.4365;
    r3 = round(res[2], 4) == 0.4022;
    r4 = round(all, 4) == 0.5287;

    print(f"Test: r1={r1}, r2={r2}, r3={r3}, r4={r4} Res: {r1 and r2 and r3 and r4}");


        
main()