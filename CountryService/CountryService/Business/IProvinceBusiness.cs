using CountryService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Business
{
	public interface IProvinceBusiness
	{
		/// <summary>
		/// Gets a list of canadian provinces.
		/// </summary>
		/// <returns>List of provinces.</returns>
		Task<List<Province>> GetAll();
	}
}
