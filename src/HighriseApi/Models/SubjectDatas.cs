using System;
using System.Collections.Generic;
using RestSharp.Serializers;

namespace HighriseApi
{
    [Serializable]
    public class SubjectDatas : List<SubjectData>
    {
        public SubjectDatas()
        {
            Type = "array";
        }

        [SerializeAs(Name = "type", Attribute = true)]
        public string Type { get; set; }
    }
}