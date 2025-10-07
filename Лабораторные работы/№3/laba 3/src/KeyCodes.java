import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class KeyCodes extends Applet {
    private boolean m_fStandAlone = false;


    private String[] lines = new String[20]; // Массив для 20 строк
    private int lineCount = 0;

    // Конструктор
    public KeyCodes() {

        for (int i = 0; i < lines.length; i++) {
            lines[i] = "";
        }
    }

    public static void main(String args[]) {
        MainWndFrame frame = new MainWndFrame("KeyCodes");
        frame.show();
        frame.hide();

        frame.resize(frame.insets().left + frame.insets().right + 320,
                frame.insets().top + frame.insets().bottom + 240);

        KeyCodes applet = new KeyCodes();
        frame.add("Center", applet);
        applet.m_fStandAlone = true;
        applet.init();
        applet.start();
        frame.show();
    }


    public String getAppletInfo() {
        return "Name: KeyCodes\nAuthor: Your Name\n";
    }

    public void init() {
        resize(320, 240);
        setBackground(Color.white);
        setFont(new Font("Monospaced", Font.PLAIN, 14));
    }

    public void paint(Graphics g) {

        for (int i = 0; i < lineCount; i++) {
            g.drawString(lines[i], 10, 20 + (i * 20)); // Рисуем строку с отступом
        }
    }


    public boolean keyDown(Event evt, int key) {
        char keyChar = (char) key;
        String modifiers = "";

        if ((evt.modifiers & Event.SHIFT_MASK) != 0) {
            modifiers += "Shift ";
        }
        if ((evt.modifiers & Event.CTRL_MASK) != 0) {
            modifiers += "Ctrl ";
        }
        if ((evt.modifiers & Event.ALT_MASK) != 0) {
            modifiers += "Alt ";
        }
        String line = "Key: " + keyChar + " (Code: " + key + ") " + modifiers;

        if (lineCount < lines.length) {
            for (int i = lineCount; i > 0; i--) {
                lines[i] = lines[i - 1];
            }
            lines[0] = line;
            lineCount++;
        } else {

            for (int i = lines.length - 1; i > 0; i--) {
                lines[i] = lines[i - 1];
            }
            lines[0] = line;
        }

        repaint();

        return true;
    }

    // Событие при отпускании клавиши (ничего не делаем, просто обновляем экран)
    public boolean keyUp(Event evt, int key) {
        repaint();
        return true;
    }
}
