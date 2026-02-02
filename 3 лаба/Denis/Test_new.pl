



:- encoding(utf8).

reverse_words(Sentence, Reversed) :-
    reverse_words_recursive(Sentence, "", Reversed).

reverse_words_recursive("", Acc, Acc).

reverse_words_recursive(Sentence, Acc, Result) :-
    % Ищем первый пробел
    sub_string(Sentence, Before, _, After, " "),
    sub_string(Sentence, 0, Before, _, Word),
    sub_string(Sentence, _, After, 0, Rest),
    % Добавляем слово к аккумулятору
    build_acc(Word, Acc, NewAcc),
    reverse_words_recursive(Rest, NewAcc, Result).

reverse_words_recursive(Sentence, Acc, Result) :-
    Sentence \== "",
    build_acc(Sentence, Acc, Result).

% Вспомогательный предикат для сборки аккумулятора
build_acc(Word, "", Word).
build_acc(Word, Acc, Result) :-
    Acc \== "",
    atom_concat(Word, " ", WordWithSpace),
    atom_concat(WordWithSpace, Acc, Result).