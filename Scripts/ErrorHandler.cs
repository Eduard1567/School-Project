using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    public class ErrorHandler
    {
        public void ThrowError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
