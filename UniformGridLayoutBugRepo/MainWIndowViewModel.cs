using System.Collections.Generic;
using ReactiveUI;

namespace UniformGridLayoutBugRepo;

public class MainWIndowViewModel : ReactiveObject
{
    public string Greeting => "Hello, World";

    public List<Data> Data
    {
        get
        {
            List<Data> data = new();
            for (int i = 0; i <= 100; i++)
            {
                data.Add(new()
                {
                    //does not display properly in UniformGridLayout
                    number = i,
                    //Displays Properly in UniformGridLayout
                    stringData1 = "This is a very long sentence ",
                    //Does not display properly in UnifromGridLayout
                    stringData2 = $"This is a very long sentence {i}",
                    //does not display properly
                    stringData3 = i.ToString()
                    
                });
            }

            return data;
        }
    }
}

public class Data
{
    public int number { get; set; }
    public string stringData1 { get; set; }
    public string stringData2 { get; set; }
    public string stringData3 { get; set; }
}