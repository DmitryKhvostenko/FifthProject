using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t52
{
    internal class GoodPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хорошист");
            Console.WriteLine("Учеба");
        }

        public override void Read()
        {
            Console.WriteLine("Хорошист");
            Console.WriteLine("Чтение");
        }

        public override void Write()
        {
            Console.WriteLine("Хорошист");
            Console.WriteLine("Письмо");
        }

        public override void Relax()
        {
            Console.WriteLine("Хорошист");
            base.Relax();
        }
    }
}
