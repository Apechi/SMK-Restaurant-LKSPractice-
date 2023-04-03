using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LATIHANMEMBUATCRUD
{
    public class formUtills
    {
        private sqlComponent comp = new sqlComponent();

        public void clearTB(params TextBox[] textBoxes)
        {
            foreach (var tb in textBoxes)
            {
                tb.Text = "";
            }
        }

        public void mainButtonState(bool state, params Button[] button)
        {
            foreach (var btn in button)
            {
                btn.Enabled = state;
            }
        }
    }
}