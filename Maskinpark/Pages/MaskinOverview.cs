

namespace Maskinpark.Pages
{
    public partial class MaskinOverview
    {
        public IEnumerable <Maskin> Maskiner { get; set; }
        public List<Verkstad> Verksteder { get; set; }
		private List<Kategori> Kategorier { get; set; }

		private void InitKategorier()
		{
			Kategorier = new List<Kategoti>()
			{
				new Kategoti { KategoriId = 1, KategoriNamn = "Svets" },
				new Kategoti { KategoriId = 2, KategoriNamn = "Bygg" },
				new Kategoti { KategoriId = 3, KategoriNamn = "Tryckar" },
				new Kategoti { KategoriId = 4, KategoriNamn = "Städmaskiner" },

			};
		}
		private void InitVerkstad()
		{
			Verksteder = new List<Verkstad>
			{
				new Verkstad { VerkstadId = 1, VerkstadNamn = "BLG22" },
				new Verkstad { VerkstadId = 2, VerkstadNamn = "NOK33" },
				new Verkstad { VerkstadId = 3, VerkstadNamn = "BUS44" },
				new Verkstad { VerkstadId = 4, VerkstadNamn = "BLL55" },
			};
		}

		private void InitMaskiner()
		{
			var m1 = new Maskin
			{
				VerkstadId = 1,
				Status = Status.online,	
				Märke = "Electrolux",
				MaskinId = 1,
				Namn = "Maskin1",
				KategoriId = 1,


			}
