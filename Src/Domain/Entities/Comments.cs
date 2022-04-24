using System.Collections.Generic;

namespace Filmos_Rating_CleanArchitecture.Domain.Entities
{
    public class Comments
    {
        public Comments()
        {
            Films = new HashSet<Film>();
            Users = new HashSet<User>();
        }

        public int Id_comment { get; set; }
        public string Text { get; set; }
        public ICollection<Film> Films { get; private set; }
        public ICollection<User> Users { get; private set; }
    }
}
