import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class PanelsDemo1 extends Applet {
    // Признак работы в standalone или в апплете
    private boolean isStandalone = false;

    // Объявляем компоненты
    Panel cardPanel, controlPanel;
    Button btn1, btn2, btn3, btnPrev, btnNext;

    // Инициализация апплета
    public void init() {
        // Устанавливаем фоновый цвет и менеджер компоновки для апплета
        setBackground(Color.yellow);
        setLayout(new GridLayout(1, 2));  // Два блока, горизонтально

        // Создаем панели
        cardPanel = new Panel();
        controlPanel = new Panel();

        // Устанавливаем для cardPanel менеджер CardLayout
        cardPanel.setLayout(new CardLayout());

        // Устанавливаем для controlPanel менеджер FlowLayout
        controlPanel.setLayout(new FlowLayout());

        // Создаем кнопки для блокнота с русскими надписями
        btn1 = new Button("1-я кнопка");
        btn2 = new Button("2-я кнопка");
        btn3 = new Button("3-я кнопка");

        // Добавляем кнопки на страницы блокнота
        cardPanel.add(btn1, "Страница 1");
        cardPanel.add(btn2, "Страница 2");
        cardPanel.add(btn3, "Страница 3");

        // Создаем кнопки управления с русскими надписями
        btnPrev = new Button("Предыдущая");
        btnNext = new Button("Следующая");

        // Добавляем кнопки управления на controlPanel
        controlPanel.add(btnPrev);
        controlPanel.add(btnNext);

        // Добавляем панели в апплет
        add(cardPanel);
        add(controlPanel);
    }

    // Метод обработки событий
    public boolean action(Event evt, Object obj) {
        if (evt.target instanceof Button) {
            Button btn = (Button) evt.target;
            String lbl = btn.getLabel();

            // Обработка нажатий кнопок на страницах блокнота
            if (btn.equals(btn1)) {
                showStatus("Нажата кнопка на Странице 1: " + lbl);
            } else if (btn.equals(btn2)) {
                showStatus("Нажата кнопка на Странице 2: " + lbl);
            } else if (btn.equals(btn3)) {
                showStatus("Нажата кнопка на Странице 3: " + lbl);
            }

            // Обработка нажатий кнопок управления страницами
            else if (btn.equals(btnPrev)) {
                // Перелистывание на предыдущую страницу
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.previous(cardPanel);
            } else if (btn.equals(btnNext)) {
                // Перелистывание на следующую страницу
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.next(cardPanel);
            }

            return true; // Событие обработано
        }

        return false; // Не обработано
    }

    // Метод для запуска как standalone приложение
    public static void main(String args[]) {
        // Создаем фрейм для отображения апплета как standalone
        Frame frame = new Frame("PanelsDemo1");
        PanelsDemo1 applet = new PanelsDemo1();
        applet.isStandalone = true; // Устанавливаем флаг standalone
        frame.add(applet);
        frame.setSize(320, 240);
        frame.setVisible(true);
        applet.init();
        applet.start();

        // Закрытие приложения при закрытии окна
        frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent we) {
                applet.stop();
                System.exit(0);
            }
        });
    }
}

