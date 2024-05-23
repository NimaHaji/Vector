using System;
using System.Windows.Forms;
using System.Diagnostics;
using Vector;
using AutoItX3Lib;
using Vector.Forms;


namespace Vector
{
    public partial class frmMain : Form
    {
        Vector vectorOutput = new Vector();
        InputAngleForm inputangleform = new InputAngleForm();
        public Vector vector1 = new Vector();
        public Vector vector2 = new Vector();
        public Vector[] GetVectorsFromTextBox()
        {
            Vector.GetVectorPoints(vector1, txtBoxVector1.Text);
            Vector.GetVectorPoints(vector2, txtBoxVector2.Text);
            Vector[] vectors = { vector1, vector2 };
            return vectors;
        }
        public frmMain()
        {
            InitializeComponent();

        }
        private void BtnGeogebra_Click(object sender, EventArgs e)
        {
            frmOptions option = new frmOptions(this);
            option.ShowDialog();

        }
        private void btnVectorSum_Click(object sender, EventArgs e)
        {
            Vector[] vectors = GetVectorsFromTextBox();
            vectorOutput = VectorOperation.AddVectors(vectors[0], vectors[1]);
            MessageBox.Show($"Sum is : ({vectorOutput._x},{vectorOutput._y},{vectorOutput._z})", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtVectorMinus_Click(object sender, EventArgs e)
        {
            Vector[] vectors = GetVectorsFromTextBox();
            vectorOutput = VectorOperation.MinusVectors(vectors[0], vectors[1]);
            MessageBox.Show($"Minus is : ({vectorOutput._x},{vectorOutput._y},{vectorOutput._z})", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVectorInter_Click(object sender, EventArgs e)
        {
            Vector[] vectors = GetVectorsFromTextBox();
            inputangleform.ShowDialog();
            double Angle;
            Angle = inputangleform.Angle;
            double result = VectorOperation.InternalMultiplicationVectors(vectors[0], vectors[1], Angle);
            MessageBox.Show($"Internal Multiple is : {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVectorOut_Click(object sender, EventArgs e)
        {
            Vector[] vectors = GetVectorsFromTextBox();
            vectorOutput = VectorOperation.OuternalMultiplicationVectors(vectors[0], vectors[1]);
            MessageBox.Show($"Outernal Multiple is : ({vectorOutput._x},{vectorOutput._y},{vectorOutput._z})", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
