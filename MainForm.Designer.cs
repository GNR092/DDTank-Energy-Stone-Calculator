/*
 * Creado por SharpDevelop.
 * Usuario: GNR092
 * Fecha: 16/03/2016
 * Hora: 06:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DDTank_Energy_Stone_Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lb_TotalValue;
		private System.Windows.Forms.Label lb_VIP;
		private System.Windows.Forms.Label lb_GuildBonus;
		private System.Windows.Forms.Label lb_BasicValue;
		private System.Windows.Forms.Button btn_Check;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox weaponlvl;
		private System.Windows.Forms.ComboBox cb_vip;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox check_Vip;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_exp;
		private System.Windows.Forms.Label lb_need;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_resultado;
		private System.Windows.Forms.TextBox txt_gbonus;
		private System.Windows.Forms.Timer _timer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Info;
		private System.Windows.Forms.LinkLabel linkLabel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lb_TotalValue = new System.Windows.Forms.Label();
			this.lb_VIP = new System.Windows.Forms.Label();
			this.lb_GuildBonus = new System.Windows.Forms.Label();
			this.lb_BasicValue = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Check = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.weaponlvl = new System.Windows.Forms.ComboBox();
			this.cb_vip = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.check_Vip = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_exp = new System.Windows.Forms.TextBox();
			this.lb_need = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_resultado = new System.Windows.Forms.TextBox();
			this.txt_gbonus = new System.Windows.Forms.TextBox();
			this._timer = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.btn_Info = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_TotalValue
			// 
			this.lb_TotalValue.AutoSize = true;
			this.lb_TotalValue.BackColor = System.Drawing.Color.Transparent;
			this.lb_TotalValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_TotalValue.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.lb_TotalValue.Location = new System.Drawing.Point(319, 293);
			this.lb_TotalValue.Name = "lb_TotalValue";
			this.lb_TotalValue.Size = new System.Drawing.Size(13, 14);
			this.lb_TotalValue.TabIndex = 28;
			this.lb_TotalValue.Text = "0";
			// 
			// lb_VIP
			// 
			this.lb_VIP.AutoSize = true;
			this.lb_VIP.BackColor = System.Drawing.Color.Transparent;
			this.lb_VIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_VIP.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.lb_VIP.Location = new System.Drawing.Point(253, 292);
			this.lb_VIP.Name = "lb_VIP";
			this.lb_VIP.Size = new System.Drawing.Size(13, 14);
			this.lb_VIP.TabIndex = 27;
			this.lb_VIP.Text = "0";
			// 
			// lb_GuildBonus
			// 
			this.lb_GuildBonus.AutoSize = true;
			this.lb_GuildBonus.BackColor = System.Drawing.Color.Transparent;
			this.lb_GuildBonus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_GuildBonus.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.lb_GuildBonus.Location = new System.Drawing.Point(176, 292);
			this.lb_GuildBonus.Name = "lb_GuildBonus";
			this.lb_GuildBonus.Size = new System.Drawing.Size(13, 14);
			this.lb_GuildBonus.TabIndex = 26;
			this.lb_GuildBonus.Text = "0";
			// 
			// lb_BasicValue
			// 
			this.lb_BasicValue.AutoSize = true;
			this.lb_BasicValue.BackColor = System.Drawing.Color.Transparent;
			this.lb_BasicValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_BasicValue.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.lb_BasicValue.Location = new System.Drawing.Point(97, 293);
			this.lb_BasicValue.Name = "lb_BasicValue";
			this.lb_BasicValue.Size = new System.Drawing.Size(13, 14);
			this.lb_BasicValue.TabIndex = 25;
			this.lb_BasicValue.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label4.Location = new System.Drawing.Point(292, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 15);
			this.label4.TabIndex = 20;
			this.label4.Text = "Total Value";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label3.Location = new System.Drawing.Point(226, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 14);
			this.label3.TabIndex = 19;
			this.label3.Text = "VIP Bonus";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label2.Location = new System.Drawing.Point(149, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 14);
			this.label2.TabIndex = 18;
			this.label2.Text = "Guild Bonus";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label1.Location = new System.Drawing.Point(70, 273);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 14);
			this.label1.TabIndex = 17;
			this.label1.Text = "Basic Value";
			// 
			// btn_Check
			// 
			this.btn_Check.Location = new System.Drawing.Point(156, 385);
			this.btn_Check.Name = "btn_Check";
			this.btn_Check.Size = new System.Drawing.Size(51, 22);
			this.btn_Check.TabIndex = 29;
			this.btn_Check.Text = "Check";
			this.btn_Check.UseVisualStyleBackColor = true;
			this.btn_Check.Click += new System.EventHandler(this.Btn_CheckClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(50, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 14);
			this.label5.TabIndex = 30;
			this.label5.Text = "Selecciona el nivel de tu arma:";
			// 
			// weaponlvl
			// 
			this.weaponlvl.DisplayMember = "Seleciona";
			this.weaponlvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.weaponlvl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.weaponlvl.ForeColor = System.Drawing.Color.Black;
			this.weaponlvl.FormattingEnabled = true;
			this.weaponlvl.Items.AddRange(new object[] {
			"+1=>+2",
			"+2=>+3",
			"+3=>+4",
			"+4=>+5",
			"+5=>+6",
			"+6=>+7",
			"+7=>+8",
			"+8=>+9",
			"+9=>+10",
			"+10=>+11",
			"+11=>+12"});
			this.weaponlvl.Location = new System.Drawing.Point(228, 46);
			this.weaponlvl.Name = "weaponlvl";
			this.weaponlvl.Size = new System.Drawing.Size(87, 22);
			this.weaponlvl.TabIndex = 31;
			this.weaponlvl.TextChanged += new System.EventHandler(this.ComboBox1TextUpdate);
			this.weaponlvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_expKeyPress2);
			// 
			// cb_vip
			// 
			this.cb_vip.DisplayMember = "Seleciona";
			this.cb_vip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_vip.Enabled = false;
			this.cb_vip.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cb_vip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.cb_vip.ForeColor = System.Drawing.Color.Black;
			this.cb_vip.FormattingEnabled = true;
			this.cb_vip.Items.AddRange(new object[] {
			"VIP1",
			"VIP2",
			"VIP3",
			"VIP4",
			"VIP5",
			"VIP6",
			"VIP7",
			"VIP8",
			"VIP9",
			"VIP10",
			"VIP11",
			"VIP12"});
			this.cb_vip.Location = new System.Drawing.Point(228, 184);
			this.cb_vip.Name = "cb_vip";
			this.cb_vip.Size = new System.Drawing.Size(87, 22);
			this.cb_vip.TabIndex = 45;
			this.cb_vip.TextUpdate += new System.EventHandler(this.ZonaVip);
			this.cb_vip.TextChanged += new System.EventHandler(this.ZonaVip);
			this.cb_vip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_expKeyPress2);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(87, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 14);
			this.label6.TabIndex = 37;
			this.label6.Text = "Experiencia de tu arma:";
			// 
			// check_Vip
			// 
			this.check_Vip.BackColor = System.Drawing.Color.Transparent;
			this.check_Vip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.check_Vip.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.check_Vip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.check_Vip.Location = new System.Drawing.Point(144, 181);
			this.check_Vip.Name = "check_Vip";
			this.check_Vip.Size = new System.Drawing.Size(78, 24);
			this.check_Vip.TabIndex = 42;
			this.check_Vip.Text = "Zona VIP";
			this.check_Vip.UseVisualStyleBackColor = false;
			this.check_Vip.CheckedChanged += new System.EventHandler(this.Check_VipCheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new System.Drawing.Point(146, 143);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 14);
			this.label7.TabIndex = 40;
			this.label7.Text = "Guild Bonus:";
			// 
			// txt_exp
			// 
			this.txt_exp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.txt_exp.ForeColor = System.Drawing.Color.Black;
			this.txt_exp.Location = new System.Drawing.Point(228, 95);
			this.txt_exp.Name = "txt_exp";
			this.txt_exp.Size = new System.Drawing.Size(110, 20);
			this.txt_exp.TabIndex = 39;
			this.txt_exp.Text = "0";
			this.txt_exp.TextChanged += new System.EventHandler(this.Txt_expTextChanged);
			this.txt_exp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_expKeyPress);
			// 
			// lb_need
			// 
			this.lb_need.AutoSize = true;
			this.lb_need.BackColor = System.Drawing.Color.Transparent;
			this.lb_need.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.lb_need.ForeColor = System.Drawing.Color.PapayaWhip;
			this.lb_need.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lb_need.Location = new System.Drawing.Point(210, 343);
			this.lb_need.Name = "lb_need";
			this.lb_need.Size = new System.Drawing.Size(13, 14);
			this.lb_need.TabIndex = 43;
			this.lb_need.Text = "=";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox1.Location = new System.Drawing.Point(156, 324);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(53, 50);
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			// 
			// txt_resultado
			// 
			this.txt_resultado.Location = new System.Drawing.Point(226, 340);
			this.txt_resultado.Name = "txt_resultado";
			this.txt_resultado.ReadOnly = true;
			this.txt_resultado.Size = new System.Drawing.Size(58, 20);
			this.txt_resultado.TabIndex = 44;
			// 
			// txt_gbonus
			// 
			this.txt_gbonus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.txt_gbonus.ForeColor = System.Drawing.Color.Black;
			this.txt_gbonus.Location = new System.Drawing.Point(228, 140);
			this.txt_gbonus.Name = "txt_gbonus";
			this.txt_gbonus.Size = new System.Drawing.Size(110, 20);
			this.txt_gbonus.TabIndex = 41;
			this.txt_gbonus.Text = "0";
			this.txt_gbonus.TextChanged += new System.EventHandler(this.Txt_gbonusTextChanged);
			this.txt_gbonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_expKeyPress);
			// 
			// _timer
			// 
			this._timer.Enabled = true;
			this._timer.Tick += new System.EventHandler(this._timerTick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(213, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 22);
			this.button1.TabIndex = 46;
			this.button1.Text = "Cerrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn_Info
			// 
			this.btn_Info.Location = new System.Drawing.Point(270, 385);
			this.btn_Info.Name = "btn_Info";
			this.btn_Info.Size = new System.Drawing.Size(51, 22);
			this.btn_Info.TabIndex = 47;
			this.btn_Info.Text = "Info";
			this.btn_Info.UseVisualStyleBackColor = true;
			this.btn_Info.Click += new System.EventHandler(this.Btn_InfoClick);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(375, 4);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(14, 13);
			this.linkLabel1.TabIndex = 48;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "X";
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(484, 410);
			this.ControlBox = false;
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btn_Info);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cb_vip);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.check_Vip);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_exp);
			this.Controls.Add(this.lb_need);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_resultado);
			this.Controls.Add(this.txt_gbonus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.weaponlvl);
			this.Controls.Add(this.btn_Check);
			this.Controls.Add(this.lb_TotalValue);
			this.Controls.Add(this.lb_VIP);
			this.Controls.Add(this.lb_GuildBonus);
			this.Controls.Add(this.lb_BasicValue);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDTank Energy Stone Calculator";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
