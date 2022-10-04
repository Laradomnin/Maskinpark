using System;

namespace Maskinpark.Shared
{
    public class Maskin  
    {
        public int MaskinId { get; set; }
        public string Namn { get; set; }
        public string Märke { get; set; }
       
        public int VerkstadId { get; set; }
        public Verkstad Verkstad { get; set; }
   
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public Status Status { get; set; }

    }
}
