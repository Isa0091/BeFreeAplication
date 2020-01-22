using BeFreeAplication.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model.Administracion
{
    public class DatosUsuario
    {
        /// <summary>
        /// identificador del usuario
        /// </summary>
        string IdUsuario { get; set; }
        /// <summary>
        /// value object de dato valor
        /// </summary>
       DatosValor DatoUsuario { get; set; }
    }
}
