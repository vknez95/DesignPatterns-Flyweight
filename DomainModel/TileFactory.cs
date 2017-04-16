using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class TileFactory
    {
        private readonly Dictionary<Type, ITile> tiles = new Dictionary<Type, ITile>();

        public ITile GetTile(Type tileType)
        {
            ITile value = null;

            if (!tiles.TryGetValue(tileType, out value))
            {
                value = Activator.CreateInstance(tileType) as ITile;
                tiles.Add(tileType, value);
            }

            return value;
        }
    }
}
