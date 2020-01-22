using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BeFreeAplication.Core.Model
{
    /// <summary>
    /// Clase base heredada por todas las entidades principales de un aggregate
    /// </summary>
    public class RootEntity : Entity
    {

        List<MediatR.INotification> _eventos;

        /// <summary>
        /// 
        /// </summary>
        public RootEntity()
        {
            _eventos = new List<MediatR.INotification>();
        }

        /// <summary>
        /// Permite agregar domain events que deben dispararse
        /// </summary>
        /// <param name="evento"></param>
        public void AgregarEvento(MediatR.INotification evento)
        {
            _eventos.Add(evento);
        }

        /// <summary>
        /// Permite quitar un domain event
        /// </summary>
        /// <param name="evento"></param>
        public void QuitarEvento(MediatR.INotification evento)
        {
            _eventos?.Remove(evento);
        }

        /// <summary>
        /// Saca todos los eventos a disparar
        /// </summary>
        public List<MediatR.INotification> Eventos => _eventos;


    }
}