import java.net.*;
import java.io.*;
class UrlOpenStream
{ public static void main(String args[])
{ URL Url;
    try
    {
        Url=new URL("http://www.microsoft.com");
        InputStream InStream=Url.openStream();

        int b;
        while ((b=InStream.read())!=-1)
        { System.out.print(""+(char)b);
        }
        InStream.close();
    }
    catch(Exception e) { System.out.println(e.toString()); }
}
}