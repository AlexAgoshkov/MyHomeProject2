using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFull
{
    interface IActionable
    {
        void MainFunction();

        bool IsMove { get; }

        int Capacity { get; }
    }
}
