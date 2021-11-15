using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IAppService
    {
        [OperationContract]
        string Greeting(string name);
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AppService" in both code and config file together.
    public class AppService : IAppService
    {
        public string Greeting(string name)
            => $"Welcome {name}";
    }
}