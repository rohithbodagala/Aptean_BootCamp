using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class BorrowCardItem
    {
        public string bookId{ get; set; }
        public BorrowCard borrowCard;
        public BorrowCardItem(string bookId,BorrowCard borrowCard)
        {
            this.bookId = bookId;
            this.borrowCard = borrowCard;
        }
    }
}
