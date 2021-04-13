using ScuffedGameFramework.Items.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.CompositeItems
{
    public class CompositeArmor : ArmorBase
    {
        public List<IArmor> EquippedArmor { get; set; }
        public CompositeArmor()
        {
            EquippedArmor = new List<IArmor>();
        }

        public override int Defense
        {
            get
            {
                return EquippedArmor.Sum(d => d.Defense);
            }
        }

        public void AddArmor(IArmor item)
        {
            var armor = EquippedArmor.FindAll(a => a.GetType() == item.GetType());
            if (armor.Count < 1)
            {
                EquippedArmor.Add(item);
                //Console.WriteLine($"{item.Name} has been equipped! Total defense is now: {Defense}");
            }
            else
            {
                //Console.WriteLine($"You found {item.Name} but can't equip it, since you already got the item equipped.");
            }
        }
    }
}
