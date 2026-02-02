



'''
. 
Напишите функцию  convert , которая умеет конвертировать доллар в другую ва-
люту и наоборот. Для конвертации используются текущие курсы валют, которые 
хранятся в глобальном словаре  exchange_rates. 
Результат округлите до двух знаков после запятой при помощи функции  round
'''



def convert(first_currency: str, second_currency: str, cout_first: float):
    global exchange_rates;
    return round(exchange_rates[f"{first_currency}-{second_currency}"] * cout_first, 2)
    
    
    
exchange_rates = {
    "EUR-USD": 1/0.8618,
    "USD-EUR": 0.8618
}
currency = convert("USD", "EUR", 100) 
print(currency)
print()


exchange_rates = {
    "AUD-USD": 1/1.33368,
    "USD-AUD": 1.33368
}
currency = convert("USD", "AUD", 1000) 
print(currency) 
print()


exchange_rates = {
    "AUD-USD": 1/1.1604,
    "EUR-USD": 1.1604
}
currency = convert("EUR", "USD", 100) 
print(currency)
print()

exchange_rates = {
    "USD-GBP": 1/1.376,
    "GBP-USD": 1.376
}
currency = convert("GBP", "USD", 100) 
print(currency)