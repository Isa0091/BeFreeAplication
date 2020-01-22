using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.Model
{
    public enum EstadoUsuario
    {
        /// <summary>
        /// indica que el usuario esta activo
        /// </summary>
        Activo = 1,
        /// <summary>
        /// indica que el suuario esta inactivo
        /// </summary>
        Inativo = 2,
        /// <summary>
        /// indica que el usuario esta ocupado
        /// </summary>
        Ocupado = 3,
        /// <summary>
        /// indica que el usuario esta trabajando
        /// </summary>
        Trabajando= 4,
        /// <summary>
        /// indica que el usuario esta descansando
        /// </summary>
        Descansando = 5,
    }
}
