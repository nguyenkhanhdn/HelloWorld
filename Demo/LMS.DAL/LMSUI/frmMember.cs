using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LMS.BLL;

namespace LMSUI
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra dữ liệu trên form trước khi add
                Member obj = new Member();
                bool b = obj.CreateMember(tbCode.Text, tbName.Text, tbAddress.Text, tbPhone.Text);
                MessageBox.Show(b.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewMember fview = new frmViewMember();
            fview.ShowDialog();
        }
    }
}
