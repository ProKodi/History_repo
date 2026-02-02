domains
	S=symbol
predicates
	male(S)
	female(S)
	parent(S,S)
	mother(S,S)
	father(S,S)
	son(S,S)
	daughter(S,S)
	brother(S,S)
	sister(S,S)
	grandmother(S,S)
	grandfather(S,S)
	uncle(S,S)
	aunt(S,S)
clauses

	male("Vasya").
	male("Serega").
	male("Stas").
	male("Slava").
	male("Stepa").
	male("Denis").
	male("Sasha").
	male("Tolya").
	male("Kostya").
	male("Dima").
	
	female("Margarita").
	female("Katya").
	female("Olga").
	female("Karina").
	female("Tamara").
	female("Tanya").
	female("Lena").
	female("Alena").
	female("Kristina").
	female("Galina").
	
	parent("Margarita", "Serega").
	parent("Margarita", "Stas").
	parent("Margarita", "Olga").
	parent("Vasya", "Serega").
	parent("Vasya", "Stas").
	parent("Vasya", "Olga").
	
	parent("Olga", "Denis").
	parent("Olga", "Tanya").
	parent("Slava", "Denis").
	parent("Slava", "Tanya").
	
	parent("Serega", "Stepa").
	parent("Katya", "Stepa").
	
	parent("Stepa", "Lena").
	parent("Stepa", "Sasha").
	parent("Karina", "Lena").
	parent("Karina", "Sasha").
	
	parent("Denis", "Tolya").
	parent("Tamara", "Tolya").
	parent("Sasha", "Kostya").
	parent("Alena", "Kostya").
	
	parent("Tolya", "Dima").
	parent("Tolya", "Galina").
	parent("Kristina", "Dima").
	parent("Kristina", "Galina").
	
mother(X,Y):-parent(X,Y),female(X).
father(X,Y):-parent(X,Y),male(X).
son(Z,X):-parent(X,Z),male(Z).
daughter(Z,X):-parent(X,Z),female(Z).
grandmother(P,Z):-parent(P,Y),parent(Y,Z),female(Z).
grandfather(P,Z):-parent(P,Y),parent(Y,Z),male(Z).
brother(X,Z):-mother(Y,X),mother(Y,Z),male(X),(X)<>(Z).
sister(X,Z):-mother(Y,X),mother(Y,Z),female(X),(X)<>(Z).
uncle(X,Z):-parent(V,Z),brother(X,V).
aunt(X,Z):-parent(V,Z),sister(X,V).