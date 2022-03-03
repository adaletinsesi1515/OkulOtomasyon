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
        FrmOgrenciler frmOgrenciler;


        private void btn_ogretmenform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmOgretmenler == null || frmOgretmenler.IsDisposed)
            {
                frmOgretmenler = new FrmOgretmenler();
                frmOgretmenler.MdiParent = this;
                frmOgretmenler.Show();
            }
            
        }

        private void FrmAnaModul_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_ogrenciform_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmOgrenciler == null || frmOgrenciler.IsDisposed)
            {
                frmOgrenciler = new FrmOgrenciler();
                frmOgrenciler.MdiParent = this;
                frmOgrenciler.Show();
            }
        }
    }
}
