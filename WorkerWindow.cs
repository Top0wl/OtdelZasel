using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtdelZasel
{
    public partial class WorkerWindow : Form
    {
        public WorkerWindow()
        {
            InitializeComponent();
            tabControl1.TabPages[0].Visible = false;
            
        }

    }
}