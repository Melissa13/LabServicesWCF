using LabServerConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChemicalLabServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceLab
    {

        [OperationContract]
        //string GetData(int value);
        bool RegistrarMatricula(int matricula, string password);

        [OperationContract]
        List<Estudiantes> ObtenerEstudiantes(int idEstudiantes);

        [OperationContract]
        string ObtenerPass(int idEstudiantes);

        // TODO: Add your service operations here
    }

}
