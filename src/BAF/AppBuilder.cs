namespace BAF
{
    public class AppBuilder : IAppBuilder
    {
        public IApp Context => BAF.App.Context;
    }
}