


import java.awt.*;

public class Main {
    public static void main(String[] args) {
        MainWindow main_wind = new MainWindow("Бегущая строка. Буханов. Д.Е 23 вариант, группа 3105 об");
        main_wind.setVisible(true);
    }
}


class Const {
    /// Текст для вывода
    public static String text = "Text for example";
    /// Задержка
    public static int count_miliseconds = 50;

    /// Шрифт для текста
    public static Font font = new Font(
            GraphicsEnvironment.getLocalGraphicsEnvironment().getAvailableFontFamilyNames()[0],
            Font.PLAIN, 21
    );
}
