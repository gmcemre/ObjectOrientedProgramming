using CustomProject.Common;

namespace CustomProject.Entity
{
    [Table(PrimaryColumn = "KategoriID", TableName = "Kategoriler")]
    public class Kategoriler
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }
    }
}
