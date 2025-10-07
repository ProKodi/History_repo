import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class LinesDraw extends Applet {

    private boolean m_fStandAlone = false;
    private int[][] lines = new int[100][4];
    private int lineCount = 0;
    private int startX, startY, endX, endY;
    private boolean isDrawing = false;
    public static void main(String args[]) {
        MainWndFrame frame = new MainWndFrame("Lines Draw");
        frame.show();
        frame.hide();

        frame.resize(frame.insets().left + frame.insets().right + 400,
                frame.insets().top + frame.insets().bottom + 320);

        LinesDraw applet = new LinesDraw();
        frame.add("Center", applet);
        applet.m_fStandAlone = true;
        applet.init();
        applet.start();
        frame.show();
    }


    public LinesDraw() {
    }


    public String getAppletInfo() {
        return "Name: LinesDraw\nAuthor: Your Name\n";
    }

    // Инициализация апплета
    public void init() {
        resize(400, 320); // Устанавливаем размер окна апплета
    }

    // Перерисовка окна апплета
    public void paint(Graphics g) {
        // Рисуем все линии, сохраненные в массиве
        for (int i = 0; i < lineCount; i++) {
            g.drawLine(lines[i][0], lines[i][1], lines[i][2], lines[i][3]);
        }

        if (isDrawing) {
            g.setColor(Color.RED); // Выбираем цвет для текущей рисуемой линии
            g.drawLine(startX, startY, endX, endY);
        }
    }

    // Событие при нажатии кнопки мыши (начало рисования)
    public boolean mouseDown(Event evt, int x, int y) {
        // При двойном щелчке очищаем все линии
        if (evt.clickCount == 2) {
            lineCount = 0; // Очищаем массив
            repaint(); // Перерисовываем апплет
            return true;
        }

        // Инициализируем начальные координаты
        startX = x;
        startY = y;
        isDrawing = true; // Начинаем рисовать

        return true;
    }


    public boolean mouseUp(Event evt, int x, int y) {
        // Сохраняем координаты линии в массив
        if (isDrawing) {
            lines[lineCount][0] = startX;
            lines[lineCount][1] = startY;
            lines[lineCount][2] = x;
            lines[lineCount][3] = y;
            lineCount++; // Увеличиваем счетчик линий

            isDrawing = false; // Останавливаем рисование
            repaint(); // Перерисовываем апплет
        }

        return true;
    }


    public boolean mouseDrag(Event evt, int x, int y) {
        if (isDrawing) {
            endX = x;
            endY = y;
            repaint();
        }
        return true;
    }


    public boolean mouseMove(Event evt, int x, int y) {
        return true;
    }

    public boolean mouseEnter(Event evt, int x, int y) {
        return true;
    }

    public boolean mouseExit(Event evt, int x, int y) {
        return true;
    }
}
