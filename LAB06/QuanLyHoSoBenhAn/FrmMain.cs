using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn
{
    public partial class FrmMain : Form
    {
        private Form activeChildForm = null;
        private Button currentButton = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateClockLabel();
            // Mặc định chọn nút đầu tiên khi mở app
            HighlightButton(btnTiepNhan);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClockLabel();
        }

        private void UpdateClockLabel()
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Hàm mở Form con vào panelContent (Sử dụng khi bạn tạo các Form con sau)
        private void OpenChildForm(Form childForm, Button senderButton)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            HighlightButton(senderButton);
            activeChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Hiệu ứng Highlight phong cách Excel Tab (Trắng - Đen)
        private void HighlightButton(Button btn)
        {
            if (btn == null) return;

            if (currentButton != null)
            {
                // Trả về giao diện Tab chưa chọn (Nền trắng, chữ xám/đen)
                currentButton.BackColor = Color.White;
                currentButton.ForeColor = Color.Black;
                currentButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            }

            currentButton = btn;
            // Tab đang chọn: Nền xám đậm (Đen tối giản), Chữ trắng đậm phong cách Excel Active Tab
            currentButton.BackColor = Color.FromArgb(38, 38, 38);
            currentButton.ForeColor = Color.White;
            currentButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            OpenChildForm(new FrmTiepNhanDangKy(), (Button)sender);
            MessageBox.Show("Màn hình Tiếp Nhận & Lịch Hẹn chưa được tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            // OpenChildForm(new FrmKhamBenh(), (Button)sender);
            MessageBox.Show("Màn hình Khám Bệnh & Điều Trị chưa được tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            // OpenChildForm(new FrmQuanLyDanhMuc(), (Button)sender);
            MessageBox.Show("Màn hình Quản Lý Danh Mục chưa được tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThanhToanVienPhi_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            // OpenChildForm(new FrmThanhToanVienPhi(), (Button)sender);
            MessageBox.Show("Màn hình Thanh Toán Viện Phí chưa được tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}