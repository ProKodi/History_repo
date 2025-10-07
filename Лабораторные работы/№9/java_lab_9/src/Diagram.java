import java.applet.Applet;
import java.awt.*;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.StringTokenizer;

public class Diagram extends Applet
{
    private URL url;
    private String content;
    private String strError;
    private int error = 0;
    private int x, y, w;

    private double beginPos, angle;

    private double unit = 3.60;

    private int rColor, gColor, bColor;
    String content1 = "10,20.3,13.1,6.9,35,14.7";

    public static void main(String[] args) {

        CombiFrame frame = new CombiFrame("Frame");

        frame.show();
        frame.hide();
        frame.resize(frame.insets().left + frame.insets().right + 500, frame.insets().top + frame.insets().bottom + 500);

        Diagram applet_Combi = new Diagram();
        frame.add("Center", applet_Combi);


        applet_Combi.init();
        applet_Combi.start();

        frame.show();
    }

    @Override
    public void init() {

        try
        {
            //url = new URL(getCodeBase(), "data.txt");
            getFileContent();
        }
        catch (Exception exception)
        {
            error = 1;
            strError = "Type of error: MalformedURLException";

        }

        repaint();
    }
    void getFileContent()
    {
        try
        {
            //Object obj = url.getContent();
            if("obj" instanceof String)
            {
                error = 0;
                strError = "";
                content = content1;
            }
            else {
                error = 2;
                strError = "Type of error: Content of file isn't string";
            }
        }
        catch (Exception e)
        {
            error = 3;
            strError = "Type of error: getContent exception";
        }
        repaint();
    }

    @Override
    public void paint(Graphics g) {
        if(false)
        {
            g.drawString(strError, 0, 0);
            return;
        }

        Dimension dimension = size();
        x = 0;
        y = 0;
        w = dimension.width;

        g.setColor(Color.black);
        g.drawRect(0, 0, dimension.width, dimension.height);
        g.drawOval(x, y, w, w);

        StringTokenizer ct = new StringTokenizer(content,",");
        beginPos=0;
        while(ct.hasMoreElements())
        {
            String word=(String)ct.nextElement();
            Double value=new Double(word);
            double percent=value.doubleValue();
            angle=percent*unit;
            rColor=(int)(255.*Math.random());
            gColor=(int)(255.*Math.random());
            bColor=(int)(255.*Math.random());
            g.setColor((new Color(rColor,gColor,bColor)));
            g.fillArc(x, y, w, w, (int)beginPos, (int)angle);
            beginPos += angle;
            if(beginPos > 360)
            {
                error = 4;
                strError = "Type of error: summa greater than 100%";
                //repaint();
            }
        }


    }

    @Override
    public boolean mouseDown(Event evt, int x, int y) {

        getFileContent();
        return true;
    }
}
