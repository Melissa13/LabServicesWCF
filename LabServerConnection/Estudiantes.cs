//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabServerConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiantes()
        {
            this.EstudiantesGrupos = new HashSet<EstudiantesGrupos>();
            this.SimmulacionEstudiante = new HashSet<SimmulacionEstudiante>();
        }
    
        public long EstudianteID { get; set; }
        public string EstNombre { get; set; }
        public string EstApellido { get; set; }
        public string EstPassword { get; set; }
        public string EstTotalNota { get; set; }
        public string EstReporte { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudiantesGrupos> EstudiantesGrupos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SimmulacionEstudiante> SimmulacionEstudiante { get; set; }
    }
}
