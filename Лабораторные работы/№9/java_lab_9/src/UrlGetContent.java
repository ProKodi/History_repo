import sun.net.www.content.text.PlainTextInputStream;

import java.applet.*;
import java.awt.*;
import java.net.*;
public class UrlGetContent extends Applet
{
    public static void main(String[] args) {
        CombiFrame frame = new CombiFrame("Frame");

        frame.show();
        frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 500, frame.insets().top + frame.insets().bottom + 500);

        UrlGetContent applet_Combi = new UrlGetContent();
        frame.add("Center", applet_Combi);


        applet_Combi.init();
        applet_Combi.start();

        frame.show();
    }

    String S;
    Object obj;
    public void init()
    {
        resize(600, 400);

        TextArea text=new TextArea(30,80);
        add(text);
        URL Url;
        try
        {
            Url = new URL(getCodeBase(),"hello.txt");
            obj = Url.getContent();

            if(obj instanceof String) { S=(String)obj; }
            else { S="Unknown object"; }
        }
        catch(Exception e)
        {
            S="hello.txt";
        }

        text.setText(S);
    }
    public void paint(Graphics g){}
}