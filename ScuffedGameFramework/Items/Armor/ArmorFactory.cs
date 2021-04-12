using ScuffedGameFramework.Items.Armor.ConcreteArmor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScuffedGameFramework.Helpers;

namespace ScuffedGameFramework.Items.Armor
{
    class ArmorFactory : IArmorFactory
    {

        public IArmor Create()
        {
            switch (EnumValueGenerator.GenerateRace<ArmorType>())
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
    }
}
