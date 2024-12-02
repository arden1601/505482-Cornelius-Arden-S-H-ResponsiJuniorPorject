using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_Junpro
{
    public class Karyawan
    {
        private string nama;
        private string id;
        private string departemen;
        private string id_dep;

        public string Nama { get { return nama; } set { nama = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Id_Dep { get { return id_dep; } set { id_dep = value; } }
        public string Departemen { get { return departemen; } set { departemen = value; } }

    }
}
