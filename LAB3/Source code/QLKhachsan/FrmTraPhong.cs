using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QLKhachsan.Services;

namespace QLKhachsan.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<DenBuItem> db = new BindingList<DenBuItem>();

        public FrmTraPhong()
        {
            InitializeComponent();
            this.Load += Frm_Load;

            dgvPhong.SelectionChanged += dgvPhong_SelectionChanged;
            btnThemDB.Click += btnThemDB_Click;
            btnLapDB.Click += btnLapDB_Click;
            btnLapHD.Click += btnLapHD_Click;
            dgvHD.SelectionChanged += dgvHD_SelectionChanged;
            btnThanhToan.Click += btnThanhToan_Click;
            btnTraPhong.Click += btnTraPhong_Click;
            btnDong.Click += btnDong_Click;
        }

        private void Frm_Load(object? a, EventArgs e)
        {
            cboDat.DataSource = s.LayPhieuDangO();
            cboDat.DisplayMember = "SoPhieuDat";
            cboDat.ValueMember = "SoPhieuDat";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "MaNV";

            cboNV2.DataSource = dm.LayNhanVien();
            cboNV2.DisplayMember = "TenNV";
            cboNV2.ValueMember = "MaNV";

            cboHT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ", "Ví điện tử" });
            cboHT.SelectedIndex = 0;

            dgvDBChon.DataSource = db;
            Tai();
        }

        string V(ComboBox c) => c.SelectedValue == null ? "" : c.SelectedValue.ToString() ?? "";

        void Tai()
        {
            if (cboDat.SelectedValue != null)
            {
                string so = V(cboDat);
                dgvPhong.DataSource = s.LayPhongTheoPhieu(so);
            }
            dgvHD.DataSource = s.LayHoaDon();
        }

        private void dgvPhong_SelectionChanged(object? a, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            txtPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value) ?? "";
            dgvTN.DataSource = s.LayTienNghiPhong(txtPhong.Text);
        }

        private void btnThemDB_Click(object? a, EventArgs e)
        {
            if (dgvTN.CurrentRow == null) return;
            string ma = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value) ?? "";
            string ten = Convert.ToString(dgvTN.CurrentRow.Cells["TenLoaiTN"].Value) ?? "";

            foreach (var x in db)
            {
                if (x.MaTienNghi == ma)
                {
                    MessageBox.Show("Tiện nghi đã có trong phiếu đền bù.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            db.Add(new DenBuItem { MaTienNghi = ma, TenLoaiTN = ten, MucDoThietHai = txtMucDo.Text.Trim(), SoTien = numDenBu.Value });
        }

        private void btnLapDB_Click(object? a, EventArgs e)
        {
            var k = s.LapPhieuDenBu(txtSoDB.Text.Trim(), V(cboDat), txtPhong.Text.Trim(), DateTime.Now, V(cboNV), new List<DenBuItem>(db));
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) db.Clear();
        }

        private void btnLapHD_Click(object? a, EventArgs e)
        {
            var k = s.LapHoaDon(txtSoHD.Text.Trim(), V(cboDat), DateTime.Now, V(cboNV2), (int)numSoNgay.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void dgvHD_SelectionChanged(object? a, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
                txtHDChon.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value) ?? "";
        }

        private void btnThanhToan_Click(object? a, EventArgs e)
        {
            var k = s.ThanhToan(txtMaTT.Text.Trim(), txtHDChon.Text.Trim(), DateTime.Now, cboHT.Text, numTienTT.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void btnTraPhong_Click(object? a, EventArgs e)
        {
            var k = s.TraPhong(V(cboDat), DateTime.Now);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void btnDong_Click(object? a, EventArgs e) => Close();
    }
}