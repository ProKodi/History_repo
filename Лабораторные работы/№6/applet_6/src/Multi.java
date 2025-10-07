import java.applet.*;
import java.awt.*;

public class Multi extends Applet implements Runnable {
    // Поток, который будет работать одновременно с апплетом
// --------------------------------------------------------------
    private Thread m_Multi = null;

    private boolean m_fStandAlone = false;

    //--------------------------------------------------------------------------
    public static void main(String args[]) { // Создать рамку (фрейм) для апплета
        MultiFrame frame = new MultiFrame("Title");

        frame.show();
        frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 320,
                frame.insets().top + frame.insets().bottom + 240);

        Multi applet_Combi = new Multi();
        frame.add("Center", applet_Combi);
// Установление признака режима работы - приложение
        applet_Combi.m_fStandAlone = true;

        applet_Combi.init();
        applet_Combi.start();
// Отображение окна фрейма
        frame.show();
    }

    //--------------------------------------------------------------------------
    public Multi() { // Сделать: Добавьте сюда код конструктора
    }

    //--------------------------------------------------------------------------
    public String getAppletInfo() {
        return "Name: CombiApplet\r\n" +
                "";
    }

    //--------------------------------------------------------------------------
    public void init() {
        resize(320, 240);
// Сделать: Добавьте сюда код инициализации
    }

    //-------------------------------------------------------------------------
    public void destroy() {
    }

    //--------------------------------------------------------------------------
    public void paint(Graphics g) { // Сделать: Добавьте сюда код перерисовки окна апплета
        g.drawString("Running: " + Math.random(), 10, 20);
    }

    //--------------------------------------------------------------------------
    public void start() {
        if (m_Multi == null) {
            m_Multi = new Thread(this); // создание потока
            m_Multi.start(); // запуск потока
        }

    }


    public void stop() {
        if (m_Multi != null)
        {
            m_Multi.stop();
            m_Multi = null;
        }

    }


    public void run() {
        while (true) {
            try {
                repaint();

                Thread.sleep(50);
            } catch (InterruptedException e) { // Сделать: Добавьте сюда код, который должен

                stop();
            }
        }
    }
}
