namespace _9_lab___C_
{
    public partial class MainMenu : Form
    {
        LinkedList<Client> list = new LinkedList<Client>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Input_Button_Click(object sender, EventArgs e)
        {
            InputWindow inputWindow = new InputWindow();
            if (inputWindow.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    for (int i = 0; i < inputWindow.GetName().Length; i++)
                    {
                        if (inputWindow.GetName()[i] >= '0' && inputWindow.GetName()[i] <= '9')
                        {
                            throw new Exception();
                        }
                    }
                    for (int i = 0; i < inputWindow.GetSurname().Length; i++)
                    {
                        if (inputWindow.GetSurname()[i] >= '0' && inputWindow.GetSurname()[i] <= '9')
                        {
                            throw new Exception();
                        }
                    }
                    if (Int32.Parse(inputWindow.GetAge()) < 0 || Int32.Parse(inputWindow.GetAge()) > 130)
                    {
                        throw new Exception();
                    }
                    Client new_client = new Client(Int32.Parse(inputWindow.GetAge()), inputWindow.GetName(), inputWindow.GetSurname(), inputWindow.GetTrait(), inputWindow.GetKey());
                    list.AddLast(new_client);
                    MessageBox.Show("Ќовый клиент задан!", "”спех!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("ќшибка. ¬ведено некорректное значение возраста клиента.", "ќшибка!");
                }
                catch (Exception)
                {
                    MessageBox.Show("ќшибка. ќдно из введЄнных значений (им€/фамили€) клиента указано неверно.", "ќшибка!");
                }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveLast();
                MessageBox.Show("Ёлемент удалЄн.", "”спех!");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("¬аш список пуст!", "ќшибка!");
            }
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            try
            {
                OutputWindow outputWindow = new OutputWindow();
                if (list.Count > 0)
                {
                    foreach (Client client in list)
                    {
                        outputWindow.Add_Client_Info(client.show_info());
                    }
                    outputWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ёлементы не заданы!", "ќшибка!");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("—корее всего, вы не ввели значени€ в список клиентов...", "ќшибка!");
            }
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                MessageBox.Show("Ёлементы отсортированы.", "”спех!");
                List<Client> ordered_clients = list.Where(client => client.age > 0).OrderBy(client => client.age).ToList();
                list.Clear();
                OutputWindow outputWindow = new OutputWindow();
                foreach (Client client in ordered_clients)
                {
                    outputWindow.Add_Client_Info(client.show_info());
                    list.AddLast(client);
                }
                outputWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("—корее всего, вы не ввели значени€ в список клиентов...", "ќшибка!");
            }
        }

        private void Find_Button_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                SearchWindow searchWindow = new SearchWindow();
                if (searchWindow.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string search_key = searchWindow.GetKey();
                        List<Client> ordered_clients = (list.Where(client => client.key == search_key).Select(client => client)).ToList();
                        MessageBox.Show(ordered_clients[0].show_info(), "”спех!");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Ёлемент не найден.", "ќшибка!");
                    }
                }
            }
            else
            {
                MessageBox.Show("—корее всего, вы не ввели значени€ в список клиентов...", "ќшибка!");
            }
        }

        private void LINQ_Filter_Button_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                MessageBox.Show("Ёлементы отфильтрованы.", "”спех!");
                List<Client> ordered_clients = (from client in list where client.age > 18 select client).ToList();
                list.Clear();
                OutputWindow outputWindow = new OutputWindow();
                foreach (Client client in ordered_clients)
                {
                    outputWindow.Add_Client_Info(client.show_info());
                    list.AddLast(client);
                }
                outputWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("—корее всего, вы не ввели значени€ в список клиентов...", "ќшибка!");
            }
        }
    }
}
