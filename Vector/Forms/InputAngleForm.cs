using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector.Forms
{
    
    public partial class InputAngleForm :Form
    {
        public double Angle;
        public InputAngleForm()
        {
            InitializeComponent();
        }

        public void InputAngleForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Angle = double.Parse(txtNumberAngle.Value.ToString());
            this.Close();
        }
    }
}
