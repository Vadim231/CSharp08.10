using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8._10
{
    class Worker:IWorker
    {
        public void Do()
        {
            Console.WriteLine("Рабочий выполнил работу");
        }
    }
}
