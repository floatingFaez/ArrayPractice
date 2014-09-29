using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Person
    {
        public string firstName { get; private set; }
        public int lastName { get; private set; }

        public string sayHello(string nam)
        {
            return "Hello there " + nam;
        }

        #region To Show Array
        //public string sayHello(params string[] names)
        //{
        //    return sayHello(string.Join(", ", names));
        //} 
        #endregion

        public string sayHello(params string[] names) {
            StringBuilder strBild = new StringBuilder();
            string tmp = string.Empty;
            foreach (string name in names)
            {
                strBild.Append(name + ", ");
            }
            tmp = strBild.ToString();
            tmp = tmp.Remove(tmp.LastIndexOf(","));
            return sayHello(tmp);     
        }
    }
}
