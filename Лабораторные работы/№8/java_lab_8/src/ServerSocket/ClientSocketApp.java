package ServerSocket;
import java.io.*;
import java.net.*;
import java.util.StringTokenizer;

public class ClientSocketApp
{
    public static void main(String[] args)
    {
        try
        {
            byte buffer[] = new byte[512];

            Socket socket = new Socket("localhost", 2000);
            DataInputStream dataIn = new DataInputStream(new BufferedInputStream(socket.getInputStream()));

            DataOutputStream dataOut = new DataOutputStream(new BufferedOutputStream(socket.getOutputStream()));
            dataOut.writeChars("\r\n");
            dataOut.flush();
            boolean quit = false;

            while(!quit)
            {
                int value = dataIn.readInt();
                System.out.println(value);

                int length = System.in.read(buffer);

                if(length == 1) continue;

                StringTokenizer strFull = new StringTokenizer(new String(buffer,0),"\r\n");
                String str = (String)strFull.nextElement();

                if(str.toLowerCase().equals("quit"))
                {
                    quit = true;
                }
                else
                {
                    dataOut.write(buffer);
                    dataOut.flush();
                }
            }
            socket.close();
        }
        catch (IOException e)
        {

        }


    }
}
