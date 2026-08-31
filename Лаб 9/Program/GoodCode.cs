



class GoodCode{
    public static int CalculateSum(List<int> numbers, bool isEven){
        return numbers
            .Where(n => isEven ? n % 2 == 0 : n % 2 != 0)
            .Sum();
    }
}
