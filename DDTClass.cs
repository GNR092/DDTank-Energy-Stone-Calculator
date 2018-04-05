using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DDTank_Energy_Stone_Calculator
{
    public class DDTClass
    {
        private static int EnergyStone = 10;
        public int LvlWeapon { get; set; }
        public double VipLvl { get; set; }
        public int GuildBonus { get; set; }
        public int Exp { get; set; }
        public bool VipEnabled { get; private set; }

        public DDTClass()
        {
            LvlWeapon = 0;
            VipLvl = 0;
            GuildBonus = 0;
            Exp = 0;
            VipEnabled = false;
        }

        internal void Check(string weapon, string exp, string bonus, string vip, bool cvip)
        {
            try
            {
                LvlWeapon = Validador.CheckWExp(weapon);
                Exp = int.Parse(exp);
                GuildBonus = int.Parse(bonus);
                VipLvl = Validador.CheckVip(vip);
                VipEnabled = cvip;
                
            }
            catch
            {

            }
        }
        #region Calculando
        public static int CalcularBonus(int _exp, int _Texp, int _Gbonus, double _vip, bool check)
        {
            int _r;
            double r;
            if (check)
            {
                double vip = EnergyStone * _vip;
                _r = _Texp - _exp;
                r = _r / (EnergyStone + vip + _Gbonus);
                if (r <= 0)
                    return 1;
                else
                    return (int)Math.Round(r);
            }
            else
            {
                _r = _Texp - _exp;
                r = _r / (EnergyStone + _Gbonus);
                if (r <= 0)
                    return 1;
                else
                    return (int)Math.Round(r);
            }
        }
        #endregion
    }
}
