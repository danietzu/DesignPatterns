using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Example2
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}