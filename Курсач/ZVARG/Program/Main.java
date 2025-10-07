import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Main extends JFrame {
    //поля для работы логики программы
    private JLabel label;
    private String text = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private int delay = 100; // Задержка в миллисекундах
    private Font currentFont = new Font("Serif", Font.PLAIN, 24);

    public Main() {
        //устанавливаем параметры гл. окна
        setTitle("Бегущая строка");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setOpacity(0.8F);
        getContentPane().setBackground(Color.orange);
        // Создаем метку для отображения текста
        label = new JLabel();
        label.setFont(currentFont);
        label.setHorizontalAlignment(JLabel.CENTER);
        add(label);

        // Создаем меню
        JMenuBar menuBar = new JMenuBar();
        menuBar.setOpaque(false);
        JMenu fontMenu = new JMenu("Шрифт");
        JMenuItem fontItem1 = new JMenuItem("Serif");
        JMenuItem fontItem2 = new JMenuItem("SansSerif");
        JMenuItem fontItem3 = new JMenuItem("Monospaced");

        fontItem1.addActionListener(new FontChangeListener("Serif"));
        fontItem2.addActionListener(new FontChangeListener("SansSerif"));
        fontItem3.addActionListener(new FontChangeListener("Monospaced"));

        fontMenu.add(fontItem1);
        fontMenu.add(fontItem2);
        fontMenu.add(fontItem3);

        JMenuItem settingsItem = new JMenuItem("Настройки");
        settingsItem.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                showSettingsDialog();
            }
        });

        menuBar.add(fontMenu);
        menuBar.add(settingsItem);
        setJMenuBar(menuBar);

        // Запускаем поток для анимации (реализация многопоточности)
        new Thread(new Runnable() {
            public void run() {
                while (true) {
                    updateText();
                    try {
                        Thread.sleep(delay);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            }
        }).start();
    }

    private void updateText() {
        // Сдвигаем текст на один символ
        text = text.charAt(text.length() - 1) + text.substring(0, text.length() - 1);
        label.setText("<html>" + text.replace("", "<br>") + "</html>");
    }
    //вывод диалогового окна для выбора параметров
    private void showSettingsDialog() {
        JDialog dialog = new JDialog(this, "Настройки", true);
        dialog.setLayout(new GridLayout(3, 2));

        JTextField textField = new JTextField(text);
        JTextField delayField = new JTextField(String.valueOf(delay));

        JButton okButton = new JButton("OK");
        okButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                text = textField.getText();
                delay = Integer.parseInt(delayField.getText());
                dialog.dispose();
            }
        });

        dialog.add(new JLabel("Текст:"));
        dialog.add(textField);
        dialog.add(new JLabel("Задержка (мс):"));
        dialog.add(delayField);
        dialog.add(okButton);

        dialog.pack();
        dialog.setLocationRelativeTo(this);
        dialog.setVisible(true);
    }
    //слушатель для изменения шрифта текста
    private class FontChangeListener implements ActionListener {
        private String fontName;

        public FontChangeListener(String fontName) {
            this.fontName = fontName;
        }
        public void actionPerformed(ActionEvent e) {
            currentFont = new Font(fontName, Font.PLAIN, 24);
            label.setFont(currentFont);
        }
    }
    //собственно, запуск
    public static void main(String[] args) {
        JFrame.setDefaultLookAndFeelDecorated(true);
        JDialog.setDefaultLookAndFeelDecorated(true);
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                new Main().setVisible(true);
            }
        });
    }
}