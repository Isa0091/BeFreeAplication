using System;
using System.Collections.Generic;
using System.Text;

namespace BeFreeAplication.Core.ValueObjects
{
    public class InfoUltimaConexion : BaseValueObject
    {

        /// <summary>
        /// constructor
        /// </summary>
        public InfoUltimaConexion(DateTimeOffset ultimaConexion) {

            UltimaConexion = ultimaConexion;

        }


        public DateTimeOffset UltimaConexion { get; private set; }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return UltimaConexion;
        }
    }
}
