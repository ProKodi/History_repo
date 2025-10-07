import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class PanelsDemo2 extends Applet {
    private boolean isStandalone = false;

    // Панели для апплета
    Panel drawPanel, cardPanel, controlPanel;
    Panel backgrPanel, foregrPanel, fontPanel;

    // Кнопки панели управления
    Button btnPrev, btnNext, btnBackgr, btnForegr, btnFont;

    // Меню выбора цвета фона, переднего плана и шрифта
    Choice chBackgr, chForegr, chFont;

    // Строка для хранения шрифта
    Font selectedFont = new Font("Helvetica", Font.PLAIN, 12);  // Начальный шрифт

    // Инициализация апплета
    public void init() {
        setBackground(Color.yellow); // Устанавливаем цвет фона апплета
        setLayout(new GridLayout(1, 3)); // Менеджер компоновки - GridLayout (3 колонки)

        // Создаем панели
        drawPanel = new Panel();
        cardPanel = new Panel();
        controlPanel = new Panel();

        // Устанавливаем менеджеры компоновки
        cardPanel.setLayout(new CardLayout());
        controlPanel.setLayout(new FlowLayout());

        // Создаем панели выбора
        backgrPanel = new Panel();
        foregrPanel = new Panel();
        fontPanel = new Panel();

        // Панель выбора фона
        backgrPanel.add(new Label("Выберите цвет фона:"));
        chBackgr = new Choice();
        chBackgr.addItem("Желтый");
        chBackgr.addItem("Зеленый");
        chBackgr.addItem("Белый");
        backgrPanel.add(chBackgr);

        // Панель выбора цвета переднего плана
        foregrPanel.add(new Label("Выберите цвет текста:"));
        chForegr = new Choice();
        chForegr.addItem("Черный");
        chForegr.addItem("Красный");
        chForegr.addItem("Синий");
        foregrPanel.add(chForegr);

        // Панель выбора шрифта
        fontPanel.add(new Label("Выберите шрифт:"));
        chFont = new Choice();

        // Добавляем реальные шрифты в список chFont
        chFont.addItem("Helvetica");
        chFont.addItem("Courier");
        chFont.addItem("TimesRoman");
        chFont.addItem("Comic Sans MS"); // Добавляем Comic Sans MS
        fontPanel.add(chFont);

        // Добавляем панели в cardPanel
        cardPanel.add("Background", backgrPanel);
        cardPanel.add("Foreground", foregrPanel);
        cardPanel.add("Font", fontPanel);

        // Кнопки управления
        btnBackgr = new Button("Цвет фона");
        btnForegr = new Button("Цвет текста");
        btnFont = new Button("Изменить шрифт");
        btnPrev = new Button("Предыдущий");
        btnNext = new Button("Следующий");

        // Добавляем кнопки в controlPanel
        controlPanel.add(btnBackgr);
        controlPanel.add(btnForegr);
        controlPanel.add(btnFont);
        controlPanel.add(btnPrev);
        controlPanel.add(btnNext);

        // Добавляем панели в апплет
        add(drawPanel);
        add(cardPanel);
        add(controlPanel);

        // Настройка начальных значений для выбранного шрифта
        chFont.select("Helvetica");

        // Обработчики событий для кнопок
        btnPrev.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.previous(cardPanel);
            }
        });

        btnNext.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.next(cardPanel);
            }
        });

        btnBackgr.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.show(cardPanel, "Background");
            }
        });

        btnForegr.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.show(cardPanel, "Foreground");
            }
        });

        btnFont.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.show(cardPanel, "Font");
            }
        });

        // Обработчики событий для меню выбора
        chBackgr.addItemListener(new ItemListener() {
            public void itemStateChanged(ItemEvent e) {
                int index = chBackgr.getSelectedIndex();
                if (index == 0) {
                    drawPanel.setBackground(Color.yellow);
                } else if (index == 1) {
                    drawPanel.setBackground(Color.green);
                } else if (index == 2) {
                    drawPanel.setBackground(Color.white);
                }
                repaint();  // Перерисовываем после изменения фона
            }
        });

        chForegr.addItemListener(new ItemListener() {
            public void itemStateChanged(ItemEvent e) {
                int index = chForegr.getSelectedIndex();
                if (index == 0) {
                    drawPanel.setForeground(Color.black);
                } else if (index == 1) {
                    drawPanel.setForeground(Color.red);
                } else if (index == 2) {
                    drawPanel.setForeground(Color.blue);
                }
                repaint();  // Перерисовываем после изменения цвета текста
            }
        });

        chFont.addItemListener(new ItemListener() {
            public void itemStateChanged(ItemEvent e) {
                String selectedFontName = chFont.getSelectedItem(); // Получаем выбранный шрифт
                if (selectedFontName.equals("Helvetica")) {
                    selectedFont = new Font("Helvetica", Font.PLAIN, 12);
                } else if (selectedFontName.equals("Courier")) {
                    selectedFont = new Font("Courier", Font.PLAIN, 12);
                } else if (selectedFontName.equals("TimesRoman")) {
                    selectedFont = new Font("TimesRoman", Font.PLAIN, 12);
                } else if (selectedFontName.equals("Comic Sans MS")) {
                    selectedFont = new Font("Comic Sans MS", Font.PLAIN, 12);
                }
                repaint();  // Перерисовываем после изменения шрифта
            }
        });
    }

    // Метод для рисования содержимого
    public void paint(Graphics g) {
        // Получаем графику панели для рисования
        Graphics gDraw = drawPanel.getGraphics();

        // Очищаем область панели перед рисованием
        gDraw.clearRect(0, 0, drawPanel.getWidth(), drawPanel.getHeight());

        // Устанавливаем шрифт и цвет текста
        gDraw.setFont(selectedFont);  // Устанавливаем текущий шрифт
        gDraw.setColor(drawPanel.getForeground());  // Устанавливаем текущий цвет текста

        // Рисуем строку
        gDraw.drawString("Пример шрифта, фона и цвета текста", 10, 50);

        // Рисуем рамки для панелей
        gDraw.setColor(Color.black);
        gDraw.drawRect(0, 0, drawPanel.getWidth() - 1, drawPanel.getHeight() - 1);
        gDraw.drawRect(0, 0, cardPanel.getWidth() - 1, cardPanel.getHeight() - 1);
        gDraw.drawRect(0, 0, controlPanel.getWidth() - 1, controlPanel.getHeight() - 1);
    }

    // Метод обработки событий
    public boolean action(Event evt, Object obj) {
        if (evt.target instanceof Button) {
            Button btn = (Button) evt.target;
            if (btn.equals(btnPrev)) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.previous(cardPanel);
                return true;
            } else if (btn.equals(btnNext)) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.next(cardPanel);
                return true;
            } else if (btn.equals(btnBackgr)) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.show(cardPanel, "Background");
                return true;
            } else if (btn.equals(btnForegr)) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.show(cardPanel, "Foreground");
                return true;
            } else if (btn.equals(btnFont)) {
                CardLayout cl = (CardLayout) cardPanel.getLayout();
                cl.show(cardPanel, "Font");
                return true;
            }
        }
        return false;
    }

    // Метод для запуска как standalone приложение
    public static void main(String[] args) {
        PanelsDemo2 applet = new PanelsDemo2();
        Frame frame = new Frame("Applet as Standalone Application");
        applet.isStandalone = true;
        applet.init();
        frame.add(applet);
        frame.setSize(320, 240);
        frame.setVisible(true);
    }
}
