using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasESeladas.Abstract
{
    //abstract, exclusivo para herança
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }

        //Método abstract trabalha como se fosse uma interface
        public abstract bool IsValid();
    }
}
