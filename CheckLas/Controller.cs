using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIS.Core;

namespace CheckLas
{
    public class Controller
    {
        public List<Dictionary<LasReader.Errors, object>> GetResults(string [] files)
        {
            Model model = new Model();
            return model.GetAnsver(files);
        }
    }
}
