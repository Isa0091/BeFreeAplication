using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model.PublicacionesUsuario
{
    /// <summary>
    /// publicaciones de post de los usuarios
    /// </summary>
    public class Post : RootEntity
    {
        /// <summary>
        /// identificador del post
        /// </summary>
        public Guid Codigo { get; set; }
        /// <summary>
        /// identificador del ususario que publica el post
        /// </summary>
        public string IdUsuario { get; set; }
        /// <summary>
        /// titulo del post
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// descripcion del post
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// identificador de la multimedia del post
        /// </summary>
        public int? idMultimedia { get; set; }
        /// <summary>
        /// fecha en que se publico el post
        /// </summary>
        public DateTimeOffset FechaPublicacion { get; set; }
    }
}
