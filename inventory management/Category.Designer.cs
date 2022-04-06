
namespace inventory_management
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLvlLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.backtohomeMcat = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtnMcat = new Guna.UI2.WinForms.Guna2Button();
            this.addBtnMcat = new Guna.UI2.WinForms.Guna2Button();
            this.catnameTbMc = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewMc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.excelExport = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.userLvlLabel);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 100);
            this.panel1.TabIndex = 22;
            // 
            // userLvlLabel
            // 
            this.userLvlLabel.AutoSize = true;
            this.userLvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLvlLabel.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLvlLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userLvlLabel.Location = new System.Drawing.Point(857, 75);
            this.userLvlLabel.Name = "userLvlLabel";
            this.userLvlLabel.Size = new System.Drawing.Size(14, 16);
            this.userLvlLabel.TabIndex = 62;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(689, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "You are logged in as :";
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
            this.label2.Location = new System.Drawing.Point(321, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGE CATEGORIES";
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
            this.panel5.Size = new System.Drawing.Size(935, 14);
            this.panel5.TabIndex = 30;
            // 
            // backtohomeMcat
            // 
            this.backtohomeMcat.AutoSize = true;
            this.backtohomeMcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtohomeMcat.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtohomeMcat.ForeColor = System.Drawing.Color.ForestGreen;
            this.backtohomeMcat.LinkColor = System.Drawing.Color.Green;
            this.backtohomeMcat.Location = new System.Drawing.Point(71, 468);
            this.backtohomeMcat.Name = "backtohomeMcat";
            this.backtohomeMcat.Size = new System.Drawing.Size(163, 25);
            this.backtohomeMcat.TabIndex = 33;
            this.backtohomeMcat.TabStop = true;
            this.backtohomeMcat.Text = "Back to Home";
            this.backtohomeMcat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(552, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "CATEGORIES LIST";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(28, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 39;
            // 
            // deleteBtnMcat
            // 
            this.deleteBtnMcat.BorderColor = System.Drawing.Color.LimeGreen;
            this.deleteBtnMcat.BorderRadius = 20;
            this.deleteBtnMcat.CheckedState.Parent = this.deleteBtnMcat;
            this.deleteBtnMcat.CustomImages.Parent = this.deleteBtnMcat;
            this.deleteBtnMcat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtnMcat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtnMcat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtnMcat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtnMcat.DisabledState.Parent = this.deleteBtnMcat;
            this.deleteBtnMcat.FillColor = System.Drawing.Color.LimeGreen;
            this.deleteBtnMcat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtnMcat.ForeColor = System.Drawing.Color.Cyan;
            this.deleteBtnMcat.HoverState.Parent = this.deleteBtnMcat;
            this.deleteBtnMcat.Location = new System.Drawing.Point(145, 321);
            this.deleteBtnMcat.Name = "deleteBtnMcat";
            this.deleteBtnMcat.ShadowDecoration.Parent = this.deleteBtnMcat;
            this.deleteBtnMcat.Size = new System.Drawing.Size(105, 37);
            this.deleteBtnMcat.TabIndex = 50;
            this.deleteBtnMcat.Text = "Delete";
            this.deleteBtnMcat.Click += new System.EventHandler(this.deleteBtnMcat_Click);
            // 
            // addBtnMcat
            // 
            this.addBtnMcat.BorderColor = System.Drawing.Color.LimeGreen;
            this.addBtnMcat.BorderRadius = 20;
            this.addBtnMcat.CheckedState.Parent = this.addBtnMcat;
            this.addBtnMcat.CustomImages.Parent = this.addBtnMcat;
            this.addBtnMcat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtnMcat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtnMcat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtnMcat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtnMcat.DisabledState.Parent = this.addBtnMcat;
            this.addBtnMcat.FillColor = System.Drawing.Color.LimeGreen;
            this.addBtnMcat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtnMcat.ForeColor = System.Drawing.Color.Cyan;
            this.addBtnMcat.HoverState.Parent = this.addBtnMcat;
            this.addBtnMcat.Location = new System.Drawing.Point(28, 321);
            this.addBtnMcat.Name = "addBtnMcat";
            this.addBtnMcat.ShadowDecoration.Parent = this.addBtnMcat;
            this.addBtnMcat.Size = new System.Drawing.Size(105, 37);
            this.addBtnMcat.TabIndex = 49;
            this.addBtnMcat.Text = "Add";
            this.addBtnMcat.Click += new System.EventHandler(this.addBtnMcat_Click);
            // 
            // catnameTbMc
            // 
            this.catnameTbMc.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.catnameTbMc.BorderThickness = 0;
            this.catnameTbMc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catnameTbMc.DefaultText = "";
            this.catnameTbMc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.catnameTbMc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.catnameTbMc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catnameTbMc.DisabledState.Parent = this.catnameTbMc;
            this.catnameTbMc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.catnameTbMc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.catnameTbMc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catnameTbMc.FocusedState.Parent = this.catnameTbMc;
            this.catnameTbMc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.catnameTbMc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catnameTbMc.HoverState.Parent = this.catnameTbMc;
            this.catnameTbMc.Location = new System.Drawing.Point(28, 183);
            this.catnameTbMc.Margin = new System.Windows.Forms.Padding(5);
            this.catnameTbMc.Name = "catnameTbMc";
            this.catnameTbMc.PasswordChar = '\0';
            this.catnameTbMc.PlaceholderForeColor = System.Drawing.Color.LimeGreen;
            this.catnameTbMc.PlaceholderText = "Category Name";
            this.catnameTbMc.SelectedText = "";
            this.catnameTbMc.ShadowDecoration.Parent = this.catnameTbMc;
            this.catnameTbMc.Size = new System.Drawing.Size(200, 44);
            this.catnameTbMc.TabIndex = 52;
            // 
            // dataGridViewMc
            // 
            this.dataGridViewMc.AllowUserToAddRows = false;
            this.dataGridViewMc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridViewMc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMc.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMc.EnableHeadersVisualStyles = false;
            this.dataGridViewMc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridViewMc.Location = new System.Drawing.Point(411, 167);
            this.dataGridViewMc.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMc.Name = "dataGridViewMc";
            this.dataGridViewMc.RowHeadersVisible = false;
            this.dataGridViewMc.RowTemplate.Height = 24;
            this.dataGridViewMc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMc.Size = new System.Drawing.Size(459, 414);
            this.dataGridViewMc.TabIndex = 60;
            this.dataGridViewMc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dataGridViewMc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridViewMc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewMc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewMc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewMc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewMc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridViewMc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewMc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dataGridViewMc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMc.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewMc.ThemeStyle.ReadOnly = false;
            this.dataGridViewMc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dataGridViewMc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMc.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewMc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dataGridViewMc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMc_CellContentClick);
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
            this.excelExport.Location = new System.Drawing.Point(783, 119);
            this.excelExport.Name = "excelExport";
            this.excelExport.ShadowDecoration.Parent = this.excelExport;
            this.excelExport.Size = new System.Drawing.Size(105, 37);
            this.excelExport.TabIndex = 61;
            this.excelExport.Text = "Export in Excel";
            this.excelExport.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(935, 619);
            this.Controls.Add(this.excelExport);
            this.Controls.Add(this.dataGridViewMc);
            this.Controls.Add(this.catnameTbMc);
            this.Controls.Add(this.deleteBtnMcat);
            this.Controls.Add(this.addBtnMcat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backtohomeMcat);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMc)).EndInit();
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
        private System.Windows.Forms.LinkLabel backtohomeMcat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button deleteBtnMcat;
        private Guna.UI2.WinForms.Guna2Button addBtnMcat;
        private Guna.UI2.WinForms.Guna2TextBox catnameTbMc;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMc;
        private System.Windows.Forms.Label userLvlLabel;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button excelExport;
    }
}