using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Thu_Vien
{
    public partial class FNewNXB : Form
    {
        string tenNXB;
        public FNewNXB(string tenNXB) : this()
        {
            this.tenNXB = tenNXB;
        }
        public FNewNXB()
        {
            InitializeComponent();
        }
    }
}
