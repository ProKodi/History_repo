domains
	S=symbol
predicates
	male(S)
	female(S)
	parent(S,S)
	mother(S,S)
	father(S,S)
	brother(S,S)
	uncle(S,S)
	nephew(S,S)
clauses

	male("Konstantin").
	male("Sergey").
	male("Andrei").
	male("Ivan").
	male("Vladislav").
	male("Egor").
	male("Dmitriy").
	male("Zahar").
	male("Victor").
	
	female("Lyudmila").
	female("Elizaveta").
	female("Alina").
	female("Galina").
	female("Maria").
	female("Kristina").
	female("Sofia").
	female("Ekaterina").

	
	parent("Lyudmila", "Sergey").
	parent("Konstantin", "Sergey").
	parent("Lyudmila", "Elizaveta").
	parent("Konstantin", "Elizaveta").
	parent("Lyudmila", "Andrei").
	parent("Konstantin", "Andrei").
	parent("Alina","Zahar").
	parent("Sergey","Zahar").
	parent("Zahar","Ekaterina").
	parent("Galina","Ekaterina").
	parent("Ekaterina","Victor").
	parent("Ivan","Victor").
	parent("Elizaveta","Vladislav").
	parent("Egor","Vladislav").
	parent("Elizaveta","Dmitriy").
	parent("Egor","Dmitriy").
	parent("Maria", "Kristina").
	parent("Andrei","Kristina").
	parent("Maria","Sofia").
	parent("Andrei","Sofia").
	
mother(X,Y):-parent(X,Y),female(X).
father(X,Y):-parent(X,Y),male(X).
brother(X,Z):-mother(Y,X),mother(Y,Z),male(X),(X)<>(Z).
uncle(X,Z):-parent(V,Z),brother(X,V).
nephew(X,Z):-uncle(Z,X),male(X).