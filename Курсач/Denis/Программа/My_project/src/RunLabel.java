



import javax.swing.*;
import java.awt.*;


public class RunLabel extends JLabel {
    /// Поток для прокручивания строки
    protected Thread thread_print = null;
    protected int index = 0;

    public RunLabel(){super();}

    /// Перезапуск потока строки
    public void reload(){
        this.thread_print = new Thread(() -> {
            int max_index = Const.text.length() + 50;

            StringBuilder string_for_print = new StringBuilder().repeat(" ", max_index);
            this.setText(string_for_print.toString());
            StringBuilder temp = new StringBuilder(Const.text);
            temp.reverse();
            try {
                for (char i : temp.toString().toCharArray()) {
                    for (int ii = 0; ii < max_index; ii += 1) {
                        string_for_print.replace(ii, ii + 1, String.valueOf(i));
                        if (ii > 0) {
                            string_for_print.replace(ii - 1, ii, " ");
                        }
                        this.setText(string_for_print.toString());
                        Thread.sleep(Const.count_miliseconds);
                    }
                    max_index -= 1;
                }
            }
            catch (InterruptedException e) {return;}
        });
    }

    /// Запуск строки
    public void run_text(){
        if(this.thread_print == null){this.reload();}
        // Если поток работает
        if(this.thread_print.getState() == Thread.State.TIMED_WAITING){return;}
        // Если поток завершен
        if(this.thread_print.getState() == Thread.State.TERMINATED){this.reload();}

        this.thread_print.start();
    }

    /// Очистка строки
    public void stop_text(){
        if(this.thread_print == null){return;}
        this.thread_print.interrupt();
        this.setText(" ");
    }
}

