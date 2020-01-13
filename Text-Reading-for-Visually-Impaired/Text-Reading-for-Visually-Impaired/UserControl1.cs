using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Reading_for_Visually_Impaired
{
    public partial class questioPanel : UserControl
    {
        public question question;
        public int correctAnsIndex;
        Dictionary<RadioButton, int> RBDict;
        public questioPanel(question q)
        {
            InitializeComponent();
            question = q;
            RBDict = new Dictionary<RadioButton, int>();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void initialRadioButtons()
        {
            Random r = new Random();
            int rInt = r.Next(1, 4);

            
        }
    }
}
