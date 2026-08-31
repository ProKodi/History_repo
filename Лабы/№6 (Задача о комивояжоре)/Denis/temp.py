



# pip install ortools
from ortools.constraint_solver import routing_enums_pb2
from ortools.constraint_solver import pywrapcp


def solve_tsp(distance_matrix):
    n = len(distance_matrix)

    # --- Менеджер индексов ---
    manager = pywrapcp.RoutingIndexManager(n, 1, 0)

    # --- Модель маршрутизации ---
    routing = pywrapcp.RoutingModel(manager)

    # --- Функция расстояний ---
    def distance_callback(from_index, to_index):
        from_node = manager.IndexToNode(from_index)
        to_node = manager.IndexToNode(to_index)
        return distance_matrix[from_node][to_node]

    transit_callback_index = routing.RegisterTransitCallback(distance_callback)
    routing.SetArcCostEvaluatorOfAllVehicles(transit_callback_index)

    # параметры поиска
    search_parameters = pywrapcp.DefaultRoutingSearchParameters()
    search_parameters.first_solution_strategy = (
        routing_enums_pb2.FirstSolutionStrategy.PATH_CHEAPEST_ARC
    )
    search_parameters.local_search_metaheuristic = (
        routing_enums_pb2.LocalSearchMetaheuristic.GUIDED_LOCAL_SEARCH
    )
    search_parameters.time_limit.seconds = 5

    # --- Решение ---
    solution = routing.SolveWithParameters(search_parameters)

    if not solution:
        print("Решение не найдено")
        return

    # --- Вывод ---
    print("Маршрут найден")
    index = routing.Start(0)
    route = []
    distance = 0

    while not routing.IsEnd(index):
        node = manager.IndexToNode(index)
        route.append(node + 1)
        prev_index = index
        index = solution.Value(routing.NextVar(index))
        distance += routing.GetArcCostForVehicle(prev_index, index, 0)

    route.append(manager.IndexToNode(index) + 1)

    print("Маршрут:", " → ".join(map(str, route)))
    print("Длина маршрута:", distance)




distance_matrix = [
    [-1,  30, 46, 19, 13],
    [10, -1,  19, 3, 13],
    [21, 15, -1, 35, 11],
    [26, 22, 30, -1, 15],
    [3,  4,  3,  2, -1]
]

solve_tsp(distance_matrix)

"""_summary_
0,  30, 46, 19, 13
10, 0,  19, 3, 13
21, 15, 0, 35, 11
26, 22, 30, 0, 15
3,  4,  3,  2, 0


"""