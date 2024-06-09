using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class BorderlessForm : Form
    {
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        public BorderlessForm()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(BorderlessForm_MouseDown);
            this.MouseMove += new MouseEventHandler(BorderlessForm_MouseMove);
            this.MouseUp += new MouseEventHandler(BorderlessForm_MouseUp);
        }

        private void BorderlessForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void BorderlessForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(diff));
            }
        }

        private void BorderlessForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
