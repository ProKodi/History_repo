



static class Sorted{
    public static void Sort(List<Human> collection, int min_index, int max_index){
        // Если сортируемая коллекция представляет из себя коллекцию с 
        //    1 элементом или без элементов
        if (max_index - min_index <= 1){return;}
        // Индекс пивота
        int pivot = min_index - 1;

        // Сравниваем коллекцию с опорным элементом 
        //    (тут опорный элемент это последний элемент)
        // Левые элементы меньше опорного, правые больше равны опорному
        for (int i = min_index; i < max_index; i++){
            // Если текущий элемент меньше
            if (collection[i].CompareTo(collection[max_index]) < 0){
                // Двигаем пивот в право (левая коллекция уверичивается на 1)
                pivot++;
                // текущий элемент становится левым, пивот - правым
                object tempp = collection[pivot].Clone();
                collection[pivot] = collection[i];
                collection[i] = (Human)tempp;
            }
        }
        // После цикла слева (включая пивот) меньше крайне левого, справа - больше равные 
        // двигаем пивот в право
        pivot++;

        // крайне правый элемент устанавливаем на пивот, пивот на крайне правый
        object temp = collection[pivot].Clone();
        collection[pivot] = collection[max_index];
        collection[max_index] = (Human)temp;

        // Сортируем левую коллекцию
        Sort(collection, min_index, pivot - 1);
        // Сортируем правую коллекцию
        Sort(collection, pivot + 1, max_index);
    }
}

static class Exemple{
    public static List <Patient_Polyclinics> Get_Patient_Polyclinics(){
        return [
            new Patient_Polyclinics(new DateOnly(2000, 10, 6), "мужчина", "Олегович",
                "Олег", new DateOnly(2024, 9, 6), true),
            new Patient_Polyclinics(new DateOnly(1999, 7, 6), "женщина", "Бомбат",
                "Ольга", new DateOnly(2024, 3, 6), true),
            new Patient_Polyclinics(new DateOnly(2002, 8, 7), "мужчина", "Михалович",
                "Михаил", new DateOnly(2023, 3, 6), false),
            new Patient_Polyclinics(new DateOnly(2001, 12, 6), "женщина", "Михалович",
                "Аня", new DateOnly(2003, 3, 6), true),
            new Patient_Polyclinics(new DateOnly(2001, 9, 26), "мужчина", "Бомбатович",
                "Омуэл", new DateOnly(2023, 6, 6), true),
            new Patient_Polyclinics(new DateOnly(2011, 12, 6), "женщина", "Олегович",
                "Ина", new DateOnly(2023, 6, 16), false),
        ]; 
    }
}