using System;
using System.Data;
using System.Windows.Forms;
using QLKhachsan.Services;

namespace QLKhachsan.Forms
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService s = new DichVuService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmDichVu()
        {
            InitializeComponent();
            this.Load += Frm_Load;
            cboLuot.SelectedIndexChanged += cboLuot_SelectedIndexChanged;
            btnGhi.Click += btnGhi_Click;
            btnDong.Click += btnDong_Click;
        }

        private void Frm_Load(object? a, EventArgs e)
        {
            cboLuot.DataSource = s.LayPhieuDangO();
            cboLuot.DisplayMember = "SoPhieuDat";
            cboLuot.ValueMember = "SoPhieuDat";

            cboDV.DataSource = s.LayDichVu();
            cboDV.DisplayMember = "TenDV";
            cboDV.ValueMember = "MaDV";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "MaNV";

            Tai();
        }

        void Tai()
        {
            if (cboLuot.SelectedValue != null)
            {
                dgvLichSu.DataSource = s.LayLichSu(cboLuot.SelectedValue.ToString() ?? "");
            }
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString() ?? "";
        }

        private void cboLuot_SelectedIndexChanged(object? a, EventArgs e)
        {
            if (cboLuot.SelectedItem is DataRowView r)
            {
                txtPhong.Text = Convert.ToString(r["SoPhong"]);
            }
            Tai();
        }

        private void btnGhi_Click(object? a, EventArgs e)
        {
            var k = s.GhiNhan(V(cboLuot), txtPhong.Text.Trim(), dtNgay.Value, V(cboNV), V(cboDV), (int)numSL.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnDong_Click(object? a, EventArgs e) => Close();
    }
}