using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] PinCode;
        TValue[] Brand;
        public MyDictionary()
        {
            PinCode = new TKey[0];
            Brand = new TValue[0];
        }
        public void Add(TKey PinCodes, TValue Brands)
        {
            TKey[] tempArrayTK = PinCode;
            TValue[] tempArrayTV = Brand;

            PinCode = new TKey[PinCode.Length + 1];
            Brand = new TValue[Brand.Length + 1];

            for (int i = 0; i < tempArrayTK.Length; i++)
            {
                PinCode[i] = tempArrayTK[i];

            }
            PinCode[PinCode.Length - 1] = PinCodes;

            for (int i = 0; i < tempArrayTV.Length; i++)
            {
                Brand[i] = tempArrayTV[i];
            }
            Brand[Brand.Length - 1] = Brands;
        }
        public void Show()
        {
            for (int i = 0; i < PinCode.Length; i++)
            {
                Console.WriteLine("If PinCode : " + PinCode[i]+",   " + "Brand Name is : " + Brand[i]);
            }
        }

    }
}