using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class Countries
    {
        public int CountryID;
        public string CountryName;
        public static DataTable GetAllCountries()
        {
            DataTable dt = CountryData.GetAllCountries();
            return dt;
        }
        public static DataColumn CountriesName()
        {
            return CountryData.GetAllCountriesName();
        }
    }
}
