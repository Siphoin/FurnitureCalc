using System;

namespace FurnitureCalc.Sources.Models
{
    [Serializable]
    public class Bed : Furniture
    {
        public double MattressThickness { get; set; }
        public double Fasteners { get; set; }

        public Bed(double length, double width, double height, double mattressThickness, double fasteners)
        {
            Length = length;
            Width = width;
            Height = height;
            MattressThickness = mattressThickness;
            Fasteners = fasteners;
        }

        public override double CalculateWoodVolume()
        {
            // Приблизительный расчет, учитывающий каркас
            return (Length * Width * Height) * 0.5; // 0.5 - коэффициент, учитывающий пустоты в каркасе
        }

        public override double CalculateFasteners()
        {
            return Fasteners;
        }

        public override double CalculatePaint()
        {
            return (Length * Width * 2) / 1000; // 1000 см2 ≈ 1 л
        }

        public override string GetNameTargetOfThickness()
        {
            return "матраса";
        }
    }

}
