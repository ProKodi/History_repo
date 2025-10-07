import java.awt.*;

class MainWndFrame extends Frame {
    // Конструктор класса фрейма
    public MainWndFrame(String str) {
        super(str);  // Вызываем конструктор родительского класса с названием окна
    }

    // Обработка событий (например, при закрытии окна)
    public boolean handleEvent(Event evt) {
        switch (evt.id) {
            case Event.WINDOW_DESTROY:
                // Закрытие приложения при закрытии окна
                dispose();  // Удалить окно
                System.exit(0);  // Завершаем работу приложения
                return true;
            default:
                // Передаем остальные события в базовый класс для обработки
                return super.handleEvent(evt);
        }
    }
}
