% ---------- Факты ----------

male(vasya).
male(serega).
male(stas).
male(slava).
male(stepa).
male(denis).
male(sasha).
male(tolya).
male(kostya).
male(dima).

female(margarita).
female(katya).
female(olga).
female(karina).
female(tamara).
female(tanya).
female(lena).
female(alena).
female(kristina).
female(galina).

% ---------- Правила ----------

mother(X, Y) :- parent(X, Y), female(X).
father(X, Y) :- parent(X, Y), male(X).

son(Z, X) :- parent(X, Z), male(Z).
daughter(Z, X) :- parent(X, Z), female(Z).

grandmother(P, Z) :- parent(P, Y), parent(Y, Z), female(P).
grandfather(P, Z) :- parent(P, Y), parent(Y, Z), male(P).

brother(X, Z) :- mother(Y, X), mother(Y, Z), male(X), X \= Z.
sister(X, Z) :- mother(Y, X), mother(Y, Z), female(X), X \= Z.

uncle(X, Z) :- parent(V, Z), brother(X, V).
aunt(X, Z) :- parent(V, Z), sister(X, V).

% ---------- Факты ----------

parent(margarita, serega).
parent(margarita, stas).
parent(margarita, olga).
parent(vasya, serega).
parent(vasya, stas).
parent(vasya, olga).

parent(olga, denis).
parent(olga, tanya).
parent(slava, denis).
parent(slava, tanya).

parent(serega, stepa).
parent(katya, stepa).

parent(stepa, lena).
parent(stepa, sasha).
parent(karina, lena).
parent(karina, sasha).

parent(denis, tolya).
parent(tamara, tolya).
parent(sasha, kostya).
parent(alena, kostya).

parent(tolya, dima).
parent(tolya, galina).
parent(kristina, dima).
parent(kristina, galina).