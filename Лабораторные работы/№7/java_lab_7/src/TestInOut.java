class TestInOut
{ public static void main(String ARGV[]) throws java.io.IOException
{ StringBuffer buffer=new StringBuffer();
    int c;
    System.out.print("Для прекращения ввода используется символ:");
    System.out.println("в Windows - Ctrl+Z, в Unix - Ctrl+D");
    System.out.println(
            "Введите несколько слов (чисел), разделенных пробелом:");
// -------------посимвольный ввод до символа конца ввода
    while((c=System.in.read())!=-1)
    { buffer.append((char)c); // добавить символ в буфер
    }
// -------------вывод по словам (токенам)
    System.out.println("\n\nВведенные слова:");
    String string=new String(buffer); // создать по буферу строку
    java.util.StringTokenizer tok=new java.util.StringTokenizer(string);
    while(tok.hasMoreTokens()) // пока есть токены
    { // получить токен и напечатать
        String word=tok.nextToken(); System.out.print(word+" ");
    }
// -------------вывод по числам
    System.out.println("\nВведенные числа:");
    tok=new java.util.StringTokenizer(string);
    while(tok.hasMoreTokens()) // пока есть токены
    { // преобразовать токен в целочисленный упаковщик
        Integer I=Integer.valueOf(tok.nextToken());
// получить из упаковщика целое число и напечатать
        System.out.print(" "+ I.intValue());
    }
}
}
