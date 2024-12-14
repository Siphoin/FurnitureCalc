using System;

namespace FurnitureCalc.Sources.Models
{
    [Serializable]
    public class Wardrobe : Furniture
    {
        public double WallThickness { get; set; }
        public double Fasteners { get; set; }

        public Wardrobe(double length, double width, double height, double wallThickness, double fasteners)
        {
            Length = length;
            Width = width;
            Height = height;
            WallThickness = wallThickness;
            Fasteners = fasteners;
        }

        public override double CalculateWoodVolume()
        {
            // Приблизительный расчет
            return (Length * Width * Height) * 0.7; // 0.7 - коэффициент, учитывающий пустоты и полки
        }

        public override double CalculateFasteners()
        {
            return Fasteners; // Примерное количество шурупов и петель
        }

        public override double CalculatePaint()
        {
            return (Length * Width * 2 + Length * Height * 2 + Width * Height * 2) / 1000; //1000 см2 ≈ 1 л
        }

        public override string GetNameTargetOfThickness()
        {
            return "стенок";
        }
    }
}
