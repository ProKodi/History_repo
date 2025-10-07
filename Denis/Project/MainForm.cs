



public partial class MainForm : Form{
    protected Thread? thread_print = null; 

    public MainForm(){InitializeComponent();}

    private void check_text(){
        string text = this.data_input.Text; 
        S1.BackColor = Color.FromArgb(0, 0, 255);
        selected_char.Text = this.data_input.Text.Substring(0, 1);
        number_selected_char.Text = "1";
        Thread.Sleep(1000);
        
        if(!text.StartsWith("0")){
            S1E.BackColor = Color.FromArgb(255, 0, 0);
            MessageBox.Show("Строка начилась не с 0", "Введены не верные данные", 
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            E.BackColor = Color.FromArgb(255, 0, 0);
            data_input.Enabled = true;
            return;
        }
        S1S2.BackColor = Color.FromArgb(0, 255, 0);
        print_data.Text = this.data_input.Text.Substring(0, 1);
        
        Thread.Sleep(1000);
        S1.BackColor = Color.FromArgb(240, 240, 240);
        S1S2.BackColor = Color.FromArgb(240, 240, 240);

        Label[] select_label = [S2, S2S2, S2S3]; 

        for(int i = 1; i < text.Length; i += 1){
            select_label[0].BackColor = Color.FromArgb(0, 0, 255);
            selected_char.Text = this.data_input.Text.Substring(i, 1);
            number_selected_char.Text = $"{i+1}";
            Thread.Sleep(1000);

            switch(text[i]){
                case '0':{
                    select_label[1].BackColor = Color.FromArgb(0, 255, 0);
                    select_label = [S2, S2S2, S2S3]; 
                    break; 
                }
                case '1':{
                    select_label[2].BackColor = Color.FromArgb(0, 255, 0);
                    select_label = [S3, S3S2, S3S3]; 
                    break;
                }
            }
            Thread.Sleep(1000);
            print_data.Text = text.Substring(0, i+1);
            S2.BackColor = Color.FromArgb(240, 240, 240);
            S2S2.BackColor = Color.FromArgb(240, 240, 240);
            S2S3.BackColor = Color.FromArgb(240, 240, 240);
            S3.BackColor = Color.FromArgb(240, 240, 240); 
            S3S2.BackColor = Color.FromArgb(240, 240, 240); 
            S3S3.BackColor = Color.FromArgb(240, 240, 240);

        }

        if(select_label[0] == S2){
            E.BackColor = Color.FromArgb(255, 0, 0);
            MessageBox.Show("Строка кончилась не 1", "Введены не верные данные", 
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            data_input.Enabled = true;
            return;
        }

        print_data.Text = this.data_input.Text;
        selected_char.Text = "";
        number_selected_char.Text = "";
        S3_1.BackColor = Color.FromArgb(0, 255, 0);
        MessageBox.Show("Введеные данные верны", "Данные верны", 
            MessageBoxButtons.OK, MessageBoxIcon.Information
        );
        data_input.Enabled = true;
    }


    private void save_data_Click(object sender, EventArgs e){
        if(this.data_input.Text.Length < 2){
            MessageBox.Show($"Строка меньше 2 символов", "Введены не верные данные",
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            return;
        }
        for(int i = 0; i < this.data_input.Text.Length; i += 1){
            char sim = this.data_input.Text[i]; 
            if(sim != '0' && sim != '1'){
                MessageBox.Show($"В строке символ с номером {i + 1}({sim}) не является 0 или 1", 
                    "Введены не верные данные", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
        }
        if((thread_print != null) && (thread_print.ThreadState != ThreadState.Stopped)){return;}

        data_input.Enabled = false;

        thread_print = new Thread(this.check_text);

        foreach(Control i in tableLayoutPanel2.Controls){
            i.BackColor = Color.FromArgb(240, 240, 240);
        }
        selected_char.Text = "";
        number_selected_char.Text ="";
        print_data.Text = "";

        thread_print.Start();
    }
}