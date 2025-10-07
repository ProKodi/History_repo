import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

public class WindowsDemo extends Applet {
    FrameWnd frmWnd;      // ссылка на окно фрейма
    Button btnShow;       // кнопка для отображения окна фрейма
    Button btnHide;       // кнопка для скрытия окна фрейма

    @Override
    public void init() {
        // Инициализация компонентов апплета
        btnShow = new Button("Show Frame Window");
        btnHide = new Button("Hide Frame Window");

        // Добавление кнопок в апплет
        add(btnShow);
        add(btnHide);

        // Создание фрейма
        frmWnd = new FrameWnd("Frame from Applet");

        // Устанавливаем обработчики событий для кнопок
        btnShow.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                frmWnd.setVisible(true); // отображаем окно фрейма
            }
        });

        btnHide.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                frmWnd.setVisible(false); // скрываем окно фрейма
            }
        });
    }

    @Override
    public void destroy() {
        frmWnd.dispose();  // освобождение ресурсов
    }

    @Override
    public void paint(Graphics g) {
        // Не требуется выполнять отрисовку в апплете
    }

    // Обработчик событий для кнопок
    public boolean action(Event evt, Object obj) {
        if (evt.target instanceof Button) {
            Button btn = (Button) evt.target;
            if (btn.equals(btnShow)) {
                frmWnd.setVisible(true);
            } else if (btn.equals(btnHide)) {
                frmWnd.setVisible(false);
            }
            return true;
        }
        return false;
    }
}
