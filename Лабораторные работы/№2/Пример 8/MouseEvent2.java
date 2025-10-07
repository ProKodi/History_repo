import java.applet.*;
import java.awt.*;

public class MouseEvent2 extends Applet{
    public String getAppletInfo(){
        return "Name: HelloApplet\r\n" + "Created with JBuilder";
    }

    Image imageCur;
    private Image OffScreenImage;
    // контекст отображения (интерфейс) изображения
    private Graphics OffscreenGraphics;
    public void init(){
        resize(700, 600);
        try{ 
            imageCur=getImage(new java.net.URL(getCodeBase(),"gg.gif"));
        }
        catch(java.net.MalformedURLException e){
            imageCur=createImage(0,0);
        }
        OffScreenImage=createImage(size().width,size().height);
        OffscreenGraphics=OffScreenImage.getGraphics();
    }

    public void update(Graphics g){
        paint(OffscreenGraphics);
        g.drawImage(OffScreenImage,0,0,this);
    }

    public void destroy(){}
    private int m_x=0, m_y=0;
    private boolean follow=true;

    public void paint(Graphics g){
        g.setColor(Color.gray);
        g.fillRect(0,0,size().width-1,size().height-1);
        g.setColor(Color.black);
        g.drawRect(0,0,size().width-1,size().height-1);
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