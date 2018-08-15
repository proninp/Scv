using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace EDO.Exite.Order
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Pronin P.S.")]
    public class OrderList
    {
        public List<String> List { get; set; }

        public OrderList()
        {
            List = new List<string>();
        }
        public int GetListLength() => List.Count;

        public String GetListElement(int i) => List[i];
    }
}
