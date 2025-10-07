import java.applet.*;
import java.awt.*;


public class AppletWithParam extends Applet{
    private String m_String_1 = "First string";
    private String m_String_2 = "Second string";

    private final String PARAM_String_1 = "String_1";
    private final String PARAM_String_2 = "String_2";

    public AppletWithParam(){}

    public String getAppletInfo(){
        return "Name: AppletWithParam\r\n" +"";
    }

    public String[][] getParameterInfo(){
        String[][] info ={
            {PARAM_String_1, "String", "Parameter description" },
            {PARAM_String_2, "String", "Parameter description" },
        };
        return info;
    }

    public void init(){
        String param;
        param = getParameter(PARAM_String_1);
        if (param != null) m_String_1 = param;
        param = getParameter(PARAM_String_2);
        if (param != null) m_String_2 = param;
        resize(320, 240);
    }

    public void destroy(){}

    public void paint(Graphics g){
        //g.drawString("Created with Microsoft Visual J++ Version 1.1", 10, 20);
        g.drawString(m_String_1, 10, 20);
        g.drawString(m_String_2, 10, 50);
    }

    public void start(){}

    public void stop(){}
}
