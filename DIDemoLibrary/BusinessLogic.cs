using DIDemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProessData()
        {
            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");

            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished the processing of data");
        }
    }
}
