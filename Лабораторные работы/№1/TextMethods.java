public class TextMethods {
    static int v = 0;
    static void setV(int i)
    {
        v = i;
        System.out.println("Void Method");
    }
    static int getV()
    {
        System.out.println("Returning method");
        return v;
    }
    static int func(int a, int b[])
    {
        a = a+1;
        b[0] = b[0]+1;
        System.out.println("a="+a+"b[0]="+b[0]);
        return a;
    }
    static String compare(int i, int j)
    {
        if(i==j) return -i+ " and " +j+ "are equal";
        else if(i>j) return +i+ "greater than" +j;
        else return +j+ "greater than" +i;
    }
    static String compare (int i, int j, int k)
    {
        String S = "";
        S = S+compare(i,j);
        S = S+compare(i,k);
        S = S+compare(j,k);
        return S;
    }
    static String compare (double i, double j)
    {
        if (i==j) return ""+i+" and " +j+ "are equal";
        else
            if (i>j) return ""+i+"greater than"+j;
            else return ""+j+"greater than"+i;
    }
    public static void main(String args[])
    {
        setV(5);
        int vv = getV();
        int A; int B[] = new int[1];
        A = 1; B[0] = 1;
        System.out.println("A="+A+"B[0]="+B[0]);
        int aa = func(A,B);
        System.out.println("aa=" +aa);
        String S;
        S=compare(2,5); System.out.println(S);
        S=compare(3,1,6);
        S=compare(1.5,2.1); System.out.println(S);
    }
}

