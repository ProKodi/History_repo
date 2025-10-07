



import java.applet.*;
import java.awt.*;

public class Hello extends Applet{
    int curX = 50, curY = 50;
    public void init(){
        resize(640, 480);
    }

    public void paint(Graphics g){
        g.drawString("Hello, WWW", curX, curY);
    }

    public boolean mouseDown(Event e, int x, int y){
        curX = x; curY = y;
        repaint();
        return true;
    }
}