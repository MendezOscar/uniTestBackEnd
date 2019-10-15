using System;
using System.Collections.Generic;

namespace uniTestApi.Models
{
    public partial class Estudiante
    {
        public long EstudianteId { get; set; }
        public string NombreEstudiante { get; set; }
        public long? CursoId { get; set; }
    }
}
