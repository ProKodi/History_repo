import java.awt.*;

public class StandAlone
{
    public static void main(String args[])
    {
        MainWndFrame frame = new MainWndFrame("Title StandAlone");

        frame.show();
    }

}

class MainWndFrame extends Frame
{
    public MainWndFrame(String str)
    {
        super (str);
        resize(320,240);
    }

    public boolean handleEvent(Event evt)
    {
        switch (evt.id)
        {
            case Event.WINDOW_DESTROY:

                dispose();
                System.exit(0);
                return true;
            default:

                return super.handleEvent(evt);
        }
    }
}
