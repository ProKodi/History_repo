



using MySql.Data.MySqlClient;



public static class ConvertDB{
    public static string? GetStringNull(this MySqlDataReader reader, string column){
        var temp = reader[column];
        return  (temp is DBNull || temp is null) ? null : Convert.ToString(temp);  
    }

    public static bool? GetBoolNull(this MySqlDataReader reader, string column){
        var temp = reader[column];
        return  (temp is DBNull || temp is null) ? null : Convert.ToBoolean(temp);  
    }

    public static int? GetInt32Null(this MySqlDataReader reader, string column){
        var temp = reader[column];
        return  (temp is DBNull || temp is null) ? null : Convert.ToInt32(temp);  
    }

    public static long? GetInt64Null(this MySqlDataReader reader, string column){
        var temp = reader[column];
        return  (temp is DBNull || temp is null) ? null : Convert.ToInt64(temp);  
    }

    public static float? GetFloatNull(this MySqlDataReader reader, string column){
        var temp = reader[column];
        return  (temp is DBNull || temp is null) ? null : Convert.ToSingle(temp); 
    }

    public static DateOnly GetDateOnly(this MySqlDataReader reader, string column){
        return DateOnly.FromDateTime(reader.GetDateTime(column));
    }

    public static DateOnly? GetDateOnlyNull(this MySqlDataReader reader, string column){
        var temp = reader[column];
        return  (temp is DBNull || temp is null) ? null : DateOnly.FromDateTime(Convert.ToDateTime(temp)); 
    }

}


public static class ConvertNew{
    public static string GetString(this string? obj){
        return obj == null ? "null" : obj; 
    }

    public static string GetString(this int? obj){
        return obj == null ? "null" : ((int)obj).ToString(); 
    }

    public static string GetString(this DateOnly? obj){
        return obj == null ? "null" : ((DateOnly)obj).ToString(); 
    }

    public static string GetString(this bool? obj){
        return obj == null ? "null" : ((bool)obj).ToString(); 
    }
    
    public static string GetString(this float? obj){
        return obj == null ? "null" : ((float)obj).ToString(); 
    }

}