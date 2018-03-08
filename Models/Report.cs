using System;
using System.Collections.Generic;

namespace SMATProgram.Models
{
    public class Report
    {
        public string Category { get; set; }
        public int Count { get { return dictionary.Count; } }
        private Dictionary<String, int> dictionary;

        public Report(string name)
        {
            Category = name;
            dictionary = new Dictionary<string, int>();
        }

        public int getCountOfSites(string url)
        {
            return dictionary[url];
        }

        private void CountSites(){

        }
    }
}