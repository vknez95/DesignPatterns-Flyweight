using System;
using DomainModel;
using Drawing;

namespace HouseInteriorApp
{
    public class TileDemo
    {
        Random random = new Random();
        Graphics graphics = new Graphics();
        TileFactory tileFactory = new TileFactory();

        public void Paint(Type tileType, int numOfTimesToPaint)
        {
            for (int i = 0; i < numOfTimesToPaint; i++)
            {
                ITile tile = tileFactory.GetTile(tileType);
                
                tile.Draw(graphics, GetRandomNumber(),
                    GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }
        }

        private int GetRandomNumber()
        {
            return (int)(random.Next(100));
        }
    }
}