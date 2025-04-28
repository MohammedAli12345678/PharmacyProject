namespace Pharmacy_project.view
{
    partial class Sales
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
            this.MinuBar = new System.Windows.Forms.MenuStrip();
            this.minuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Header = new System.Windows.Forms.Panel();
            this.DataTableContainer = new System.Windows.Forms.DataGridView();
            this.FilterContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.CategotyLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.SearchContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchPicture = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.MinuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableContainer)).BeginInit();
            this.FilterContainer.SuspendLayout();
            this.SearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MinuBar
            // 
            this.MinuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minuToolStripMenuItem});
            this.MinuBar.Location = new System.Drawing.Point(0, 0);
            this.MinuBar.Name = "MinuBar";
            this.MinuBar.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.MinuBar.Size = new System.Drawing.Size(952, 27);
            this.MinuBar.TabIndex = 1;
            this.MinuBar.Text = "menuStrip1";
            // 
            // minuToolStripMenuItem
            // 
            this.minuToolStripMenuItem.Name = "minuToolStripMenuItem";
            this.minuToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.minuToolStripMenuItem.Text = "Minu";
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 27);
            this.Header.Margin = new System.Windows.Forms.Padding(7);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(952, 72);
            this.Header.TabIndex = 2;
            // 
            // DataTableContainer
            // 
            this.DataTableContainer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataTableContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataTableContainer.Location = new System.Drawing.Point(0, 184);
            this.DataTableContainer.Name = "DataTableContainer";
            this.DataTableContainer.Size = new System.Drawing.Size(952, 347);
            this.DataTableContainer.TabIndex = 4;
            // 
            // FilterContainer
            // 
            this.FilterContainer.ColumnCount = 6;
            this.FilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.FilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.FilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.FilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.FilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.FilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.FilterContainer.Controls.Add(this.SearchLabel, 5, 0);
            this.FilterContainer.Controls.Add(this.CategotyLabel, 4, 0);
            this.FilterContainer.Controls.Add(this.TypeLabel, 3, 0);
            this.FilterContainer.Controls.Add(this.CompanyLabel, 2, 0);
            this.FilterContainer.Controls.Add(this.ToLabel, 1, 0);
            this.FilterContainer.Controls.Add(this.FromLabel, 0, 0);
            this.FilterContainer.Controls.Add(this.SearchContainer, 5, 1);
            this.FilterContainer.Controls.Add(this.comboBox1, 4, 1);
            this.FilterContainer.Controls.Add(this.comboBox2, 3, 1);
            this.FilterContainer.Controls.Add(this.comboBox3, 2, 1);
            this.FilterContainer.Controls.Add(this.ToDate, 1, 1);
            this.FilterContainer.Controls.Add(this.FromDate, 0, 1);
            this.FilterContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterContainer.Location = new System.Drawing.Point(0, 99);
            this.FilterContainer.Margin = new System.Windows.Forms.Padding(7);
            this.FilterContainer.Name = "FilterContainer";
            this.FilterContainer.RowCount = 2;
            this.FilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterContainer.Size = new System.Drawing.Size(952, 83);
            this.FilterContainer.TabIndex = 3;
            this.FilterContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.FilterContainer_Paint);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLabel.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchLabel.Location = new System.Drawing.Point(7, 0);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(259, 27);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "البحث";
            // 
            // CategotyLabel
            // 
            this.CategotyLabel.AutoSize = true;
            this.CategotyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategotyLabel.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CategotyLabel.Location = new System.Drawing.Point(280, 0);
            this.CategotyLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CategotyLabel.Name = "CategotyLabel";
            this.CategotyLabel.Size = new System.Drawing.Size(122, 27);
            this.CategotyLabel.TabIndex = 1;
            this.CategotyLabel.Text = "الصنف";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeLabel.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TypeLabel.Location = new System.Drawing.Point(416, 0);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(122, 27);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "النوع";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyLabel.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyLabel.Location = new System.Drawing.Point(552, 0);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(122, 27);
            this.CompanyLabel.TabIndex = 3;
            this.CompanyLabel.Text = "الشركة المصنعة";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToLabel.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLabel.Location = new System.Drawing.Point(688, 0);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(122, 27);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "حتى";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromLabel.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLabel.Location = new System.Drawing.Point(824, 0);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(121, 27);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "من تاريخ";
            // 
            // SearchContainer
            // 
            this.SearchContainer.ColumnCount = 2;
            this.SearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.SearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SearchContainer.Controls.Add(this.SearchText, 1, 0);
            this.SearchContainer.Controls.Add(this.SearchPicture, 0, 0);
            this.SearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchContainer.Location = new System.Drawing.Point(7, 34);
            this.SearchContainer.Margin = new System.Windows.Forms.Padding(7);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.RowCount = 1;
            this.SearchContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchContainer.Size = new System.Drawing.Size(259, 49);
            this.SearchContainer.TabIndex = 6;
            // 
            // SearchText
            // 
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchText.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchText.Location = new System.Drawing.Point(7, 7);
            this.SearchText.Margin = new System.Windows.Forms.Padding(7);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(205, 34);
            this.SearchText.TabIndex = 1;
            this.SearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SearchPicture
            // 
            this.SearchPicture.Location = new System.Drawing.Point(222, 3);
            this.SearchPicture.Name = "SearchPicture";
            this.SearchPicture.Size = new System.Drawing.Size(34, 38);
            this.SearchPicture.TabIndex = 2;
            this.SearchPicture.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 35);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 34);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(122, 35);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(552, 34);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(122, 35);
            this.comboBox3.TabIndex = 9;
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/mm/yyyy";
            this.ToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDate.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(688, 34);
            this.ToDate.Margin = new System.Windows.Forms.Padding(7);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(122, 34);
            this.ToDate.TabIndex = 10;
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/mm/yyyy";
            this.FromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDate.Font = new System.Drawing.Font("PT Bold Dusky", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(824, 34);
            this.FromDate.Margin = new System.Windows.Forms.Padding(7);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(121, 34);
            this.FromDate.TabIndex = 11;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 531);
            this.Controls.Add(this.FilterContainer);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.DataTableContainer);
            this.Controls.Add(this.MinuBar);
            this.Font = new System.Drawing.Font("PT Bold Broken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.MinuBar;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Sales";
            this.MinuBar.ResumeLayout(false);
            this.MinuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableContainer)).EndInit();
            this.FilterContainer.ResumeLayout(false);
            this.FilterContainer.PerformLayout();
            this.SearchContainer.ResumeLayout(false);
            this.SearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MinuBar;
        private System.Windows.Forms.ToolStripMenuItem minuToolStripMenuItem;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.DataGridView DataTableContainer;
        private System.Windows.Forms.TableLayoutPanel FilterContainer;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label CategotyLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.TableLayoutPanel SearchContainer;
        private System.Windows.Forms.PictureBox SearchPicture;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
    }
}