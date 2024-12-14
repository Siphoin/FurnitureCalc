using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCalc.Sources.Models
{
    public class Table : Furniture
    {
        public double TabletopThickness { get; set; }
        public double Fasteners { get; set; }

        public Table(double length, double width, double height, double tabletopThickness, double fasteners)
        {
            Length = length;
            Width = width;
            Height = height;
            TabletopThickness = tabletopThickness;
            Fasteners = fasteners;
        }

        public override double CalculateWoodVolume()
        {
            // Приблизительный расчет, учитывающий ножки и каркас
            return (Length * Width * TabletopThickness) + (Length * Height * 0.1 * 4); // 0.1 - приблизительный объем ножек
        }

        public override double CalculateFasteners()
        {
            return Fasteners;
        }

        public override double CalculatePaint()
        {
            // Приблизительное количество краски для поверхности
            return (Length * Width + 4 * Length * Height * 0.1) / 1000; // 1000 см2 ≈ 1 л
        }

        public override string GetNameTargetOfThickness()
        {
            return "столешницы";
        }
    }
}
