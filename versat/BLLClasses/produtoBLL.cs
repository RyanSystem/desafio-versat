using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versat.BLLClasses
{
    internal class produtoBLL
    {
        public int id_prod {get;set;}
        public string nome_prod { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int categoria { get; set; }
        public int qntd { get; set; }


    }
}
