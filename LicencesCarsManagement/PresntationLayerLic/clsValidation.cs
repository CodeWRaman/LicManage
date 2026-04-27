using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresntationLayerLic
{
    internal class clsValidation
    {
        public static bool CheckNumricFormat(KeyPressEventArgs e)
        {
           bool  isNumber = false;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                isNumber = true; 
    
            return isNumber; 
        }

        public static int CheckIfIntegerFormat(string Text)
        {
            int number = -1; 
            if (int.TryParse(Text, out  int Num))
                number = Num;


            return number; 
                
        }
    }
}
