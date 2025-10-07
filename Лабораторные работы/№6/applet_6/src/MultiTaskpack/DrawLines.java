package MultiTaskpack;

import java.awt.*;

class DrawLines implements Runnable
{ // конструктор, получающий ссылку на создателя объекта
    public DrawLines(MultiTask parentObj)
    { parent=parentObj;
    }
    public void draw()
    { int w=parent.size().width-1, h=parent.size().height-1;
        Graphics gr=parent.getGraphics();
        gr.setColor(new Color((float)Math.random(),
                (float)Math.random(),(float)Math.random()));
        gr.drawLine((int)(Math.random()*w),(int)(Math.random()*h),
                (int)(Math.random()*w),(int)(Math.random()*h));
    }
    MultiTask parent; // ссылка на создателя объекта
    // этот метод получает управление при запуске потока
    public void run()
    { while(true) { draw(); }
    }
}