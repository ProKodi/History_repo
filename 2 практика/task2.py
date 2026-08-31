


class Const:
    # Скорость света
    c = 3 * (10 ** 8)
    


V = 4 * 1024 * 1024 

L = 5000 * 1000

C = 0.6 * Const.c

T_kanal = 418 / 1000

I = (T_kanal - (L / C)) * V

print(f"Объем {(I / 8) / 1024}")

