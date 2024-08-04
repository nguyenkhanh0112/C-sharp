namespace WinFormsApp123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void dbConnect()
        {
            String StrCon = @"Data Source=DESKTOP-PKDF6GS\SQLEXPRESS;Initial Catalog=Thong_Tin_Sinh_Vien;Integrated Security=True";
        }
        private void btnclick_Click(object sender, EventArgs e)
        {
            String ten =txtTen.Text.Trim();
            String masv = txtMSV.Text.Trim();
            String diachi = txtDiaChi.Text.Trim();
            int phone = Int32.Parse(txtSDT.Text.Trim());
            
        }
    }
}