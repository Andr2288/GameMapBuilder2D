using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace GameMapBuilder2D
{
    public class TileMapConfigElement
    {
        public List<int> elementNumbers { get; set; }

        public TileMapConfigElement()
        {
            elementNumbers = new List<int>();
        }
    }
}
