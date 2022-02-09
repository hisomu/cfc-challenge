using CountryService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Data
{
	public interface ICityRepository
	{
		/// <summary>
		/// Gets a list of canadian cities.
		/// </summary>
		/// <returns>List of cities.</returns>
		Task<List<City>> GetAll();
	}
}
