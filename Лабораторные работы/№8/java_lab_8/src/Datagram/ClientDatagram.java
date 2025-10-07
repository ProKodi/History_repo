package Datagram;

import java.io.*;
import java.net.*;
import java.util.*;
class ClientDatagram
{ public static void main(String args[])
{ boolean quit=false; int length;
    String str; StringTokenizer strFull;
    System.out.println("Client Application");
    System.out.println("Enter any string or 'quit' to exit...");
    byte buf[]=new byte[512]; // буфер для передачи данных
    try
    { // создание сокета клиента с
// использованием свободного порта
        DatagramSocket s=new DatagramSocket();
// адрес узла, на котором запущен сервер
// в процессе отладки сетевых приложений, когда
// сервер и клиент работают на одном узле,
// в качестве адреса сервера используется адрес
// данного локального узла, выдаваемый методом
// InetAddress.getLocalHost();
        InetAddress serverAdd=InetAddress.getLocalHost();
// в рабочей версии клиента указывается IP-адрес сервера
//InetAddress serverAdd=
// InetAddress.getByName("194.84.124.60");
//InetAddress serverAdd=InetAddress.getByName("gosha");
//InetAddress serverAdd=
// InetAddress.getByName("gosha.vvsu.ru");
// создание пакета для передачи команд серверу
        DatagramPacket pOut=
                new DatagramPacket(buf,512,serverAdd,9999);

        while(!quit)
        { // ввод строки с клавиатуры
            length=System.in.read(buf);
            if(length==1)

                continue;

            s.send(pOut);

            strFull=new StringTokenizer(new String(buf,0),"\r\n");
            str=(String)strFull.nextElement();
            if(str.toLowerCase().equals("quit")) quit=true;
        }
        s.close();
    }
    catch(IOException ioe)
    { System.out.println(ioe.toString());
    }
}
}

