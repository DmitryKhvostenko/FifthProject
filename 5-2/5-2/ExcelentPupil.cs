using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t52
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Отличник");
            Console.WriteLine("Учеба");
        }

        public override void Read()
        {
            Console.WriteLine("Отличник");
            Console.WriteLine("Чтение");
        }

        public override void Write()
        {
            Console.WriteLine("Отличник");
            Console.WriteLine("Письмо");
        }

        public override void Relax()
        {
            Console.WriteLine("Отличник");
            base.Relax();
        }
    }
}
