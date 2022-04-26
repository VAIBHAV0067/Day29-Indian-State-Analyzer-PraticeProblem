﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianStateAnalyzer.DTO;


namespace IndianStateAnalyzer
{
     public class CSVAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyzer.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyzer.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                case (CensusAnalyzer.Country.US):
                    return new USCensusAdapter().LoadUSCensusData(csvFilePath,dataHeaders);
                default:
                    throw new CensusAnalyserException("No such country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}
