using InventoryCompanion5e.bll.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCompanion5e.bll
{
    public class Race
    {
        private string Name;
        private string Description;
        private SizeEnum Size;

        public Race(string name, string description, SizeEnum size)
        {
            Name = name;
            Description = description;
            Size = size;
        }
    }
}
