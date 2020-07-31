using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegamanXPasswordGenerator.source
{
    class Criteria
    {
        public Pair<int, int> Position { get; set; }
        public Pair<int, int> N        { get; set; }
        public Pair<int, int> X        { get; set; }
        public Pair<int, int> Y        { get; set; }
        public Pair<int, int> XY       { get; set; }
    }
}
