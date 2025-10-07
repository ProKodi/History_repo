



/// <summary>Класс стек тудентов</summary>
class Stack_Student{
    protected Stack<Student> students;

    public Stack<Student> Students{get{return new Stack<Student>(this.students);}}

    protected Stack_Student(){this.students = new Stack<Student>();}

    protected static Stack_Student? self = null;

    public static Stack_Student get_obj(){
        if(self == null) {self = new Stack_Student();}
        return self;
    }

    /// <summary>Добавляем элемент в стек</summary>
    /// <param name="obj"></param>
    public void append(Student obj){students.Push(obj);}

    public void delete(){this.students.Pop();}

    public Stack<Student> select_age(int age){
        //Stack<Student> temp = new Stack<Student>(this.students); 
        var new_list = (from i in this.students
            where i.Age >= age
            select i
        );
        Stack<Student> temp = new Stack<Student>();
        foreach(Student person in new_list){
            temp.Push(person);
        }
        return temp;
    }

    public Stack<Student> select_name(string name){
        var new_list = (from i in this.students
            where i.Name == name
            select i
        );
        Stack<Student> temp = new Stack<Student>();
        foreach(Student person in new_list){
            temp.Push(person);
        }
        return temp;
    }


    public int Count{get{return this.students.Count;}}

    public int find_item(string name){
        int index = 0;
        Stack<Student> temp = new Stack<Student>(this.students);
        while(temp.Count > 0){
            Student i = temp.Pop();
            if(i.Name == name){return index;}
            index += 1;
        }
        return -1;
    }

    public override string ToString(){
        string res = "[";
        foreach(Student i in students){
            res += i.ToString() + "\n";
        }
        res += "\b]";
        return res;
    }
    
}