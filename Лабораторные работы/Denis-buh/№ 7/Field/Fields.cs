



class Fields{
    // Массив полей
    protected Field[] arr = new Field[4]; 

    public Fields(int Width, int Height){
        Width -= 100; Height -= 100; 
        int x_len = Width / 2; int y_len = Height / 2;
        this.arr[0] = new Field(new Point(0, 50), new Point(x_len , y_len + 50), 40);
        this.arr[1] = new Field(new Point(x_len + 100, 50), new Point((x_len * 2) + 100, y_len + 50), 40);
        this.arr[2] = new Field(new Point(0, y_len + 100), new Point(x_len, (y_len * 2) + 100), 40);
        this.arr[3] = new Field(new Point(x_len + 100, y_len + 100), new Point((x_len * 2) + 100, (y_len * 2) + 100), 40);
    }

    public void DrawDrid(ref Graphics g){
        this.arr[0].DrawDrid(ref g);
        this.arr[1].DrawDrid(ref g);
        this.arr[2].DrawDrid(ref g);
        this.arr[3].DrawDrid(ref g);
    }

    public Field this[int index]{get{return this.arr[index];}}
}