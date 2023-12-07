using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            List<tbl_SinhVien> dssv = new List<tbl_SinhVien>();
            dssv = db.tbl_SinhViens.ToList();
            SinhVien_dgv.DataSource = dssv;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            Sua_btn.Enabled = false;
            Xoa_btn.Enabled = false;
            Clear_btn.Enabled = false;
        }
        private void Them_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MSSV_txt.Text==""||HoTen_txt.Text=="")
                {
                    MessageBox.Show("Không được để trống MSSV, Họ tên!");
                }
                else
                {
                    tbl_SinhVien newObj = new tbl_SinhVien();
                    newObj.MSSV = MSSV_txt.Text;
                    newObj.HoTen = HoTen_txt.Text;
                    newObj.GioiTinh = GioiTinh_txt.Text;
                    newObj.DiaChi = DiaChi_txt.Text;
                    newObj.Email = Email_txt.Text;
                    newObj.SDT = SDT_txt.Text;
                    newObj.NgaySinh = Convert.ToString(NgaySinh_dtp.Value);
                    db.tbl_SinhViens.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm mới sinh viên thành công!");
                    LoadData();
                }
            }
            catch (Exception)
            {
                if (db.GetChangeSet().Inserts.Count() > 0)
                {
                    foreach(tbl_SinhVien item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_SinhViens.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm mới sinh viên KHÔNG thành công!");
            }
            
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_SinhVien editObj = db.tbl_SinhViens.Where(o => o.MSSV.Equals(MSSV_txt.Text)).FirstOrDefault();
                editObj.MSSV = MSSV_txt.Text;
                editObj.HoTen = HoTen_txt.Text;
                editObj.GioiTinh = GioiTinh_txt.Text;
                editObj.DiaChi = DiaChi_txt.Text;
                editObj.Email = Email_txt.Text;
                editObj.SDT = SDT_txt.Text;
                editObj.NgaySinh = Convert.ToString(NgaySinh_dtp.Value);
                db.SubmitChanges();
                MessageBox.Show("Sưa thông tin sinh viên thành công!");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin sinh viên KHÔNG thành công!");
            }
        }

        private void SinhVien_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MSSV_txt.ReadOnly = true;  
                DataGridViewRow row = SinhVien_dgv.Rows[e.RowIndex];
                MSSV_txt.Text = row.Cells[0].Value.ToString();
                HoTen_txt.Text = row.Cells[1].Value.ToString();
                GioiTinh_txt.Text = row.Cells[2].Value.ToString();
                NgaySinh_dtp.Text = row.Cells[3].Value.ToString();
                SDT_txt.Text = row.Cells[4].Value.ToString();
                DiaChi_txt.Text = row.Cells[5].Value.ToString();
                Email_txt.Text = row.Cells[6].Value.ToString();
                Them_btn.Enabled = false;
                Sua_btn.Enabled = true;
                Xoa_btn.Enabled = true;
            }
        }

        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_SinhVien delObj = db.tbl_SinhViens.Where(o => o.MSSV.Equals(MSSV_txt.Text)).FirstOrDefault();
                db.tbl_SinhViens.DeleteOnSubmit(delObj);
                db.SubmitChanges();
                MessageBox.Show("Xóa sinh viên thành công!");
                LoadData();
                Clear_btn_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin sinh viên KHÔNG thành công!");
            }
        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            MSSV_txt.ReadOnly = false;
            MSSV_txt.Text = "";
            HoTen_txt.Text = "";
            GioiTinh_txt.Text = "";
            NgaySinh_dtp.Text = "";
            SDT_txt.Text = "";
            DiaChi_txt.Text = "";
            Email_txt.Text = "";
            Them_btn.Enabled = true;
            Sua_btn.Enabled = false;
            Xoa_btn.Enabled = false;
        }

        private void SinhVien_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
