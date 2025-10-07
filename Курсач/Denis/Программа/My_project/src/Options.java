




import javax.swing.*;
import java.awt.*;
import java.util.HashMap;


class Options extends JDialog{
    protected JTextField text_for_print;
    protected JSpinner count_seconds;
    protected JComboBox<String> font_selected;
    protected JSpinner font_size;
    protected JComboBox<String> font_style;
    protected HashMap<String, Integer> types = new HashMap<>(){{
        put("Обычное написание", Font.PLAIN);
        put("Жирное написание", Font.BOLD);
        put("Курсивное написание", Font.ITALIC);
    }};


    public Options(String title){
        super();
        this.setTitle(title);
        this.setModalityType(ModalityType.APPLICATION_MODAL);
        this.setMinimumSize(new Dimension(400, 300));

        this.setLayout(new GridLayout(2, 1));

        /// Ввод текста
        JPanel panel = new JPanel();
        panel.setLayout(new GridLayout(6, 2));
        panel.add(new JLabel("Введите текст для бегущей строки"));

        this.text_for_print = new JTextField();
        panel.add(this.text_for_print);
        this.text_for_print.setText(Const.text);

        /// Ввод задержки
        panel.add(new JLabel("Введите задержку (в миллисекундах)"));
        this.count_seconds = new JSpinner();
        panel.add(this.count_seconds);
        count_seconds.setModel(new SpinnerNumberModel(Const.count_miliseconds, 1, 100_000, 1));

        /// Выбор шрифта
        String[] fonts = GraphicsEnvironment.getLocalGraphicsEnvironment().getAvailableFontFamilyNames();
        Font select_font = Const.font;

        panel.add(new JLabel("Выберете шрифт"));
        font_selected = new JComboBox<>(fonts);
        font_selected.setSelectedItem(select_font.getFontName());
        panel.add(font_selected);

        panel.add(new JLabel("Введите размер шрифта"));
        font_size = new JSpinner();
        font_size.setModel(new SpinnerNumberModel(select_font.getSize(), 6, 100, 1));
        panel.add(font_size);

        panel.add(new JLabel("Начертание шрифта"));
        font_style = new JComboBox<>(types.keySet().toArray(new String[0]));
        panel.add(font_style);

        JButton save = new JButton("Сохранить изменения");
        save.addActionListener(e -> save_option());
        panel.add(save);
        this.add(panel);
        this.add(new JPanel());
    }

    void save_option(){
        if(this.text_for_print.getText().length() <= 0){
            JOptionPane.showMessageDialog(this, "Вы не ввели текст для строки",
                "Ошибка", JOptionPane.ERROR_MESSAGE
            );
            return;
        }

        Const.text = this.text_for_print.getText();
        Const.count_miliseconds = (int)this.count_seconds.getValue();
        Const.font = new Font(
                (String)this.font_selected.getSelectedItem(),
                this.types.get((String)this.font_style.getSelectedItem()),
                (int)this.font_size.getValue()
        );
    }
}
