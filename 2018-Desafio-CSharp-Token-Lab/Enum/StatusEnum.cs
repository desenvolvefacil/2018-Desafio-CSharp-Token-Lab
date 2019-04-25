using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_Desafio_CSharp_Token_Lab.Enum
{
    public enum StatusEnum:int
    {
        [Description("Padrao")]
        PADRAO = -1,

        [Description("Incluido")]
        INCLUIDO = 1,

        [Description("Removido")]
        REMOVIDO = 2,

    }
}
