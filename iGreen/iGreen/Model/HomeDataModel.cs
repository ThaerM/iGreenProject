using System;
using System.Collections.Generic;
using System.Text;

namespace iGreen.Model
{
    public class HomeDataModel
    {
        public string Name { get; set; }
        public string ImageName { set; get; }
        public List<FactoryDataModel> factoryDataModels { get; set; }
    }

    public class FactoryDataModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string NameStreet { get; set; }
        public string Poster { get; set; }
        public double letudeLocation { get; set; }
        public double longtudeLoacation { get; set; }
        public List<Details> details { get; set; }
    }
    public class Details
    {
        public string NameDetails { get; set; }
    }
}
