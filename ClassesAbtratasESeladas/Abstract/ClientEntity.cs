using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasESeladas.Abstract
{
    public class ClientEntity : EntityBase
    {
        public override bool IsValid()
        {
            //if(Id <= 0) Exemplos
            //    return false;

            return true;
        }
    }
}
