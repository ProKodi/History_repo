



#pragma once


#include <iostream>


#include <chrono>
#include <cmath>
#include <numeric>
#include <algorithm>
#include <random>
#include <array>
#include <tuple>

namespace new_profiler_task{

// --- Диагностика (НЕ ТРОГАТЬ) ---
long long branch_mispredictions = 0;
long long cache_misses = 0;
// --------------------------------


float energy_limit = 100.0f * (std::log(2.718) + std::sin(0.5) / std::cos(0.5) * std::tan(0.2));






int test() {
    
    const size_t DATA_SIZE = 8'388'608;

    double* particles = new double[DATA_SIZE];


    std::vector<int> process_order(DATA_SIZE);

    for(size_t i = 0; i < DATA_SIZE; ++i){

        float temp1 = rand() % 200; 
        //temp1 *= temp1;

        float temp2 = rand() % 200; 
       // temp2 *= temp2;

        float temp3 = rand() % 200; 
        //temp3 *= temp3;

        particles[i] = 0.5f * (pow(temp1, 2) + pow(temp2, 2) + pow(temp3, 2));
    }

    std::iota(process_order.begin(), process_order.end(), 0);
    std::mt19937 g(0); // Фиксированный seed для повторяемости
    std::shuffle(process_order.begin(), process_order.end(), g);






    double total_energy = 0.0;
    auto start = std::chrono::high_resolution_clock::now();


    for (size_t i = 0; i < DATA_SIZE; i += 1) {
        const double& p =  particles[process_order[i]];

        // --- Симуляция промаха кэша и провала предвыборки ---
        if (i > 0 && (&p - &particles[process_order[i-1]]) != 1) { cache_misses++; }
        // ----------------------------------------------------


        // --- Симуляция ошибки предсказателя переходов ---
        bool is_high_energy = particles[i] > energy_limit;

        if (i > 0 && is_high_energy != ( particles[process_order[i-1]] > energy_limit) ) {
            branch_mispredictions++;
        }
        // -------------------------------------------------

        if (is_high_energy) { total_energy += particles[i]; }
    }






    auto end = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double, std::milli> duration = end - start;


    // --- ВЫВОД ДИАГНОСТИКИ ---
    std::cout << "--- Performance Report(new) ---" << std::endl;
    std::cout << "Total execution time: " << duration.count() << " ms" << std::endl;
    std::cout << "Simulated Cache Misses: " << cache_misses << " (~" << (100.0 * cache_misses / DATA_SIZE) << "%)" << std::endl;
    std::cout << "Simulated Branch Mispredictions: " << branch_mispredictions << " (~" << (100.0 * branch_mispredictions / DATA_SIZE) << "%)" << std::endl;
    std::cout << "Final energy sum: " << total_energy << std::endl; // Для проверки корректности


    delete particles; 


    return 0;
}




}



