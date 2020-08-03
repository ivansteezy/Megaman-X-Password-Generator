using MegamanXPasswordGenerator.source;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegamanXCodeGenerator.source
{
    public class PasswordGrid
    {
        public PasswordGrid(PasswordGenerator genetor)
        {
            passwordSlots = genetor.GeneratePasswordSlots();
        }

        public ObservableCollection<String> GenerateGrid()
        {
            var paths = new ObservableCollection<String>();

            foreach(var i in passwordSlots)
                paths.Add(pathsMap[i]);

            return paths;
        }

        private Dictionary<int, string> pathsMap = new Dictionary<int, string>()
        {
            {1, "Sprites/code-1.png" }, {2, "Sprites/code-2.png" }, { 3, "Sprites/code-3.png" }, { 4, "Sprites/code-4.png" },
            {5, "Sprites/code-5.png" }, {6, "Sprites/code-6.png" }, { 7, "Sprites/code-7.png" }, { 8, "Sprites/code-8.png" }
        };

        List<int> passwordSlots { get; set; }
    }
}
