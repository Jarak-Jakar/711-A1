﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _711_A1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServerService" in both code and config file together.
    public class ServerService : IServerService
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        byte[] IServerService.GetFile(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }

        string[] IServerService.GetFileList()
        {
            return Directory.GetFiles(Directory.GetCurrentDirectory() + "\\server");
        }
    }
}
