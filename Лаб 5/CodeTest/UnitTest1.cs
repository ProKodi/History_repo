



/*
Подключить основной проект
dotnet add reference ../Code/Code.csproj
dotnet test

*/


public class Tests{
    [Fact]
    public void Test1(){
        Assert.Equal(9, Program.Square(3));
    }
}