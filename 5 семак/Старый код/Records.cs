



// Рестораны с их адресами и временем работы
record RestarantsWithSchedule{
    public required string Name;
    public required string Address;
    public string? TimeMonday = null;
    public string? TimeTuesday = null;
    public string? TimeWednesday = null;
    public string? TimeThursday = null;
    public string? TimeFriday = null;
    public string? TimeSaturday = null;
    public string? TimeSunday = null;
}

// доступные блюда в ресторане
record DishInRestarant{
    public required string Name;
    public string? Describe = null;
    public bool? ForChildren = null;
    public required int Cost;
    public int? Weight = null;
    public bool? InStock = null;
}

// заказы клиента
record ClientsOrders{
    public string? Name;
    public bool? State = null;
    public required DateOnly Date;
}

// Сотрудники
record WorkersInRestaurant{
    public required string Name;
    public string? Describe;
    public int? Salary;
    public DateOnly? BirthdayDate;
    
}