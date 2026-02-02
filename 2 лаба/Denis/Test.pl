



:- encoding(utf8).

% --------------------
% Кандидаты на роли
% --------------------

% Биологи
can(biologist, "Евгений").
can(biologist, "Григорий").

% Врачи
can(doctor, "Андрей").
can(doctor, "Дмитрий").

% Синоптики
can(meteorologist, "Федор").
can(meteorologist, "Григорий").

% Гидлологи
can(hydrologist, "Виктор").
can(hydrologist, "Федор").

% Радисты
can(radioman, "Сергей").
can(radioman, "Дмитрий").

% Механики
can(mechanic, "Сергей").
can(mechanic, "Николай").


% Ограничения:
% Федор не может ехать без Виктора.
% Дмитрий не может ехать без Николая и без Сергея.
% Сергей не может ехать с Григорием.
% Андрей не может ехать с Виктором.
restriction(Team) :-
    % если в команде есть Фёдор, то должен быть и Виктор
    ( member("Федор", Team) -> member("Виктор", Team) ; true ),

    % если в команде есть Дмитрий, то должны быть и Николай, и Сергей
    ( member("Дмитрий", Team) -> (member("Николай", Team), member("Сергей", Team)) ; true ),

    % Сергей не может ехать с Григорием
    \+ (member("Сергей", Team), member("Григорий", Team)),

    % Андрей не может ехать с Виктором
    \+ (member("Андрей", Team), member("Виктор", Team)).

% Проверка уникальности
all_different([]).
all_different([H|T]) :-
    \+ member(H, T),
    all_different(T).



% Формирование команды
expedition(Team) :-
    can(biologist, Bio),
    can(doctor, Doc),
    can(meteorologist, Met),
    can(hydrologist, Hyd),
    can(radioman, Rad),
    can(mechanic, Mec),

    Team = [Bio, Doc, Met, Hyd, Rad, Mec],

    % выполняем все ограничения
    restriction(Team),

    % все участники разные
    all_different(Team).

% Формирование команды (форматированный вывод)
fexpedition(Team) :-
    expedition(Team),

    nl, write('===== Состав экспедиции ====='), nl,
    NameRoles = ["Биолог", "Врач", "Синоптик", "Гидлолог", "Радист", "Механик"],

    length(NameRoles, Len),
    MaxIndex is Len - 1,

    forall(
        (
            between(0, MaxIndex, Index),
            nth0(Index, Team, TeamPeople),
            nth0(Index, NameRoles, RolePeople)
        ),
        format('~w: ~w~n', [RolePeople, TeamPeople])
    ),
    write('=============================='), nl.