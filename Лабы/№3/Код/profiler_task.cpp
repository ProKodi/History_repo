



#pragma once


#include <iostream>
#include <vector>
#include <chrono>
#include <cmath>
#include <numeric>
#include <algorithm>
#include <random>


namespace profiler_task{



// --- Блок диагностических метрик (НЕ ТРОГАТЬ!) ---
long long branch_mispredictions = 0;
long long cache_misses = 0;
// --------------------------------------------------

// Структура, имитирующая частицу
struct Particle {
    float px, py, pz;    // Положение
    float vx, vy, vz;    // Скорость (полезные данные)
    char name[40];       // Имя частицы (лишние данные)
    bool isActive;       // Флаг активности (лишние данные)
};

// Функция, имитирующая сложный расчет
float get_energy_limit() {
    return 100.0f * (log(2.718) + sin(0.5) / cos(0.5) * tan(0.2));
}

int test() {
    const size_t DATA_SIZE = 8 * 1024 * 1024;


    std::vector<Particle> particles(DATA_SIZE);

    // Карта индексов, задающая случайный порядок доступа
    std::vector<int> process_order(DATA_SIZE);
    std::iota(process_order.begin(), process_order.end(), 0);
    std::mt19937 g(0); // Фиксированный seed для повторяемости
    std::shuffle(process_order.begin(), process_order.end(), g);

    for (size_t i = 0; i < DATA_SIZE; ++i) {
        particles[i].vx = static_cast<float>(rand() % 200);
        particles[i].vy = static_cast<float>(rand() % 200);
        particles[i].vz = static_cast<float>(rand() % 200);
    }


    
    double total_energy = 0.0;
    auto start = std::chrono::high_resolution_clock::now();


    for (size_t i = 0; i < DATA_SIZE; ++i) {
        // --- Симуляция промаха кэша и провала предвыборки ---
        const Particle& p = particles[process_order[i]];
        if (i > 0 && (&p - &particles[process_order[i-1]]) != 1) {
            cache_misses++;
        }
        // ----------------------------------------------------
        
        float kinetic_energy = 0.5f * (p.vx * p.vx + p.vy * p.vy + p.vz * p.vz);

        float energy_limit = get_energy_limit();

        // --- Симуляция ошибки предсказателя переходов ---
        bool is_high_energy = kinetic_energy > energy_limit;
        if (i > 0 && is_high_energy != ( (0.5f * (particles[process_order[i-1]].vx * particles[process_order[i-1]].vx + particles[process_order[i-1]].vy * particles[process_order[i-1]].vy + particles[process_order[i-1]].vz * particles[process_order[i-1]].vz)) > get_energy_limit()) ) {
            branch_mispredictions++;
        }
        // -------------------------------------------------

        if (is_high_energy) {
            total_energy += kinetic_energy;
        }
    }

    auto end = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double, std::milli> duration = end - start;

    // --- ВЫВОД ДИАГНОСТИКИ ---
    std::cout << "--- Performance Report(old) ---" << std::endl;
    std::cout << "Total execution time: " << duration.count() << " ms" << std::endl;
    std::cout << "Simulated Cache Misses: " << cache_misses << " (~" << (100.0 * cache_misses / DATA_SIZE) << "%)" << std::endl;
    std::cout << "Simulated Branch Mispredictions: " << branch_mispredictions << " (~" << (100.0 * branch_mispredictions / DATA_SIZE) << "%)" << std::endl;
    std::cout << "Final energy sum: " << total_energy << std::endl; // Для проверки корректности

    return 0;
}


}