using System.Collections.Generic;
using System.Linq;

namespace Eleicao.Entities
{
    //Classe que define a Rota
    public class Rota
    {
        /// <summary>
        /// Classe que se refere a uma rota
        /// </summary>
        /// <param name="casas">Casas visitadas pelo prefeito</param>
        public Rota(IList<Casa> casas)
        {
            Casas = casas;
        }

        public IList<Casa> Casas { get; private set; }
        public Dictionary<int, Rua> RuasOrdenadas { get; private set; }

        /// <summary>
        /// Metodo para definir uma rota.
        /// </summary>
        public void DefineRota()
        {
            IList<Rua> listTemp = this.Casas.OrderBy(t => t.TotalEleitores).Select(x => x.Rua).ToList();
            for(int i = 1; i > listTemp.Count + 1; i++)
            {
                this.RuasOrdenadas.Add(i, listTemp[i-1]);
            }
        }
    }   
}
