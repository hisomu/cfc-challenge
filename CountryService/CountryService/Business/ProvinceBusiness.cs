using CountryService.Data;
using CountryService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Business
{
	public class ProvinceBusiness : IProvinceBusiness
	{
		private readonly IProvinceRepository _repo;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProvinceBusiness"/> class.
		/// </summary>
		/// <param name="provinceRepository">Data repository of provinces.</param>
		public ProvinceBusiness(IProvinceRepository provinceRepository)
		{
			_repo = provinceRepository;
		}

		/// <inheritdoc/>
		public async Task<List<Province>> GetAll()
		{
			return await _repo.GetAll();
		}
	}
}
