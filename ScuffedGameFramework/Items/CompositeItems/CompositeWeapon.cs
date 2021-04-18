using ScuffedGameFramework.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.CompositeItems
{
    public class CompositeWeapon : WeaponBase
    {
        public List<IWeapon> EquippedWeapons { get; set; }
        public CompositeWeapon()
        {
            EquippedWeapons = new List<IWeapon>();
        }

        public override int Damage
        {
            get
            {
                return EquippedWeapons.Sum(d => d.Damage);
            }
        }

        public void AddWeapon(IWeapon item)
        {
            var weapon = EquippedWeapons.FindAll(a => a.GetType() == item.GetType());
            if (weapon.Count <= 2)
            {
                EquippedWeapons.Add(item);
                //Console.WriteLine($"{item.Name} has been equipped! Total attack power is now: {Damage}");
            }
            else
            {
                //Console.WriteLine($"You found {item.Name} but can't equip it, since you already got the item equipped.");
            }
        }
    }
}
