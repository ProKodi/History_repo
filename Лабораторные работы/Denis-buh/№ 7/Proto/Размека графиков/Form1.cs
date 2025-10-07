using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class Form1 : Form{
    Fields new_fild; 
    public Form1()
    {
        InitializeComponent();
        new_fild = new Fields(900, 900); 
    }

    private void NewSize(object sender, System.EventArgs e) // Метод вызывается при конце редактирования размера формы
    {
        /*Console.WriteLine(DisplayRectangle); 
        Console.WriteLine(DisplayRectangle.Width); // Ширина
        Console.WriteLine(DisplayRectangle.Height); // Высота
        Console.WriteLine(ClientRectangle);*/ 
        //Field new_fild = new Field(100, 100, DisplayRectangle.Width, DisplayRectangle.Height); 
        //Console.WriteLine(new_fild); 
        Console.WriteLine(6767); 
    }



    private void Form1_Load(object sender, EventArgs e){
    }
    private void Form1_Paint(object sender, PaintEventArgs e){
         
        Graphics g = e.Graphics;
        new_fild.Show(ref g); 
        new_fild[0].DrawLine(ref g, 
            new FPoint(1, 1), new FPoint(2, 3), Color.Blue
        ); 
        
        



       /* new_fild.Test(ref g); 
        
        
        //new_fild.DrawPoin(ref g, 10, 0); 
        Console.WriteLine(new_fild);*/ 
        // Console.WriteLine(2); 
        /*Field new_fild = new Field(100, 100, DisplayRectangle.Width, DisplayRectangle.Height); 
        Console.WriteLine(new_fild); */
        /*Graphics g = e.Graphics; //использование графическ. объекта
        Pen pen = new Pen(Color.Black, 1);*/
        /*g.DrawLine(pen, 0, 0, 10, 9);
        g.DrawLine(pen, 0, 0, 8, 900);*/
        // g.DrawLine(pen, 40, 40, DisplayRectangle.Width , DisplayRectangle.Height )
    }
}
