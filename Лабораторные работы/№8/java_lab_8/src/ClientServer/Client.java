package ClientServer;

import java.io.*;
import java.net.*;
class Client
{ public static void main(String args[])
{ int b=0; boolean quit=false;
    System.out.println("Socket ClientServer.Client Application");
    try
    {
        Socket s=new Socket("localhost",2000);

        DataInputStream dataIn=new DataInputStream(
                new BufferedInputStream(
                        s.getInputStream()));

        DataOutputStream dataOut=new DataOutputStream(
                new BufferedOutputStream(
                        s.getOutputStream()));

        dataOut.writeChar(0); dataOut.flush();

        while(!quit)
        {
            if(b!=-1)
            { b=dataIn.readInt();
                System.out.println(" "+b);
            }
// ввод пользователем символа 
            b=System.in.read();
            if(b!=-1)
            { if((char)b=='Q'||(char)b=='q') quit=true;
// передача символа серверу
                dataOut.writeChar(b);
                dataOut.flush();
            }
        }
        dataIn.close(); // закрытие входного потока
        dataOut.close(); // закрытие выходного потока
        s.close(); // закрытие сокета
    }
    catch(IOException ioe)
    { System.out.println(ioe.toString());
    }
}
}