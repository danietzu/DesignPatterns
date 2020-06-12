using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}