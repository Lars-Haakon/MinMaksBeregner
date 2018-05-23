using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaksBeregner
{
    public class Beregner
    {
        // Antall skudd i serien, eksempelvis 6 skudd for vanlig innledende hold og 12 for vanlig finalehold
        private int AntallSkuddHold;

        public Beregner(int antallSkuddHold)
        {
            AntallSkuddHold = antallSkuddHold;
        }

        public String BeregnMin(int antallSkudd, int antallTreff, int antallInnertreff)
        {
            int minTreff = AntallSkuddHold - (antallSkudd - antallTreff);
            if (minTreff < 0)
                minTreff = 0;

            int minInnerTreff = AntallSkuddHold - (antallSkudd - antallInnertreff);
            if (minInnerTreff < 0)
                minInnerTreff = 0;

            return minTreff + "/" + minInnerTreff;
        }

        public String BeregnMaks(int antallSkudd, int antallTreff, int antallInnertreff)
        {
            int maksTreff = antallTreff;
            if (maksTreff > AntallSkuddHold)
                maksTreff = AntallSkuddHold;

            int maksInnertreff = antallInnertreff;
            if (maksInnertreff > AntallSkuddHold)
                maksInnertreff = AntallSkuddHold;

            return maksTreff + "/" + maksInnertreff;
        }
    }
}
