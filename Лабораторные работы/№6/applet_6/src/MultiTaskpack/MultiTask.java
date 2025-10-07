package MultiTaskpack;

import java.applet.*;
import java.awt.*;

public class MultiTask extends Applet
{
    DrawRects Rects =null;
    DrawOvals Ovals =null;
    Thread Lines = null;

    public static void main(String[] args) {
        CombiFrame frame = new CombiFrame("Frame");

        frame.show();
        frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 500, frame.insets().top + frame.insets().bottom + 500);

        MultiTask applet_Combi = new MultiTask();
        frame.add("Center", applet_Combi);


        applet_Combi.init();
        applet_Combi.start();

        frame.show();
    }

    public MultiTask()
    {

    }
    public String getAppletInfo()
    { return "Name: Applet\r\n"; // информация об апплете
    }
    public void init()
    { resize(320, 240); // установка размера апплета
// здесь можно добавить код инициализации апплета
    }
    public void destroy()
    { // здесь можно добавить код завершения работы апплета
    }
    public void paint(Graphics g)
    { // здесь можно добавить код вывода в окно апплета
    }
    public void start()
    {
        if(Rects==null) { Rects=new DrawRects(this); Rects.start(); }
        if(Ovals==null) { Ovals=new DrawOvals(this); Ovals.start(); }
        if(Lines==null) { Lines=new Thread(new DrawLines(this)); Lines.start(); }
    }
    public void stop()
    {

        if(Rects!=null) Rects.stop();
        if(Ovals!=null) Ovals.stop();
        if(Lines!=null) Lines.stop();
    }
// здесь можно добавить специализированный для класса код
}
