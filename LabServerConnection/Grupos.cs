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
    
    public partial class Grupos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupos()
        {
            this.EstudiantesGrupos = new HashSet<EstudiantesGrupos>();
        }
    
        public int GrupoID { get; set; }
        public string GrupoNombre { get; set; }
        public string NotaPromedio { get; set; }
        public string GrupoProfesor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudiantesGrupos> EstudiantesGrupos { get; set; }
        public virtual Profesores Profesores { get; set; }
    }
}
