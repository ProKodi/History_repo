



# pip install ortools
from ortools.linear_solver import *


def solve_assignment(cost_matrix):
    n = len(cost_matrix)

    # === Создание MIP-решателя ===
    solver = pywraplp.Solver.CreateSolver("CBC")
    if solver is None:
        raise RuntimeError("CBC solver недоступен")

    # === Переменные x[i][j] ∈ {0,1} ===
    assign = [
        [solver.IntVar(0, 1, f"x_{i}_{j}") for j in range(n)]
        for i in range(n)
    ]

    # === Ограничения: каждый исполнитель → одна работа ===
    for i in range(n):
        solver.Add(sum(assign[i][j] for j in range(n)) == 1)

    # === Ограничения: каждая работа → одному исполнителю ===
    for j in range(n):
        solver.Add(sum(assign[i][j] for i in range(n)) == 1)

    # === Целевая функция: минимизация стоимости ===
    solver.Minimize(
        sum(cost_matrix[i][j] * assign[i][j]
            for i in range(n) for j in range(n))
    )

    # === Решение ===
    status = solver.Solve()

    if status != pywraplp.Solver.OPTIMAL:
        print("Оптимальное решение не найдено")
        return

    # === Вывод результата ===
    print("Оптимальное назначение найдено")
    print("Минимальная стоимость:", solver.Objective().Value(), "\n")

    print("Назначения (исполнитель → работа):")
    for i in range(n):
        for j in range(n):
            if assign[i][j].solution_value() > 0.5:
                print(
                    f"Исполнитель {i + 1} → Работа {j + 1} "
                    f"(стоимость {cost_matrix[i][j]})"
                )
    
    for i in showorctols(status):
        for ii in i:
            print(ii, end="\t")
        print()
        
    


# ===== Пример =====
costs = [
    [3, 6, 4, 6, 4, 2],
    [1, 3, 2, 1, 3, 5],
    [5, 5, 5, 5, 1, 4],
    [4, 5, 6, 7, 1, 9],
    [2, 6, 6, 6, 1, 7],
    [5, 6, 4, 5, 1, 5]
]

solve_assignment(costs)


