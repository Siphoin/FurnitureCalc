using FurnitureCalc.Sources.Models;
using System;
using System.Collections.Generic;

namespace FurnitureCalc.Sources.Services
{
    public static class CalculatorService
    {
        private static Dictionary<int, Type> _furnitures = new Dictionary<int, Type>
        {
            {0, typeof(Table) },
            {1, typeof(Bed) },
            {2, typeof(Wardrobe) },
        };

        public static CalcData Calculate (int index, string name, double length, double width, double height, double thickness, double fasteners)
        {
            Furniture selectedFurniture = null;

            switch (index)
            {
                case 0:
                    Table table = new Table(length, width, height, thickness, fasteners);
                    selectedFurniture = table;
                    break;
                case 1:
                    Bed bed = new Bed(length, width, height, thickness, fasteners);
                    selectedFurniture = bed;
                    break;
                case 2:
                    Wardrobe wardrobe = new Wardrobe(length, width, height, thickness, fasteners);
                    selectedFurniture = wardrobe;
                    break;
                default:
                    throw new ArgumentException(nameof(index));
            }

            double woodValue = selectedFurniture.CalculateWoodVolume();
            double paintValue = selectedFurniture.CalculatePaint();
            double fastenersResult = selectedFurniture.CalculateFasteners();
            string nameTargetOfThickness = selectedFurniture.GetNameTargetOfThickness();
            return new CalcData(
                index, 
                name, 
                length, 
                width, 
                height, 
                thickness,
                woodValue, 
                paintValue, 
                nameTargetOfThickness, 
                fastenersResult);
        }
    }
}
