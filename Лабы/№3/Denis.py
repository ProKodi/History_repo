



from ortools.linear_solver import pywraplp

def solve_transportation_problem():
    # Создаем решатель
    solver = pywraplp.Solver.CreateSolver('SCIP')
    
    # Данные задачи
    num_suppliers = 3
    num_consumers = 4
    
    # Запасы поставщиков
    supply = [30, 40, 80]
    
    # Потребности потребителей
    demand = [20, 70, 10, 50]
    
    # Матрица стоимостей перевозок
    costs = [
        [ 1,  5, 4,  2 ],  # от поставщика 1
        [12, 10, 16, 8 ],   # от поставщика 2
        [ 4, 13, 14, 10]   # от поставщика 2
    ]
    
    # Создаем переменные
    x = {}
    for i in range(num_suppliers):
        for j in range(num_consumers):
            x[i, j] = solver.NumVar(0, solver.infinity(), f'x_{i}_{j}')
    
    # Ограничения по запасам
    for i in range(num_suppliers):
        solver.Add(
            sum(x[i, j] for j in range(num_consumers)) <= supply[i],
            f'Supply_{i}'
        )
    
    # Ограничения по потребностям
    for j in range(num_consumers):
        solver.Add(
            sum(x[i, j] for i in range(num_suppliers)) >= demand[j],
            f'Demand_{j}'
        )
    
    # Целевая функция - минимизация стоимости
    objective = solver.Objective()
    for i in range(num_suppliers):
        for j in range(num_consumers):
            objective.SetCoefficient(x[i, j], costs[i][j])
    objective.SetMinimization()
    
    # Решаем задачу
    status = solver.Solve()
    
    # Вывод результатов
    if status == pywraplp.Solver.OPTIMAL:
        print('Решение найдено!')
        print(f'Общая стоимость: {solver.Objective().Value():.2f}\n')
        
        print('Оптимальный план перевозок:')
        total_cost = 0
        for i in range(num_suppliers):
            for j in range(num_consumers):
                amount = x[i, j].solution_value()
                if amount > 0:
                    cost = amount * costs[i][j]
                    print(f'От поставщика {i+1} к потребителю {j+1}: {amount:.1f} units (стоимость: {cost:.2f})')
                    total_cost += cost
        print(f'\nОбщая стоимость: {total_cost:.2f}')
        
        # Проверка ограничений
        print('\nПроверка ограничений:')
        for i in range(num_suppliers):
            used = sum(x[i, j].solution_value() for j in range(num_consumers))
            print(f'Поставщик {i+1}: использовано {used:.1f} из {supply[i]}')
        
        for j in range(num_consumers):
            received = sum(x[i, j].solution_value() for i in range(num_suppliers))
            print(f'Потребитель {j+1}: получено {received:.1f} из {demand[j]}')
    
    else:
        print('Решение не найдено!')

solve_transportation_problem()