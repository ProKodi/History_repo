import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class AllElements extends Applet {
    // Объявление компонентов
    Button btn;
    Checkbox chck;
    Checkbox chck1, chck2;
    Choice mn;
    List lst;
    Scrollbar scrllbr;
    Label lbl;
    TextField txt;
    TextArea area;

    // Признак режима работы (true - standalone, false - апплет)
    private boolean isStandalone = false;

    // Компонент для вывода сообщений в standalone
    private TextArea outputArea;

    // Инициализация апплета
    public void init() {
        setSize(320, 240);
        // Создаем компоненты
        btn = new Button("Нажми!");
        chck = new Checkbox("Независимый переключатель");
        CheckboxGroup gr = new CheckboxGroup();
        chck1 = new Checkbox("1-й переключатель из группы", gr, true);
        chck2 = new Checkbox("2-й переключатель из группы", gr, false);
        mn = new Choice();
        lst = new List(3, false);
        scrllbr = new Scrollbar(Scrollbar.HORIZONTAL, 10, 1, 1, 100);
        lbl = new Label("Метка", Label.CENTER);
        txt = new TextField("Введите текст в текстовое поле", 30);
        area = new TextArea("Введите текст в текстовую область", 5, 40);

        // Если это standalone режим, добавляем TextArea для вывода сообщений
        if (isStandalone) {
            outputArea = new TextArea( 5, 40);
            outputArea.setEditable(false); // Не даем пользователю изменять текст
        }

        // Добавляем компоненты в апплет
        add(btn);
        add(chck);
        add(chck1);
        add(chck2);
        add(mn);
        add(lst);
        add(scrllbr);
        add(lbl);
        add(txt);
        add(area);

        // Добавляем элементы в меню и список
        mn.add("1-й пункт");
        mn.add("2-й пункт");
        mn.add("3-й пункт");

        lst.add("1-й пункт");
        lst.add("2-й пункт");
        lst.add("3-й пункт");
        lst.add("4-й пункт");

        // Если это standalone режим, добавляем TextArea
        if (isStandalone) {
            add(outputArea, BorderLayout.SOUTH); // Размещаем внизу окна
        }

        // Если это не standalone режим, добавляем апплет в окно
        if (!isStandalone) {
            setLayout(new FlowLayout());
        }
    }

    // Переопределяем метод paint (не используется, так как графики нет)
    public void paint(Graphics g) {
        // Здесь не требуется отрисовка графики
    }

    // Обработка событий
    public boolean handleEvent(Event evt) {
        switch (evt.id) {
            case Event.ACTION_EVENT:
                if (evt.target instanceof Button) {
                    String text = ((Button) evt.target).getLabel();
                    if (evt.target.equals(btn)) {
                        showMessage("Нажата кнопка: <<"+text+">>");
                    } else {
                        return false;
                    }
                } else if (evt.target instanceof Checkbox) {
                    String text = ((Checkbox) evt.target).getLabel();
                    boolean ch = ((Checkbox) evt.target).getState();
                    if (evt.target.equals(chck)) {
                        showMessage("Состояние " + text + " равно <<"+ch+">>");
                    } else if (evt.target.equals(chck1)) {
                        showMessage("Состояние " + text + " равно <<"+ch+">> но Состояние " + chck2.getLabel() + " равно <<"+chck2.getState()+">>");
                    } else if (evt.target.equals(chck2)) {
                        showMessage("Состояние " + text + " равно <<"+ch+">> но Состояние " + chck1.getLabel() + " равно <<"+chck1.getState()+">>");
                    } else {
                        return false;
                    }
                } else if (evt.target instanceof Choice) {
                    String text = ((Choice) evt.target).getSelectedItem();
                    if (evt.target.equals(mn)) {
                        showMessage("Выбран пункт в меню: <<"+text+">>");
                    } else {
                        return false;
                    }
                } else if (evt.target instanceof List) {
                    String text = ((List) evt.target).getSelectedItem();
                    if (evt.target.equals(lst)) {
                        showMessage("Выбран пункт в списке: <<"+text+">>");
                    } else {
                        return false;
                    }
                } else if (evt.target instanceof TextField) {
                    String text = ((TextField) evt.target).getText();
                    if (evt.target.equals(txt)) {
                        showMessage("В текстовое поле введено: <<"+text+">>");
                    } else {
                        return false;
                    }
                }
                break;

            case Event.LIST_SELECT:
                if (evt.target.equals(lst)) {
                    String selectedItem = lst.getSelectedItem();
                    showMessage("В списке выбран пункт: <<"+selectedItem+">>");
                } else {
                    return false;
                }
                break;

            case Event.LIST_DESELECT:
                if (evt.target.equals(lst)) {
                    showMessage("Отменен выбор пункта из списка");
                } else {
                    return false;
                }
                break;

            case Event.SCROLL_LINE_UP:
            case Event.SCROLL_LINE_DOWN:
            case Event.SCROLL_PAGE_UP:
            case Event.SCROLL_PAGE_DOWN:
                if (evt.target.equals(scrllbr)) {
                    int pos = scrllbr.getValue();
                    if (evt.id == Event.SCROLL_LINE_UP) {
                        showMessage("Событие - Линия вверх, текущее положение полосы прокрутки: <<"+pos+">>");
                    } else if (evt.id == Event.SCROLL_LINE_DOWN) {
                        showMessage("Событие - Линия вниз, текущее положение полосы прокрутки: <<"+pos+">>");
                    } else if (evt.id == Event.SCROLL_PAGE_UP) {
                        showMessage("Событие - Страница вверх, текущее положение полосы прокрутки: <<"+pos+">>");
                    } else if (evt.id == Event.SCROLL_PAGE_DOWN) {
                        showMessage("Событие - Страница вниз, текущее положение полосы прокрутки: <<"+pos+">>");
                    }
                } else {
                    return false;
                }
                break;

            default:
                return super.handleEvent(evt);
        }
        return true;
    }

    // Метод для вывода сообщений (заменяет showStatus для standalone)
    private void showMessage(String message) {
        if (isStandalone) {
            outputArea.append(message + "\n");  // Для standalone выводим в TextArea
        } else {
            showStatus(message);  // Для апплета вывод в строку состояния
        }
    }

    // Метод для запуска апплета как standalone-приложение
    public static void main(String[] args) {
        // Создаем фрейм и апплет
        Frame frame = new Frame("AllElements");
        AllElements applet = new AllElements();
        applet.isStandalone = true; // Устанавливаем режим работы как standalone
        frame.add(applet);
        frame.setSize(320, 240);
        frame.setVisible(true);
        applet.init(); // Инициализируем апплет
        applet.start(); // Запускаем апплет

        // Обработка закрытия окна
        frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent we) {
                applet.stop(); // Останавливаем апплет
                System.exit(0);
            }
        });
    }
}
