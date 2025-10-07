import java.applet.Applet;
import java.awt.*;
import java.net.MalformedURLException;
import java.net.URL;


public class ParamsUrl extends Applet {
    private String m_String_1 = "First string";
    private String m_String_2 = "Second string";
    private Image Im;
    private String m_FileName = "ff.gif";

    private final String PARAM_String_1 = "String_1";
    private final String PARAM_String_2= " String_2";

    public ParamsUrl(){}

    public String getAppletInfo(){
        return "Name: AppletWithParam\r\n";
    }

    public String[][] getParameterInfo(){
        String[][] info ={
            { PARAM_String_1, "String", "Parameter description" },
            { PARAM_String_2, "String", "Parameter description" },
        };
        return info;
    }
    public void init(){
        try{ 
            Im=getImage(new URL(getCodeBase(),m_FileName));
        }
        catch(MalformedURLException e){
            Im=createImage(0,0); // создание пустого изображения
        }

        String param;
        param = getParameter(PARAM_String_1);
        if (param != null) m_String_1 = param;

        param = getParameter(PARAM_String_2);
        if (param != null) m_String_2 = param;
        resize(320, 240);
    }

    public void destroy(){}

    public void start(){}

    public void stop(){}

    public void paint(Graphics g){ 
        g.drawImage(Im,0,0,this);
    }
}
