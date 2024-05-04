using System.Drawing;

namespace TextureAtlasView
{
    public class AtlasBase
    {
        protected Bitmap Data { get; set; }
        protected Size TextureSize { get; set; }
    }

    public class TexturesAtlas : AtlasBase
    {
        public TexturesAtlas(string filename)
        {
            Data = new Bitmap(filename);
            TextureSize = Data.Size;
        }
        public TexturesAtlas(Bitmap data)
        {
            Data = data;
            TextureSize = Data.Size;
        }
    }

    public class ItemTextureAtlas : TexturesAtlas
    {
        public readonly int Columns = 15;
        public readonly int Rows = 16;
        public readonly int ItemSize = 16;
        public ItemTextureAtlas (Bitmap data) : base(data)
        {
            this.Data = data;
        }
        public Bitmap GetItem(int row, int column)
        {
            return Data.Crop(new Rectangle(ItemSize * column, ItemSize * row, ItemSize, ItemSize));
        }
        
    }
    public class HDFontTextureAtlas : TexturesAtlas
    {
        public readonly int Columns = 24;
        public readonly int Rows = 28;

        public readonly int ItemSize = 16;
        public HDFontTextureAtlas(Bitmap item) : base(item) 
        {

        }
        public Bitmap GetItem(int row, int column)
        {
            return Data.Crop(new Rectangle(ItemSize * column, ItemSize * row, ItemSize, ItemSize));
        }
    }
    public class TerrainTextureAtlas : TexturesAtlas
    {

        public readonly int Columns = 15;
        public readonly int Rows = 34;
        public readonly int ItemSize = 16;
        public TerrainTextureAtlas(Bitmap data) : base(data)
        {
            this.Data = data;
        }
        public Bitmap GetItem(int row, int column)
        {
            return Data.Crop(new Rectangle(ItemSize * column, ItemSize * row, ItemSize, ItemSize));
        }
    }
}