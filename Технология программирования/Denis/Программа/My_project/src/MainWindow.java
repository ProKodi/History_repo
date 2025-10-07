



import javax.swing.*;
import java.awt.*;


public class MainWindow extends JFrame {
    protected RunLabel label = null;

    public MainWindow(String title) {
        super(title);
        this.setMinimumSize(new Dimension(600, 400));
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JMenuBar menuBar = new JMenuBar();

        JMenu option = new JMenu("Опции");
        option.setCursor(new Cursor(Cursor.HAND_CURSOR));
        option.addMouseListener(new java.awt.event.MouseAdapter() {
            @Override
            public void mouseClicked(java.awt.event.MouseEvent evt ) {
                Options wind = new Options("Опции");
                wind.setVisible(true);
            }
        });
        menuBar.add(option);

        ///  Menu
        JMenu start_string = new JMenu("Запустить строку");
        start_string.setCursor(new Cursor(Cursor.HAND_CURSOR));
        start_string.addMouseListener(new java.awt.event.MouseAdapter() {
            @Override
            public void mouseClicked(java.awt.event.MouseEvent evt ) {label.run_text();}
        });
        menuBar.add(start_string);

        JMenu reload = new JMenu("Очистить строку");
        reload.setCursor(new Cursor(Cursor.HAND_CURSOR));
        reload.addMouseListener(new java.awt.event.MouseAdapter() {
            @Override
            public void mouseClicked(java.awt.event.MouseEvent evt ) {label.stop_text();}
        });
        menuBar.add(reload);

        this.label = new RunLabel();

        this.setJMenuBar(menuBar);
        this.add(this.label, BorderLayout.NORTH);
    }
}
