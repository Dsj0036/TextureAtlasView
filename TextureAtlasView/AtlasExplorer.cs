
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureAtlasView
{
    public partial class AtlasExplorer : Form
    {
        
        ItemTextureAtlas ItemAtlas;
        TerrainTextureAtlas TerrainTextureAtlas;
        HDFontTextureAtlas FontAtlas;
        Bitmap original_items;
        Bitmap original_terrain;
        Bitmap originalFont;
        short mode = 0;
        public AtlasExplorer()
        {
            InitializeComponent();
        }
        public string GetFile()
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Multiselect = false;
            diag.Title = "Select graphic";
            diag.Filter = "Portable Network Graphics|*.png";
            diag.DefaultExt = ".png";
            diag.AddExtension = true;
            string fn = null;
            if (diag.ShowDialog()==DialogResult.OK)
            {
                fn = diag.FileName;
            }
            diag.Dispose();
            return fn;


                
        }
        public Bitmap GetItem()
        {
            if (mode == 0)
            {
                return ItemAtlas.GetItem((int)NumericROW.Value, (int)NumericColumn.Value).Upscale();
            }
            else if (mode == 1)
            {
                return TerrainTextureAtlas.GetItem((int)NumericROW.Value, (int)NumericColumn.Value).Upscale();
            }
            else if (mode == 2)
            {
                return FontAtlas.GetItem((int)NumericROW.Value, (int)NumericColumn.Value).Upscale();
            }
            else return null;
        }
        private void NumericROW_ValueChanged(object sender, EventArgs e)
        {
            this.PictureBoxItem.Image = GetItem();
            this.pictureBox1.Invalidate();
        }

        private void NumericColumn_ValueChanged(object sender, EventArgs e)
        {
            this.PictureBoxItem.Image = GetItem();
            this.pictureBox1.Invalidate();
        }

        private void RenderBox(object sender, PaintEventArgs e)
        {
            
            Pen solidpen = new Pen(new SolidBrush(Color.Green));
            int X = (16 * (int)NumericColumn.Value)+8;
            int Y = (16 * (int)NumericROW.Value)+8;
            e.Graphics.DrawLine(solidpen,
                new Point(X, 0), new Point(X, (int)e.Graphics.ClipBounds.Height));
            e.Graphics.DrawLine(solidpen,
                new Point(0, Y), new Point((int)e.Graphics.ClipBounds.Width, Y));
           
        }
        void ITEMS_MODE()
        {

            string fn = GetFile();
            if (fn != null)
            {
                original_items = new Bitmap(fn);
                ItemAtlas = new ItemTextureAtlas(original_items);
                this.NumericColumn.Minimum = 0;
                this.NumericColumn.Maximum = ItemAtlas.Columns;
                this.NumericROW.Minimum = 0;
                this.NumericROW.Maximum = ItemAtlas.Rows;
                this.pictureBox1.Image = original_items;
                mode = 0;
            }
        }
        void TERRAIN_MODE()
        {
            string fn = GetFile();
            if (fn!= null)
            {
                original_terrain = new Bitmap(fn);

                TerrainTextureAtlas = new TerrainTextureAtlas(original_terrain);
                this.NumericColumn.Minimum = 0;
                this.NumericColumn.Maximum = TerrainTextureAtlas.Columns;
                this.NumericROW.Minimum = 0;
                this.NumericROW.Maximum = TerrainTextureAtlas.Rows;
                this.pictureBox1.Image = original_terrain;
                mode = 1;

            }
        }
        private void ButtonItemsMode_Click(object sender, EventArgs e)
        {
            ITEMS_MODE();
        }

        private void ButtonTerrainMode_Click(object sender, EventArgs e)
        {
            TERRAIN_MODE();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            string fn = GetFile();
            if (fn != null)
            {
                originalFont = new Bitmap(fn);

                FontAtlas = new HDFontTextureAtlas(originalFont);
                this.NumericColumn.Minimum = 0;
                this.NumericColumn.Maximum = FontAtlas.Columns;
                this.NumericROW.Minimum = 0;
                this.NumericROW.Maximum = FontAtlas.Rows;
                this.pictureBox1.Image = originalFont;
                mode = 2;

            }
        }
    }
}
