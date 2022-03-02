using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonWebForm
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        FrmOgretmenler frmOgretmenler;

        private void btn_ogretmenform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmOgretmenler == null)
            {
                frmOgretmenler = new FrmOgretmenler();
                frmOgretmenler.MdiParent = this;
                frmOgretmenler.Show();
            }
            
        }
    }
}
