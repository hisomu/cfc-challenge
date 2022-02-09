using CountryService.Data;
using CountryService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryService.Business
{
	public class CityBusiness : ICityBusiness
	{
		private readonly ICityRepository _repo;

		/// <summary>
		/// Initializes a new instance of the <see cref="CityBusiness"/> class.
		/// </summary>
		/// <param name="cityRepository">Data repository of cities.</param>
		public CityBusiness(ICityRepository cityRepository)
		{
			_repo = cityRepository;
		}

		/// <inheritdoc/>
		public async Task<List<City>> GetAll()
		{
			var cities = await _repo.GetAll();

			return cities.OrderBy(c => c.Municipality).ToList();
		}

		/// <inheritdoc/>
		public async Task<List<City>> GetAllByProvince(string province)
		{
			var cities = await _repo.GetAll();

			return cities.Where(c => c.Province.ToLower() == province.ToLower()).OrderBy(c => c.Municipality).ToList();
		}
	}
}
