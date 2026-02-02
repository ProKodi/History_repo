




#include <iostream>
#include <vector>
#include <chrono>
#include <cmath>
#include <numeric>
#include <algorithm>
#include <random>



#include "new_profiler_task.cpp"
#include "profiler_task.cpp"






int main(){
    system("chcp 65001");

    profiler_task::test();




    std::cout << "\n";


    new_profiler_task::test();


    return 0;
}


/*
--- Performance Report ---
Total execution time: 1108.46 ms
Simulated Cache Misses: 8388607 (~100%)
Simulated Branch Mispredictions: 4212 (~0.050211%)
Final energy sum: 1.66202e+11

--- Performance Report ---
Total execution time: 1162.06 ms
Simulated Cache Misses: 8388607 (~100%)
Simulated Branch Mispredictions: 4254 (~0.0507116%)
Final energy sum: 1.66252e+11
Press any key to continue . . .

*/