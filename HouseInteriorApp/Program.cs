using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DomainModel;
using Utility;

namespace HouseInteriorApp
{
    static class Program
    {
        static IList<Type> tileTypes = new List<Type>();
        static TileDemo tileDemo = new TileDemo();

        static void Main()
        {
            LoadTileTypes();

            foreach (Type tileType in tileTypes)
            {
                Console.WriteLine(tileType.Name);
                tileDemo.Paint(tileType, 5);
            }
        }

        static void LoadTileTypes()
        {
            typeof(ITile)
                .GetTypeInfo()
                .Assembly
                .GetTypes()
                .ForEach(type =>
                {
                    if (type
                        .GetInterfaces()
                        .Where(i => i.Name == typeof(ITile).Name)
                        .Any())
                        tileTypes.Add(type);
                });
        }
    }
}
