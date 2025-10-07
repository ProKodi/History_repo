



class Field{
    /// <summary>Координаты центра графика + его же радиус</summary>
    protected Point zero = new Point(0, 0); 
    public Point Zero{get{return this.zero;}} 

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



    /// <summary>Рисование линии</summary>
    public void DrawLine(ref Graphics g, FPoint start, FPoint end, int charts_width = 1, Color? colr = null){
        if(colr == null){colr = Color.Black;}
        start *= this.kof; 
        start = new FPoint(this.start.X + this.zero.X + start.X,
            this.start.Y + this.zero.Y - start.Y
        );
        end *= this.kof; 
        end = new FPoint(this.start.X + this.zero.X + end.X,
            this.start.Y + this.zero.Y - end.Y
        );
        if(start < this.start || start > this.finish){return;}
        if(end < this.start || end > this.finish){return;}
        Pen pen = new Pen((Color)colr, charts_width);
        g.DrawLine(pen, (int)start.X, (int)start.Y, (int)end.X, (int)end.Y);
    }

    public override string ToString(){
        return $"start point: [{this.start.X}, {this.start.Y}] end point: [{this.finish.X}, {this.finish.Y}] zero: [{this.zero.X}, {this.zero.Y}]"; 
    }
}