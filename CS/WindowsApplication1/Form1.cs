using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void comboBoxEdit1_Properties_MouseWheel(object sender, MouseEventArgs e) {
            ((DXMouseEventArgs)e).Handled = true;
        }
    }
}