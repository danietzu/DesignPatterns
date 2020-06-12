using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}