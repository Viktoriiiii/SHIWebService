using System;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
    [OperationContract]
    Dictionary<string, int> GetDataDictionaryOne(string fileContent);

    [OperationContract]
    Dictionary<string, int> GetDataDictionaryTwo(string fileContent);
}
