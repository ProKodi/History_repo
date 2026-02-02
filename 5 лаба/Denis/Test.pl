



:- encoding(utf8).


get_number(PrintString, Number) :-
    writeln(PrintString),
    read_line_to_string(user_input, Input),
    number_string(Number, Input).


read_items(0, []) :- !.
read_items(N, [X|Xs]) :-
    N > 0,
    get_number('Введите число: ', X),
    N1 is N - 1,
    read_items(N1, Xs).

read_list(List) :-
    get_number('Сколько чисел хотите ввести? ', Number),
    read_items(Number, List).


min_list([X], X) :- !.              % в списке один элемент — он и есть минимум.

min_list([H|T], Min) :-
    min_list(T, MinTail),           % Рекурсивно ищем минимум хвоста
    ( H < MinTail -> Min = H        % Сравниваем голову с минимумом хвоста
    ; Min = MinTail ).


main(Min) :-
    read_list(List),
    min_list(List, Min).