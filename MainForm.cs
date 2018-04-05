/* one line to give the program's name and an idea of what it does.
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
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.*/

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DDTank_Energy_Stone_Calculator
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Haga clic en cualquier lugar para moverse
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        private const int EnergyStone = 10;
        private int _TExp;
        private double _vip;
        private int _GuildBonus;
        private int _Exp;

        DDTClass DDTank;
        public MainForm()
        {
            InitializeComponent();
            DDTank = new DDTClass();
            lb_BasicValue.Text = EnergyStone.ToString();
        }
        #region Niveles de arma
        void ComboBox1TextUpdate(object sender, EventArgs e)
        { 
            _TExp = Validador.CheckTExp(weaponlvl.Text);
            
        }
        #endregion
        #region ZonaVip
        void ZonaVip(object sender, EventArgs e)
        {
            _vip = Validador.CheckVip(cb_vip.Text);
            if (string.IsNullOrEmpty(weaponlvl.Text))
            {
                lb_VIP.Text = "0";
                lb_VIP.Update();
            }
            else
            {
                lb_VIP.Text = (EnergyStone * _vip).ToString();
                lb_VIP.Update();
            }

        }
        void ZonaVip()
        {
            _vip = Validador.CheckVip(cb_vip.Text);
            if (string.IsNullOrEmpty(weaponlvl.Text))
            {
                lb_VIP.Text = "0";
                lb_VIP.Update();
            }
            else
            {
                lb_VIP.Text = (EnergyStone * _vip).ToString();
                lb_VIP.Update();
            }
        }
        #endregion
        #region KeyPress
        private void Txt_expKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            e.Handled = Validador.Numerico(Convert.ToString(e.KeyChar));
        }
        
        private void Check_VipCheckedChanged(object sender, EventArgs e)
        {
            if (cb_vip.Enabled)
            {
                cb_vip.Enabled = false;
                _vip = 0;
                lb_VIP.Text = "0";
                lb_VIP.Update();
            }
            else
            {
                cb_vip.Enabled = true;
            }
        }
        #endregion
       
        #region CambioDeTexto
        private void Txt_gbonusTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_gbonus.Text))
            {
                _GuildBonus = 0;
                txt_gbonus.Text = _GuildBonus.ToString();
                lb_GuildBonus.Text = _GuildBonus.ToString();
                lb_GuildBonus.Update();
            }
            else
            {
                _GuildBonus = int.Parse(txt_gbonus.Text);
                lb_GuildBonus.Text = txt_gbonus.Text;
                lb_GuildBonus.Update();
            }
        }

        private void Txt_expTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_exp.Text))
            {
                _Exp = 0;
                txt_exp.Text = _Exp.ToString();

            }
            if (Convert.ToInt32(txt_exp.Text) > Convert.ToInt32(_TExp))
            {
                txt_exp.Text = _TExp.ToString();
            }
            if (!string.IsNullOrEmpty(txt_exp.Text))
            {
                _Exp = int.Parse(txt_exp.Text);
            }
            pbar_exp.Value = _Exp;
        }
        #endregion
        #region Check
        private void Btn_CheckClick(object sender, EventArgs e)
        {
            _GuildBonus = int.Parse(txt_gbonus.Text);
            try
            {
                if (string.IsNullOrEmpty(weaponlvl.Text))
                    MessageBox.Show("Seleciona el nivel del arma", "Seleciona Un Nivel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    txt_resultado.Text = DDTClass.CalcularBonus(_Exp, _TExp, _GuildBonus, _vip, check_Vip.Checked).ToString();
                }
            }
            catch (Exception)
            {

                if (string.IsNullOrEmpty(txt_exp.Text))
                {
                    MessageBox.Show("El Campo Experiencia no puede estar vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txt_exp.Focus();
            }

        }
        #endregion
        private void _timerTick(object sender, EventArgs e)
        {
            DDTank.Check(weaponlvl.Text, txt_exp.Text, txt_gbonus.Text, cb_vip.Text, cb_vip.Enabled);

            if(cb_vip.Enabled)
            {
                _vip = Validador.CheckVip(cb_vip.Text);
                lb_VIP.Text = (EnergyStone * _vip).ToString();
                lb_VIP.Update();
            }
            double vip = (EnergyStone * _vip);
            if (cb_vip.Enabled)
            {
                lb_VIP.Text = (EnergyStone * _vip).ToString();
                lb_VIP.Update();
            }
            lb_GuildBonus.Update();
            lb_TotalValue.Text = (EnergyStone + _GuildBonus + vip).ToString();
            lb_TotalValue.Update();

        }
        private void Button1Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btn_InfoClick(object sender, EventArgs e)
        {
            MessageBox.Show("1.-Selecciona el Nivel de tu arma.\n2.-Introduce la Experiencia que tiene tu arma.\n3.-Introduce el bonus de tu liga de lo contrario dejalo como esta.\n4.-Si eres VIP marcalo y selecciona tu Nivel de VIP.\n5.-Por ultimo dale al boton check.\n\nCreado por GNR092 Gracias por usar mi programa.\nCualquier Error Notificarlo en https://github.com/GNR092", "Como Usarlo:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void weaponlvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbar_exp.Maximum = _TExp;
        }
    }
}
