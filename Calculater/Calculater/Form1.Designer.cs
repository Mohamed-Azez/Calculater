namespace Calculater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnexit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btndevide = new Guna.UI2.WinForms.Guna2Button();
            this.btnmulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnplus = new Guna.UI2.WinForms.Guna2Button();
            this.btnthree = new Guna.UI2.WinForms.Guna2Button();
            this.btnsix = new Guna.UI2.WinForms.Guna2Button();
            this.btnnine = new Guna.UI2.WinForms.Guna2Button();
            this.btnrd = new Guna.UI2.WinForms.Guna2Button();
            this.btnone = new Guna.UI2.WinForms.Guna2Button();
            this.btnfour = new Guna.UI2.WinForms.Guna2Button();
            this.btnseven = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btntwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnfive = new Guna.UI2.WinForms.Guna2Button();
            this.btneight = new Guna.UI2.WinForms.Guna2Button();
            this.btnzero = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.txtstore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtresualt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageRotate = 0F;
            this.btnexit.Location = new System.Drawing.Point(335, 8);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.ShadowDecoration.Parent = this.btnexit;
            this.btnexit.Size = new System.Drawing.Size(31, 32);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 0;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.lbl.Location = new System.Drawing.Point(-3, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(151, 40);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Calculator";
            // 
            // btndevide
            // 
            this.btndevide.BackColor = System.Drawing.Color.Transparent;
            this.btndevide.BorderRadius = 15;
            this.btndevide.CheckedState.Parent = this.btndevide;
            this.btndevide.CustomImages.Parent = this.btndevide;
            this.btndevide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndevide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndevide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndevide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndevide.DisabledState.Parent = this.btndevide;
            this.btndevide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndevide.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndevide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btndevide.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btndevide.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndevide.HoverState.Parent = this.btndevide;
            this.btndevide.Location = new System.Drawing.Point(268, 249);
            this.btndevide.Name = "btndevide";
            this.btndevide.ShadowDecoration.BorderRadius = 15;
            this.btndevide.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btndevide.ShadowDecoration.Enabled = true;
            this.btndevide.ShadowDecoration.Parent = this.btndevide;
            this.btndevide.Size = new System.Drawing.Size(56, 45);
            this.btndevide.TabIndex = 2;
            this.btndevide.Text = "/";
            this.btndevide.Click += new System.EventHandler(this.btndevide_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.Transparent;
            this.btnmulti.BorderRadius = 15;
            this.btnmulti.CheckedState.Parent = this.btnmulti;
            this.btnmulti.CustomImages.Parent = this.btnmulti;
            this.btnmulti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmulti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmulti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmulti.DisabledState.Parent = this.btnmulti;
            this.btnmulti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmulti.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnmulti.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnmulti.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmulti.HoverState.Parent = this.btnmulti;
            this.btnmulti.Location = new System.Drawing.Point(268, 312);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.ShadowDecoration.BorderRadius = 15;
            this.btnmulti.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnmulti.ShadowDecoration.Enabled = true;
            this.btnmulti.ShadowDecoration.Parent = this.btnmulti;
            this.btnmulti.Size = new System.Drawing.Size(56, 45);
            this.btnmulti.TabIndex = 3;
            this.btnmulti.Text = "x";
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BorderRadius = 15;
            this.btnmin.CheckedState.Parent = this.btnmin;
            this.btnmin.CustomImages.Parent = this.btnmin;
            this.btnmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmin.DisabledState.Parent = this.btnmin;
            this.btnmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnmin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmin.HoverState.Parent = this.btnmin;
            this.btnmin.Location = new System.Drawing.Point(268, 438);
            this.btnmin.Name = "btnmin";
            this.btnmin.ShadowDecoration.BorderRadius = 15;
            this.btnmin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnmin.ShadowDecoration.Enabled = true;
            this.btnmin.ShadowDecoration.Parent = this.btnmin;
            this.btnmin.Size = new System.Drawing.Size(56, 45);
            this.btnmin.TabIndex = 5;
            this.btnmin.Text = "-";
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Transparent;
            this.btnplus.BorderRadius = 15;
            this.btnplus.CheckedState.Parent = this.btnplus;
            this.btnplus.CustomImages.Parent = this.btnplus;
            this.btnplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnplus.DisabledState.Parent = this.btnplus;
            this.btnplus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnplus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnplus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnplus.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnplus.HoverState.Parent = this.btnplus;
            this.btnplus.Location = new System.Drawing.Point(268, 375);
            this.btnplus.Name = "btnplus";
            this.btnplus.ShadowDecoration.BorderRadius = 15;
            this.btnplus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnplus.ShadowDecoration.Enabled = true;
            this.btnplus.ShadowDecoration.Parent = this.btnplus;
            this.btnplus.Size = new System.Drawing.Size(56, 45);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.Color.Transparent;
            this.btnthree.BorderRadius = 15;
            this.btnthree.CheckedState.Parent = this.btnthree;
            this.btnthree.CustomImages.Parent = this.btnthree;
            this.btnthree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthree.DisabledState.Parent = this.btnthree;
            this.btnthree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnthree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnthree.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnthree.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnthree.HoverState.Parent = this.btnthree;
            this.btnthree.Location = new System.Drawing.Point(194, 438);
            this.btnthree.Name = "btnthree";
            this.btnthree.ShadowDecoration.BorderRadius = 15;
            this.btnthree.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnthree.ShadowDecoration.Enabled = true;
            this.btnthree.ShadowDecoration.Parent = this.btnthree;
            this.btnthree.Size = new System.Drawing.Size(56, 45);
            this.btnthree.TabIndex = 9;
            this.btnthree.Text = "3";
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnsix
            // 
            this.btnsix.BackColor = System.Drawing.Color.Transparent;
            this.btnsix.BorderRadius = 15;
            this.btnsix.CheckedState.Parent = this.btnsix;
            this.btnsix.CustomImages.Parent = this.btnsix;
            this.btnsix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsix.DisabledState.Parent = this.btnsix;
            this.btnsix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnsix.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnsix.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnsix.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnsix.HoverState.Parent = this.btnsix;
            this.btnsix.Location = new System.Drawing.Point(194, 375);
            this.btnsix.Name = "btnsix";
            this.btnsix.ShadowDecoration.BorderRadius = 15;
            this.btnsix.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnsix.ShadowDecoration.Enabled = true;
            this.btnsix.ShadowDecoration.Parent = this.btnsix;
            this.btnsix.Size = new System.Drawing.Size(56, 45);
            this.btnsix.TabIndex = 8;
            this.btnsix.Text = "6";
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.Color.Transparent;
            this.btnnine.BorderRadius = 15;
            this.btnnine.CheckedState.Parent = this.btnnine;
            this.btnnine.CustomImages.Parent = this.btnnine;
            this.btnnine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnine.DisabledState.Parent = this.btnnine;
            this.btnnine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnnine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnnine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnnine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnnine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnnine.HoverState.Parent = this.btnnine;
            this.btnnine.Location = new System.Drawing.Point(194, 312);
            this.btnnine.Name = "btnnine";
            this.btnnine.ShadowDecoration.BorderRadius = 15;
            this.btnnine.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnnine.ShadowDecoration.Enabled = true;
            this.btnnine.ShadowDecoration.Parent = this.btnnine;
            this.btnnine.Size = new System.Drawing.Size(56, 45);
            this.btnnine.TabIndex = 7;
            this.btnnine.Text = "9";
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnrd
            // 
            this.btnrd.BackColor = System.Drawing.Color.Transparent;
            this.btnrd.BorderRadius = 15;
            this.btnrd.CheckedState.Parent = this.btnrd;
            this.btnrd.CustomImages.Parent = this.btnrd;
            this.btnrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrd.DisabledState.Parent = this.btnrd;
            this.btnrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnrd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnrd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnrd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnrd.HoverState.Parent = this.btnrd;
            this.btnrd.Location = new System.Drawing.Point(194, 249);
            this.btnrd.Name = "btnrd";
            this.btnrd.ShadowDecoration.BorderRadius = 15;
            this.btnrd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnrd.ShadowDecoration.Enabled = true;
            this.btnrd.ShadowDecoration.Parent = this.btnrd;
            this.btnrd.Size = new System.Drawing.Size(56, 45);
            this.btnrd.TabIndex = 6;
            this.btnrd.Text = "%";
            this.btnrd.Click += new System.EventHandler(this.btnrd_Click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.Transparent;
            this.btnone.BorderRadius = 15;
            this.btnone.CheckedState.Parent = this.btnone;
            this.btnone.CustomImages.Parent = this.btnone;
            this.btnone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnone.DisabledState.Parent = this.btnone;
            this.btnone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnone.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnone.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnone.HoverState.Parent = this.btnone;
            this.btnone.Location = new System.Drawing.Point(49, 438);
            this.btnone.Name = "btnone";
            this.btnone.ShadowDecoration.BorderRadius = 15;
            this.btnone.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnone.ShadowDecoration.Enabled = true;
            this.btnone.ShadowDecoration.Parent = this.btnone;
            this.btnone.Size = new System.Drawing.Size(56, 45);
            this.btnone.TabIndex = 17;
            this.btnone.Text = "1";
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnfour
            // 
            this.btnfour.BackColor = System.Drawing.Color.Transparent;
            this.btnfour.BorderRadius = 15;
            this.btnfour.CheckedState.Parent = this.btnfour;
            this.btnfour.CustomImages.Parent = this.btnfour;
            this.btnfour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfour.DisabledState.Parent = this.btnfour;
            this.btnfour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnfour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnfour.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnfour.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfour.HoverState.Parent = this.btnfour;
            this.btnfour.Location = new System.Drawing.Point(49, 375);
            this.btnfour.Name = "btnfour";
            this.btnfour.ShadowDecoration.BorderRadius = 15;
            this.btnfour.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnfour.ShadowDecoration.Enabled = true;
            this.btnfour.ShadowDecoration.Parent = this.btnfour;
            this.btnfour.Size = new System.Drawing.Size(56, 45);
            this.btnfour.TabIndex = 16;
            this.btnfour.Text = "4";
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnseven
            // 
            this.btnseven.BackColor = System.Drawing.Color.Transparent;
            this.btnseven.BorderRadius = 15;
            this.btnseven.CheckedState.Parent = this.btnseven;
            this.btnseven.CustomImages.Parent = this.btnseven;
            this.btnseven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnseven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnseven.DisabledState.Parent = this.btnseven;
            this.btnseven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnseven.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnseven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnseven.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnseven.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnseven.HoverState.Parent = this.btnseven;
            this.btnseven.Location = new System.Drawing.Point(49, 312);
            this.btnseven.Name = "btnseven";
            this.btnseven.ShadowDecoration.BorderRadius = 15;
            this.btnseven.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnseven.ShadowDecoration.Enabled = true;
            this.btnseven.ShadowDecoration.Parent = this.btnseven;
            this.btnseven.Size = new System.Drawing.Size(56, 45);
            this.btnseven.TabIndex = 15;
            this.btnseven.Text = "7";
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderRadius = 15;
            this.btnclear.CheckedState.Parent = this.btnclear;
            this.btnclear.CustomImages.Parent = this.btnclear;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.DisabledState.Parent = this.btnclear;
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnclear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnclear.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnclear.HoverState.Parent = this.btnclear;
            this.btnclear.Location = new System.Drawing.Point(49, 249);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.BorderRadius = 15;
            this.btnclear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnclear.ShadowDecoration.Enabled = true;
            this.btnclear.ShadowDecoration.Parent = this.btnclear;
            this.btnclear.Size = new System.Drawing.Size(130, 45);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.Color.Transparent;
            this.btntwo.BorderRadius = 15;
            this.btntwo.CheckedState.Parent = this.btntwo;
            this.btntwo.CustomImages.Parent = this.btntwo;
            this.btntwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntwo.DisabledState.Parent = this.btntwo;
            this.btntwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btntwo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btntwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btntwo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btntwo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btntwo.HoverState.Parent = this.btntwo;
            this.btntwo.Location = new System.Drawing.Point(123, 438);
            this.btntwo.Name = "btntwo";
            this.btntwo.ShadowDecoration.BorderRadius = 15;
            this.btntwo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btntwo.ShadowDecoration.Enabled = true;
            this.btntwo.ShadowDecoration.Parent = this.btntwo;
            this.btntwo.Size = new System.Drawing.Size(56, 45);
            this.btntwo.TabIndex = 13;
            this.btntwo.Text = "2";
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnfive
            // 
            this.btnfive.BackColor = System.Drawing.Color.Transparent;
            this.btnfive.BorderRadius = 15;
            this.btnfive.CheckedState.Parent = this.btnfive;
            this.btnfive.CustomImages.Parent = this.btnfive;
            this.btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfive.DisabledState.Parent = this.btnfive;
            this.btnfive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnfive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnfive.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnfive.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfive.HoverState.Parent = this.btnfive;
            this.btnfive.Location = new System.Drawing.Point(123, 375);
            this.btnfive.Name = "btnfive";
            this.btnfive.ShadowDecoration.BorderRadius = 15;
            this.btnfive.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnfive.ShadowDecoration.Enabled = true;
            this.btnfive.ShadowDecoration.Parent = this.btnfive;
            this.btnfive.Size = new System.Drawing.Size(56, 45);
            this.btnfive.TabIndex = 12;
            this.btnfive.Text = "5";
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.Color.Transparent;
            this.btneight.BorderRadius = 15;
            this.btneight.CheckedState.Parent = this.btneight;
            this.btneight.CustomImages.Parent = this.btneight;
            this.btneight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneight.DisabledState.Parent = this.btneight;
            this.btneight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btneight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btneight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btneight.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btneight.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btneight.HoverState.Parent = this.btneight;
            this.btneight.Location = new System.Drawing.Point(123, 312);
            this.btneight.Name = "btneight";
            this.btneight.ShadowDecoration.BorderRadius = 15;
            this.btneight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btneight.ShadowDecoration.Enabled = true;
            this.btneight.ShadowDecoration.Parent = this.btneight;
            this.btneight.Size = new System.Drawing.Size(56, 45);
            this.btneight.TabIndex = 11;
            this.btneight.Text = "8";
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.Transparent;
            this.btnzero.BorderRadius = 15;
            this.btnzero.CheckedState.Parent = this.btnzero;
            this.btnzero.CustomImages.Parent = this.btnzero;
            this.btnzero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnzero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnzero.DisabledState.Parent = this.btnzero;
            this.btnzero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnzero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnzero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnzero.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnzero.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnzero.HoverState.Parent = this.btnzero;
            this.btnzero.Location = new System.Drawing.Point(49, 501);
            this.btnzero.Name = "btnzero";
            this.btnzero.ShadowDecoration.BorderRadius = 15;
            this.btnzero.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnzero.ShadowDecoration.Enabled = true;
            this.btnzero.ShadowDecoration.Parent = this.btnzero;
            this.btnzero.Size = new System.Drawing.Size(56, 45);
            this.btnzero.TabIndex = 20;
            this.btnzero.Text = "0";
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BorderRadius = 15;
            this.btndot.CheckedState.Parent = this.btndot;
            this.btndot.CustomImages.Parent = this.btndot;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.DisabledState.Parent = this.btndot;
            this.btndot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btndot.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btndot.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndot.HoverState.Parent = this.btndot;
            this.btndot.Location = new System.Drawing.Point(123, 501);
            this.btndot.Name = "btndot";
            this.btndot.ShadowDecoration.BorderRadius = 15;
            this.btndot.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btndot.ShadowDecoration.Enabled = true;
            this.btndot.ShadowDecoration.Parent = this.btndot;
            this.btndot.Size = new System.Drawing.Size(56, 45);
            this.btndot.TabIndex = 19;
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BorderRadius = 15;
            this.btnequal.CheckedState.Parent = this.btnequal;
            this.btnequal.CustomImages.Parent = this.btnequal;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.DisabledState.Parent = this.btnequal;
            this.btnequal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnequal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnequal.ForeColor = System.Drawing.Color.White;
            this.btnequal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnequal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnequal.HoverState.Parent = this.btnequal;
            this.btnequal.Location = new System.Drawing.Point(197, 501);
            this.btnequal.Name = "btnequal";
            this.btnequal.ShadowDecoration.BorderRadius = 15;
            this.btnequal.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnequal.ShadowDecoration.Enabled = true;
            this.btnequal.ShadowDecoration.Parent = this.btnequal;
            this.btnequal.Size = new System.Drawing.Size(127, 45);
            this.btnequal.TabIndex = 18;
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // txtstore
            // 
            this.txtstore.BorderThickness = 0;
            this.txtstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstore.DefaultText = "";
            this.txtstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.DisabledState.Parent = this.txtstore;
            this.txtstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.txtstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.FocusedState.Parent = this.txtstore;
            this.txtstore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.HoverState.Parent = this.txtstore;
            this.txtstore.Location = new System.Drawing.Point(49, 163);
            this.txtstore.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtstore.Name = "txtstore";
            this.txtstore.PasswordChar = '\0';
            this.txtstore.PlaceholderText = "";
            this.txtstore.SelectedText = "";
            this.txtstore.ShadowDecoration.Parent = this.txtstore;
            this.txtstore.Size = new System.Drawing.Size(275, 63);
            this.txtstore.TabIndex = 21;
            this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtresualt
            // 
            this.txtresualt.BorderThickness = 0;
            this.txtresualt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresualt.DefaultText = "";
            this.txtresualt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtresualt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtresualt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresualt.DisabledState.Parent = this.txtresualt;
            this.txtresualt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresualt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.txtresualt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresualt.FocusedState.Parent = this.txtresualt;
            this.txtresualt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtresualt.ForeColor = System.Drawing.Color.White;
            this.txtresualt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresualt.HoverState.Parent = this.txtresualt;
            this.txtresualt.Location = new System.Drawing.Point(49, 71);
            this.txtresualt.Margin = new System.Windows.Forms.Padding(6);
            this.txtresualt.Name = "txtresualt";
            this.txtresualt.PasswordChar = '\0';
            this.txtresualt.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtresualt.PlaceholderText = "0";
            this.txtresualt.SelectedText = "";
            this.txtresualt.ShadowDecoration.Parent = this.txtresualt;
            this.txtresualt.Size = new System.Drawing.Size(275, 81);
            this.txtresualt.TabIndex = 22;
            this.txtresualt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.txtresualt);
            this.Controls.Add(this.txtstore);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btnrd);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndevide);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnexit;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button btndevide;
        private Guna.UI2.WinForms.Guna2Button btnmulti;
        private Guna.UI2.WinForms.Guna2Button btnmin;
        private Guna.UI2.WinForms.Guna2Button btnplus;
        private Guna.UI2.WinForms.Guna2Button btnthree;
        private Guna.UI2.WinForms.Guna2Button btnsix;
        private Guna.UI2.WinForms.Guna2Button btnnine;
        private Guna.UI2.WinForms.Guna2Button btnrd;
        private Guna.UI2.WinForms.Guna2Button btnone;
        private Guna.UI2.WinForms.Guna2Button btnfour;
        private Guna.UI2.WinForms.Guna2Button btnseven;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btntwo;
        private Guna.UI2.WinForms.Guna2Button btnfive;
        private Guna.UI2.WinForms.Guna2Button btneight;
        private Guna.UI2.WinForms.Guna2Button btnzero;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2TextBox txtstore;
        private Guna.UI2.WinForms.Guna2TextBox txtresualt;
    }
}

