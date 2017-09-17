using System.ServiceModel;

namespace Mini.WCF
{
    [ServiceContract]
    public interface IServiceMini
    {
        [OperationContract]
        void Executar(string origem, string destino);
    }
}
