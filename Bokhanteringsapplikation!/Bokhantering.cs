using System;
using System.Collections.Generic;

public class Bokningshantering
{
    public List<Pass> PassLista { get; set; }

    public Bokningshantering()
    {
        PassLista = new List<Pass>
        {
            new Pass("Boxning", new DateTime(2023, 11, 1, 10, 0, 0), 10),
            new Pass("Yoga", new DateTime(2023, 11, 1, 12, 0, 0), 15),
            new Pass("Vikter", new DateTime(2023, 11, 1, 14, 0, 0), 20)
        };
    }
}
