



/// Модуль реализующий ошибки БД



/// <summary> Для борьбы с всякими </summary>
class SQLInjection: Exception{
    public SQLInjection(string message = "В запросе были недопустимые символы"): base(message){}
}

/// <summary> Исключение подымаемое если данные некорректны или пусты</summary>
class DataError: Exception{
    public DataError(string message = "Данные некорректны или пусты"): base(message){}
}