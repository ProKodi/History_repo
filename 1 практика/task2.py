



# ===== Исходные данные (вариант 1) =====
import ipaddress

"""
Небольшая работа с адресами
Адрес с которого мы начнем:   10.0.20.0
Адрес с которого мы закончим: 10.0.20.255
Маска: 255.255.255.0 (/24)
"""

BASE_NETWORK = ipaddress.ip_network("10.0.20.0/24")

# Узлы (которые небольшие подсети)
subnets_requirements = {
    "A": 5,
    "B": 10,
    "C": 20,
    "D": 15,
    "E": 50,
}

# ===== Вспомогательные функции =====
def required_prefix(hosts: int) -> int:
    """
    Возвращает префикс подсети, достаточный для заданного числа хостов
    """
    for prefix in range(32, 0, -1):
        if (2 ** (32 - prefix) - 2) >= hosts:
            return prefix
    raise ValueError("Невозможно подобрать маску")


# ===== Шаг 1. Сортировка подсетей (VLSM) ===== 
# От больших к меньши 
sorted_subnets = sorted(
    subnets_requirements.items(),
    key=lambda x: x[1],
    reverse=True
)

# ===== Шаг 2. Разбиение сети =====
current_address = BASE_NETWORK.network_address
allocated_subnets = {}

for name, hosts in sorted_subnets:
    prefix = required_prefix(hosts)
    subnet = ipaddress.ip_network(f"{current_address}/{prefix}", strict=False)

    allocated_subnets[name] = subnet
    current_address = subnet.broadcast_address + 1

# ===== Шаг 3. Вывод подсетей =====
print("=== VLSM разбиение ===\n")

for name, subnet in allocated_subnets.items():
    hosts = list(subnet.hosts())
    print(f"Подсеть {name}")
    print(f"  Network   : {subnet.network_address}/{subnet.prefixlen}")
    print(f"  Mask      : {subnet.netmask}")
    print(f"  Hosts     : {hosts[0]} - {hosts[-1]}")
    print(f"  Broadcast : {subnet.broadcast_address}")
    print(f"  Gateway   : {hosts[0]}")
    print()

# ===== Шаг 4. Таблица маршрутизации маршрутизатора =====
print("=== Таблица маршрутизации маршрутизатора ===\n")

print(f"{'Destination':<18} {'Mask':<18} {'Next hop'}")
for subnet in allocated_subnets.values():
    print(f"{str(subnet.network_address):<18} {str(subnet.netmask):<18} connected")

# ===== Шаг 5. Таблица маршрутизации хоста  =====
host_subnet = allocated_subnets["C"]
gateway = list(host_subnet.hosts())[0]
host_ip = list(host_subnet.hosts())[5]

print("\n=== Таблица маршрутизации хоста (подсеть C) ===\n")
print(f"Host IP: {host_ip}")
print(f"Gateway: {gateway}\n")

print(f"{'Destination':<18} {'Mask':<18} {'Gateway'}")
print(f"{str(host_subnet.network_address):<18} {str(host_subnet.netmask):<18} local")
print(f"{'0.0.0.0':<18} {'0.0.0.0':<18} {gateway}")