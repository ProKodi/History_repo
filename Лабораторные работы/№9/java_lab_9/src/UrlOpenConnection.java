import java.net.*;
public class UrlOpenConnection
{ public static void main(String args[])
{ URL Url; URLConnection UrlConnection;
    try
    {
        Url=new URL
                ("http://www.vvsu.ru/cts/teachers/arhipova/pictures/clock.gif");
        UrlConnection=Url.openConnection();

        System.out.println("Size:"+UrlConnection.getContentLength());
        System.out.println("Type:"+UrlConnection.getContentType());
        System.out.println("Date:"+UrlConnection.getDate());
    }
    catch(Exception e) { System.out.println(e.toString()); }
}
}