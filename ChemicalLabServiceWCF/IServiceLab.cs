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
        bool RegistrarMatricula(string matricula, string password);

        [OperationContract]
        List<Estudiantes> ObtenerEstudiantes(string idEstudiantes);

        [OperationContract]
        string ObtenerPass(string idEstudiantes);

        [OperationContract]
        //string GetData(int value);
        bool GenerarReporteEstudiante(List<string> notas);

        [OperationContract]
        bool RegistrarEsudiante(string id, string name,string lastname, int matricula);

        [OperationContract]
        bool RegistrarProfesor(string id, string name, string lastname);

        [OperationContract]
        bool RegistrarCurso(string name, string idprofesor);

        [OperationContract]
        bool RegistrarCursoestudiante(int idCurso, string idEstudiante);

        [OperationContract]
        bool RegistrarSimulacion(string name, int fallos, int duracion);

        [OperationContract]
        bool RegistrarSimulacionEst(int idCurso, string idEstudiante, string nota);

        // TODO: Add your service operations here
    }

}
