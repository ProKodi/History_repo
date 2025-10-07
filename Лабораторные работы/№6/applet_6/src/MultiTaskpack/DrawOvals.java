package MultiTaskpack;

import java.awt.*;

class DrawOvals extends Thread
{ // конструктор, получающий ссылку на создателя объекта - апплет
    public DrawOvals(MultiTask parentObj)
    { parent=parentObj;
    }
    public void run()
    { Graphics gr=parent.getGraphics(); // контекст апплета
        while(true) // в цикле выводятся эллипсы
        { int w=parent.size().width-1, h=parent.size().height-1;
            gr.setColor(new Color((float)Math.random(),
                    (float)Math.random(),(float)Math.random()));
            gr.fillOval((int)(Math.random()*w),(int)(Math.random()*h),
                    (int)(Math.random()*w),(int)(Math.random()*h));
        }
    }
    MultiTask parent; // ссылка на создателя объекта
}