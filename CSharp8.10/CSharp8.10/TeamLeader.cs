using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8._10
{
    class TeamLeader:IWorker
    {
        public string Info{ get; set; }
        public void Do()
        {
            Console.WriteLine(Info);
        }
    }
}
