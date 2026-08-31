



"""
УНИВЕРСАЛЬНАЯ РЕАЛИЗАЦИЯ
линейных групповых (систематических) кодов

Основано на методичке:
- построение G = [I | P]
- построение H = [P^T | I]
- синдромное декодирование
- исправление одиночной ошибки

Поддерживает:
✔ любое количество сообщений N
✔ автоматический расчет:
    - n_info
    - n_check
    - n
✔ автоматическое построение:
    - матрицы P
    - порождающей матрицы G
    - контрольной матрицы H
✔ кодирование
✔ внесение ошибок
✔ синдромное декодирование
✔ исправление ошибки

Библиотеки:
    pip install numpy
"""

import math
import random
import numpy as np
from itertools import combinations


class LinearSystematicCode:

    # ==========================================================
    # ИНИЦИАЛИЗАЦИЯ
    # ==========================================================
    def __init__(self, N, d0=3):
        """
        N  - количество передаваемых сообщений
        d0 - кодовое расстояние

        Для исправления одиночной ошибки:
            d0 = 3
        """

        self.N = N
        self.d0 = d0

        # ------------------------------------------------------
        # Число информационных разрядов
        # ------------------------------------------------------
        self.n_info = math.ceil(math.log2(N))

        # ------------------------------------------------------
        # Число контрольных разрядов
        # ------------------------------------------------------
        self.n_check = self.calculate_check_bits()

        # ------------------------------------------------------
        # Общая длина кода
        # ------------------------------------------------------
        self.n = self.n_info + self.n_check

        # ------------------------------------------------------
        # Построение матриц
        # ------------------------------------------------------
        self.I = np.eye(self.n_info, dtype=int)

        self.P = self.generate_P_matrix()

        self.G = np.hstack((self.I, self.P))

        self.H = np.hstack((
            self.P.T,
            np.eye(self.n_check, dtype=int)
        ))

    # ==========================================================
    # РАСЧЕТ ЧИСЛА КОНТРОЛЬНЫХ БИТОВ
    # ==========================================================
    def calculate_check_bits(self):
        """
        Условие:
            2^nk >= n_info + nk + 1
        """

        nk = 1

        while (2 ** nk) < (self.n_info + nk + 1):
            nk += 1

        return nk

    # ==========================================================
    # ГЕНЕРАЦИЯ ПРОВЕРОЧНОЙ МАТРИЦЫ P
    # ==========================================================
    def generate_P_matrix(self):
        """
        Генерация матрицы P

        Требование методички:
            вес строки >= d0 - 1

        Для d0 = 3:
            вес >= 2
        """

        required_weight = self.d0 - 1

        all_vectors = []

        # Генерация всех двоичных комбинаций
        for i in range(1, 2 ** self.n_check):

            binary = list(map(int, bin(i)[2:].zfill(self.n_check)))

            weight = sum(binary)

            if weight >= required_weight:
                all_vectors.append(binary)

        # Проверка достаточности строк
        if len(all_vectors) < self.n_info:
            raise ValueError(
                "Недостаточно комбинаций для построения P"
            )

        # Берем первые n_info строк
        P = np.array(all_vectors[:self.n_info])

        return P

    # ==========================================================
    # КОДИРОВАНИЕ
    # ==========================================================
    def encode(self, data_bits):
        """
        Кодирование сообщения
        """

        data_bits = np.array(data_bits, dtype=int)

        if len(data_bits) != self.n_info:
            raise ValueError(
                f"Нужно {self.n_info} информационных бит"
            )

        codeword = np.dot(data_bits, self.G) % 2

        return codeword

    # ==========================================================
    # ВНЕСЕНИЕ ОШИБКИ
    # ==========================================================
    def add_error(self, codeword, position=None):

        corrupted = codeword.copy()

        if position is None:
            position = random.randint(0, self.n - 1)

        corrupted[position] ^= 1

        return corrupted, position

    # ==========================================================
    # СИНДРОМ
    # ==========================================================
    def syndrome(self, received):

        received = np.array(received)

        S = np.dot(self.H, received.T) % 2

        return S

    # ==========================================================
    # ПОИСК ОШИБКИ
    # ==========================================================
    def find_error(self, syndrome):

        for i in range(self.H.shape[1]):

            column = self.H[:, i]

            if np.array_equal(column, syndrome):
                return i

        return None

    # ==========================================================
    # ИСПРАВЛЕНИЕ ОШИБКИ
    # ==========================================================
    def correct(self, received):

        received = np.array(received)

        syndrome = self.syndrome(received)

        # Если синдром нулевой
        if np.all(syndrome == 0):
            return received, syndrome, None

        error_pos = self.find_error(syndrome)

        corrected = received.copy()

        if error_pos is not None:
            corrected[error_pos] ^= 1

        return corrected, syndrome, error_pos

    # ==========================================================
    # ГЕНЕРАЦИЯ СЛУЧАЙНОГО СООБЩЕНИЯ
    # ==========================================================
    def random_message(self):

        return np.random.randint(0, 2, self.n_info)

    # ==========================================================
    # ПЕЧАТЬ ПАРАМЕТРОВ
    # ==========================================================
    def print_info(self):

        print("=" * 60)

        print("ПАРАМЕТРЫ КОДА")

        print("=" * 60)

        print(f"N                    = {self.N}")
        print(f"Кодовое расстояние   = {self.d0}")

        print(f"Информационных бит   = {self.n_info}")
        print(f"Контрольных бит      = {self.n_check}")

        print(f"Длина кода           = {self.n}")

    # ==========================================================
    # ПЕЧАТЬ МАТРИЦ
    # ==========================================================
    def print_matrices(self):

        print("\n" + "=" * 60)
        print("МАТРИЦА I")
        print("=" * 60)
        print(self.I)

        print("\n" + "=" * 60)
        print("МАТРИЦА P")
        print("=" * 60)
        print(self.P)

        print("\n" + "=" * 60)
        print("ПОРОЖДАЮЩАЯ МАТРИЦА G")
        print("=" * 60)
        print(self.G)

        print("\n" + "=" * 60)
        print("КОНТРОЛЬНАЯ МАТРИЦА H")
        print("=" * 60)
        print(self.H)

    # ==========================================================
    # ДЕМОНСТРАЦИЯ РАБОТЫ
    # ==========================================================
    def demo(self):

        print("\n" + "=" * 60)
        print("ДЕМОНСТРАЦИЯ РАБОТЫ")
        print("=" * 60)

        # Случайное сообщение
        data = self.random_message()

        print("\nИсходное сообщение:")
        print(data)

        # Кодирование
        encoded = self.encode(data)

        print("\nЗакодированное сообщение:")
        print(encoded)

        # Ошибка
        corrupted, real_error = self.add_error(encoded)

        print("\nСообщение с ошибкой:")
        print(corrupted)

        print(f"\nОшибка внесена в бит: {real_error}")

        # Синдром
        syndrome = self.syndrome(corrupted)

        print("\nСиндром:")
        print(syndrome)

        # Исправление
        corrected, syndrome, found_error = self.correct(corrupted)

        print("\nНайденная ошибка:")
        print(found_error)

        print("\nИсправленное сообщение:")
        print(corrected)

        # Проверка
        success = np.array_equal(encoded, corrected)

        print("\nРезультат:")
        print(
            "Ошибка исправлена"
            if success
            else "Ошибка НЕ исправлена"
        )


# ==============================================================
# MAIN
# ==============================================================

if __name__ == "__main__":

    # ----------------------------------------------------------
    # КОЛИЧЕСТВО ПЕРЕДАВАЕМЫХ СООБЩЕНИЙ
    # ----------------------------------------------------------
    N = 16

    # ----------------------------------------------------------
    # СОЗДАНИЕ КОДА
    # ----------------------------------------------------------
    code = LinearSystematicCode(N)

    # ----------------------------------------------------------
    # ВЫВОД ПАРАМЕТРОВ
    # ----------------------------------------------------------
    code.print_info()

    # ----------------------------------------------------------
    # ВЫВОД МАТРИЦ
    # ----------------------------------------------------------
    code.print_matrices()

    # ----------------------------------------------------------
    # ТЕСТ
    # ----------------------------------------------------------
    code.demo()