



delegate void Change_Function(Student stude);
delegate void Filter_Function();



partial class MainForm: Form{
    public MainForm(){
        InitializeComponent();
        Stack_Student.get_obj();
    }
    
    /// <summary>Перерисовка таблицы</summary>
    void refresh_table(){
        this.TableTree.Rows.Clear();
        Stack<Student> temp = Stack_Student.get_obj().Students;
        while(temp.Count > 0){
            Student stude = temp.Pop();
            this.TableTree.Rows.Add(new object[]{stude.Name, stude.Age, stude.Number_cout, stude.Name_group, stude.Hp});
        }
    }

    /// <summary>Добавление данных</summary>
    private void append_item_Click(object sender, EventArgs e){
        Input.InputForm form = new Input.InputForm();
        form.append_function = (Student stude) =>{
            Stack_Student.get_obj().append(stude);
            this.refresh_table();
        }; 
        form.ShowDialog(this);
    }

    /// <summary>Удаление данных с таблицы и структуры</summary>
    private void delete_item_Click(object sender, EventArgs e){
        try{
            Stack_Student.get_obj().delete();
            this.refresh_table();
        }
        catch{MessageBox.Show("Нечего удалять", "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
    }

    private void find_item_Click(object sender, EventArgs e){
        Console.WriteLine("Find item");
        FindForm form = new FindForm();
        form.ShowDialog(this);

        int index = Stack_Student.get_obj().find_item(form.Name_found);
        if(index == -1){
            MessageBox.Show("Обьект не найден", "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        for(int i = 0; i < Stack_Student.get_obj().Count; i += 1){
            this.TableTree.Rows[i].Selected = false;
        }
        this.TableTree.Rows[index].Selected = true;
    }


    private void filtration_item_Click(object sender, EventArgs e){
        Filter form = new Filter();

        form.fultrete = () => {
            this.TableTree.Rows.Clear();
            Stack<Student> temp = Stack_Student.get_obj().select_name(form.Name_find.Trim());
            while(temp.Count > 0){
                Student stude = temp.Pop();
                this.TableTree.Rows.Add(new object[]{stude.Name, stude.Age, stude.Number_cout, stude.Name_group, stude.Hp});
            }
        };

        form.ShowDialog(this);
    }

    private void filtration_item2_Click(object sender, EventArgs e){
        Filter2 form = new Filter2();

        form.fultrete = () => {
            this.TableTree.Rows.Clear();
            Stack<Student> temp = Stack_Student.get_obj().select_age(form.Age_find);
            while(temp.Count > 0){
                Student stude = temp.Pop();
                this.TableTree.Rows.Add(new object[]{stude.Name, stude.Age, stude.Number_cout, stude.Name_group, stude.Hp});
            }
        };
        form.ShowDialog(this);
    }

    private void filtration_item3_Click(object sender, EventArgs e){
        this.TableTree.Rows.Clear();
        this.refresh_table(); 
    }
}