using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_С_Sharp
{
    class Tank
    {
        Random rnd = new Random();
        public String NameTank { get; set; }
        public int LvlAmmunition { get; set; }
        public int LvLArmor { get; set; }
        public int LvlManeu { get; set; }
        public Tank(string name)
        {
            NameTank = name;
            LvlAmmunition = rnd.Next(100);
            LvLArmor = rnd.Next(100);
            LvlManeu = rnd.Next(100);
        }

        public static int operator *(Tank t1, Tank t2)
        {
            int tc1 = 0;
            int tc2 = 0;
            if (t1.LvlAmmunition > t2.LvlAmmunition)
                tc1++;
            else
                tc2++;
            if (t1.LvLArmor > t2.LvLArmor)
                tc1++;
            else
                tc2++;
            if (t1.LvlManeu > t2.LvlManeu)
                tc1++;
            else
                tc2++;
            if (tc1 > tc2)
                return 1;
            else if (tc1 < tc2)
                return 2;
            else
                return 0;

        }
        public override string ToString()
        {
            return $"Tank: {NameTank}, {LvlAmmunition}, {LvLArmor}, {LvlManeu}";
        }

    }
}
