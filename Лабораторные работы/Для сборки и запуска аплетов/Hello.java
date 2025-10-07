



import java.applet.*;
import java.awt.*;

public class Hello extends Applet{
    public void init(){
        resize(150, 150);
    }

    public void paint(Graphics g){
        g.drawString("Hello, WWW", 10, 20);
    }
}