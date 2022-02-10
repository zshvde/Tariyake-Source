namespace xainp
{
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox14 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox10 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox9 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox8 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.siticoneMetroTrackBar3 = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.siticoneMetroTrackBar2 = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.siticoneMetroTrackBar1 = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox5 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox4 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox3 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox2 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox13 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox12 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox11 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse3 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse4 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse5 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse6 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.rightClick = new System.Windows.Forms.Timer(this.components);
            this.leftClick = new System.Windows.Forms.Timer(this.components);
            this.bindTimer = new System.Windows.Forms.Timer(this.components);
            this.bgwWrite = new System.ComponentModel.BackgroundWorker();
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.bgwDestruct = new System.ComponentModel.BackgroundWorker();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 100;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(79, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 346);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox14);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox10);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox9);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox8);
            this.tabPage1.Controls.Add(this.guna2Panel6);
            this.tabPage1.Controls.Add(this.siticoneMetroTrackBar3);
            this.tabPage1.Controls.Add(this.siticoneMetroTrackBar2);
            this.tabPage1.Controls.Add(this.siticoneMetroTrackBar1);
            this.tabPage1.Controls.Add(this.guna2Button1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox5);
            this.tabPage1.Controls.Add(this.guna2Panel5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.guna2CustomCheckBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(464, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 15);
            this.label15.TabIndex = 54;
            this.label15.Text = "discord.gg/spe7kezUTT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(490, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "Unpacked by avoid";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(458, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 15);
            this.label23.TabIndex = 50;
            this.label23.Text = "Deactivate with shift";
            // 
            // guna2CustomCheckBox14
            // 
            this.guna2CustomCheckBox14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox14.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox14.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox14.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox14.CheckedState.Parent = this.guna2CustomCheckBox14;
            this.guna2CustomCheckBox14.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox14.Location = new System.Drawing.Point(432, 99);
            this.guna2CustomCheckBox14.Name = "guna2CustomCheckBox14";
            this.guna2CustomCheckBox14.ShadowDecoration.Parent = this.guna2CustomCheckBox14;
            this.guna2CustomCheckBox14.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox14.TabIndex = 49;
            this.guna2CustomCheckBox14.Text = "guna2CustomCheckBox14";
            this.guna2CustomCheckBox14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox14.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox14.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox14.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox14.UncheckedState.Parent = this.guna2CustomCheckBox14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(164, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 15);
            this.label19.TabIndex = 48;
            this.label19.Text = "Deactivate in menu";
            // 
            // guna2CustomCheckBox10
            // 
            this.guna2CustomCheckBox10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox10.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox10.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox10.CheckedState.Parent = this.guna2CustomCheckBox10;
            this.guna2CustomCheckBox10.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox10.Location = new System.Drawing.Point(138, 203);
            this.guna2CustomCheckBox10.Name = "guna2CustomCheckBox10";
            this.guna2CustomCheckBox10.ShadowDecoration.Parent = this.guna2CustomCheckBox10;
            this.guna2CustomCheckBox10.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox10.TabIndex = 47;
            this.guna2CustomCheckBox10.Text = "guna2CustomCheckBox10";
            this.guna2CustomCheckBox10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox10.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox10.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox10.UncheckedState.Parent = this.guna2CustomCheckBox10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(164, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 15);
            this.label18.TabIndex = 46;
            this.label18.Text = "Deactivate with shift";
            // 
            // guna2CustomCheckBox9
            // 
            this.guna2CustomCheckBox9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox9.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox9.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox9.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox9.CheckedState.Parent = this.guna2CustomCheckBox9;
            this.guna2CustomCheckBox9.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox9.Location = new System.Drawing.Point(138, 229);
            this.guna2CustomCheckBox9.Name = "guna2CustomCheckBox9";
            this.guna2CustomCheckBox9.ShadowDecoration.Parent = this.guna2CustomCheckBox9;
            this.guna2CustomCheckBox9.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox9.TabIndex = 45;
            this.guna2CustomCheckBox9.Text = "guna2CustomCheckBox9";
            this.guna2CustomCheckBox9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox9.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox9.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox9.UncheckedState.Parent = this.guna2CustomCheckBox9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(65, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 44;
            this.label17.Text = "RMB Lock";
            // 
            // guna2CustomCheckBox8
            // 
            this.guna2CustomCheckBox8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox8.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox8.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox8.CheckedState.Parent = this.guna2CustomCheckBox8;
            this.guna2CustomCheckBox8.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox8.Location = new System.Drawing.Point(39, 229);
            this.guna2CustomCheckBox8.Name = "guna2CustomCheckBox8";
            this.guna2CustomCheckBox8.ShadowDecoration.Parent = this.guna2CustomCheckBox8;
            this.guna2CustomCheckBox8.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox8.TabIndex = 43;
            this.guna2CustomCheckBox8.Text = "guna2CustomCheckBox8";
            this.guna2CustomCheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox8.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox8.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox8.UncheckedState.Parent = this.guna2CustomCheckBox8;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2Panel6.BorderRadius = 5;
            this.guna2Panel6.Location = new System.Drawing.Point(35, 281);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(565, 5);
            this.guna2Panel6.TabIndex = 20;
            // 
            // siticoneMetroTrackBar3
            // 
            this.siticoneMetroTrackBar3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneMetroTrackBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneMetroTrackBar3.HoveredState.Parent = this.siticoneMetroTrackBar3;
            this.siticoneMetroTrackBar3.IndicateFocus = false;
            this.siticoneMetroTrackBar3.Location = new System.Drawing.Point(352, 61);
            this.siticoneMetroTrackBar3.Maximum = 20;
            this.siticoneMetroTrackBar3.Minimum = 1;
            this.siticoneMetroTrackBar3.Name = "siticoneMetroTrackBar3";
            this.siticoneMetroTrackBar3.Size = new System.Drawing.Size(236, 23);
            this.siticoneMetroTrackBar3.TabIndex = 39;
            this.siticoneMetroTrackBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.siticoneMetroTrackBar3.Value = 1;
            this.siticoneMetroTrackBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneMetroTrackBar3_Scroll);
            this.siticoneMetroTrackBar3.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneMetroTrackBar3_Paint);
            // 
            // siticoneMetroTrackBar2
            // 
            this.siticoneMetroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneMetroTrackBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneMetroTrackBar2.HoveredState.Parent = this.siticoneMetroTrackBar2;
            this.siticoneMetroTrackBar2.IndicateFocus = false;
            this.siticoneMetroTrackBar2.Location = new System.Drawing.Point(39, 156);
            this.siticoneMetroTrackBar2.Minimum = 1;
            this.siticoneMetroTrackBar2.Name = "siticoneMetroTrackBar2";
            this.siticoneMetroTrackBar2.Size = new System.Drawing.Size(236, 23);
            this.siticoneMetroTrackBar2.TabIndex = 38;
            this.siticoneMetroTrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.siticoneMetroTrackBar2.Value = 1;
            this.siticoneMetroTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneMetroTrackBar2_Scroll);
            this.siticoneMetroTrackBar2.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneMetroTrackBar2_Paint);
            // 
            // siticoneMetroTrackBar1
            // 
            this.siticoneMetroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneMetroTrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneMetroTrackBar1.HoveredState.Parent = this.siticoneMetroTrackBar1;
            this.siticoneMetroTrackBar1.IndicateFocus = false;
            this.siticoneMetroTrackBar1.Location = new System.Drawing.Point(39, 61);
            this.siticoneMetroTrackBar1.Maximum = 20;
            this.siticoneMetroTrackBar1.Minimum = 1;
            this.siticoneMetroTrackBar1.Name = "siticoneMetroTrackBar1";
            this.siticoneMetroTrackBar1.Size = new System.Drawing.Size(236, 23);
            this.siticoneMetroTrackBar1.TabIndex = 37;
            this.siticoneMetroTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.siticoneMetroTrackBar1.Value = 1;
            this.siticoneMetroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneMetroTrackBar1_Scroll);
            this.siticoneMetroTrackBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneMetroTrackBar1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(144, 16);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(63, 26);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "Press";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.guna2Button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindKey_Down);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(378, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "More";
            // 
            // guna2CustomCheckBox5
            // 
            this.guna2CustomCheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox5.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox5.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox5.CheckedState.Parent = this.guna2CustomCheckBox5;
            this.guna2CustomCheckBox5.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox5.Location = new System.Drawing.Point(352, 99);
            this.guna2CustomCheckBox5.Name = "guna2CustomCheckBox5";
            this.guna2CustomCheckBox5.ShadowDecoration.Parent = this.guna2CustomCheckBox5;
            this.guna2CustomCheckBox5.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox5.TabIndex = 20;
            this.guna2CustomCheckBox5.Text = "guna2CustomCheckBox5";
            this.guna2CustomCheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox5.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox5.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox5.UncheckedState.Parent = this.guna2CustomCheckBox5;
            this.guna2CustomCheckBox5.Click += new System.EventHandler(this.guna2CustomCheckBox5_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2Panel5.BorderRadius = 5;
            this.guna2Panel5.Location = new System.Drawing.Point(318, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(5, 282);
            this.guna2Panel5.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(65, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "More";
            // 
            // guna2CustomCheckBox4
            // 
            this.guna2CustomCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox4.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox4.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox4.CheckedState.Parent = this.guna2CustomCheckBox4;
            this.guna2CustomCheckBox4.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox4.Location = new System.Drawing.Point(39, 203);
            this.guna2CustomCheckBox4.Name = "guna2CustomCheckBox4";
            this.guna2CustomCheckBox4.ShadowDecoration.Parent = this.guna2CustomCheckBox4;
            this.guna2CustomCheckBox4.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox4.TabIndex = 15;
            this.guna2CustomCheckBox4.Text = "guna2CustomCheckBox4";
            this.guna2CustomCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox4.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox4.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox4.UncheckedState.Parent = this.guna2CustomCheckBox4;
            this.guna2CustomCheckBox4.Click += new System.EventHandler(this.guna2CustomCheckBox4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(378, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Right CPS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(574, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(532, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "CPS:";
            // 
            // guna2CustomCheckBox3
            // 
            this.guna2CustomCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox3.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox3.CheckedState.Parent = this.guna2CustomCheckBox3;
            this.guna2CustomCheckBox3.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox3.Location = new System.Drawing.Point(352, 19);
            this.guna2CustomCheckBox3.Name = "guna2CustomCheckBox3";
            this.guna2CustomCheckBox3.ShadowDecoration.Parent = this.guna2CustomCheckBox3;
            this.guna2CustomCheckBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox3.TabIndex = 11;
            this.guna2CustomCheckBox3.Text = "guna2CustomCheckBox3";
            this.guna2CustomCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox3.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox3.UncheckedState.Parent = this.guna2CustomCheckBox3;
            this.guna2CustomCheckBox3.Click += new System.EventHandler(this.guna2CustomCheckBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blockhit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(261, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(179, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Percentage:";
            // 
            // guna2CustomCheckBox2
            // 
            this.guna2CustomCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox2.CheckedState.Parent = this.guna2CustomCheckBox2;
            this.guna2CustomCheckBox2.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox2.Location = new System.Drawing.Point(39, 111);
            this.guna2CustomCheckBox2.Name = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.ShadowDecoration.Parent = this.guna2CustomCheckBox2;
            this.guna2CustomCheckBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox2.TabIndex = 6;
            this.guna2CustomCheckBox2.Text = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox2.UncheckedState.Parent = this.guna2CustomCheckBox2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Left CPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPS:";
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox1.CheckedState.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(39, 19);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.ShadowDecoration.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 1;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox1.UncheckedState.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Click += new System.EventHandler(this.guna2CustomCheckBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tabPage2.Controls.Add(this.guna2Button4);
            this.tabPage2.Controls.Add(this.guna2Panel7);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.guna2CustomCheckBox13);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.guna2CustomCheckBox12);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.guna2CustomCheckBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(36, 89);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(211, 38);
            this.guna2Button4.TabIndex = 48;
            this.guna2Button4.Text = "Destruct";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel7.BorderRadius = 5;
            this.guna2Panel7.Location = new System.Drawing.Point(322, 15);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(3, 270);
            this.guna2Panel7.TabIndex = 47;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(62, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 18);
            this.label22.TabIndex = 46;
            this.label22.Text = "Clear USN";
            // 
            // guna2CustomCheckBox13
            // 
            this.guna2CustomCheckBox13.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox13.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox13.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox13.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox13.CheckedState.Parent = this.guna2CustomCheckBox13;
            this.guna2CustomCheckBox13.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox13.Location = new System.Drawing.Point(36, 65);
            this.guna2CustomCheckBox13.Name = "guna2CustomCheckBox13";
            this.guna2CustomCheckBox13.ShadowDecoration.Parent = this.guna2CustomCheckBox13;
            this.guna2CustomCheckBox13.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox13.TabIndex = 45;
            this.guna2CustomCheckBox13.Text = "guna2CustomCheckBox13";
            this.guna2CustomCheckBox13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox13.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox13.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox13.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox13.UncheckedState.Parent = this.guna2CustomCheckBox13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(62, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 18);
            this.label21.TabIndex = 44;
            this.label21.Text = "Clear Strings";
            // 
            // guna2CustomCheckBox12
            // 
            this.guna2CustomCheckBox12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox12.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox12.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox12.CheckedState.Parent = this.guna2CustomCheckBox12;
            this.guna2CustomCheckBox12.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox12.Location = new System.Drawing.Point(36, 39);
            this.guna2CustomCheckBox12.Name = "guna2CustomCheckBox12";
            this.guna2CustomCheckBox12.ShadowDecoration.Parent = this.guna2CustomCheckBox12;
            this.guna2CustomCheckBox12.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox12.TabIndex = 43;
            this.guna2CustomCheckBox12.Text = "guna2CustomCheckBox12";
            this.guna2CustomCheckBox12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox12.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox12.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox12.UncheckedState.Parent = this.guna2CustomCheckBox12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(62, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 18);
            this.label20.TabIndex = 42;
            this.label20.Text = "Clear Prefetch";
            // 
            // guna2CustomCheckBox11
            // 
            this.guna2CustomCheckBox11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox11.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox11.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox11.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox11.CheckedState.Parent = this.guna2CustomCheckBox11;
            this.guna2CustomCheckBox11.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.guna2CustomCheckBox11.Location = new System.Drawing.Point(36, 15);
            this.guna2CustomCheckBox11.Name = "guna2CustomCheckBox11";
            this.guna2CustomCheckBox11.ShadowDecoration.Parent = this.guna2CustomCheckBox11;
            this.guna2CustomCheckBox11.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox11.TabIndex = 41;
            this.guna2CustomCheckBox11.Text = "guna2CustomCheckBox11";
            this.guna2CustomCheckBox11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox11.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox11.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CustomCheckBox11.UncheckedState.Parent = this.guna2CustomCheckBox11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tariyake.Properties.Resources.bayologochroma;
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button3.Location = new System.Drawing.Point(463, 16);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(63, 26);
            this.guna2Button3.TabIndex = 36;
            this.guna2Button3.Text = "no";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            this.guna2Button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindKey1_Down);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(79, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(711, 23);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(79, 372);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(711, 23);
            this.guna2Panel2.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(710, 54);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(23, 500);
            this.guna2Panel3.TabIndex = 6;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Location = new System.Drawing.Point(60, 54);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(23, 500);
            this.guna2Panel4.TabIndex = 7;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this.siticoneMetroTrackBar1;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.TargetControl = this.siticoneMetroTrackBar2;
            // 
            // siticoneElipse3
            // 
            this.siticoneElipse3.TargetControl = this.siticoneMetroTrackBar3;
            // 
            // rightClick
            // 
            this.rightClick.Tick += new System.EventHandler(this.rightClick_Tick);
            // 
            // leftClick
            // 
            this.leftClick.Tick += new System.EventHandler(this.leftClick_Tick);
            // 
            // bindTimer
            // 
            this.bindTimer.Enabled = true;
            this.bindTimer.Interval = 300;
            this.bindTimer.Tick += new System.EventHandler(this.bindTimer_Tick);
            // 
            // bgwWrite
            // 
            this.bgwWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWrite_DoWork);
            // 
            // bgwScan
            // 
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            // 
            // bgwDestruct
            // 
            this.bgwDestruct.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDestruct_DoWork);
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Panel8.Controls.Add(this.pictureBox1);
            this.guna2Panel8.Controls.Add(this.guna2Button6);
            this.guna2Panel8.Controls.Add(this.guna2Button5);
            this.guna2Panel8.Controls.Add(this.guna2Button3);
            this.guna2Panel8.Controls.Add(this.guna2Button2);
            this.guna2Panel8.Location = new System.Drawing.Point(0, -2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.Parent = this.guna2Panel8;
            this.guna2Panel8.Size = new System.Drawing.Size(56, 498);
            this.guna2Panel8.TabIndex = 15;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.DisabledState.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Image = global::tariyake.Properties.Resources.gear;
            this.guna2Button6.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button6.Location = new System.Drawing.Point(0, 108);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(60, 46);
            this.guna2Button6.TabIndex = 38;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.DisabledState.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Image = global::tariyake.Properties.Resources.computer_mouse;
            this.guna2Button5.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button5.Location = new System.Drawing.Point(0, 60);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(60, 46);
            this.guna2Button5.TabIndex = 37;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::tariyake.Properties.Resources.exit;
            this.guna2Button2.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button2.Location = new System.Drawing.Point(0, 349);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(60, 46);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(76, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 52;
            this.label13.Text = "Bayoneta On Top";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(746, 395);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2Panel8);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3W4bGYJrMh";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components = null;
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel4;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private global::System.Windows.Forms.TabControl tabControl1;
		private global::System.Windows.Forms.TabPage tabPage2;
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse3;
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse4;
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse5;
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse6;
		private global::System.Windows.Forms.Timer rightClick;
		private global::System.Windows.Forms.Timer leftClick;
		private global::System.Windows.Forms.Timer bindTimer;
		private global::System.Windows.Forms.Label label22;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox13;
		private global::System.Windows.Forms.Label label21;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox12;
		private global::System.Windows.Forms.Label label20;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox11;
		private global::System.ComponentModel.BackgroundWorker bgwWrite;
		private global::System.ComponentModel.BackgroundWorker bgwScan;
		private global::System.ComponentModel.BackgroundWorker bgwDestruct;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel7;
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel8;
		private global::System.Windows.Forms.TabPage tabPage1;
		private global::System.Windows.Forms.Label label23;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox14;
		private global::System.Windows.Forms.Label label19;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox10;
		private global::System.Windows.Forms.Label label18;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox9;
		private global::System.Windows.Forms.Label label17;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox8;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel6;
		private global::Siticone.UI.WinForms.SiticoneMetroTrackBar siticoneMetroTrackBar3;
		private global::Siticone.UI.WinForms.SiticoneMetroTrackBar siticoneMetroTrackBar2;
		private global::Siticone.UI.WinForms.SiticoneMetroTrackBar siticoneMetroTrackBar1;
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;
		private global::System.Windows.Forms.Label label11;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox5;
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel5;
		private global::System.Windows.Forms.Label label10;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox4;
		private global::System.Windows.Forms.Label label7;
		private global::System.Windows.Forms.Label label8;
		private global::System.Windows.Forms.Label label9;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox3;
		private global::System.Windows.Forms.Label label4;
		private global::System.Windows.Forms.Label label5;
		private global::System.Windows.Forms.Label label6;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox2;
		private global::System.Windows.Forms.Label label3;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.Label label1;
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}
