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
        string GenerarReporteEstudiante(string estudianteID);

        [OperationContract]
        bool RegistrarEsudiante(string id, string name,string lastname, string matricula);

        [OperationContract]
        bool RegistrarProfesor(string id, string name, string lastname);

        [OperationContract]
        bool RegistrarCurso(string name, string idprofesor);

        [OperationContract]
        bool ActualizarCurso(string name, string idprofesor);

        [OperationContract]
        bool RegistrarCursoestudiante(int idCurso, string idEstudiante);

        [OperationContract]
        bool RegistrarSimulacion(string name, int fallos, int duracion);

        [OperationContract]
        bool RegistrarSimulacionEst(string NombreSim, string idEstudiante, string nota);

        [OperationContract]
        bool verificarEstudiante(string idEstudiantes, string password);

        [OperationContract]
        bool verificarProfesor(string idprofesor, string password);

        [OperationContract]
        bool GuardarCambioDinamicos(string simulacion, string[] dato, int dato2, string nivel, string[] nombreData);

        [OperationContract]
        string[] BuscarDatosD(string simulacion, string nivel, string[] nombreData);

        [OperationContract]
        string[] devolverNotasEst(string idEstudiantes);

        [OperationContract]
        bool updateNota(string NombreSim, string idEstudiante, string nota, int id);

        [OperationContract]
        void datosUser(string idEstudiante);

        [OperationContract]
        void datosUserProf(string idProf);

        [OperationContract]
        string[] LinkDocumentos();

        [OperationContract]
        bool ActualizarSimulacion(string name, int fallos, int duracion);

        [OperationContract]
        long[] DatosSimulacion(string name);

        // TODO: Add your service operations here
    }

}
