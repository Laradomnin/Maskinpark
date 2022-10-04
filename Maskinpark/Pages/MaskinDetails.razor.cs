using Maskinpark.Shared;
using Microsoft.AspNetCore.Components;

namespace Maskinpark.Pages
{
    public partial class MaskinDetails
	{
        [Parameter]
		public string MaskinId { get; set; }
		public	Maskin Maskin { get; set; }= new Maskin();

		public IEnumerable<Maskin> Maskiner { get; set; } = new List<Maskin>();
		public List<Verkstad> Verksteder { get; set; } = new List<Verkstad>();
		private List<Kategori> Kategorier { get; set; } = new List<Kategori>();

		protected override Task OnInitializedAsync()
		{
			InitMaskin();
			InitKategori();
			InitVerkstad();
			Maskin = Maskiner.FirstOrDefault(m => m.MaskinId == int.Parse(MaskinId));

			return base.OnInitializedAsync();
		}
		private void InitKategori()
		{
			Kategorier = new List<Kategori>()
			{
				new Kategori { KategoriId = 1, KategoriNamn = "Svets" },
				new Kategori { KategoriId = 2, KategoriNamn = "Bygg" },
				new Kategori { KategoriId = 3, KategoriNamn = "Tryckar" },
				new Kategori { KategoriId = 4, KategoriNamn = "Städmaskiner" },

			};
		}
		private void InitVerkstad()
		{
			Verksteder = new List<Verkstad>()
			{
				new Verkstad { VerkstadId = 1, VerkstadNamn = "BLG22" },
				new Verkstad { VerkstadId = 2, VerkstadNamn = "NOK33" },
				new Verkstad { VerkstadId = 3, VerkstadNamn = "BUS44" },
				new Verkstad { VerkstadId = 4, VerkstadNamn = "BLL55" },
			};
		}

		private void InitMaskin()
		{
			var m1 = new Maskin
			{
				VerkstadId = 1,
				Status = Status.Oneline,
				Märke = "Electrolux",
				MaskinId = 1,
				Namn = "Maskin1",
				KategoriId = 1,


			};

			var m2 = new Maskin
			{
				VerkstadId = 2,
				Status = Status.Ofline,
				Märke = "Scania",
				MaskinId = 2,
				Namn = "Maskin2",
				KategoriId = 2,
			};

			Maskiner = new List<Maskin> { m1, m2 };

		}
	}
}


