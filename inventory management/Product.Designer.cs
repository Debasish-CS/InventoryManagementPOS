
namespace inventory_management
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLvlLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backtohomeMs = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtnMs = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtnMs = new Guna.UI2.WinForms.Guna2Button();
            this.editBtnMs = new Guna.UI2.WinForms.Guna2Button();
            this.productnameTbMs = new Guna.UI2.WinForms.Guna2TextBox();
            this.productqtyTbMs = new Guna.UI2.WinForms.Guna2TextBox();
            this.productamtTbMs = new Guna.UI2.WinForms.Guna2TextBox();
            this.catcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridMS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CatSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.excelExport = new Guna.UI2.WinForms.Guna2Button();
            this.TotAmtTbMs = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.userLvlLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 100);
            this.panel1.TabIndex = 2;
            // 
            // userLvlLabel
            // 
            this.userLvlLabel.AutoSize = true;
            this.userLvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLvlLabel.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLvlLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userLvlLabel.Location = new System.Drawing.Point(867, 67);
            this.userLvlLabel.Name = "userLvlLabel";
            this.userLvlLabel.Size = new System.Drawing.Size(14, 16);
            this.userLvlLabel.TabIndex = 64;
            this.userLvlLabel.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(699, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "You are logged in as :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(411, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(521, 294);
            this.dataGridView2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(351, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGE STOCK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(0, 605);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(936, 14);
            this.panel5.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(30, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(30, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(30, 312);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 38;
            // 
            // backtohomeMs
            // 
            this.backtohomeMs.AutoSize = true;
            this.backtohomeMs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtohomeMs.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtohomeMs.ForeColor = System.Drawing.Color.ForestGreen;
            this.backtohomeMs.LinkColor = System.Drawing.Color.Green;
            this.backtohomeMs.Location = new System.Drawing.Point(45, 545);
            this.backtohomeMs.Name = "backtohomeMs";
            this.backtohomeMs.Size = new System.Drawing.Size(163, 25);
            this.backtohomeMs.TabIndex = 43;
            this.backtohomeMs.TabStop = true;
            this.backtohomeMs.Text = "Back to Home";
            this.backtohomeMs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(536, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "PRODUCTS LIST";
            // 
            // addBtnMs
            // 
            this.addBtnMs.BorderColor = System.Drawing.Color.LimeGreen;
            this.addBtnMs.BorderRadius = 20;
            this.addBtnMs.CheckedState.Parent = this.addBtnMs;
            this.addBtnMs.CustomImages.Parent = this.addBtnMs;
            this.addBtnMs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtnMs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtnMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtnMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtnMs.DisabledState.Parent = this.addBtnMs;
            this.addBtnMs.FillColor = System.Drawing.Color.LimeGreen;
            this.addBtnMs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtnMs.ForeColor = System.Drawing.Color.Cyan;
            this.addBtnMs.HoverState.Parent = this.addBtnMs;
            this.addBtnMs.Location = new System.Drawing.Point(30, 433);
            this.addBtnMs.Name = "addBtnMs";
            this.addBtnMs.ShadowDecoration.Parent = this.addBtnMs;
            this.addBtnMs.Size = new System.Drawing.Size(105, 37);
            this.addBtnMs.TabIndex = 46;
            this.addBtnMs.Text = "Add";
            this.addBtnMs.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // deleteBtnMs
            // 
            this.deleteBtnMs.BorderColor = System.Drawing.Color.LimeGreen;
            this.deleteBtnMs.BorderRadius = 20;
            this.deleteBtnMs.CheckedState.Parent = this.deleteBtnMs;
            this.deleteBtnMs.CustomImages.Parent = this.deleteBtnMs;
            this.deleteBtnMs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtnMs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtnMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtnMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtnMs.DisabledState.Parent = this.deleteBtnMs;
            this.deleteBtnMs.FillColor = System.Drawing.Color.LimeGreen;
            this.deleteBtnMs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtnMs.ForeColor = System.Drawing.Color.Cyan;
            this.deleteBtnMs.HoverState.Parent = this.deleteBtnMs;
            this.deleteBtnMs.Location = new System.Drawing.Point(141, 433);
            this.deleteBtnMs.Name = "deleteBtnMs";
            this.deleteBtnMs.ShadowDecoration.Parent = this.deleteBtnMs;
            this.deleteBtnMs.Size = new System.Drawing.Size(105, 37);
            this.deleteBtnMs.TabIndex = 47;
            this.deleteBtnMs.Text = "Delete";
            this.deleteBtnMs.Click += new System.EventHandler(this.deleteBtnMs_Click);
            // 
            // editBtnMs
            // 
            this.editBtnMs.BorderColor = System.Drawing.Color.LimeGreen;
            this.editBtnMs.BorderRadius = 20;
            this.editBtnMs.CheckedState.Parent = this.editBtnMs;
            this.editBtnMs.CustomImages.Parent = this.editBtnMs;
            this.editBtnMs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtnMs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtnMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtnMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtnMs.DisabledState.Parent = this.editBtnMs;
            this.editBtnMs.FillColor = System.Drawing.Color.LimeGreen;
            this.editBtnMs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtnMs.ForeColor = System.Drawing.Color.Cyan;
            this.editBtnMs.HoverState.Parent = this.editBtnMs;
            this.editBtnMs.Location = new System.Drawing.Point(80, 485);
            this.editBtnMs.Name = "editBtnMs";
            this.editBtnMs.ShadowDecoration.Parent = this.editBtnMs;
            this.editBtnMs.Size = new System.Drawing.Size(105, 37);
            this.editBtnMs.TabIndex = 48;
            this.editBtnMs.Text = "Edit";
            this.editBtnMs.Click += new System.EventHandler(this.editBtnMs_Click);
            // 
            // productnameTbMs
            // 
            this.productnameTbMs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.productnameTbMs.BorderThickness = 0;
            this.productnameTbMs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productnameTbMs.DefaultText = "";
            this.productnameTbMs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productnameTbMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productnameTbMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productnameTbMs.DisabledState.Parent = this.productnameTbMs;
            this.productnameTbMs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productnameTbMs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productnameTbMs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productnameTbMs.FocusedState.Parent = this.productnameTbMs;
            this.productnameTbMs.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.productnameTbMs.ForeColor = System.Drawing.Color.Black;
            this.productnameTbMs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productnameTbMs.HoverState.Parent = this.productnameTbMs;
            this.productnameTbMs.Location = new System.Drawing.Point(30, 157);
            this.productnameTbMs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productnameTbMs.Name = "productnameTbMs";
            this.productnameTbMs.PasswordChar = '\0';
            this.productnameTbMs.PlaceholderForeColor = System.Drawing.Color.LimeGreen;
            this.productnameTbMs.PlaceholderText = "Product Name";
            this.productnameTbMs.SelectedText = "";
            this.productnameTbMs.ShadowDecoration.Parent = this.productnameTbMs;
            this.productnameTbMs.Size = new System.Drawing.Size(200, 24);
            this.productnameTbMs.TabIndex = 53;
            this.productnameTbMs.TextChanged += new System.EventHandler(this.productnameTbMs_TextChanged);
            // 
            // productqtyTbMs
            // 
            this.productqtyTbMs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.productqtyTbMs.BorderThickness = 0;
            this.productqtyTbMs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productqtyTbMs.DefaultText = "";
            this.productqtyTbMs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productqtyTbMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productqtyTbMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productqtyTbMs.DisabledState.Parent = this.productqtyTbMs;
            this.productqtyTbMs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productqtyTbMs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productqtyTbMs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productqtyTbMs.FocusedState.Parent = this.productqtyTbMs;
            this.productqtyTbMs.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.productqtyTbMs.ForeColor = System.Drawing.Color.Black;
            this.productqtyTbMs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productqtyTbMs.HoverState.Parent = this.productqtyTbMs;
            this.productqtyTbMs.Location = new System.Drawing.Point(30, 196);
            this.productqtyTbMs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productqtyTbMs.Name = "productqtyTbMs";
            this.productqtyTbMs.PasswordChar = '\0';
            this.productqtyTbMs.PlaceholderForeColor = System.Drawing.Color.LimeGreen;
            this.productqtyTbMs.PlaceholderText = "Product Quantity";
            this.productqtyTbMs.SelectedText = "";
            this.productqtyTbMs.ShadowDecoration.Parent = this.productqtyTbMs;
            this.productqtyTbMs.Size = new System.Drawing.Size(200, 29);
            this.productqtyTbMs.TabIndex = 54;
            this.productqtyTbMs.TextChanged += new System.EventHandler(this.productqtyTbMs_TextChanged);
            // 
            // productamtTbMs
            // 
            this.productamtTbMs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.productamtTbMs.BorderThickness = 0;
            this.productamtTbMs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productamtTbMs.DefaultText = "";
            this.productamtTbMs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productamtTbMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productamtTbMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productamtTbMs.DisabledState.Parent = this.productamtTbMs;
            this.productamtTbMs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productamtTbMs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productamtTbMs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productamtTbMs.FocusedState.Parent = this.productamtTbMs;
            this.productamtTbMs.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.productamtTbMs.ForeColor = System.Drawing.Color.Black;
            this.productamtTbMs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productamtTbMs.HoverState.Parent = this.productamtTbMs;
            this.productamtTbMs.Location = new System.Drawing.Point(30, 239);
            this.productamtTbMs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productamtTbMs.Name = "productamtTbMs";
            this.productamtTbMs.PasswordChar = '\0';
            this.productamtTbMs.PlaceholderForeColor = System.Drawing.Color.LimeGreen;
            this.productamtTbMs.PlaceholderText = "Product Per Piece";
            this.productamtTbMs.SelectedText = "";
            this.productamtTbMs.ShadowDecoration.Parent = this.productamtTbMs;
            this.productamtTbMs.Size = new System.Drawing.Size(200, 32);
            this.productamtTbMs.TabIndex = 55;
            this.productamtTbMs.TextChanged += new System.EventHandler(this.productamtTbMs_TextChanged);
            // 
            // catcombo
            // 
            this.catcombo.AutoRoundedCorners = true;
            this.catcombo.BackColor = System.Drawing.Color.Transparent;
            this.catcombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.catcombo.BorderRadius = 17;
            this.catcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.catcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catcombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.catcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catcombo.FocusedState.Parent = this.catcombo;
            this.catcombo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.catcombo.HoverState.Parent = this.catcombo;
            this.catcombo.ItemHeight = 30;
            this.catcombo.ItemsAppearance.Parent = this.catcombo;
            this.catcombo.Location = new System.Drawing.Point(45, 337);
            this.catcombo.Name = "catcombo";
            this.catcombo.ShadowDecoration.Parent = this.catcombo;
            this.catcombo.Size = new System.Drawing.Size(140, 36);
            this.catcombo.TabIndex = 58;
            this.catcombo.SelectedIndexChanged += new System.EventHandler(this.catcombo_SelectedIndexChanged);
            // 
            // dataGridMS
            // 
            this.dataGridMS.AllowUserToAddRows = false;
            this.dataGridMS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridMS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridMS.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMS.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridMS.EnableHeadersVisualStyles = false;
            this.dataGridMS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridMS.Location = new System.Drawing.Point(327, 196);
            this.dataGridMS.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMS.Name = "dataGridMS";
            this.dataGridMS.RowHeadersVisible = false;
            this.dataGridMS.RowTemplate.Height = 24;
            this.dataGridMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMS.Size = new System.Drawing.Size(582, 389);
            this.dataGridMS.TabIndex = 61;
            this.dataGridMS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dataGridMS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridMS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridMS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridMS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridMS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridMS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridMS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridMS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridMS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dataGridMS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridMS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridMS.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridMS.ThemeStyle.ReadOnly = false;
            this.dataGridMS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dataGridMS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridMS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridMS.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridMS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dataGridMS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMS_CellContentClick);
            // 
            // CatSelect
            // 
            this.CatSelect.AutoRoundedCorners = true;
            this.CatSelect.BackColor = System.Drawing.Color.Transparent;
            this.CatSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CatSelect.BorderRadius = 17;
            this.CatSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CatSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CatSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatSelect.FocusedState.Parent = this.CatSelect;
            this.CatSelect.Font = new System.Drawing.Font("Georgia", 12F);
            this.CatSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CatSelect.HoverState.Parent = this.CatSelect;
            this.CatSelect.ItemHeight = 30;
            this.CatSelect.ItemsAppearance.Parent = this.CatSelect;
            this.CatSelect.Location = new System.Drawing.Point(471, 150);
            this.CatSelect.Name = "CatSelect";
            this.CatSelect.ShadowDecoration.Parent = this.CatSelect;
            this.CatSelect.Size = new System.Drawing.Size(140, 36);
            this.CatSelect.TabIndex = 64;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BorderColor = System.Drawing.Color.LimeGreen;
            this.SearchBtn.BorderRadius = 10;
            this.SearchBtn.CheckedState.Parent = this.SearchBtn;
            this.SearchBtn.CustomImages.Parent = this.SearchBtn;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.DisabledState.Parent = this.SearchBtn;
            this.SearchBtn.FillColor = System.Drawing.Color.LimeGreen;
            this.SearchBtn.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Cyan;
            this.SearchBtn.HoverState.Parent = this.SearchBtn;
            this.SearchBtn.Location = new System.Drawing.Point(645, 150);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.ShadowDecoration.Parent = this.SearchBtn;
            this.SearchBtn.Size = new System.Drawing.Size(105, 37);
            this.SearchBtn.TabIndex = 65;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.LimeGreen;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Cyan;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(756, 150);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(105, 37);
            this.guna2Button1.TabIndex = 66;
            this.guna2Button1.Text = "Refresh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // excelExport
            // 
            this.excelExport.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.excelExport.BorderRadius = 10;
            this.excelExport.CheckedState.Parent = this.excelExport;
            this.excelExport.CustomImages.Parent = this.excelExport;
            this.excelExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.excelExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.excelExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.excelExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.excelExport.DisabledState.Parent = this.excelExport;
            this.excelExport.FillColor = System.Drawing.Color.Yellow;
            this.excelExport.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold);
            this.excelExport.ForeColor = System.Drawing.Color.SeaGreen;
            this.excelExport.HoverState.Parent = this.excelExport;
            this.excelExport.Location = new System.Drawing.Point(756, 106);
            this.excelExport.Name = "excelExport";
            this.excelExport.ShadowDecoration.Parent = this.excelExport;
            this.excelExport.Size = new System.Drawing.Size(105, 37);
            this.excelExport.TabIndex = 67;
            this.excelExport.Text = "Export in Excel";
            this.excelExport.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // TotAmtTbMs
            // 
            this.TotAmtTbMs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TotAmtTbMs.BorderThickness = 0;
            this.TotAmtTbMs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotAmtTbMs.DefaultText = "";
            this.TotAmtTbMs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TotAmtTbMs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TotAmtTbMs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotAmtTbMs.DisabledState.Parent = this.TotAmtTbMs;
            this.TotAmtTbMs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotAmtTbMs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotAmtTbMs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotAmtTbMs.FocusedState.Parent = this.TotAmtTbMs;
            this.TotAmtTbMs.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TotAmtTbMs.ForeColor = System.Drawing.Color.Black;
            this.TotAmtTbMs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotAmtTbMs.HoverState.Parent = this.TotAmtTbMs;
            this.TotAmtTbMs.Location = new System.Drawing.Point(30, 277);
            this.TotAmtTbMs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TotAmtTbMs.Name = "TotAmtTbMs";
            this.TotAmtTbMs.PasswordChar = '\0';
            this.TotAmtTbMs.PlaceholderForeColor = System.Drawing.Color.LimeGreen;
            this.TotAmtTbMs.PlaceholderText = "Product Amount";
            this.TotAmtTbMs.ReadOnly = true;
            this.TotAmtTbMs.SelectedText = "";
            this.TotAmtTbMs.ShadowDecoration.Parent = this.TotAmtTbMs;
            this.TotAmtTbMs.Size = new System.Drawing.Size(200, 31);
            this.TotAmtTbMs.TabIndex = 68;
            this.TotAmtTbMs.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(30, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 69;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(936, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TotAmtTbMs);
            this.Controls.Add(this.excelExport);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CatSelect);
            this.Controls.Add(this.dataGridMS);
            this.Controls.Add(this.catcombo);
            this.Controls.Add(this.productamtTbMs);
            this.Controls.Add(this.productqtyTbMs);
            this.Controls.Add(this.productnameTbMs);
            this.Controls.Add(this.editBtnMs);
            this.Controls.Add(this.deleteBtnMs);
            this.Controls.Add(this.addBtnMs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backtohomeMs);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel backtohomeMs;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button addBtnMs;
        private Guna.UI2.WinForms.Guna2Button deleteBtnMs;
        private Guna.UI2.WinForms.Guna2Button editBtnMs;
        private Guna.UI2.WinForms.Guna2TextBox productnameTbMs;
        private Guna.UI2.WinForms.Guna2TextBox productqtyTbMs;
        private Guna.UI2.WinForms.Guna2TextBox productamtTbMs;
        private Guna.UI2.WinForms.Guna2ComboBox catcombo;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridMS;
        private Guna.UI2.WinForms.Guna2ComboBox CatSelect;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label userLvlLabel;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button excelExport;
        private Guna.UI2.WinForms.Guna2TextBox TotAmtTbMs;
        private System.Windows.Forms.Panel panel3;
    }
}