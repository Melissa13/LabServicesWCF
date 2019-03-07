using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LabServerConnection;

namespace ChemicalLabServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceLab : IServiceLab
    {
        DBCHEMICALLABEntities conexionDB = new DBCHEMICALLABEntities();

        public List<Estudiantes> ObtenerEstudiantes(string idEstudiantes)
        {
            List<Estudiantes> vacio = new List<Estudiantes>();
            //return conexionDB.Estudiantes.Where(Estudiantes => Estudiantes.EstudianteID == idEstudiantes || idEstudiantes == -1).ToList();
            return vacio;
        }

        public string ObtenerPass(string idEstudiantes)
        {
            
            return conexionDB.Estudiantes.Find(idEstudiantes).EstPassword;
        }

        public bool RegistrarMatricula(string matricula, string password)
        {
            try
            {
                var nuevoEstudiante = conexionDB.Estudiantes.Create();
                //if para verificar aqui
                nuevoEstudiante.EstudianteID = matricula;
                nuevoEstudiante.EstPassword = password;


                conexionDB.Estudiantes.Add(nuevoEstudiante);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }
    }
}
