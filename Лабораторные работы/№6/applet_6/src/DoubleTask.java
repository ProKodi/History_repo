import MultiTaskpack.CombiFrame;
import MultiTaskpack.MultiTask;

import java.applet.*;
import java.awt.*;
public class DoubleTask extends Applet implements Runnable
{
    public static void main(String[] args) {
        CombiFrame frame = new CombiFrame("Frame");

        frame.show();
        frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 500, frame.insets().top + frame.insets().bottom + 500);

        DoubleTask applet_Combi = new DoubleTask();
        frame.add("Center", applet_Combi);


        applet_Combi.init();
        applet_Combi.start();

        frame.show();
    }
    public String getAppletInfo()
    { return "Name: Applet\r\n";
    }
    public void init()
    { resize(320, 240);

    }
    public void destroy()
    {
    }
    public void paint(Graphics g)
    { g.drawString("Random value "+Math.random(),10,20);
    }
    public void start()
    {
        if(task==null) { task=new Thread(this); task.start(); }
    }
    public void stop()
    { // остановка потока
        if(task!=null) task.stop();
    }
    public void run()
    {
        while(true)
        {
            repaint();
            try{ Thread.sleep(50); } catch(InterruptedException e) { stop(); }
        }
    }
    Thread task=null;
}
