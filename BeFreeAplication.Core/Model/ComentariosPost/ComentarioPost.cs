using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model.ComentariosPost
{
    /// <summary>
    /// Comentarios realizados a un post
    /// </summary>
    public class ComentarioPost : RootEntity
    {
        /// <summary>
        /// identificador del usuario que comenta el post
        /// </summary>
        public string IdUsuarioComenta{ get; set; }
        /// <summary>
        /// comentario a el post
        /// </summary>
        public string Comentario { get; set; }
        /// <summary>
        /// si envio algun tipo de archivo multimedia
        /// </summary>
        public int? IdMultimedia { get; set; }
        /// <summary>
        /// identificador del usuario que recibe el mensaje
        /// </summary>
        public string IdUsuarioPost{ get; set; }
        /// <summary>
        /// fecha que se envio el mensaje
        /// </summary>
        public DateTimeOffset FechaComentario { get; set; }
        /// <summary>
        /// si esta visible o no el comentario
        /// </summary>
        public bool Visible { get; set; }
    }
}
