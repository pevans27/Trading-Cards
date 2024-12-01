using System.Drawing;

namespace Assignment3
{
    public class PlayerCard
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public Image Photo { get; set; }
        public double Points { get; set; }
        public double Rebounds { get; set; }
        public double Assists { get; set; }
        public double FGPercentage { get; set; }
    }
}
