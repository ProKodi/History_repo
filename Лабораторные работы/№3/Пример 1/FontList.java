import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class FontList extends Applet {
    // Признак режима работы программы: true для приложения, false для апплета
    private boolean m_fStandAlone = false;
    private List fontList;

    // Основной метод для запуска апплета как приложения
    public static void main(String[] args) {
        // Создать фрейм (рамку) для апплета
        MainWndFrame frame = new MainWndFrame("Fonts List");
        frame.show();
        frame.hide();

        frame.resize(frame.insets().left + frame.insets().right + 1000,  // Увеличиваем ширину окна
                frame.insets().top + frame.insets().bottom + 1000);  // Увеличиваем высоту окна

        // Создание объекта апплета и его инициализация
        FontList applet = new FontList();
        frame.add("Center", applet);
        applet.m_fStandAlone = true; // Установка режима работы как приложения
        applet.init();
        applet.start();
        frame.show();
    }

    // Конструктор
    public FontList() {
        // Конструктор может быть пустым, если дополнительная инициализация не требуется
    }

    // Метод для получения информации о апплете
    public String getAppletInfo() {
        return "Name: FontsList\nAuthor: Your Name\n";
    }

    // Инициализация апплета
    public void init() {
        resize(1000, 1000);  // Устанавливаем более крупный размер окна

        // Создаем компонент списка
        fontList = new List();
        fontList.setSize(10000, 10000);  // Устанавливаем размер самого списка
        // Получаем все доступные шрифты
        Font[] fonts = GraphicsEnvironment.getLocalGraphicsEnvironment().getAllFonts();

        // Добавляем шрифты в список
        for (Font font : fonts) {
            fontList.add(font.getName());  // Добавляем название шрифта
        }

        add(fontList);  // Добавляем список в апплет
    }

    // Метод для перерисовки апплета (пока не требуется)
    public void paint(Graphics g) {
        // Можно добавить код перерисовки, если потребуется
    }

    // Метод, который вызывается при старте апплета
    public void start() {
        // Добавьте код, который должен быть выполнен при запуске апплета
    }

    // Метод, который вызывается при остановке апплета
    public void stop() {
        // Добавьте код для завершения работы, если необходимо
    }

    // Метод, который вызывается при завершении работы апплета
    public void destroy() {
        // Здесь можно очистить ресурсы
    }
}
