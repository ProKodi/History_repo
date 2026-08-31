



# pip install ortools

from ortools.linear_solver import pywraplp

# Создание решателя
solver = pywraplp.Solver.CreateSolver('GLOP')

# Переменные
x = solver.NumVar(0, solver.infinity(), 'x')
y = solver.NumVar(0, solver.infinity(), 'y')

# Ограничения
solver.Add(-2 * x + 3 * y <= 6)
solver.Add(x + 3*y <= 15)
solver.Add(3*x - y <= 15)

# Целевая функция
solver.Maximize(x - 3*y)

# Решение
status = solver.Solve()

if status == pywraplp.Solver.OPTIMAL:
    print("Оптимальное решение найдено")
    print(f"Целевое значение (Z) = {solver.Objective().Value():.2f}")
    print(f"x = {x.solution_value():.2f}")
    print(f"y = {y.solution_value():.2f}")
else:
    print("Решение не найдено")