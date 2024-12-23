using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacherMuellerLB_426
{
    public class Jetons
    {
        private double _jetons;

        public Jetons(double bougthjetons)
        {
            _jetons = bougthjetons;
        }

        public int AddJetons(double multiplicator)
        {
            return (int)(_jetons * multiplicator);
        }

      
    }
}

