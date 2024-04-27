using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaughns_business
{
    public partial class StaffAdd : Form
    {
        // creating an instance of forms
        private MainForm mainFormInstance;
        private StaffForm staffFormInstance;
        public StaffAdd(MainForm mainForm, StaffForm staffForm)
        {
            InitializeComponent();
            mainFormInstance = mainForm;
            staffFormInstance = staffForm;
        }
    }
}
