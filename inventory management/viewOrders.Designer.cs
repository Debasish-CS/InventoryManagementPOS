
namespace inventory_management
{
    partial class viewOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLvlLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Orderdgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CustName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FilterBtn2 = new Guna.UI2.WinForms.Guna2Button();
            this.FilterBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orderdgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.userLvlLabel);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 100);
            this.panel1.TabIndex = 3;
            // 
            // userLvlLabel
            // 
            this.userLvlLabel.AutoSize = true;
            this.userLvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLvlLabel.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLvlLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userLvlLabel.Location = new System.Drawing.Point(851, 74);
            this.userLvlLabel.Name = "userLvlLabel";
            this.userLvlLabel.Size = new System.Drawing.Size(14, 16);
            this.userLvlLabel.TabIndex = 64;
            this.userLvlLabel.Text = "  ";
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(243, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "VIEW ORDERS";
            // 
            // Orderdgv
            // 
            this.Orderdgv.AllowUserToAddRows = false;
            this.Orderdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.Orderdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Orderdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orderdgv.BackgroundColor = System.Drawing.Color.White;
            this.Orderdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Orderdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orderdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Orderdgv.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Orderdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.Orderdgv.EnableHeadersVisualStyles = false;
            this.Orderdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Orderdgv.Location = new System.Drawing.Point(34, 171);
            this.Orderdgv.Margin = new System.Windows.Forms.Padding(2);
            this.Orderdgv.Name = "Orderdgv";
            this.Orderdgv.RowHeadersVisible = false;
            this.Orderdgv.RowTemplate.Height = 24;
            this.Orderdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orderdgv.Size = new System.Drawing.Size(637, 326);
            this.Orderdgv.TabIndex = 65;
            this.Orderdgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Orderdgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Orderdgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Orderdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Orderdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.Orderdgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Orderdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Orderdgv.ThemeStyle.HeaderStyle.Height = 30;
            this.Orderdgv.ThemeStyle.ReadOnly = false;
            this.Orderdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.Orderdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Orderdgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Orderdgv.ThemeStyle.RowsStyle.Height = 24;
            this.Orderdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.Orderdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Orderdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderdgv_CellContentClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BorderRadius = 10;
            this.SearchBtn.CheckedState.Parent = this.SearchBtn;
            this.SearchBtn.CustomImages.Parent = this.SearchBtn;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.DisabledState.Parent = this.SearchBtn;
            this.SearchBtn.FillColor = System.Drawing.Color.Navy;
            this.SearchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.SearchBtn.HoverState.Parent = this.SearchBtn;
            this.SearchBtn.Location = new System.Drawing.Point(26, 525);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.ShadowDecoration.Parent = this.SearchBtn;
            this.SearchBtn.Size = new System.Drawing.Size(109, 36);
            this.SearchBtn.TabIndex = 71;
            this.SearchBtn.Text = "Back ";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2Button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Navy;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(441, 512);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(105, 59);
            this.guna2Button1.TabIndex = 72;
            this.guna2Button1.Text = "Export As excel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(0, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 10);
            this.panel2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(851, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(683, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "You are logged in as :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 294);
            this.dataGridView1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(900, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            // 
            // OrderDate
            // 
            this.OrderDate.AutoRoundedCorners = true;
            this.OrderDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OrderDate.BorderRadius = 17;
            this.OrderDate.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.OrderDate.BorderThickness = 2;
            this.OrderDate.CheckedState.Parent = this.OrderDate;
            this.OrderDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OrderDate.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDate.ForeColor = System.Drawing.Color.Navy;
            this.OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.OrderDate.HoverState.Parent = this.OrderDate;
            this.OrderDate.Location = new System.Drawing.Point(258, 118);
            this.OrderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.OrderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ShadowDecoration.Parent = this.OrderDate;
            this.OrderDate.Size = new System.Drawing.Size(188, 36);
            this.OrderDate.TabIndex = 74;
            this.OrderDate.Value = new System.DateTime(2021, 9, 30, 12, 34, 43, 26);
            // 
            // CustName
            // 
            this.CustName.AutoRoundedCorners = true;
            this.CustName.BackColor = System.Drawing.Color.Transparent;
            this.CustName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CustName.BorderRadius = 17;
            this.CustName.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.CustName.BorderThickness = 2;
            this.CustName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustName.FocusedState.Parent = this.CustName;
            this.CustName.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.ForeColor = System.Drawing.Color.Blue;
            this.CustName.HoverState.Parent = this.CustName;
            this.CustName.ItemHeight = 30;
            this.CustName.ItemsAppearance.Parent = this.CustName;
            this.CustName.Location = new System.Drawing.Point(27, 118);
            this.CustName.Name = "CustName";
            this.CustName.ShadowDecoration.Parent = this.CustName;
            this.CustName.Size = new System.Drawing.Size(110, 36);
            this.CustName.TabIndex = 75;
            // 
            // FilterBtn2
            // 
            this.FilterBtn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FilterBtn2.BorderRadius = 10;
            this.FilterBtn2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.FilterBtn2.BorderThickness = 2;
            this.FilterBtn2.CheckedState.Parent = this.FilterBtn2;
            this.FilterBtn2.CustomImages.Parent = this.FilterBtn2;
            this.FilterBtn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterBtn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterBtn2.DisabledState.Parent = this.FilterBtn2;
            this.FilterBtn2.FillColor = System.Drawing.Color.Blue;
            this.FilterBtn2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn2.ForeColor = System.Drawing.Color.GhostWhite;
            this.FilterBtn2.HoverState.Parent = this.FilterBtn2;
            this.FilterBtn2.Location = new System.Drawing.Point(448, 106);
            this.FilterBtn2.Name = "FilterBtn2";
            this.FilterBtn2.ShadowDecoration.Parent = this.FilterBtn2;
            this.FilterBtn2.Size = new System.Drawing.Size(86, 48);
            this.FilterBtn2.TabIndex = 76;
            this.FilterBtn2.Text = "Search by OrderDate";
            this.FilterBtn2.Click += new System.EventHandler(this.FilterBtn2_Click);
            // 
            // FilterBtn1
            // 
            this.FilterBtn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FilterBtn1.BorderRadius = 10;
            this.FilterBtn1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.FilterBtn1.BorderThickness = 2;
            this.FilterBtn1.CheckedState.Parent = this.FilterBtn1;
            this.FilterBtn1.CustomImages.Parent = this.FilterBtn1;
            this.FilterBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterBtn1.DisabledState.Parent = this.FilterBtn1;
            this.FilterBtn1.FillColor = System.Drawing.Color.Blue;
            this.FilterBtn1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.FilterBtn1.ForeColor = System.Drawing.Color.GhostWhite;
            this.FilterBtn1.HoverState.Parent = this.FilterBtn1;
            this.FilterBtn1.Location = new System.Drawing.Point(141, 106);
            this.FilterBtn1.Name = "FilterBtn1";
            this.FilterBtn1.ShadowDecoration.Parent = this.FilterBtn1;
            this.FilterBtn1.Size = new System.Drawing.Size(83, 48);
            this.FilterBtn1.TabIndex = 77;
            this.FilterBtn1.Text = "Search by Customer Name";
            this.FilterBtn1.Click += new System.EventHandler(this.FilterBtn1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2Button2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Navy;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(578, 118);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(105, 36);
            this.guna2Button2.TabIndex = 78;
            this.guna2Button2.Text = "Refresh";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // viewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 587);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.FilterBtn1);
            this.Controls.Add(this.FilterBtn2);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Orderdgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewOrders";
            this.Text = "viewOrders";
            this.Load += new System.EventHandler(this.viewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orderdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userLvlLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView Orderdgv;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker OrderDate;
        private Guna.UI2.WinForms.Guna2ComboBox CustName;
        private Guna.UI2.WinForms.Guna2Button FilterBtn2;
        private Guna.UI2.WinForms.Guna2Button FilterBtn1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}