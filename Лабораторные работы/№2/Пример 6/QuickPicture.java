import java.applet.Applet;
import java.awt.*;
import java.net.MalformedURLException;
import java.net.URL;

public class QuickPicture extends Applet{
    private String m_String_1 = "First string";
    private final String PARAM_String_1 = "m_FileName";

    public String getAppletInfo(){
        return "Name: ParamUrlImage\r\n";
    }

    public String[][] getParameterInfo(){
        String[][] info ={
            { PARAM_String_1, "String", "Parameter description" }
        };
        return info;
    }

    Image pic;
    boolean picLoaded = false;
    public void init(){
        String param;
        param = getParameter(PARAM_String_1);
        if (param != null) m_String_1 = param;
        resize(320, 240);
        try{ 
            pic=getImage(new URL(getCodeBase(),m_String_1));
        }
        catch(MalformedURLException e){ 
            pic=createImage(0,0); // создание пустого изображения
        }
        Image offScreenImage=createImage(size().width,size().height);
        Graphics offScreenGraphics= offScreenImage.getGraphics();
        offScreenGraphics.drawImage(pic,0,0,this);
    }

    public void destroy(){}
    
    public boolean imageUpdate(Image img,int infoflags,int x,int y,int w,int h){ 
        if(infoflags==ALLBITS){
            picLoaded=true;
            repaint();
            return false;
        }
        return true;
    }

    public void paint (Graphics g){ 
        if(picLoaded){ 
            g.drawImage(pic,0,0,null);
            showStatus("Done");
        }
        else{ 
            showStatus("Loading image");
        }
    }

    public void start(){}

    public void stop(){}
}