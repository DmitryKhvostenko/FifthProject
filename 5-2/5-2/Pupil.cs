using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t52
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Учеба");
        }

        public virtual void Read()
        {
            Console.WriteLine("Чтение");
        }

        public virtual void Write()
        {
            Console.WriteLine("Письмо");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Отдых");
        }
    }
}
