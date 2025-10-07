



static partial class Input{


public partial class InputForm : Form{
    /// <summary>Функция добавления данных на main форму</summary>
    public Change_Function? append_function = null; 

    public InputForm(){
        InitializeComponent();
    }


    private void input_data_Click(object sender, EventArgs e){
        if(this.Name_input.Text == "" || this.Name_group_input.Text == ""){
            MessageBox.Show("ФИО или номер группы студента не введен", "Введены не все данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if(this.append_function == null){return;} 

        this.append_function(
            new Student(this.Name_input.Text, 
                (int)this.Age_input.Value,(int)this.Number_cout_input.Value, 
                this.Name_group_input.Text, (int)this.Hp_input.Value
            )
        );

    }
}





}