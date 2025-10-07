



class Field{
    /// <summary>Координаты центра графика + его же радиус</summary>
    protected Point zero = new Point(0, 0); 

    /// <summary>Точка начала посторения графика <summary>
    protected Point start = new Point(0, 0); 

    /// <summary>Точка конца посторения графика <summary>
    protected Point finish = new Point(0, 0); 

    /// <summary>коофицент масштабирования</summary>  
    public int kof = 0; 


    public Field(Point start, Point finish, int kof){
        this.start = start;
        this.finish = finish;
        this.zero = new Point(
            (finish.X - start.X) / 2, 
            (finish.Y - start.Y) / 2
        );

        this.kof = kof; 
    }

    /// <summary>Метод ресующий поле</summary>
    /// <param name="g"></param>
    public void DrawDrid(ref Graphics g){
        Pen pen = new Pen(Color.Black, 1);
        for(int x = this.start.X; x <= this.finish.X; x += this.kof){
            g.DrawLine(pen, x, this.start.Y, x, this.finish.Y);
        }
        for(int y = this.start.Y; y <= this.finish.Y; y += this.kof){
            g.DrawLine(pen, this.start.X, y, this.finish.X, y);
        }
        pen = new Pen(Color.Red, 3);
        g.DrawEllipse(pen, this.start.X + this.zero.X - 1, this.start.Y + this.zero.Y - 1, 2, 2);

    }

    public void Show(ref Graphics g, bool flag_drid = true){
        //g.Clear(Color.White); 
        if(flag_drid){this.DrawDrid(ref g); }
    }
    
    /// <summary>Рисование линии</summary>
    public void DrawPoin(ref Graphics g, int x, int y){
        x *= this.kof; y *= this.kof; 
        Pen pen = new Pen(Color.Blue, 1);
        g.DrawLine(pen, this.start.X + this.zero.X, this.start.Y + this.zero.Y, 
            this.start.X + this.zero.X + x, this.start.Y + this.zero.Y - y
        );
    }

    
    public void DrawLine(ref Graphics g, FPoint start, FPoint end, Color? colr = null){
        if(colr == null){colr = Color.Black;}
        start *= this.kof; 
        end *= this.kof; 

        Pen pen = new Pen((Color)colr, 1);

        g.DrawLine(pen, this.start.X + this.zero.X + (int)start.X, this.start.Y + this.zero.Y - (int)start.Y, 
            this.start.X + this.zero.X + (int)end.X, this.start.Y + this.zero.Y - (int)end.Y
        );
    }

    

    public override string ToString(){
        return $"start point: [{this.start.X}, {this.start.Y}] end point: [{this.finish.X}, {this.finish.Y}] zero: [{this.zero.X}, {this.zero.Y}]"; 
    }
}