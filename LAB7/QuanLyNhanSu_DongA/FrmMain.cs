using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu_DongA
{
    public partial class FrmMain : Form
    {
        private Form activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Mặc định nhấn vào nút Hồ sơ & Hợp đồng
            btnNhanSu_HopDong.PerformClick();
        }

        // Hàm hỗ trợ nhúng Form con vào panelContent
        private void OpenChildForm(Form childForm, Button activeBtn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            HighlightButton(activeBtn);
        }

        // Đổi màu Tab làm nổi bật theo phong cách Excel tối giản (Đen / Trắng)
        private void HighlightButton(Button activeBtn)
        {
            foreach (Control ctrl in panelTopNav.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                }
            }
            if (activeBtn != null)
            {
                activeBtn.BackColor = Color.Black;
                activeBtn.ForeColor = Color.White;
                activeBtn.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            }
        }

        private void btnNhanSu_HopDong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTiepNhanVaHopDong(), btnNhanSu_HopDong);
            HighlightButton(btnNhanSu_HopDong);
            ShowPlaceholderMessage("PHÂN HỆ: HỒ SƠ NHÂN SỰ & HỢP ĐỒNG LAO ĐỘNG");
        }

        private void btnChamCong_PhuTroi_Click(object sender, EventArgs e)
        {
            HighlightButton(btnChamCong_PhuTroi);
            ShowPlaceholderMessage("PHÂN HỆ: PHÂN CÔNG CA & CHẤM CÔNG HẰNG THÁNG");
        }

        private void btnQuyetDinh_Click(object sender, EventArgs e)
        {
            HighlightButton(btnQuyetDinh);
            ShowPlaceholderMessage("PHÂN HỆ: QUẢN LÝ QUYẾT ĐỊNH (LƯƠNG, CHỨC VỤ, THƯỞNG / PHẠT)");
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBangLuong);
            ShowPlaceholderMessage("PHÂN HỆ: TÍNH & XUẤT BẢNG LƯƠNG HẰNG THÁNG");
        }

        private void ShowPlaceholderMessage(string featureName)
        {
            panelContent.Controls.Clear();
            Label lbl = new Label
            {
                Text = $"[ EXCEL WORKSPACE - {featureName} ]\n(Sẵn sàng nhúng Form chức năng)",
                Font = new Font("Consolas", 10F, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelContent.Controls.Add(lbl);
        }
    }
}