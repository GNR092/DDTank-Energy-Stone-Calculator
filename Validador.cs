// one line to give the program's name and an idea of what it does.
// Copyright (C) GNR092 2016-2018
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
using System;

namespace DDTank_Energy_Stone_Calculator
{
	/// <summary>
	/// Description of Validador.
	/// </summary>
	public static  class Validador
	{
        private const int EnergyStone = 10;
        public static int CheckTExp(string lvlarma)
		{
			if ((string.Compare(lvlarma, "+1=>+2", StringComparison.Ordinal) == 0)) 
			{
				return 10;
			}
			
			if ((string.Compare(lvlarma, "+2=>+3", StringComparison.Ordinal) == 0)) 
			{
				return 50;
			}
			
			if ((string.Compare(lvlarma, "+3=>+4", StringComparison.Ordinal) == 0)) 
			{
				return 150;
			}
			
			if ((string.Compare(lvlarma, "+4=>+5", StringComparison.Ordinal) == 0)) 
			{
				return 700;
			}
			
			if ((string.Compare(lvlarma, "+5=>+6", StringComparison.Ordinal) == 0)) 
			{
				return 1500;
			}
			
			if ((string.Compare(lvlarma, "+6=>+7", StringComparison.Ordinal) == 0)) 
			{
				return 2300;
			}
			
			if ((string.Compare(lvlarma, "+7=>+8", StringComparison.Ordinal) == 0)) 
			{
				return 3300;
			}
			
			if ((string.Compare(lvlarma, "+8=>+9", StringComparison.Ordinal) == 0)) 
			{
				return 4500;
			}
			
			if ((string.Compare(lvlarma, "+9=>+10", StringComparison.Ordinal) == 0)) 
			{
				return 6000;
			}
			
			if ((string.Compare(lvlarma, "+10=>+11", StringComparison.Ordinal) == 0)) 
			{
				return 7500;
			}
			
			if ((string.Compare(lvlarma, "+11=>+12", StringComparison.Ordinal) == 0)) 
			{
				return 9000;
			}
			return 0;
		}
        public static int CheckWExp(string lvlarma)
        {
            if (string.IsNullOrEmpty(lvlarma))
            {
                lvlarma = "+1=>+2";
            }
            if ((string.Compare(lvlarma, "+1=>+2", StringComparison.Ordinal) == 0))
            {
                return 10;
            }

            if ((string.Compare(lvlarma, "+2=>+3", StringComparison.Ordinal) == 0))
            {
                return 50;
            }

            if ((string.Compare(lvlarma, "+3=>+4", StringComparison.Ordinal) == 0))
            {
                return 150;
            }

            if ((string.Compare(lvlarma, "+4=>+5", StringComparison.Ordinal) == 0))
            {
                return 700;
            }

            if ((string.Compare(lvlarma, "+5=>+6", StringComparison.Ordinal) == 0))
            {
                return 1500;
            }

            if ((string.Compare(lvlarma, "+6=>+7", StringComparison.Ordinal) == 0))
            {
                return 2300;
            }

            if ((string.Compare(lvlarma, "+7=>+8", StringComparison.Ordinal) == 0))
            {
                return 3300;
            }

            if ((string.Compare(lvlarma, "+8=>+9", StringComparison.Ordinal) == 0))
            {
                return 4500;
            }

            if ((string.Compare(lvlarma, "+9=>+10", StringComparison.Ordinal) == 0))
            {
                return 6000;
            }

            if ((string.Compare(lvlarma, "+10=>+11", StringComparison.Ordinal) == 0))
            {
                return 7500;
            }

            if ((string.Compare(lvlarma, "+11=>+12", StringComparison.Ordinal) == 0))
            {
                return 9000;
            }
            return 0;
        }
        public static double CheckVip(string viparma)
		{
            if (string.IsNullOrEmpty(viparma))
            {
                return 0.25;
            }
			if ((string.Compare(viparma, "VIP1", StringComparison.Ordinal) == 0)) 
			{
				return 0.25;
			}
			if ((string.Compare(viparma, "VIP2", StringComparison.Ordinal) == 0)) 
			{
				return 0.25;
			}
			if ((string.Compare(viparma, "VIP3", StringComparison.Ordinal) == 0)) 
			{
				return 0.25;
			}
			if ((string.Compare(viparma, "VIP4", StringComparison.Ordinal) == 0)) 
			{
				return 0.35;
			}
			if ((string.Compare(viparma, "VIP5", StringComparison.Ordinal) == 0)) 
			{
				return 0.35;
			}
			if ((string.Compare(viparma, "VIP6", StringComparison.Ordinal) == 0)) 
			{
				return 0.35;
			}
			if ((string.Compare(viparma, "VIP7", StringComparison.Ordinal) == 0)) 
			{
				return 0.50;
			}
			if ((string.Compare(viparma, "VIP8", StringComparison.Ordinal) == 0)) 
			{
				return 0.50;
			}
			if ((string.Compare(viparma, "VIP9", StringComparison.Ordinal) == 0)) 
			{
				return 0.50;
			}
			if ((string.Compare(viparma, "VIP10", StringComparison.Ordinal) == 0)) 
			{
				return 0.50;
			}
			if ((string.Compare(viparma, "VIP11", StringComparison.Ordinal) == 0)) 
			{
				return 0.50;
			}
			if ((string.Compare(viparma, "VIP12", StringComparison.Ordinal) == 0)) 
			{
				return 0.50;
			}
			return 0.0;
		}
		public static bool Numerico(string e)
		{
			const string _Numeros = "1234567890\b";
			
			if (!_Numeros.Contains(e))
				return true;
			return false;
		}
		public static bool borrar(string e)
		{
			const string _borrar = "\b\r";
			
			if (!_borrar.Contains(e))
				return true;
			else
				return true;
		}
    }
}
