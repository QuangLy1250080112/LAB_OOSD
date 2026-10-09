using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace QLCtyDuLich
{
    public partial class FrmMain : Form
    {
        private Form activeForm = null;
        private Button currentBtn = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DataTable dtTest = Database.ExecuteQuery("SELECT COUNT(*) FROM Tour");
            if (dtTest != null)
            {
                this.Text += "";
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    // Kiểu Excel Active: Nền đen, chữ trắng
                    currentBtn.BackColor = Color.Black;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    // Kiểu Excel Inactive: Nền trắng, chữ đen, đường viền đen
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDangKyTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDangKyTour(), sender);
            lblTitle.Text = "ĐĂNG KÝ TOUR DU LỊCH";

            ActivateButton(sender);
            lblTitle.Text = "ĐĂNG KÝ TOUR DU LỊCH";
            MessageBox.Show("Chức năng 'Đăng ký Tour' đang chờ mở khi bạn khởi tạo FrmDangKyTour!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDieuHanhQuyetToan_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FrmDieuHanhVaQuyetToan(), sender);
            lblTitle.Text = "ĐIỀU HÀNH & QUYẾT TOÁN";

            ActivateButton(sender);
            lblTitle.Text = "ĐIỀU HÀNH & QUYẾT TOÁN";
            MessageBox.Show("Chức năng 'Điều hành & Quyết toán' đang chờ mở khi bạn khởi tạo FrmDieuHanhVaQuyetToan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKhaoSat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhaoSatTour(), sender);
            lblTitle.Text = "KHẢO SÁT CHẤT LƯỢNG";

            ActivateButton(sender);
            lblTitle.Text = "KHẢO SÁT CHẤT LƯỢNG";
            MessageBox.Show("Chức năng 'Khảo sát Tour' đang chờ mở khi bạn khởi tạo FrmKhaoSatTour!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}