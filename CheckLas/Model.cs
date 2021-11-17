using System.Collections.Generic;
using GIS.Core;

namespace CheckLas
{
    public class Model
    {
        //question - то что ищем  
        public List<Dictionary<LasReader.Errors, object>> GetAnsver(string[] files)
        {
            if (files.Length == 0)
            {
                return null;
            }

            List < Dictionary < LasReader.Errors, object>> result = new List<Dictionary<LasReader.Errors, object>>();
            foreach (var file in files)
            {
                Dictionary<LasReader.Errors, object> dictionary = new Dictionary<LasReader.Errors, object>();
                LasReader reader = new LasReader();
                reader.Read(file, ref dictionary);
                result.Add(dictionary);
            }
            return result;
        }
    }
}
