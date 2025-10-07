



static class Sorted{
    public static void Sort(List<Patient_Hospital> collection, int min_index, int max_index){
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
                collection[i] = (Patient_Hospital)tempp;
            }
        }
        // После цикла слева (включая пивот) меньше крайне левого, справа - больше равные 
        // двигаем пивот в право
        pivot++;

        // крайне правый элемент устанавливаем на пивот, пивот на крайне правый
        object temp = collection[pivot].Clone();
        collection[pivot] = collection[max_index];
        collection[max_index] = (Patient_Hospital)temp;

        // Сортируем левую коллекцию
        Sort(collection, min_index, pivot - 1);
        // Сортируем правую коллекцию
        Sort(collection, pivot + 1, max_index);
    }

    public static void Sort(List<Doctor> collection, int min_index, int max_index){
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
                collection[i] = (Doctor)tempp;
            }
        }
        // После цикла слева (включая пивот) меньше крайне левого, справа - больше равные 
        // двигаем пивот в право
        pivot++;

        // крайне правый элемент устанавливаем на пивот, пивот на крайне правый
        object temp = collection[pivot].Clone();
        collection[pivot] = collection[max_index];
        collection[max_index] = (Doctor)temp;

        // Сортируем левую коллекцию
        Sort(collection, min_index, pivot - 1);
        // Сортируем правую коллекцию
        Sort(collection, pivot + 1, max_index);
    }

    public static void Sort(List<Patient_Polyclinics> collection, int min_index, int max_index){
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
                collection[i] = (Patient_Polyclinics)tempp;
            }
        }
        // После цикла слева (включая пивот) меньше крайне левого, справа - больше равные 
        // двигаем пивот в право
        pivot++;

        // крайне правый элемент устанавливаем на пивот, пивот на крайне правый
        object temp = collection[pivot].Clone();
        collection[pivot] = collection[max_index];
        collection[max_index] = (Patient_Polyclinics)temp;

        // Сортируем левую коллекцию
        Sort(collection, min_index, pivot - 1);
        // Сортируем правую коллекцию
        Sort(collection, pivot + 1, max_index);
    }
}




public partial class MainWindow : Form{
    public MainWindow(){
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e){
        this.Close();
    }



    private void show_Patient_Hospital_Click(object sender, EventArgs e){
        List <Patient_Hospital> list = [
            new Patient_Hospital(new DateOnly(2000, 10, 6), "мужчина", "Олегович",
                "Олег", "098x80086", new DateOnly(2020, 10, 6)),
            new Patient_Hospital(new DateOnly(1999, 7, 6), "женщина", "Бомбат",
                "Ольга", "028x8976", new DateOnly(2022, 10, 6)),
            new Patient_Hospital(new DateOnly(2002, 8, 7), "мужчина", "Михалович",
                "Михаил", "098x866", new DateOnly(2023, 10, 6)),
            new Patient_Hospital(new DateOnly(2001, 12, 6), "женщина", "Михалович",
                "Аня", "098x8976", new DateOnly(2022, 10, 6)),
            new Patient_Hospital(new DateOnly(2001, 9, 26), "мужчина", "Бомбатович",
                "Омуэл", "098x8976", new DateOnly(2022, 11, 26)),
            new Patient_Hospital(new DateOnly(2011, 12, 6), "женщина", "Олегович",
                "Ина", "098x8236", new DateOnly(2024, 3, 2)),
        ]; 

        Sorted.Sort(list, 0, list.Count-1);
        ShowInform form = new ShowInform();
        foreach (Patient_Hospital i in list){
            form.AppendInform(i.ToString());
        }
        form.ShowDialog(this);

    }

    private void show_Doctor_Click(object sender, EventArgs e){
        List <Doctor> list = [
            new Doctor(new DateOnly(2000, 10, 6), "мужчина", "Олегович",
                "Олег", "Терапевт", "врач обыкновенный"),
            new Doctor(new DateOnly(1999, 7, 6), "женщина", "Бомбат",
                "Ольга", "Хирург", "глав-врач"),
            new Doctor(new DateOnly(2002, 8, 7), "мужчина", "Михалович",
                "Михаил", "Дерматолог", "заместитель главного врача"),
            new Doctor(new DateOnly(2001, 12, 6), "женщина", "Михалович",
                "Аня", "Нарколог", "врач нарколог"),
            new Doctor(new DateOnly(2001, 9, 26), "мужчина", "Бомбатович",
                "Омуэл", "Фельшер", "медбрат"),
            new Doctor(new DateOnly(2011, 12, 6), "женщина", "Олегович",
                "Ина", "Окулист", "заведующая"),
        ]; 
        Sorted.Sort(list, 0, list.Count-1);
        ShowInform form = new ShowInform();

        if (this.delete_terapeft.Checked){
            for (int i = 0; i < list.Count; i += 1){
                if (list[i].Speciality == "Терапевт"){list.RemoveAt(i);}
            }
        }

        foreach (Doctor i in list){
            form.AppendInform(i.ToString());
        }
        form.ShowDialog(this);

    }

    private void show_Patient_Polyclinics_Click(object sender, EventArgs e){
        List <Patient_Polyclinics> list = [
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
        Sorted.Sort(list, 0, list.Count-1);

        ShowInform form = new ShowInform();

        foreach (Patient_Polyclinics i in list){
            form.AppendInform(i.ToString());
        }
        form.ShowDialog(this);
    }
}

