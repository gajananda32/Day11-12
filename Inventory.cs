using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangment
{
    public class Inventory
    {
        public List<TypesofRice> typesofRice;
        public List<TypesofPulses>typesofPulses;
        public List<TypesofWeats> typesofWeats;
    }
    public class TypesofRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesofPulses
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesofWeats
    {
        public string name;
        public int weight;
        public int price;
    }
}
