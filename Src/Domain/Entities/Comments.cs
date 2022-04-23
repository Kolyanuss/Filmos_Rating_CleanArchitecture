namespace Filmos_Rating_CleanArchitecture.Domain.Entities
{
    public class Comments
    {
        public int Id_comment { get; set; }
        public int Text { get; set; }
        public int Id_film { get; set; }
        public int Id_user { get; set; }
    }
}
