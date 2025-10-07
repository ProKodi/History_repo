package ClientServer;

import java.io.*;
import java.net.*;
public class Server
{
    public static void main(String args[])
    { char b; int count=-1; boolean quit=false;
        System.out.println("Socket ClientServer.Server Application");
        System.out.println("---- Start ----");
        try
        {

            ServerSocket ss = new ServerSocket(2000);

            Socket s = ss.accept();

            DataInputStream dataIn = new DataInputStream(new BufferedInputStream(s.getInputStream()));

            DataOutputStream dataOut = new DataOutputStream(new BufferedOutputStream(s.getOutputStream()));

            while(!quit)
            {
                b = dataIn.readChar();
                System.out.println(""+b);
                if(b!=-1)
                { if(b=='Q'||b=='q') quit=true;
                else
                {
                    count++;
                    dataOut.writeInt(count);
                    dataOut.flush();
                }
                }
            }
            dataIn.close();
            dataOut.close();
            s.close();
            ss.close();
        }
        catch(IOException ioe)
        {
            System.out.println(ioe.toString());
        }
        System.out.println("---- Finish ----");
    }
}
