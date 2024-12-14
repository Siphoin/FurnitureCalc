using System;

namespace FurnitureCalc.Sources.Models
{
    [Serializable]
    public class CalcData
    {
        public int Type { get; set; }
        public string NameFurniture { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Fasteners { get; set; }
        public double Thickness { get; set; }
        public double PaintCount { get; set; }
        public double WoodCount { get; set; }
        public string NameTargetOfThickness { get; set; }

        public CalcData(int type, string name, double length, double width, double height, double thickness, double woodCount, double paintCount, string nameTargetOfThickness, double fasteners)
        {
            Type = type;
            NameFurniture = name;
            Length = length;
            Width = width;
            Height = height;
            Thickness = thickness;
            PaintCount = paintCount;
            WoodCount = woodCount;
            NameTargetOfThickness = nameTargetOfThickness;
            Fasteners = fasteners;
           
        }

        public CalcData()
        {

        }
    }
}
