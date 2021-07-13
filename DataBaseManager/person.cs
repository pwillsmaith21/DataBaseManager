using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseManager
{
    public class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string profession { get; set; }
        public int ID { get; set; }
        public override string ToString()
        {
            return ($"{ID}: Firstname: {firstName} Lastname: {lastName} Profession: {profession}");
        }
    }
}
