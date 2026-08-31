



# pip install ortools
from ortools.linear_solver import pywraplp


def find_optimal_nuts(costs, supply, demand):
    m = len(supply)      # число поставщиков
    n = len(demand)      # число потребителей

    # === Проверка баланса ===
    total_sup = sum(supply)
    total_tnt = sum(demand)

    if total_sup != total_tnt:
        print(f"[!] Задача небалансированная: supply={total_sup}, demand={total_tnt}")
        print("[*] Добавляем фиктивного потребителя/поставщика для баланса.\n")

        if total_sup > total_tnt:
            # добавляем фиктивного потребителя с нулевой стоимостью
            diff = total_sup - total_tnt
            demand.append(diff)
            for row in costs:
                row.append(0)
            n += 1

        else:
            # добавляем фиктивного поставщика
            diff = total_tnt - total_sup
            supply.append(diff)
            costs.append([0] * n)
            m += 1

    solver = pywraplp.Solver.CreateSolver("GLOP")

    # === Переменные x[i][j] ===
    x = [[solver.NumVar(0, solver.infinity(), f'x_{i}_{j}')
          for j in range(n)] for i in range(m)]

    # === Ограничения поставщиков ===
    for i in range(m):
        solver.Add(sum(x[i][j] for j in range(n)) <= supply[i])

    # === Ограничения потребителей ===
    for j in range(n):
        solver.Add(sum(x[i][j] for i in range(m)) >= demand[j])

    # === Цель ===
    solver.Minimize(sum(costs[i][j] * x[i][j] for i in range(m) for j in range(n)))

    status = solver.Solve()

    if status != pywraplp.Solver.OPTIMAL:
        print("❌ Оптимальное решение не найдено")
        return

    print("✅ Оптимальное решение найдено\n")
    print("Минимальная стоимость перевозок:", solver.Objective().Value(), "\n")



# ==== Пример задачи ====
costs = [
    [5, 2, 4, 4],
    [8, 6, 3, 2],
    [8, 5, 1, 5]
]

# спрос потребителей
demand = [60, 90, 40, 60]

# запасы поставщиков
supply = [120, 80, 50]

find_optimal_nuts(costs, supply, demand)