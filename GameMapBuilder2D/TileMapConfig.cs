using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMapBuilder2D
{
    public class TileMapConfig
    {
        public int tileMapWidth;
        public int tileMapHeight;

        private TileMapConfigElement[] tileMapElements;
        public List<string> imageNames;

        public TileMapConfigElement[] TileMapElements
        {
            get { return tileMapElements; }
            set { tileMapElements = value; }
        }

        public TileMapConfig(int mapWidth, int mapHeight)
        {
            tileMapWidth = mapWidth;
            tileMapHeight = mapHeight;

            TileMapElements = new TileMapConfigElement[mapHeight * mapWidth];

            for (int i = 0; i < TileMapElements.Length; i++)
            {
                TileMapElements[i] = new TileMapConfigElement();
            }

            imageNames = new List<string>();
        }
    }
}
