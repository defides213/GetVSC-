using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammeringuke4
{
    internal class Task
    {
        public string Name { get; set; }
        public string Beskrivelse { get; set; }

        public Task(string name, string beskrivelse)
        {
            Name = name;
            Beskrivelse = beskrivelse;
        }

        public void PrintTaskInfo()
        {
            Console.WriteLine($"Denne oppgaven handler om:\n{Beskrivelse}");
        }
    }
}
