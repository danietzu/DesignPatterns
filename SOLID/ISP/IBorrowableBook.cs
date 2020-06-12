using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public interface IBorrowableBook : IBook, IBorrowable
    {
    }
}