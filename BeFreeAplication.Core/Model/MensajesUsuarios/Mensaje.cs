using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model.MensajesUsuarios
{
    public class Mensaje : RootEntity
    {
        /// <summary>
        /// identificador del suuario que envia el mensaje
        /// </summary>
        public string IdUsuarioEnvia { get; set; }
        /// <summary>
        /// mensaje
        /// </summary>
        public string MensajeEnviado { get; set; }
        /// <summary>
        /// si envio algun tipo de archivo multimedia
        /// </summary>
        public int? IdMultimedia { get; set; }
        /// <summary>
        /// identificador del usuario que recibe el mensaje
        /// </summary>
        public string IdUsuarioRecibe { get; set; }
        /// <summary>
        /// fecha que se envio el mensaje
        /// </summary>
        public DateTimeOffset FechaEnvio { get; set; }
    }
}
