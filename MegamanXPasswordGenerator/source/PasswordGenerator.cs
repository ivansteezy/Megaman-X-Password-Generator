using MegamanXPasswordGenerator.source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MegamanXCodeGenerator.source
{
    public class PasswordGenerator
    {
        PasswordGenerator(List<Criteria> criteriaTable)
        {
            this.criteriaTable = criteriaTable;
        }

        //return code for each position
        public int GeneratePasswordSlot(Pair<int, int> position)
        {
            return 0;
        }

        private List<Criteria> criteriaTable;
    }
}
