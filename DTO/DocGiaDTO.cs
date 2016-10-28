using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGiaDTO
    {
        public int maDocGia { get; set; }
        public string tenDocGia { get; set; }
        public DateTime ngaySinh { get; set; }

        public int cmnd { get; set; }

        public bool hide { get; set; }
    }
}
