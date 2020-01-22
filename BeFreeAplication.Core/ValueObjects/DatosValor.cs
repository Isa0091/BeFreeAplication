using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.ValueObjects
{
    public class DatosValor : BaseValueObject
    {

         public DatosValor(string dato , string valor){
            Dato = dato;
            Valor = valor;
        
        }
        /// <summary>
        /// dato
        /// </summary>
        public string Dato { get; private set; }

        /// <summary>
        /// valor del dato
        /// </summary>
        public string Valor { get; private set; }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Dato;
            yield return Valor;

        }
    }
}
