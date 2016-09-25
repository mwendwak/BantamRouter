using BantamRouter.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace BantamRouter.Faces
{
    [ServiceContract(Namespace = "http://localhost/BantamRouter/Bantam.svc/Employees")]
    public interface IBantamRouterEmployees
    {
        [OperationContract]
        List<Employee> GetNavActiveEmployees();
    }
}
