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
    
    public partial class SimmulacionEstudiante
    {
        public long SimEstId { get; set; }
        public Nullable<int> SimulacionId { get; set; }
        public Nullable<long> EstudianteId { get; set; }
        public string Nota { get; set; }
    
        public virtual Estudiantes Estudiantes { get; set; }
        public virtual Simulaciones Simulaciones { get; set; }
    }
}
