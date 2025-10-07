import java.applet.*;
import java.awt.*;

public class MouseEvent extends Applet
{

    public String getAppletInfo(){
        return "Name: HelloApplet\r\n" + "Created with JBuilder";
    }

    Image imageCur;

    public void init(){
        resize(320, 240);
        try{ 
            imageCur=getImage(new java.net.URL(getCodeBase(),"gg.gif"));
        }
        catch(java.net.MalformedURLException e){
            imageCur=createImage(0,0); // создание пустого изображения
        }
    }

    public void destroy(){}
    private int m_x=0, m_y=0;
    private boolean follow=true;

    public void paint(Graphics g){
        Dimension size=size();
        g.drawRect(0,0,size.width-1,size.height-1);
        g.drawImage(imageCur,m_x,m_y,this);
    }

    public boolean mouseMove(Event evt, int x, int y){ 
        if(follow){ 
            m_x=x; m_y=y;
            repaint();
        }
        return true;
    }

    public boolean mouseDown(Event evt, int x, int y){ 
        follow=!follow;
        return true;
    }

    public void start(){}

    public void stop(){}
}