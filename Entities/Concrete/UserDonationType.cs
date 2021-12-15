using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserDonationType
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

        public int DonorTypeId { get; set; }

        public DonationType? DonationType { get; set; }

        public int IsActive { get; set; } = 1;
        public int IsDelete { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
