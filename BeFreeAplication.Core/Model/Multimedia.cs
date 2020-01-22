using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model
{
    /// <summary>
    /// se guardara la multimedia
    /// </summary>
    public class Multimedia : RootEntity
    {
        /// <summary>
        /// identificador de la multimedia
        /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// archivo guardado
        /// </summary>
        public byte[] Archivo { get; set; }
        /// <summary>
        /// archivo ya sea en base64 o la ruta
        /// </summary>
        public string ArchivoData { get; set; }
        /// <summary>
        /// identificador del tipo de archivo guardado
        /// </summary>
        public string MymeType { get; set; }
    }
}
