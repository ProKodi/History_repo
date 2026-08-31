



using Autofac;



namespace  MyDataBase;

public class ServicesModule : Module{
    protected override void Load( ContainerBuilder builder ) {
        builder.RegisterInstance(
            new MySqlDataBase()
            
        ).As<IDataBase>().SingleInstance();
    }
}
    



