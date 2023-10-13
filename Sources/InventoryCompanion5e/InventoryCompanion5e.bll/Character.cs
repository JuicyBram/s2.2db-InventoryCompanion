using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCompanion5e.bll
{
    public class Character
    {
        private string Name;
        private Race Race;
        private Archetype Archetype;
        private int Strength;
        private string carryCapacity;
        private string carryWeight;
        private string attunementSlots;
        private string Inventory;

        public Character(string name, Race race, Archetype archetype, int strength)
        {
            Name = name;
            Race = race;
            Archetype = archetype;
            Strength = strength;
        }
    }
}
