using System.Collections.Immutable;

namespace _6_lab___C_
{
    public partial class MainWindow : Form
    {
        Fish[] allfish = new Fish[]
        {
            new Fish ("Esox lucius", "Евразия, Сев. Америка", "щуки", true),
            new Fish ("Mugil", "Чёрное, Азовское, Японское моря", "кефали (серые)", false),
            new Fish ("Cyprinus carpio", "Евразия, Сев. Америка", "карпы", true),
            new Fish ("Silurus glanis", "Европа", "сомы", true),
            new Fish ("Takifugu rubripes", "западные акватории Японского моря", "такифугу", false),
            new Fish ("Amphiprion percula", "западная часть Тихого океана", "рыбы-клоуны", false)
        };
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < allfish.Length; i++)
            {
                OutputBox.Items.Add(allfish[i].ShowInfo());
            }
        }
        private void Modify_Button_Click(object sender, EventArgs e)
        {
            OutputBox.Items.Clear();
            Fish[] temp = new Fish[allfish.Length];
            for (int i =0; i < allfish.Length;i++)
            {
                temp[i] = allfish[i];
            }
            for (int i = 0; i < allfish.Length; i++)
            {
                if (allfish[i].is_it_freshwater)
                {
                    OutputBox.Items.Add(allfish[i].ShowInfo());
                    allfish[i] = temp[i];
                }
            }
            for (int i = 0; i < allfish.Length; i++)
            {
                if (!(allfish[i].is_it_freshwater))
                {
                    OutputBox.Items.Add(allfish[i].ShowInfo());
                    allfish[i] = temp[i];
                }
            }
            MessageBox.Show("Список отсортирован. Сначала записана пресноводная рыба.", "Сортировка выполнена.");
        }
        private void Compare1_2_Click(object sender, EventArgs e)
        {
            if (allfish[0] == allfish[1])
            {
                MessageBox.Show("Объекты равны", "Результат");
            }
            else MessageBox.Show("Объекты неравны", "Результат");
        }
        private void Clone_Button_Click(object sender, EventArgs e)
        {
            allfish[5] = (Fish)allfish[1].Clone();
            OutputBox.Items.Clear();
            for (int i = 0; i < allfish.Length; i++)
            {
                OutputBox.Items.Add(allfish[i].ShowInfo());
            }
            MessageBox.Show("Поверхностное копирование завершено", "Операция завершена");
        }
        private void Compare2_6_Click(object sender, EventArgs e)
        {
            if (allfish[1] == allfish[5])
            {
                MessageBox.Show("Объекты равны", "Результат");
            }
            else MessageBox.Show("Объекты неравны", "Результат");
        }

        private void Upcast_Button_Click(object sender, EventArgs e)
        {
            Animal animal = allfish[3] as Animal;
            Animal animal2 = new Mammal("Felis Catus", "в домах", "кошки", 2);
            Animal[] animals = new Animal[2]
            {
                animal,
                animal2
            };
            MessageBox.Show($"Полученные объекты: первый: {animals[0].ShowInfo()}. Второй: {animals[1].ShowInfo()}", "Upcast завершён.");
        }
    }
}

