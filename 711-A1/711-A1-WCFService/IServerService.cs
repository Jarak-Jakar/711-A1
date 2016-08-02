﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _711_A1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServerService" in both code and config file together.
    [ServiceContract]
    public interface IServerService
    {
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        Stream GetFile(string fileName);

        [OperationContract]
        string[] GetFileList();
    }

    [ServiceContract]
    public interface ICacheService
    {
        [OperationContract]
        Stream GetFile(string fileName);

        [OperationContract]
        string[] GetFileList();
    }

    //[ServiceContract]
    //public interface ICacheService
    //{
    //    //[OperationContract]
    //    //string GetData(int value);

    //    //[OperationContract]
    //    //CompositeType GetDataUsingDataContract(CompositeType composite);

    //    // TODO: Add your service operations here

    //    [OperationContract]
    //    //string GetFile(string fileName);

    //    [OperationContract]
    //    //string GetFileList();
    //}

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "_711_A1.ContractType".
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
