



# pip install ortools
from ortools.constraint_solver import pywrapcp
from ortools.constraint_solver import routing_enums_pb2


def solve_tsp(distance_matrix):
    num_cities = len(distance_matrix)
    depot = 0  # стартовый город

    # === Менеджер индексов ===
    manager = pywrapcp.RoutingIndexManager(
        num_cities,
        1,          # число транспортных средств
        depot       # депо (старт и финиш)
    )

    # === Модель маршрутизации ===
    routing = pywrapcp.RoutingModel(manager)

    # === Callback расстояний ===
    def distance_callback(from_index, to_index):
        from_city = manager.IndexToNode(from_index)
        to_city = manager.IndexToNode(to_index)
        return distance_matrix[from_city][to_city]

    transit_cb = routing.RegisterTransitCallback(distance_callback)
    routing.SetArcCostEvaluatorOfAllVehicles(transit_cb)

    # === Параметры поиска ===
    search_parameters = pywrapcp.DefaultRoutingSearchParameters()
    search_parameters.first_solution_strategy = (
        routing_enums_pb2.FirstSolutionStrategy.PATH_CHEAPEST_ARC
    )
    search_parameters.local_search_metaheuristic = (
        routing_enums_pb2.LocalSearchMetaheuristic.GUIDED_LOCAL_SEARCH
    )
    search_parameters.time_limit.seconds = 5

    # === Решение ===
    solution = routing.SolveWithParameters(search_parameters)

    if solution is None:
        print("Решение не найдено")
        return

    # === Восстановление маршрута ===
    index = routing.Start(0)
    route = []
    total_distance = 0

    while not routing.IsEnd(index):
        city = manager.IndexToNode(index)
        route.append(city + 1)  # нумерация с 1
        next_index = solution.Value(routing.NextVar(index))
        total_distance += routing.GetArcCostForVehicle(index, next_index, 0)
        index = next_index

    route.append(manager.IndexToNode(index) + 1)

    # === Вывод ===
    print("Оптимальный маршрут найден")
    print("Маршрут:", " → ".join(map(str, route)))
    print("Длина маршрута:", total_distance)


# ===== Пример =====
distance_matrix = [
    [0,  2,  4, 10, 4],
    [1,  0, 15, 6,  4],
    [6,  3,  0, 14, 2],
    [5, 21, 10, 0,  5],
    [14, 3,  4,  7,  0]
]

solve_tsp(distance_matrix)

"""_summary_
0 , 2 , 4 , 10, 4
1 , 0 , 15, 6 , 4
6 , 3 , 0 , 14, 2
5 , 21, 10, 0,  5
14, 3,  4,  7,  0


"""