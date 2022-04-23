using System.Collections.Generic;

namespace Filmos_Rating_CleanArchitecture.Domain.Entities
{
    public class Comments
    {
        public Comments()
        {
            Films = new HashSet<Films>();
            Users = new HashSet<Users>();
        }

        public int Id_comment { get; set; }
        public int Text { get; set; }
        public ICollection<Films> Films { get; private set; }
        public ICollection<Users> Users { get; private set; }
    }
}
