using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class BorrowCard
    {
        public string studentId { get; set; }
        public DateTime? dateBorrowed;
        public DateTime? dateReturned;
        public BorrowCard(string studentId,DateTime? dateBorrowed,DateTime? dateReturned)
        {
            this.studentId = studentId;
            this.dateBorrowed = dateBorrowed;
            this.dateReturned = dateReturned;

        }
    }
}
