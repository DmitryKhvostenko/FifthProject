using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t52
{
    internal class BadPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Двоечник");
            Console.WriteLine("Учеба");
        }

        public override void Read()
        {
            Console.WriteLine("Двоечник");
            Console.WriteLine("Чтение");
        }

        public override void Write()
        {
            Console.WriteLine("Двоечник");
            Console.WriteLine("Письмо");
        }

        public override void Relax()
        {
            Console.WriteLine("Двоечник");
            base.Relax();
        }
    }
}
