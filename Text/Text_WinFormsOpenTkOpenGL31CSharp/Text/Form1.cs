using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Text
{
    public partial class Form1 : Form
    {
        private GLControl _glControl;

        public Form1()
        {
            InitializeComponent();

            _glControl = new GLControl();
            _glControl.Load += GLControl_Load;
            _glControl.Paint += GLControl_Paint;
            _glControl.Dock = DockStyle.Fill;
            Controls.Add(_glControl);
        }

        private void GLControl_Load(object sender, EventArgs e)
        {
            // Set clear color
            GL.ClearColor(Color4.Black);
        }

        private void GLControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Viewport(0, 0, _glControl.Width, _glControl.Height);

            // Clear _glControl
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // Swap the front and back buffers
            _glControl.SwapBuffers();
        }
    }
}
