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
    
    public partial class Simulaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Simulaciones()
        {
            this.Datosdinamicos = new HashSet<Datosdinamicos>();
            this.SimmulacionEstudiante = new HashSet<SimmulacionEstudiante>();
        }
    
        public int SimID { get; set; }
        public string SimNombre { get; set; }
        public Nullable<int> SimCantFallos { get; set; }
        public Nullable<long> SimDuracion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datosdinamicos> Datosdinamicos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SimmulacionEstudiante> SimmulacionEstudiante { get; set; }
    }
}
