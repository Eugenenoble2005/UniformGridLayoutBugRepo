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
                    number = i
                });
            }

            return data;
        }
    }
}

public class Data
{
    public int number { get; set; }
}