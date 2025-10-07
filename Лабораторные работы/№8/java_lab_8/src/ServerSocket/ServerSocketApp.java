package ServerSocket;

import java.io.*;
import java.net.*;
import java.util.StringTokenizer;

public class ServerSocketApp
{

    public static void main(String[] args)
    {
        int bytesTransmitted = 0;
        byte buffer[] = new byte[512];

        try
        {
            ServerSocket serverSocket = new ServerSocket(2000);
            Socket socket = serverSocket.accept();

            DataInputStream dataIn = new DataInputStream(new BufferedInputStream(socket.getInputStream()));

            DataOutputStream dataOut = new DataOutputStream(new BufferedOutputStream(socket.getOutputStream()));

            boolean quit = false;

            while(!quit)
            {
                dataIn.read(buffer);

                StringTokenizer strFull = new StringTokenizer(new String(buffer,0),"\r\n");
                String str = (String)strFull.nextElement();
                System.out.println(str);

                if(str.toLowerCase().equals("quit"))
                {
                    quit = true;
                }
                else
                {
                    bytesTransmitted += buffer.length;
                    dataOut.writeInt(bytesTransmitted);
                    dataOut.flush();
                }
            }
            socket.close();
            serverSocket.close();
            System.out.println("-- Finish --");
        }
        catch (IOException e)
        {
            System.out.println(e.toString());
        }

    }
}
