using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divicion_constructor
{
    internal class DIVICION
    
        {
            //campos, propiedades, como es 
            private float n1, n2;
            //constructor
            public DIVICION(float n1, float n2)
            {
                this.n1 = n1;
                this.n2 = n2;
            }
            public float dividir()
            {
                return (n1 / n2);
            }
    }
}

