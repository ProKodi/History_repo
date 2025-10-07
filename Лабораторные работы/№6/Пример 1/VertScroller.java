import java.applet.Applet;
import java.awt.*;

public class VertScroller extends Applet implements Runnable
{

    private Thread m_Task = null;
    String strs[]={"First string", "Second string", "Third string"};
    Dimension appSize;


    private boolean m_fStandAlone = false;

    public static void main(String args[])
    {// Создать рамку (фрейм) для апплета
        MainWndFrame frame = new MainWndFrame("Title");

        frame.show(); frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 320,
                frame.insets().top + frame.insets().bottom + 240);

        VertScroller applet_Combi = new VertScroller();
        frame.add("Center", applet_Combi);

        applet_Combi.m_fStandAlone = true;

        applet_Combi.init();
        applet_Combi.start();

        frame.show();
    }

    public String getAppletInfo()
    { return "Name: CombiApplet\r\n" +"";
    }

    public void init()
    {
        resize(320, 240);
        appSize = getSize();
    }

    public void destroy()
    {
    }

    Graphics graphics;
    public void paint(Graphics g)
    {
        graphics = g;
        appSize = size();
        g.setColor(Color.YELLOW);
        g.fillRect(0, 0, appSize.width, appSize.height);
        g.setColor(Color.black);
        g.drawRect(0, 0, appSize.width- 1, appSize.height -1);
    }

    public void start()
    {
        if (m_Task == null)
        { m_Task = new Thread(this); // создание задачи
            m_Task.start(); // запуск задачи
        }

    }

    public void stop()
    {

        if (m_Task != null) {
            m_Task.stop();
            m_Task = null;
        }
    }

    public void run()
    {
        int counter=0; // счетчик сдвигов
        int current=0; // номер текущей рисуемой строки
        int hy=1; // размер сдвига по вертикали
        Graphics g = getGraphics(); // контекст окна апплета
        int yChar=g.getFontMetrics().getHeight(); // высота символа

        while (true)
        {
            try
            {
                g.copyArea(0, hy+1,appSize.width -1, appSize.height-1, 0, -hy);
                g.setColor(Color.YELLOW);
                g.fillRect(1, appSize.height-hy-1, appSize.width-2, hy);
                counter++;
                if(counter == yChar+5)
                {
                    counter=0;
                    if(current == 0)
                    {
                        g.setColor(Color.RED);
                    }
                    else
                    {
                        g.setColor(Color.BLACK);
                    }
                    g.drawString(strs[current], 10, appSize.height-10);
                    current++;
                    if(current >= strs.length) current = 0;
                }



                Thread.sleep(50);
                //repaint();
            }
        catch (InterruptedException e)
        {
            stop();
        }
        }
    }

}