using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using Vector;

namespace Vector
{
    public partial class frmOptions : Form
    {
        AutoItX3 auto = new AutoItX3();
        Vector vector1 = new Vector();
        Vector vector2 = new Vector();
        frmMain main;
        public frmOptions(frmMain mainfrm)
        {
            InitializeComponent();
            this.main = mainfrm;
        }
        public Vector[] GetVectorFromMainfrm()
        {
            Vector.GetVectorPoints(vector1, main.txtBoxVector1.Text);
            Vector.GetVectorPoints(vector2, main.txtBoxVector2.Text);
            Vector[] vector = { vector1, vector2 };
            return vector;
        }
        
        public void OpenGeoGebra()
        {
            System.Diagnostics.Process.Start("F:\\learning\\C#\\Vector\\GeoGebra Classic.lnk");
        }
        public void SumGeoGebra()
        {
            Vector[] vectors = GetVectorFromMainfrm();
            GoTo3D();
            auto.WinWaitActive("3D Graphics - GeoGebra", "");
            //auto.Sleep(20000);
            auto.Send($"vector{{SHIFTDOWN}}9{{SHIFTUP}}{{SHIFTDOWN}}9{{SHIFTUP}}{vectors[0]._x},{vectors[0]._y},{vectors[0]._z}{{END}}+vector{{SHIFTDOWN}}9{{SHIFTUP}}{{SHIFTDOWN}}9{{SHIFTUP}}{vectors[1]._x},{vectors[1]._y},{vectors[1]._z}");
        }
        public void MinusGeoGebra()
        {
            Vector[] vectors = GetVectorFromMainfrm();
            GoTo3D();
            auto.WinWaitActive("3D Graphics - GeoGebra", "");
            auto.Sleep(1000);
            auto.Send($"vector{{SHIFTDOWN}}9{{SHIFTUP}}{{SHIFTDOWN}}9{{SHIFTUP}}{vectors[0]._x},{vectors[0]._y},{vectors[0]._z}{{END}}-vector{{SHIFTDOWN}}9{{SHIFTUP}}{{SHIFTDOWN}}9{{SHIFTUP}}{vectors[1]._x},{vectors[1]._y},{vectors[1]._z}");
        }
        public void GoTo3D()
        {
            auto.WinWaitActive("GeoGebra Classic", "");
            auto.Sleep(5000);
            auto.MouseClick("LEFT", 993, 350, 1, -1);
        }
        private void frmOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnSumOption_Click(object sender, EventArgs e)
        {
            OpenGeoGebra();
           // GoTo3D();
            SumGeoGebra();

        }

        private void btnMinusOption_Click(object sender, EventArgs e)
        {
            OpenGeoGebra();
            MinusGeoGebra();
        }
    }
}
