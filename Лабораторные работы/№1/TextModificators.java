class A
{
    public int k;
    private int n;
    A() {k = 2; n = 11;}
    int summa()
    {
        return k+n;
    }
    public int getN()
    {
        return n;
    }
    public void setN(int nn) {
        n = nn;
    }
}
class TextModifiers
{
    public static void main (String args[])
    {
        A obj = new A();
        int kk = obj.k;
        int nn = obj.getN();
        obj.k=10;
        obj.setN(15);
        int s = obj.summa();
        System.out.println("summa="+s);
    }
}
