using CountryService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Business
{
    public interface ICityBusiness
    {
        /// <summary>
        /// Gets a list of canadian cities.
        /// </summary>
        /// <returns>List of cities sorted by name.</returns>
        Task<List<City>> GetAll();

        /// <summary>
        /// Gets a list of canadian cities filtered by province.
        /// </summary>
        /// <returns>List of cities sorted by name.</returns>
        Task<List<City>> GetAllByProvince(string province);
    }
}
