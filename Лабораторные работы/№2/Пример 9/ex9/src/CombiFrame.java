import java.awt.*;

class CombiFrame extends Frame{
    
    public CombiFrame(String str){
        super (str);
    }
    public boolean handleEvent(Event evt){
        switch (evt.id){
            case Event.WINDOW_DESTROY:
                dispose(); // удаление окна
                System.exit(0); // завершение приложение
                return true;
            default:
                return super.handleEvent(evt);
        }
    }
}