import java.applet.*;
import java.awt.*; // импорт класса рамки (фрейма)
public class Combi extends Applet{
    private boolean m_fStandAlone = false;

    public static void main(String args[]){ 
        CombiFrame frame = new CombiFrame("Combi");
        frame.show(); frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 320,
            frame.insets().top + frame.insets().bottom + 240);
        Combi applet_Combi = new Combi();
        frame.add("Center", applet_Combi);
        applet_Combi.m_fStandAlone = true;
        applet_Combi.init();
        applet_Combi.start();
        frame.show();
    }

    public Combi(){}

    public String getAppletInfo(){
        return "Name: Combi\r\n";
    }
    
    public void init(){ 
        resize(320, 240);
    }
    
    public void destroy(){}
    
    public void paint(Graphics g){
        g.drawString("Created with Microsoft Visual J++ Version 1.1",10, 20);
    }
    
    public void start(){}
    
    public void stop(){}
}