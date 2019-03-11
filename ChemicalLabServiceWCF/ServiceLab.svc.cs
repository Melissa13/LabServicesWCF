using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LabServerConnection;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



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

        public bool GenerarReporteEstudiante(string estudianteID)
        {
            CrystalReport1 crpt = new CrystalReport1();
            crpt.Load(@"C:\CrystalReport2.rpt");

            //crpt.SetDataSource(datatablesource);
            crpt.SetParameterValue("nombre", "Melissa");

            try
            {
                CrystalDecisions.Shared.ExportOptions rptExportOption = crpt.ExportOptions;
                DiskFileDestinationOptions rptFileDestOption = new DiskFileDestinationOptions();
                string reportFileName = @"C:\SampleReport.pdf";
                rptFileDestOption.DiskFileName = reportFileName;
                
                {
                    rptExportOption.ExportDestinationType = ExportDestinationType.DiskFile;
                    //if we want to generate the report as PDF, change the ExportFormatType as "ExportFormatType.PortableDocFormat"
                    //if we want to generate the report as Excel, change the ExportFormatType as "ExportFormatType.Excel"
                    rptExportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                    rptExportOption.ExportDestinationOptions = rptFileDestOption;
                    PdfRtfWordFormatOptions rptFormatOption = new PdfRtfWordFormatOptions();
                    rptExportOption.ExportFormatOptions = rptFormatOption;
                }

                crpt.Export();

            }
            catch(Exception ex)
            {
                return false;
            }
           
           
            return true;
        }
        
        //registro de datos
        public bool RegistrarEsudiante(string id, string name, string lastname, int matricula)
        {
            try
            {
                var nuevoEstudiante = conexionDB.Estudiantes.Create();
                //if para verificar aqui
                nuevoEstudiante.EstudianteID = id;
                nuevoEstudiante.EstNombre = name;
                nuevoEstudiante.EstApellido = lastname;
                nuevoEstudiante.EstMatricula = matricula;


                conexionDB.Estudiantes.Add(nuevoEstudiante);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RegistrarProfesor(string id, string name, string lastname)
        {
            try
            {
                var nuevoProf = conexionDB.Profesores.Create();
                //if para verificar aqui
                nuevoProf.ProfesorId = id;
                nuevoProf.ProfNombre = name;
                nuevoProf.ProfApellido = lastname;


                conexionDB.Profesores.Add(nuevoProf);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RegistrarCurso(string name, string idprofesor)
        {
            try
            {
                //conexionDB.Profesores.Find(idEstudiantes).EstPassword;

                var nuevoCurso = conexionDB.Grupos.Create();
                //if para verificar aqui
                nuevoCurso.GrupoNombre = name;
                nuevoCurso.GrupoProfesor = idprofesor;


                conexionDB.Grupos.Add(nuevoCurso);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RegistrarCursoestudiante(int idCurso, string idEstudiante)
        {
            try
            {

                var nuevoCursoEst = conexionDB.EstudiantesGrupos.Create();
                //if para verificar aqui
                nuevoCursoEst.GrupoID = idCurso;
                nuevoCursoEst.EstudianteID = idEstudiante;


                conexionDB.EstudiantesGrupos.Add(nuevoCursoEst);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RegistrarSimulacion(string name, int fallos, int duracion)
        {
            try
            {

                var nuevoaSimulacion = conexionDB.Simulaciones.Create();
                //if para verificar aqui
                nuevoaSimulacion.SimCantFallos = fallos;
                nuevoaSimulacion.SimDuracion = duracion;
                nuevoaSimulacion.SimNombre = name;


                conexionDB.Simulaciones.Add(nuevoaSimulacion);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RegistrarSimulacionEst(int idSim, string idEstudiante, string nota)
        {
            try
            {

                var nuevoaSimulacionEst = conexionDB.SimmulacionEstudiante.Create();
                //if para verificar aqui
                nuevoaSimulacionEst.EstudianteId = idEstudiante;
                nuevoaSimulacionEst.SimulacionId = idSim;
                nuevoaSimulacionEst.Nota = nota;


                conexionDB.SimmulacionEstudiante.Add(nuevoaSimulacionEst);
                //guardar en la base de datos
                conexionDB.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
