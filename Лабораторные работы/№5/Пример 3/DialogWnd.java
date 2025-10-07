import java.awt.*;
import java.awt.event.*;

public class DialogWnd extends Dialog {
    Label lbMsg;  // метка для отображения сообщения
    Button btnOk; // кнопка "Ok"

    public DialogWnd(String msg, Frame parent, String title, boolean modal) {
        super(parent, title, modal);
        resize(200, 100);  // размер окна

        // Установка расположения компонентов
        setLayout(new GridLayout(2, 1));

        // Создание метки и кнопки
        lbMsg = new Label(msg, Label.CENTER);
        btnOk = new Button("Ok");

        // Добавление компонентов в окно
        add(lbMsg);
        add(btnOk);

        // Обработчик для кнопки "Ok"
        btnOk.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                dispose();  // закрытие диалога
            }
        });
    }

    @Override
    public boolean handleEvent(Event evt) {
        if (evt.id == Event.ACTION_EVENT && evt.target instanceof Button) {
            Button btn = (Button) evt.target;
            if (btn.equals(btnOk)) {
                dispose();  // закрытие диалога при нажатии на кнопку "Ok"
                return true;
            }
        }
        return super.handleEvent(evt);
    }
}

