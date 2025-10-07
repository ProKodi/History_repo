import java.applet.Applet;
import java.awt.*;
import java.net.MalformedURLException;
import java.net.URL;

public class ParamUrlImage extends Applet{
    private String m_String_1 = "First string";
    private final String PARAM_String_1 = "m_FileName";

    public String getAppletInfo(){
        return "Name: ParamUrlImage\r\n";
    }

    public String[][] getParameterInfo(){
        String[][] info = {
            { PARAM_String_1, "String", "Parameter description" }
        };
        return info;
    }

    Image Im;
    public void init(){
        String param;
        param = getParameter(PARAM_String_1);
        if (param != null) m_String_1 = param;
        resize(320, 240);

        try{ 
            Im=getImage(new URL(getCodeBase(),m_String_1));
        }
        catch(MalformedURLException e){ 
            Im=createImage(0,0); // создание пустого изображения
        }
    }

    public void destroy(){}

    public void paint(Graphics g){
        g.drawImage(Im,0,0,this);
    }

    public void start(){}

    public void stop(){}
}