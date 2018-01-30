using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class Cortado : Kaffe , IMælk
    {
        /// <summary>
        /// hvor meget mælk skal bruge i cortado
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}
