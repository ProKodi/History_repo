



:- encoding(utf8).


% Файл: min_of_three.pl
% Нахождение наименьшего из трех чисел

% Определение предиката min_of_three/4
% min_of_three(A, B, C, Min) - Min будет наименьшим из A, B и C

% Альтернативное решение с использованием отсечения (!)
% Это более точно соответствует примеру из лабораторной работы


get_number(PrintString, Number) :-
    writeln(PrintString),
    read_line_to_string(user_input, Input),
    number_string(Number, Input).


main(Result) :-
    % min
    get_number("Введите значение для a", A),
    get_number("Введите значение для b", B),
    get_number("Введите значение для s", S),

    % max
    get_number("Введите значение для c", C),
    get_number("Введите значение для d", D),
    min(A, B, S, Min),
    max(B, C, D, Max),
    Result is Min + Max.





min(A, B, C, Min) :-
    A < B, A < C, Min = A, !.
    
min(A, B, C, Min) :-
    B < A, B < C, Min = B, !.
    
min(A, B, C, Min) :-
    C < A, C < B, Min = C, !.


max(A, B, C, Max) :-
    A > B, A > C, Max = A, !.
    
max(A, B, C, Max) :-
    B > A, B > C, Max = B, !.
    
max(A, B, C, Max) :-
    C > A, C > B, Max = C, !.