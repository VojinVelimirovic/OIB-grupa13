﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface ISmartCardsService
    {
        [OperationContract]
        [FaultContract(typeof(SecurityException))]
        void TestCommunication();

        [OperationContract]
        void CreateSmartCard(string username, int pin);

        [OperationContract]
        bool ValidateSmartCard(string username, int pin);

        [OperationContract]
        void UpdatePin(string username, int oldPin, int newPin);

    }
}
