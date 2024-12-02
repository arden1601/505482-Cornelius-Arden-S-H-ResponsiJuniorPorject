using Npgsql;

namespace Responsi_Junpro
{
    public partial class Form1 : Form
    {
        private Karyawan emp;
        private KaryawanTable emp_table;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emp_table.Load();
        }
    }
}
