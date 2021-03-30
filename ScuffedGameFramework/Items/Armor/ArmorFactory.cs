using ScuffedGameFramework.Items.Armor.ConcreteArmor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor
{
    class ArmorFactory : IArmorFactory
    {
        private static Random _rng = new Random(Guid.NewGuid().GetHashCode());

        public IArmor Create()
        {
            switch (GenerateArmorType())
            {
                case ArmorType.Helmet:
                    return new LeatherHelmet();
                case ArmorType.Boots:
                    return new LeatherBoots();
                case ArmorType.Shield:
                    return new WornShield();
                default:
                    return null;
            }
        }

        private ArmorType GenerateArmorType()
        {
            var enums = Enum.GetValues(typeof(ArmorType));
            return (ArmorType)enums.GetValue(_rng.Next(enums.Length));
        }
    }
}
