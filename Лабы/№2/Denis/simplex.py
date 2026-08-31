



# pip install ortools

from ortools.linear_solver import pywraplp

# Создание решателя
solver = pywraplp.Solver.CreateSolver('GLOP')

# Переменные
y1 = solver.NumVar(0, solver.infinity(), 'y1')
y2 = solver.NumVar(0, solver.infinity(), 'y2')
y3 = solver.NumVar(0, solver.infinity(), 'y3')

# Ограничения
solver.Add(-4 * y1 - y2 - y3 <= -3)
solver.Add( 3 * y1 + 3 * y2 - 2 * y3 <= -4)


# Целевая функция
solver.Minimize(32 * y1 + 21 * y2 + 19 * y3)

# Решение
status = solver.Solve()

if status == pywraplp.Solver.OPTIMAL:
    print("Оптимальное решение найдено")
    print(f"Целевое значение (Z) = {solver.Objective().Value():.2f}")
    print(f"y1 = {y1.solution_value():.2f}")
    print(f"y2 = {y2.solution_value():.2f}")
    print(f"y3 = {y3.solution_value():.2f}")
else:
    print("Решение не найдено")