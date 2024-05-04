namespace TextureAtlasView
{
    partial class AtlasExplorer
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
            this.label5 = new System.Windows.Forms.Label();
            this.NumericColumn = new DarkUI.Controls.DarkNumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericROW = new DarkUI.Controls.DarkNumericUpDown();
            this.ButtonItemsMode = new DarkUI.Controls.DarkButton();
            this.ButtonTerrainMode = new DarkUI.Controls.DarkButton();
            this.PictureBoxItem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericROW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(319, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Atlas Explorer";
            // 
            // NumericColumn
            // 
            this.NumericColumn.Location = new System.Drawing.Point(323, 115);
            this.NumericColumn.Name = "NumericColumn";
            this.NumericColumn.Size = new System.Drawing.Size(150, 20);
            this.NumericColumn.TabIndex = 15;
            this.NumericColumn.ValueChanged += new System.EventHandler(this.NumericColumn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(320, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(320, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Row";
            // 
            // NumericROW
            // 
            this.NumericROW.Location = new System.Drawing.Point(323, 162);
            this.NumericROW.Name = "NumericROW";
            this.NumericROW.Size = new System.Drawing.Size(150, 20);
            this.NumericROW.TabIndex = 17;
            this.NumericROW.ValueChanged += new System.EventHandler(this.NumericROW_ValueChanged);
            // 
            // ButtonItemsMode
            // 
            this.ButtonItemsMode.Location = new System.Drawing.Point(12, 7);
            this.ButtonItemsMode.Name = "ButtonItemsMode";
            this.ButtonItemsMode.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonItemsMode.Size = new System.Drawing.Size(75, 23);
            this.ButtonItemsMode.TabIndex = 19;
            this.ButtonItemsMode.Text = "ITEMS";
            this.ButtonItemsMode.Click += new System.EventHandler(this.ButtonItemsMode_Click);
            // 
            // ButtonTerrainMode
            // 
            this.ButtonTerrainMode.Location = new System.Drawing.Point(90, 7);
            this.ButtonTerrainMode.Name = "ButtonTerrainMode";
            this.ButtonTerrainMode.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonTerrainMode.Size = new System.Drawing.Size(75, 23);
            this.ButtonTerrainMode.TabIndex = 20;
            this.ButtonTerrainMode.Text = "TERRAIN";
            this.ButtonTerrainMode.Click += new System.EventHandler(this.ButtonTerrainMode_Click);
            // 
            // PictureBoxItem
            // 
            this.PictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxItem.Location = new System.Drawing.Point(323, 188);
            this.PictureBoxItem.Name = "PictureBoxItem";
            this.PictureBoxItem.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxItem.TabIndex = 1;
            this.PictureBoxItem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 547);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.RenderBox);
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(282, 7);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(75, 23);
            this.darkButton1.TabIndex = 21;
            this.darkButton1.Text = "PREVIEW";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(171, 7);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 23);
            this.darkButton2.TabIndex = 22;
            this.darkButton2.Text = "FONT";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // AtlasExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(492, 601);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.ButtonTerrainMode);
            this.Controls.Add(this.ButtonItemsMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericROW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericColumn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PictureBoxItem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AtlasExplorer";
            this.Text = "AtlasExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.NumericColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericROW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureBoxItem;
        private System.Windows.Forms.Label label5;
        private DarkUI.Controls.DarkNumericUpDown NumericColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DarkUI.Controls.DarkNumericUpDown NumericROW;
        private DarkUI.Controls.DarkButton ButtonItemsMode;
        private DarkUI.Controls.DarkButton ButtonTerrainMode;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton darkButton2;
    }
}