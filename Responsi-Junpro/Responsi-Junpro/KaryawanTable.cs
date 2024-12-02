using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql; 

namespace Responsi_Junpro
{
    internal class KaryawanTable : Karyawan
    {
        private static NpgsqlConnection conn;
        private string connstring= String.Format("Host=localhost;Port=5432;Username=postgres;Password='2Matasaya_';Database=ListofName");
        private static DataTable dt;
        private static NpgsqlCommand cmd;
        private DataGridView dgvData;
        private DataGridViewRow r;

        public DataGridViewRow Row { set { r = value; } }
        public KaryawanTable(DataGridView _dgvData)
        {
            dgvData = _dgvData;
        }
        public void Load()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                dt = new DataTable();
                string sql = "SELECT * from karyawan_select()";
                cmd = new NpgsqlCommand(sql, conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            finally { conn.Close(); }
        }
        public void Insert(TextBox tbNama, ComboBox cbDep, Button btnLoad)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                string sql = @"SELECT * from karyawan_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.Text);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan");
                    conn.Close();
                    tbNama.Text = null;
                    cbDep.Text = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }
        public void Delete(TextBox tbNama)
    }
}
