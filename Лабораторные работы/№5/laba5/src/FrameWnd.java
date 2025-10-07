import java.awt.*;
import java.awt.event.*;

public class FrameWnd extends Frame {
    Button btnOk;        // кнопка для скрытия фрейма
    MenuBar mainMenu;    // панель меню
    Menu fileMenu;       // меню "File"
    Menu helpMenu;       // меню "Help"

    public FrameWnd(String title) {
        super(title);
        resize(320, 240);  // установка размеров фрейма

        // Установка фона и переднего плана
        setBackground(Color.yellow);
        setForeground(Color.black);

        // Устанавливаем расположение компонентов
        setLayout(new FlowLayout());

        // Создание кнопки "Ok"
        btnOk = new Button("Ok");
        add(btnOk);

        // Создание панели меню
        mainMenu = new MenuBar();
        fileMenu = new Menu("File");
        helpMenu = new Menu("Help");

        // Добавление пунктов в меню
        fileMenu.add(new MenuItem("New"));
        fileMenu.add(new MenuItem("Exit"));
        helpMenu.add(new MenuItem("Content"));
        helpMenu.add(new MenuItem("About"));

        // Добавление меню в панель
        mainMenu.add(fileMenu);
        mainMenu.add(helpMenu);
        setMenuBar(mainMenu);

        // Устанавливаем обработчики событий
        btnOk.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                hide(); // скрыть фрейм при нажатии на кнопку
            }
        });
    }

    @Override
    public boolean handleEvent(Event evt) {
        if (evt.id == Event.WINDOW_DESTROY) {
            hide();  // скрываем окно при закрытии
            return true;
        }

        if (evt.id == Event.ACTION_EVENT) {
            if (evt.target instanceof Button) {
                // Обработка события от кнопки "Ok"
                Button btn = (Button) evt.target;
                if (btn.equals(btnOk)) {
                    hide();  // скрыть окно при нажатии на кнопку "Ok"
                    return true;
                }
            }

            // Обработка событий от меню
            if (evt.target instanceof MenuItem) {
                String label = (String) evt.arg;
                if (label.equals("Exit")) {
                    System.exit(0);  // завершить работу апплета
                    return true;
                }

                // Создание диалогового окна для пунктов меню "New", "Content", "About"
                String msg = label + " selected";
                DialogWnd dialog = new DialogWnd(msg, this, "Dialog from Frame", true);
                dialog.show();
                return true;
            }
        }

        return super.handleEvent(evt);
    }

    @Override
    public void paint(Graphics g) {
        g.drawString("Это окно - объект FrameWnd", 100, 100);
    }
}
