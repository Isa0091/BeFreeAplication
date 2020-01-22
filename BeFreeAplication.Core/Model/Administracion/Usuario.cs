using BeFreeAplication.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model.Administracion
{
    /// <summary>
    /// 
    /// </summary>
    public class Usuario : RootEntity
    {
        /// <summary>
        /// nombre del usuario
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// apellido del usuario 
        /// </summary>
        public string Apellido { get; set; }
        /// <summary>
        /// email del usuario
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// fecha de nacimiento 
        /// </summary>
        public DateTimeOffset Fechanacimiento { get; set; }
        /// <summary>
        /// informacion de la ultima vez conectada la personas
        /// </summary>
        public InfoUltimaConexion InfoUltimaConexion { get; set; }
        /// <summary>
        /// fecha de creacion del usuario
        /// </summary>
        public DateTimeOffset FechaCreacion { get; set; }
        /// <summary>
        /// estado del usuario
        /// </summary>
        public EstadoUsuario EstadoUsuario { get; set; }
        /// <summary>
        /// listado de los datos del usuario
        /// </summary>
        public List<DatosUsuario> DatosUsuario { get; set; }

    }
}
