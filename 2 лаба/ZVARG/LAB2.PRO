domains
    S = symbol

predicates
    person(S)
    profession(S)
    solve(S, S, S)

clauses
    person("Borisov").
    person("Ivanov").
    person("Semenov").

    profession("Locksmith").
    profession("Turner").
    profession("Welder").
	
    solve(Borisov, Ivanov, Semenov) :-
        profession(Borisov), profession(Ivanov), profession(Semenov),
        Borisov <> Ivanov, Borisov <> Semenov, Ivanov <> Semenov,
        Borisov <> "Locksmith",
        Semenov <> "Turner",
		Semenov <> "Locksmith".
        
goal
    solve(Borisov, Ivanov, Semenov),
    write("Borisov is ", Borisov), nl,
    write("Ivanov is ", Ivanov), nl,
    write("Semenov is ", Semenov).