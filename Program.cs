using System;
using System.Collections.Generic;

namespace CS133PROJECT8
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> myLicensePlates = new HashSet<string>();

            bool didAddTheValue = false;

          
            didAddTheValue = myLicensePlates.Add("YHG567");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("YUH098");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("ASP513");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("LKO945");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("DSF667");
            Console.WriteLine(didAddTheValue);

            HashSet<String> myLicensePlates2 = new HashSet<string>();

            didAddTheValue = myLicensePlates.Add("YHG567");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("YUI099");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("ATP533");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("MKO045");
            Console.WriteLine(didAddTheValue);
            didAddTheValue = myLicensePlates.Add("DKF668");
            Console.WriteLine(didAddTheValue);

            myLicensePlates2.UnionWith(myLicensePlates);

            foreach (var item in myLicensePlates2)
            {
                Console.WriteLine(item + ", ");
            }

            myLicensePlates2.IntersectWith(myLicensePlates);

            foreach (var item in myLicensePlates2)
            {
                Console.WriteLine("This license plate already exist " + item + ", ");
            }

            {
                Console.WriteLine("This are the License plates alreary exists: " + myLicensePlates.Count);
            }
        }
    }
}

public class MyClass
{
    public string MyProperty { get; set; }
}
