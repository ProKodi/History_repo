



import math

# =========================
# Исходные данные
# =========================

# Сообщение
message_kb = 200            # Кбайт

# Канал
bandwidth_mbps = 1          # Мбит/с
distance_km = 1000          # км
signal_speed = 0.6 * 3e8    # м/с

# Пакеты
packet_kb = 40              # Кбайт (весь пакет)
header_bytes = 40           # байт

# Коммутация
switch_count = 8            # промежуточных узлов
switch_time_ms = 10         # мс

# =========================
# Приведение единиц
# =========================

message_bytes = message_kb * 1024
message_bits = message_bytes * 8

bandwidth_bps = bandwidth_mbps * 1_000_000
distance_m = distance_km * 1_000

packet_bytes = packet_kb * 1024
packet_bits = packet_bytes * 8

payload_bytes = packet_bytes - header_bytes

switch_time_s = switch_time_ms / 1000

# =========================
# Коммутация каналов
# =========================

t_transmission_cc = message_bits / bandwidth_bps
t_propagation = distance_m / signal_speed
t_channel_switching = t_transmission_cc + t_propagation

# =========================
# Коммутация пакетов
# =========================

packet_count = math.ceil(message_bytes / payload_bytes)
t_packet = packet_bits / bandwidth_bps
t_switching = switch_count * switch_time_s

t_packet_switching = (
    packet_count * t_packet +
    (packet_count - 1) * t_packet +
    t_switching +
    t_propagation
)

# =========================
# Разница
# =========================

delta_time = t_packet_switching - t_channel_switching

# =========================
# Вывод результатов
# =========================

print("===== Исходные данные =====")
print(f"Объём сообщения: {message_kb} Кбайт")
print(f"Размер пакета: {packet_kb} Кбайт")
print(f"Заголовок: {header_bytes} байт")
print(f"Полезная нагрузка: {payload_bytes} байт")
print(f"Количество пакетов: {packet_count}")

print("\n===== Коммутация каналов =====")
print(f"Время передачи: {t_transmission_cc:.4f} с")
print(f"Время распространения: {t_propagation:.4f} с")
print(f"Итого: {t_channel_switching:.4f} с")

print("\n===== Коммутация пакетов =====")
print(f"Время передачи 1 пакета: {t_packet:.4f} с")
print(f"Время коммутации: {t_switching:.4f} с")
print(f"Итого: {t_packet_switching:.4f} с")

print("\n===== Сравнение =====")
print(f"Увеличение времени: {delta_time:.4f} с")