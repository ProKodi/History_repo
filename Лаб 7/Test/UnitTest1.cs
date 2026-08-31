



/*
Подключить основной проект
dotnet add reference ../Code/Code.csproj
dotnet test
*/
[assembly: CollectionBehavior(DisableTestParallelization = true)]

public class DatabaseFixture{
    public DatabaseFixture(){
        DataBase.DataBaseServis.Init();
    }

    public void Dispose(){
        DataBase.DataBaseServis.Dispose();
    }
}

public class TestDataBase : IClassFixture<DatabaseFixture>{
    private DatabaseFixture _fixture;

    public TestDataBase(DatabaseFixture fixture){
        _fixture = fixture;
    }

    /// <summary>
    /// Тестовое запись и чтение из БД
    /// </summary>
    [Fact]
    public async Task TestWriteRead(){
        await DataBase.DataBaseServis.Write("Привет тупой бот", true);
        await DataBase.DataBaseServis.Write("Сам тупой", false);


        List<(string, bool)> temp = await DataBase.DataBaseServis.Read(^2, 2);

        Assert.Equal("Привет тупой бот", temp[0].Item1);
        Assert.True(temp[0].Item2);

        Assert.Equal("Сам тупой", temp[1].Item1);
        Assert.False(temp[1].Item2);

       // await DataBase.DataBaseServis.Clear();
    }

}
