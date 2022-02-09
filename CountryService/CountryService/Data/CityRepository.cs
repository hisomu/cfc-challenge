﻿using CountryService.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Data
{
	public class CityRepository : ICityRepository
	{
		/// <inheritdoc/>
		public async Task<List<City>> GetAll()
		{
			return JsonConvert.DeserializeObject<List<City>>(cityJSON());
		}

		// data of cities.json
		private string cityJSON()
		{
			return @"[
			  {
				'Municipality': 'Toronto',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '630.2',
				'Population(2016)': '2,731,571',
				'Population(2011)': '2,615,060',
				'Population(2006)': '2,503,281',
				'Population(2001)': '2,481,494',
				'Population(1996)': '2,385,421'
			  },
			  {
				'Municipality': 'Montreal',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '365.1',
				'Population(2016)': '1,704,694',
				'Population(2011)': '1,649,519',
				'Population(2006)': '1,620,693',
				'Population(2001)': '1,583,590',
				'Population(1996)': '1,547,030'
			  },
			  {
				'Municipality': 'Calgary',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '825.3',
				'Population(2016)': '1,239,220',
				'Population(2011)': '1,096,833',
				'Population(2006)': '988,193',
				'Population(2001)': '879,003',
				'Population(1996)': '768,082'
			  },
			  {
				'Municipality': 'Ottawa',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '2,790.2',
				'Population(2016)': '934,243',
				'Population(2011)': '883,391',
				'Population(2006)': '812,129',
				'Population(2001)': '774,072',
				'Population(1996)': '721,136'
			  },
			  {
				'Municipality': 'Edmonton',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '684.4',
				'Population(2016)': '932,546',
				'Population(2011)': '812,201',
				'Population(2006)': '730,372',
				'Population(2001)': '666,104',
				'Population(1996)': '616,306'
			  },
			  {
				'Municipality': 'Mississauga',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '292.4',
				'Population(2016)': '721,599',
				'Population(2011)': '713,443',
				'Population(2006)': '668,549',
				'Population(2001)': '612,925',
				'Population(1996)': '544,382'
			  },
			  {
				'Municipality': 'Winnipeg',
				'Province': 'Manitoba',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '464.1',
				'Population(2016)': '705,224',
				'Population(2011)': '663,617',
				'Population(2006)': '633,451',
				'Population(2001)': '619,544',
				'Population(1996)': '618,477'
			  },
			  {
				'Municipality': 'Vancouver',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '115.0',
				'Population(2016)': '631,486',
				'Population(2011)': '603,502',
				'Population(2006)': '578,041',
				'Population(2001)': '545,671',
				'Population(1996)': '514,008'
			  },
			  {
				'Municipality': 'Brampton',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '266.3',
				'Population(2016)': '593,638',
				'Population(2011)': '523,911',
				'Population(2006)': '433,806',
				'Population(2001)': '325,428',
				'Population(1996)': '268,251'
			  },
			  {
				'Municipality': 'Hamilton',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '1,117.2',
				'Population(2016)': '536,917',
				'Population(2011)': '519,949',
				'Population(2006)': '504,559',
				'Population(2001)': '490,268',
				'Population(1996)': '467,799'
			  },
			  {
				'Municipality': 'Quebec City',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '454.1',
				'Population(2016)': '531,902',
				'Population(2011)': '516,622',
				'Population(2006)': '491,142',
				'Population(2001)': '476,330',
				'Population(1996)': '473,569'
			  },
			  {
				'Municipality': 'Surrey',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '316.4',
				'Population(2016)': '517,887',
				'Population(2011)': '468,251',
				'Population(2006)': '394,976',
				'Population(2001)': '347,820',
				'Population(1996)': '304,477'
			  },
			  {
				'Municipality': 'Laval',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '247.1',
				'Population(2016)': '422,993',
				'Population(2011)': '401,553',
				'Population(2006)': '368,709',
				'Population(2001)': '343,005',
				'Population(1996)': '330,393'
			  },
			  {
				'Municipality': 'Halifax',
				'Province': 'Nova Scotia',
				'Municipal status': 'Regional municipality',
				'Land area(km2, 2011)': '5,490.3',
				'Population(2016)': '403,131',
				'Population(2011)': '390,096',
				'Population(2006)': '372,679',
				'Population(2001)': '359,111',
				'Population(1996)': '342,851'
			  },
			  {
				'Municipality': 'London',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '420.6',
				'Population(2016)': '383,822',
				'Population(2011)': '366,151',
				'Population(2006)': '352,395',
				'Population(2001)': '336,539',
				'Population(1996)': '325,669'
			  },
			  {
				'Municipality': 'Markham',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '212.6',
				'Population(2016)': '328,966',
				'Population(2011)': '301,709',
				'Population(2006)': '261,573',
				'Population(2001)': '208,615',
				'Population(1996)': '173,383'
			  },
			  {
				'Municipality': 'Vaughan',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '273.5',
				'Population(2016)': '306,233',
				'Population(2011)': '288,301',
				'Population(2006)': '238,866',
				'Population(2001)': '182,022',
				'Population(1996)': '132,549'
			  },
			  {
				'Municipality': 'Gatineau',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '343.0',
				'Population(2016)': '276,245',
				'Population(2011)': '265,349',
				'Population(2006)': '242,124',
				'Population(2001)': '226,696',
				'Population(1996)': '217,591'
			  },
			  {
				'Municipality': 'Saskatoon',
				'Province': 'Saskatchewan',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '209.6',
				'Population(2016)': '246,376',
				'Population(2011)': '222,189',
				'Population(2006)': '202,340',
				'Population(2001)': '196,861',
				'Population(1996)': '193,653'
			  },
			  {
				'Municipality': 'Longueuil',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '115.6',
				'Population(2016)': '239,700',
				'Population(2011)': '231,409',
				'Population(2006)': '229,330',
				'Population(2001)': '225,761',
				'Population(1996)': '227,408'
			  },
			  {
				'Municipality': 'Kitchener',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '136.8',
				'Population(2016)': '233,222',
				'Population(2011)': '219,153',
				'Population(2006)': '204,668',
				'Population(2001)': '190,399',
				'Population(1996)': '178,420'
			  },
			  {
				'Municipality': 'Burnaby',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '90.6',
				'Population(2016)': '232,755',
				'Population(2011)': '223,218',
				'Population(2006)': '202,799',
				'Population(2001)': '193,954',
				'Population(1996)': '179,209'
			  },
			  {
				'Municipality': 'Windsor',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '146.3',
				'Population(2016)': '217,188',
				'Population(2011)': '210,891',
				'Population(2006)': '216,473',
				'Population(2001)': '209,218',
				'Population(1996)': '197,694'
			  },
			  {
				'Municipality': 'Regina',
				'Province': 'Saskatchewan',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '179.97',
				'Population(2016)': '215,106',
				'Population(2011)': '193,100',
				'Population(2006)': '179,246',
				'Population(2001)': '178,225',
				'Population(1996)': '180,404'
			  },
			  {
				'Municipality': 'Richmond',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '129.3',
				'Population(2016)': '198,309',
				'Population(2011)': '190,473',
				'Population(2006)': '174,461',
				'Population(2001)': '164,345',
				'Population(1996)': '148,867'
			  },
			  {
				'Municipality': 'Richmond Hill',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '101.0',
				'Population(2016)': '195,022',
				'Population(2011)': '185,541',
				'Population(2006)': '162,704',
				'Population(2001)': '132,030',
				'Population(1996)': '101,725'
			  },
			  {
				'Municipality': 'Oakville',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '138.9',
				'Population(2016)': '193,832',
				'Population(2011)': '182,520',
				'Population(2006)': '165,613',
				'Population(2001)': '144,738',
				'Population(1996)': '128,405'
			  },
			  {
				'Municipality': 'Burlington',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '185.7',
				'Population(2016)': '183,314',
				'Population(2011)': '175,779',
				'Population(2006)': '164,415',
				'Population(2001)': '150,836',
				'Population(1996)': '136,976'
			  },
			  {
				'Municipality': 'Greater Sudbury',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '3,227.4',
				'Population(2016)': '161,531',
				'Population(2011)': '160,274',
				'Population(2006)': '157,857',
				'Population(2001)': '155,219',
				'Population(1996)': '165,336'
			  },
			  {
				'Municipality': 'Sherbrooke',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '353.5',
				'Population(2016)': '161,323',
				'Population(2011)': '154,601',
				'Population(2006)': '147,427',
				'Population(2001)': '138,785',
				'Population(1996)': '136,883'
			  },
			  {
				'Municipality': 'Oshawa',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '145.7',
				'Population(2016)': '159,458',
				'Population(2011)': '149,607',
				'Population(2006)': '141,590',
				'Population(2001)': '139,051',
				'Population(1996)': '134,464'
			  },
			  {
				'Municipality': 'Saguenay',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '1,126.5',
				'Population(2016)': '145,949',
				'Population(2011)': '144,746',
				'Population(2006)': '143,692',
				'Population(2001)': '147,133',
				'Population(1996)': '152,811'
			  },
			  {
				'Municipality': 'Lévis',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '449.3',
				'Population(2016)': '143,414',
				'Population(2011)': '138,769',
				'Population(2006)': '130,006',
				'Population(2001)': '121,999',
				'Population(1996)': '103,750'
			  },
			  {
				'Municipality': 'Barrie',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '77.4',
				'Population(2016)': '141,434',
				'Population(2011)': '135,711',
				'Population(2006)': '128,430',
				'Population(2001)': '103,710',
				'Population(1996)': '79,191'
			  },
			  {
				'Municipality': 'Abbotsford',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '375.6',
				'Population(2016)': '141,397',
				'Population(2011)': '133,497',
				'Population(2006)': '123,864',
				'Population(2001)': '115,494',
				'Population(1996)': '105,403'
			  },
			  {
				'Municipality': 'Coquitlam',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '122.3',
				'Population(2016)': '139,284',
				'Population(2011)': '126,456',
				'Population(2006)': '114,565',
				'Population(2001)': '112,890',
				'Population(1996)': '101,820'
			  },
			  {
				'Municipality': 'Trois-Rivières',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '288.9',
				'Population(2016)': '134,413',
				'Population(2011)': '131,338',
				'Population(2006)': '126,323',
				'Population(2001)': '122,395',
				'Population(1996)': '124,417'
			  },
			  {
				'Municipality': 'St. Catharines',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '96.1',
				'Population(2016)': '133,113',
				'Population(2011)': '131,400',
				'Population(2006)': '131,989',
				'Population(2001)': '129,170',
				'Population(1996)': '130,926'
			  },
			  {
				'Municipality': 'Guelph',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '87.2',
				'Population(2016)': '131,794',
				'Population(2011)': '121,688',
				'Population(2006)': '114,943',
				'Population(2001)': '106,170',
				'Population(1996)': '95,821'
			  },
			  {
				'Municipality': 'Cambridge',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '113.0',
				'Population(2016)': '129,920',
				'Population(2011)': '126,748',
				'Population(2006)': '120,371',
				'Population(2001)': '110,372',
				'Population(1996)': '101,429'
			  },
			  {
				'Municipality': 'Whitby',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '146.5',
				'Population(2016)': '128,377',
				'Population(2011)': '122,022',
				'Population(2006)': '111,184',
				'Population(2001)': '87,413',
				'Population(1996)': '73,794'
			  },
			  {
				'Municipality': 'Kelowna',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '211.6',
				'Population(2016)': '127,380',
				'Population(2011)': '117,312',
				'Population(2006)': '106,707',
				'Population(2001)': '96,288',
				'Population(1996)': '89,442'
			  },
			  {
				'Municipality': 'Kingston',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '451.2',
				'Population(2016)': '123,798',
				'Population(2011)': '123,363',
				'Population(2006)': '117,207',
				'Population(2001)': '114,195',
				'Population(1996)': '112,605'
			  },
			  {
				'Municipality': 'Ajax',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '67.1',
				'Population(2016)': '119,677',
				'Population(2011)': '109,600',
				'Population(2006)': '90,167',
				'Population(2001)': '73,753',
				'Population(1996)': '64,430'
			  },
			  {
				'Municipality': 'Langley',
				'Province': 'British Columbia',
				'Municipal status': 'District municipality',
				'Land area(km2, 2011)': '308.0',
				'Population(2016)': '117,285',
				'Population(2011)': '104,177',
				'Population(2006)': '93,726',
				'Population(2001)': '86,896',
				'Population(1996)': '80,179'
			  },
			  {
				'Municipality': 'Saanich',
				'Province': 'British Columbia',
				'Municipal status': 'District municipality',
				'Land area(km2, 2011)': '103.8',
				'Population(2016)': '114,148',
				'Population(2011)': '109,752',
				'Population(2006)': '108,265',
				'Population(2001)': '103,654',
				'Population(1996)': '101,388'
			  },
			  {
				'Municipality': 'Terrebonne',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '154.7',
				'Population(2016)': '111,575',
				'Population(2011)': '106,322',
				'Population(2006)': '94,703',
				'Population(2001)': '80,536',
				'Population(1996)': '75,116'
			  },
			  {
				'Municipality': 'Milton',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '363.2',
				'Population(2016)': '110,128',
				'Population(2011)': '84,362',
				'Population(2006)': '53,939',
				'Population(2001)': '31,471',
				'Population(1996)': '32,104'
			  },
			  {
				'Municipality': 'St. Johns',
				'Province': 'Newfoundland and Labrador',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '446.0',
				'Population(2016)': '108,860',
				'Population(2011)': '106,172',
				'Population(2006)': '100,646',
				'Population(2001)': '99,182',
				'Population(1996)': '101,936'
			  },
			  {
				'Municipality': 'Thunder Bay',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '328.2',
				'Population(2016)': '107,909',
				'Population(2011)': '108,359',
				'Population(2006)': '109,140',
				'Population(2001)': '109,016',
				'Population(1996)': '113,662'
			  },
			  {
				'Municipality': 'Waterloo',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '64.0',
				'Population(2016)': '104,986',
				'Population(2011)': '98,780',
				'Population(2006)': '97,475',
				'Population(2001)': '86,543',
				'Population(1996)': '77,949'
			  },
			  {
				'Municipality': 'Delta',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '180.1',
				'Population(2016)': '102,238',
				'Population(2011)': '99,863',
				'Population(2006)': '96,723',
				'Population(2001)': '96,950',
				'Population(1996)': '95,411'
			  },
			  {
				'Municipality': 'Chatham-Kent',
				'Province': 'Ontario',
				'Municipal status': 'Municipality',
				'Land area(km2, 2011)': '2,458.1',
				'Population(2016)': '101,647',
				'Population(2011)': '103,671',
				'Population(2006)': '108,177',
				'Population(2001)': '107,341',
				'Population(1996)': '109,950'
			  },
			  {
				'Municipality': 'Red Deer',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '104.3',
				'Population(2016)': '100,418',
				'Population(2011)': '90,564',
				'Population(2006)': '82,772',
				'Population(2001)': '67,829',
				'Population(1996)': '60,080'
			  },
			  {
				'Municipality': 'Strathcona County',
				'Province': 'Alberta',
				'Municipal status': 'Specialized municipality',
				'Land area(km2, 2011)': '1,180.6',
				'Population(2016)': '98,044',
				'Population(2011)': '92,490',
				'Population(2006)': '82,511',
				'Population(2001)': '71,986',
				'Population(1996)': '64,176'
			  },
			  {
				'Municipality': 'Brantford',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '72.5',
				'Population(2016)': '97,496',
				'Population(2011)': '93,650',
				'Population(2006)': '90,192',
				'Population(2001)': '86,417',
				'Population(1996)': '86,417'
			  },
			  {
				'Municipality': 'Saint-Jean-sur-Richelieu',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '225.8',
				'Population(2016)': '95,114',
				'Population(2011)': '92,394',
				'Population(2006)': '87,492',
				'Population(2001)': '79,600',
				'Population(1996)': '76,461'
			  },
			  {
				'Municipality': 'Cape Breton',
				'Province': 'Nova Scotia',
				'Municipal status': 'Regional municipality',
				'Land area(km2, 2011)': '2,433.4',
				'Population(2016)': '94,285',
				'Population(2011)': '97,398',
				'Population(2006)': '102,250',
				'Population(2001)': '105,968',
				'Population(1996)': '114,733'
			  },
			  {
				'Municipality': 'Lethbridge',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '122.4',
				'Population(2016)': '92,729',
				'Population(2011)': '83,517',
				'Population(2006)': '74,637',
				'Population(2001)': '67,374',
				'Population(1996)': '63,053'
			  },
			  {
				'Municipality': 'Clarington',
				'Province': 'Ontario',
				'Municipal status': 'Municipality',
				'Land area(km2, 2011)': '611.3',
				'Population(2016)': '92,013',
				'Population(2011)': '84,548',
				'Population(2006)': '77,820',
				'Population(2001)': '69,834',
				'Population(1996)': '60,615'
			  },
			  {
				'Municipality': 'Pickering',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '231.6',
				'Population(2016)': '91,771',
				'Population(2011)': '88,721',
				'Population(2006)': '87,838',
				'Population(2001)': '87,139',
				'Population(1996)': '78,989'
			  },
			  {
				'Municipality': 'Nanaimo',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '91.3',
				'Population(2016)': '90,504',
				'Population(2011)': '83,810',
				'Population(2006)': '78,692',
				'Population(2001)': '73,000',
				'Population(1996)': '70,130'
			  },
			  {
				'Municipality': 'Kamloops',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '299.2',
				'Population(2016)': '90,280',
				'Population(2011)': '85,678',
				'Population(2006)': '80,376',
				'Population(2001)': '77,281',
				'Population(1996)': '76,394'
			  },
			  {
				'Municipality': 'Niagara Falls',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '209.7',
				'Population(2016)': '88,071',
				'Population(2011)': '82,997',
				'Population(2006)': '82,184',
				'Population(2001)': '78,815',
				'Population(1996)': '76,917'
			  },
			  {
				'Municipality': 'North Vancouver',
				'Province': 'British Columbia',
				'Municipal status': 'District municipality',
				'Land area(km2, 2011)': '160.8',
				'Population(2016)': '85,935',
				'Population(2011)': '84,412',
				'Population(2006)': '82,562',
				'Population(2001)': '82,310',
				'Population(1996)': '80,418'
			  },
			  {
				'Municipality': 'Victoria',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '19.5',
				'Population(2016)': '85,792',
				'Population(2011)': '80,017',
				'Population(2006)': '78,057',
				'Population(2001)': '74,125',
				'Population(1996)': '73,405'
			  },
			  {
				'Municipality': 'Brossard',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '45.2',
				'Population(2016)': '85,721',
				'Population(2011)': '79,273',
				'Population(2006)': '71,154',
				'Population(2001)': '65,026',
				'Population(1996)': '65,927'
			  },
			  {
				'Municipality': 'Repentigny',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '61.8',
				'Population(2016)': '84,285',
				'Population(2011)': '82,000',
				'Population(2006)': '76,237',
				'Population(2001)': '72,218',
				'Population(1996)': '70,677'
			  },
			  {
				'Municipality': 'Newmarket',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '38.3',
				'Population(2016)': '84,224',
				'Population(2011)': '79,978',
				'Population(2006)': '74,295',
				'Population(2001)': '65,788',
				'Population(1996)': '57,125'
			  },
			  {
				'Municipality': 'Chilliwack',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '261.65',
				'Population(2016)': '83,788',
				'Population(2011)': '77,936',
				'Population(2006)': '69,217',
				'Population(2001)': '62,567',
				'Population(1996)': '60,186'
			  },
			  {
				'Municipality': 'Maple Ridge',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '266.8',
				'Population(2016)': '82,256',
				'Population(2011)': '76,052',
				'Population(2006)': '68,949',
				'Population(2001)': '63,169',
				'Population(1996)': '56,173'
			  },
			  {
				'Municipality': 'Peterborough',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '63.8',
				'Population(2016)': '81,032',
				'Population(2011)': '78,698',
				'Population(2006)': '74,898',
				'Population(2001)': '71,446',
				'Population(1996)': '69,742'
			  },
			  {
				'Municipality': 'Kawartha Lakes',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '3,083.1',
				'Population(2016)': '75,423',
				'Population(2011)': '73,219',
				'Population(2006)': '74,561',
				'Population(2001)': '69,179',
				'Population(1996)': '67,926'
			  },
			  {
				'Municipality': 'Drummondville',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '246.9',
				'Population(2016)': '75,423',
				'Population(2011)': '71,852',
				'Population(2006)': '67,392',
				'Population(2001)': '63,029',
				'Population(1996)': '58,588'
			  },
			  {
				'Municipality': 'Saint-Jérôme',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '90.5',
				'Population(2016)': '74,346',
				'Population(2011)': '68,456',
				'Population(2006)': '63,729',
				'Population(2001)': '59,614',
				'Population(1996)': '59,533'
			  },
			  {
				'Municipality': 'Prince George',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '318.3',
				'Population(2016)': '74,003',
				'Population(2011)': '71,974',
				'Population(2006)': '70,981',
				'Population(2001)': '72,406',
				'Population(1996)': '75,510'
			  },
			  {
				'Municipality': 'Sault Ste. Marie',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '223.3',
				'Population(2016)': '73,368',
				'Population(2011)': '75,141',
				'Population(2006)': '74,948',
				'Population(2001)': '74,566',
				'Population(1996)': '80,054'
			  },
			  {
				'Municipality': 'Moncton',
				'Province': 'New Brunswick',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '141.2',
				'Population(2016)': '71,889',
				'Population(2011)': '69,074',
				'Population(2006)': '64,128',
				'Population(2001)': '61,046',
				'Population(1996)': '59,313'
			  },
			  {
				'Municipality': 'Sarnia',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '164.7',
				'Population(2016)': '71,594',
				'Population(2011)': '72,366',
				'Population(2006)': '71,419',
				'Population(2001)': '70,876',
				'Population(1996)': '72,738'
			  },
			  {
				'Municipality': 'Wood Buffalo',
				'Province': 'Alberta',
				'Municipal status': 'Specialized municipality',
				'Land area(km2, 2011)': '63,637.5',
				'Population(2016)': '71,589',
				'Population(2011)': '65,565',
				'Population(2006)': '51,496',
				'Population(2001)': '41,445',
				'Population(1996)': '35,213'
			  },
			  {
				'Municipality': 'New Westminster',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '15.6',
				'Population(2016)': '70,996',
				'Population(2011)': '65,976',
				'Population(2006)': '58,549',
				'Population(2001)': '54,656',
				'Population(1996)': '49,350'
			  },
			  {
				'Municipality': 'Saint John',
				'Province': 'New Brunswick',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '315.8',
				'Population(2016)': '67,575',
				'Population(2011)': '70,063',
				'Population(2006)': '68,043',
				'Population(2001)': '69,661',
				'Population(1996)': '72,494'
			  },
			  {
				'Municipality': 'Caledon',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '688.2',
				'Population(2016)': '66,502',
				'Population(2011)': '59,460',
				'Population(2006)': '57,050',
				'Population(2001)': '50,605',
				'Population(1996)': '39,893'
			  },
			  {
				'Municipality': 'Granby',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '152.7',
				'Population(2016)': '66,222',
				'Population(2011)': '63,433',
				'Population(2006)': '47,637',
				'Population(2001)': '44,121',
				'Population(1996)': '43,316'
			  },
			  {
				'Municipality': 'St. Albert',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '48.3',
				'Population(2016)': '65,589',
				'Population(2011)': '61,466',
				'Population(2006)': '57,719',
				'Population(2001)': '53,081',
				'Population(1996)': '46,888'
			  },
			  {
				'Municipality': 'Norfolk County',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '1,607.6',
				'Population(2016)': '64,044',
				'Population(2011)': '63,175',
				'Population(2006)': '62,563',
				'Population(2001)': '60,847',
				'Population(1996)': '60,534'
			  },
			  {
				'Municipality': 'Medicine Hat',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '112.0',
				'Population(2016)': '63,260',
				'Population(2011)': '60,005',
				'Population(2006)': '56,997',
				'Population(2001)': '51,249',
				'Population(1996)': '46,783'
			  },
			  {
				'Municipality': 'Grande Prairie',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '72.8',
				'Population(2016)': '63,166',
				'Population(2011)': '55,655',
				'Population(2006)': '47,076',
				'Population(2001)': '36,983',
				'Population(1996)': '31,353'
			  },
			  {
				'Municipality': 'Airdrie',
				'Province': 'Alberta',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '84.57',
				'Population(2016)': '61,581',
				'Population(2011)': '43,271',
				'Population(2006)': '28,927',
				'Population(2001)': '20,407',
				'Population(1996)': '15,946'
			  },
			  {
				'Municipality': 'Halton Hills',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '276.3',
				'Population(2016)': '61,161',
				'Population(2011)': '59,013',
				'Population(2006)': '55,289',
				'Population(2001)': '48,184',
				'Population(1996)': '42,390'
			  },
			  {
				'Municipality': 'Port Coquitlam',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '29.2',
				'Population(2016)': '58,612',
				'Population(2011)': '55,958',
				'Population(2006)': '52,687',
				'Population(2001)': '51,257',
				'Population(1996)': '46,682'
			  },
			  {
				'Municipality': 'Fredericton',
				'Province': 'New Brunswick',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '131.7',
				'Population(2016)': '58,220',
				'Population(2011)': '56,224',
				'Population(2006)': '50,535',
				'Population(2001)': '47,580',
				'Population(1996)': '46,507'
			  },
			  {
				'Municipality': 'Blainville',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '55.1',
				'Population(2016)': '56,863',
				'Population(2011)': '53,510',
				'Population(2006)': '46,493',
				'Population(2001)': '36,029',
				'Population(1996)': '29,603'
			  },
			  {
				'Municipality': 'Saint-Hyacinthe',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '188.7',
				'Population(2016)': '55,648',
				'Population(2011)': '53,236',
				'Population(2006)': '51,616',
				'Population(2001)': '50,394',
				'Population(1996)': '50,027'
			  },
			  {
				'Municipality': 'Aurora',
				'Province': 'Ontario',
				'Municipal status': 'Town',
				'Land area(km2, 2011)': '49.8',
				'Population(2016)': '55,445',
				'Population(2011)': '53,203',
				'Population(2006)': '47,629',
				'Population(2001)': '40,167',
				'Population(1996)': '34,857'
			  },
			  {
				'Municipality': 'North Vancouver',
				'Province': 'British Columbia',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '11.8',
				'Population(2016)': '52,898',
				'Population(2011)': '48,196',
				'Population(2006)': '45,165',
				'Population(2001)': '44,303',
				'Population(1996)': '41,475'
			  },
			  {
				'Municipality': 'Welland',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '81.1',
				'Population(2016)': '52,293',
				'Population(2011)': '50,631',
				'Population(2006)': '50,331',
				'Population(2001)': '48,402',
				'Population(1996)': '48,411'
			  },
			  {
				'Municipality': 'North Bay',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '319.1',
				'Population(2016)': '51,553',
				'Population(2011)': '53,651',
				'Population(2006)': '53,966',
				'Population(2001)': '52,771',
				'Population(1996)': '54,332'
			  },
			  {
				'Municipality': 'Belleville',
				'Province': 'Ontario',
				'Municipal status': 'City',
				'Land area(km2, 2011)': '247.2',
				'Population(2016)': '50,716',
				'Population(2011)': '49,454',
				'Population(2006)': '48,821',
				'Population(2001)': '46,029',
				'Population(1996)': '46,195'
			  },
			  {
				'Municipality': 'Mirabel',
				'Province': 'Quebec',
				'Municipal status': 'Ville',
				'Land area(km2, 2011)': '485.07',
				'Population(2016)': '50,513',
				'Population(2011)': '41,957',
				'Population(2006)': '34,626',
				'Population(2001)': '27,315',
				'Population(1996)': '22,626'
			  }
			]";
		}
	}
}
