



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


% ---------- Правила ----------
grandchild(GC, GP) :-        % GC — grandchild (внук/внучка), GP — grandparent
    parent(GP, P),           % GP — родитель P
    parent(P, GC).           % P — родитель GC

grandson(GC, GP) :-        % GC — grandson (внук/внучка), GP — grandparent
    parent(GP, P),          % GP — родитель P
    male(GC),
    parent(P, GC).           % P — родитель GC
