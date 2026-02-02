



:- encoding(utf8).

% Основной предикат: разворачивает порядок слов в строке
reverse_words(Sentence, Reversed) :-
    % Разделяем строку на слова
    split_string(Sentence, " ", "", Words),
    % Переворачиваем список слов
    reverse_words_recursive(Words, [], ReversedWords),
    % Собираем обратно в строку
    atomic_list_concat(ReversedWords, " ", Reversed).

% Базовый случай рекурсии: когда исходный список пуст
reverse_words_recursive([], Acc, Acc).

% Рекурсивный случай: берем первое слово, добавляем в аккумулятор
reverse_words_recursive([Word|Rest], Acc, Result) :-
    % Рекурсивно обрабатываем хвост списка
    reverse_words_recursive(Rest, [Word|Acc], Result).