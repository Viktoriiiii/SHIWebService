using System;
using System.Collections.Generic;
using System.Reflection;
using ClassLibraryDictionary;

public class Service : IService
{
    public Dictionary<string, int> GetDataDictionaryOne(string fileContent)
    {
        DictionaryTask dt = new DictionaryTask();
        var di = dt.GetType().InvokeMember("GetDictionary", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null, dt, new object[] { fileContent });
        return (Dictionary<string, int>)di;
    }

    public Dictionary<string, int> GetDataDictionaryTwo(string fileContent)
    {
        DictionaryTask dt = new DictionaryTask();
        var diThread = dt.GetDictionaryWithThreading(fileContent);
        return diThread;
    }
}
