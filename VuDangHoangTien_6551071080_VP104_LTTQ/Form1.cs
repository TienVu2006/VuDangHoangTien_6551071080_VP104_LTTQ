using Microsoft.Data.SqlClient;
using System.Data;

namespace VuDangHoangTien_6551071080_VP104_LTTQ
{
    public partial class Form1 : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=DuLieu_NhanSu;Integrated Security=True;TrustServerCertificate=True";
        DataTable LayBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        void ChayLenh(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                new SqlCommand(sql, conn).ExecuteNonQuery();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = LayBang("SELECT * FROM NhanVien");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void txtLuongCoBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtLuongCoBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            DataTable dtCheck = LayBang($"SELECT * FROM NhanVien WHERE MaNhanVien = '{txtMaNV.Text.Trim()}'");
            if (dtCheck.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại");
                txtMaNV.Focus();
                return;
            }
            ChayLenh($"INSERT INTO NhanVien VALUES('{txtMaNV.Text.Trim()}', N'{txtTenNV.Text.Trim()}', '{txtLuongCoBan.Text.Trim()}')");
            dgvNhanVien.DataSource = LayBang("SELECT * FROM NhanVien");
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuongCoBan.Clear();
            btnThem.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChayLenh($"UPDATE NhanVien SET TenNhanVien = N'{txtTenNV.Text.Trim()}', LuongCoBan = '{txtLuongCoBan.Text.Trim()}' WHERE MaNhanVien = '{txtMaNV.Text.Trim()}'");
            dgvNhanVien.DataSource = LayBang("SELECT * FROM NhanVien");
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuongCoBan.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ChayLenh($"DELETE FROM NhanVien WHERE MaNhanVien = '{txtMaNV.Text.Trim()}'");
                dgvNhanVien.DataSource = LayBang("SELECT * FROM NhanVien");
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtLuongCoBan.Clear();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtLuongCoBan.Text = row.Cells[2].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
    }
}
