﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalLanguageProcessingLibrary.Schemas
{
    public class Relation
    {

        public enum relation
        {
            head
        }

        public Relation(string a, string b, relation relationBetweenWords)
        {
            this.a = a;
            this.b = b;
            this.relationBetweenWords = relationBetweenWords;
        }

        public string a { get; set; }
        public string b { get; set; }
        public relation relationBetweenWords { get; set; }

        public override string ToString()
        {
            return String.Format("{0} |--[{1}]--> {2}", a, relationBetweenWords, b);
        }
    }
}
