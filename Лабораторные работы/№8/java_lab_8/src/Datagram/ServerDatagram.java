package Datagram;

import java.io.*;
import java.net.*;
import java.util.*;
class ServerDatagram
{ public static void main(String args[])
{ boolean quit=false;
    String str; StringTokenizer strFull;
    System.out.println("Server Application");
    System.out.println("---- Start ----");
    byte buf[]=new byte[512]; // буфер для данных
    InetAddress srcAdd; // адрес узла, откуда пришел пакет
    int srcPort; // порт, откуда пришел пакет
    try
    { // создание сокета сервера
        DatagramSocket s=new DatagramSocket(9999);
// создание пакета для приема команд
        DatagramPacket pIn=new DatagramPacket(buf,512);
// цикл получения команд от клиента
        while(!quit)
        { // ---- получение данных от клиентов
            s.receive(pIn); // получение пакета
            srcAdd=pIn.getAddress(); // адрес узла-отправителя
            srcPort=pIn.getPort(); // порт узла-отправителя

            strFull=new StringTokenizer(new String(buf,0),"\r\n");
            str=(String)strFull.nextElement();
            if(str.toLowerCase().equals("quit")) quit=true;
// ---- вывод полученной от клиента строки
            str="Address:"+srcAdd.toString()+
                    " Port:"+srcPort+" String:"+str;
            System.out.println(str);
        }
        s.close(); // закрытие сокета
    }
    catch(IOException ioe)
    { System.out.println(ioe.toString());
    }
    System.out.println("---- Finish ----");
}
}

