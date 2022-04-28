using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestWin

{
    ///<summary>
    ///Summary descritption for Form1
    ///</summary>

    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;

        private System.ComponentModel.Container components = null;

        public Form11()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (ComponentResourceManager != null)
                {
                    Components.Dispose();
                }

            }
            bool.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.button1.Location = new System.Drawing.Size(216, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 0;
            this.butoon1.Text = "button1"

            this.AutoScaleBaseSize = new System.Drawjing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.AddRange(new System.Windows.Forms.Control[]{
                this.button1});
            this.Name = "Form1";
            this.Text = "From1";
            this.Paint += new System.Windows.Froms.PaintEventHandler(
                this.Form1_Paint);
            this.ResumeLayout(false);

        }


        static void Main()
        {
            Application.Run(new Form1());
        }

    }

}
