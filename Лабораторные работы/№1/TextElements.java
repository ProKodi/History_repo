class StaticAndDynamic
{
    int i = 0;
    static int j = 0;
    static void setJ(int k)
    {
        System.out.println("Static Method");
        j=k;
    }
    static int getJ()
    {
        System.out.println("Static Method");
        return j;
    }
    void setI(int k)
    {
        System.out.println("Dynamic Method");
        i = k;
    }
    int getI()
    {
        System.out.println("Dynamic Method");
        return i;
    }
    int summa()
    {
        System.out.println("Dynamic Method");
        return i+j;
    }
}

class TextElements
{
    public static void main(String args[])
    {
        int ii, jj;
        StaticAndDynamic.j = 6;
        jj = StaticAndDynamic.j;
        System.out.println("Main.jj"+jj);
        StaticAndDynamic.setJ(4);
        jj = StaticAndDynamic.j;
        System.out.println("Main.jj" + jj);
        StaticAndDynamic obj = new StaticAndDynamic();
        obj.i = 3;
        ii = obj.i;
        System.out.println("Main.ii"+ii);
        obj.setI(8);
        ii = obj.getI();
        System.out.println("Main.ii"+ii);
        ii = obj.summa();
        System.out.println("Main.summa="+ii);
    }
}