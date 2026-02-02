



from pyswip import Prolog

prolog = Prolog()
prolog.consult("Test.pl")  # Загрузка файла

print( prolog.query("expedition(Team)") )



'''
# Теперь можно выполнять запросы из загруженного файла
for soln in prolog.query("expedition(Team)."):
    print(soln["X"])
'''
