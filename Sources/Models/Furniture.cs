using System;

namespace FurnitureCalc.Sources.Models
{
    [Serializable]
    public abstract class Furniture
    {
        public string NameFurniture { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateWoodVolume();
        public abstract double CalculateFasteners(); // Количество комплектующих
        public abstract double CalculatePaint(); // Количество краски/лака
        public abstract string GetNameTargetOfThickness();
    }
}
