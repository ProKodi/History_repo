



import java.applet.*;
import java.awt.*;

public class HelloApplet extends Applet{
    public HelloApplet(){}

    public String getAppletInfo(){
        return "Name: HelloApplet\r\n" + 
            "Created with JBuilder";
    }

    public void init(){
        resize(320, 240);
    }


    public void destroy(){}

    public void paint(Graphics g){
        g.drawString("Created with JBuilder", 10, 20);
    }

    public void start(){}

    public void stop(){}
}
