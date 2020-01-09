using iGreen.Model;
using System.Collections.ObjectModel;

namespace iGreen.ViewModel
{
    public class HomViewModel : BaseViewModel
    {
        private ObservableCollection<HomeDataModel> _homeData;
        public ObservableCollection<HomeDataModel> homeData { get { return _homeData; } set { SetProperty(ref _homeData, value); } }
        public HomViewModel()
        {
            homeData = LoadData();
        }

        private ObservableCollection<HomeDataModel> LoadData()
        {
            return new ObservableCollection<HomeDataModel>()
            {
                new HomeDataModel(){
                    Name="Paper" ,
                    ImageName="ic_paper",
                    factoryDataModels=new System.Collections.Generic.List<FactoryDataModel>
                    {
                        new FactoryDataModel()
                        {
                            Icon="BE_Environmental_Services.png",
                            Name="BE Environmental Services",
                            Poster="BE_Environmental_Services_location.png",
                            NameStreet="BE+Environmental+Services,+Amman",
                            letudeLocation=31.9901922,
                            longtudeLoacation=35.8486464,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){ NameDetails="•	Paper of any kind (e.g. newspapers, magazines, office paper whole or shredded, cardboard."},
                                new Details(){ NameDetails="•	Any metal, including aluminum (e.g. soda cans), steel and other scrap."},
                                new Details(){ NameDetails="•	Polyethylene terephthalate (PET) bottles (e.g. plastic water and soda bottles)."},
                                new Details(){ NameDetails="•	All other plastic materials, including wrappings, bags, containers, boxes, Styrofoam etc."},
                                new Details(){ NameDetails="•	Wood scraps including broken furniture, pallets, cable rolls etc."},
                                new Details(){ NameDetails="•	Printer and copier toner cartridges, batteries of any size and kind."},
                                new Details(){ NameDetails="•	Old bread and used cooking oil."},
                            }
                        } ,
                        new FactoryDataModel()
                        {
                            Icon="ic_GreenSpot.png",
                            Name="GreenSpot",
                            Poster="GreenSpot_Location.png",
                            NameStreet="Green+Spot+Recycling+Company+%7C+Amman+Jordan,+Abu+Abdo+Commercial+Complex,+Abbad+Bin+Bishr+St+3,+Amman,+Jordan",
                            letudeLocation=31.9118259,
                            longtudeLoacation=35.9359193,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Paper."},
                                new Details(){NameDetails="•	Metal: aluminum, brass, copper, lead, steel." },
                                new Details(){NameDetails="•	Cardboard." },
                                new Details(){NameDetails="•	Electric motors." },
                            }
                        }
                    }
                },
                new HomeDataModel()
                {
                    Name="Glass" ,
                    ImageName="ic_glass",
                    factoryDataModels=new System.Collections.Generic.List<FactoryDataModel>
                    {
                        new FactoryDataModel()
                        {
                            Icon="ic_Ziadat4Recycling.png",
                            Name="Ziadat4recycling",
                            Poster="Ziadat4Recycling_Location.png",
                            NameStreet="Ziadat4Recycling,+Nemr+Al-Edwan+St.+21,+Amman",
                            letudeLocation=31.9553135,
                            longtudeLoacation=35.9286144,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Glass."},
                                new Details(){NameDetails="•	Wood." },
                                new Details(){NameDetails="•	Furniture: broken chair, bed frame, mirror, shelf." },
                            }
                        }
                    }
                },
                new HomeDataModel(){
                    Name="Plastic" ,
                    ImageName="ic_plastic",
                    factoryDataModels=new System.Collections.Generic.List<FactoryDataModel>
                    {
                        new FactoryDataModel()
                        {
                            Icon="BE_Environmental_Services.png",
                            Name="BE Environmental Services",
                            Poster="BE_Environmental_Services_location.png",
                            NameStreet="BE+Environmental+Services,+Amman",
                            letudeLocation=31.9901922,
                            longtudeLoacation=35.8486464,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){ NameDetails="•	Paper of any kind (e.g. newspapers, magazines, office paper whole or shredded, cardboard."},
                                new Details(){ NameDetails="•	Any metal, including aluminum (e.g. soda cans), steel and other scrap."},
                                new Details(){ NameDetails="•	Polyethylene terephthalate (PET) bottles (e.g. plastic water and soda bottles)."},
                                new Details(){ NameDetails="•	All other plastic materials, including wrappings, bags, containers, boxes, Styrofoam etc."},
                                new Details(){ NameDetails="•	Wood scraps including broken furniture, pallets, cable rolls etc."},
                                new Details(){ NameDetails="•	Printer and copier toner cartridges, batteries of any size and kind."},
                                new Details(){ NameDetails="•	Old bread and used cooking oil."},
                            }
                        } ,
                        new FactoryDataModel()
                        {
                            Icon="ic_GreenWheelz.png",
                            Name="GreenWheelz",
                            Poster="GreenWheelz_Location.png",
                            NameStreet="Green+Wheelz+Drop+Point,+no.+6,+May+Ziadah+St.,+Amman",
                            letudeLocation=31.9507776,
                            longtudeLoacation=35.9038108,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Aluminum cans (metal)."},
                                new Details(){NameDetails="•	Plastic caps (plastic)."}
                            }
                        },
                        new FactoryDataModel()
                        {
                            Icon="ic_JowaidaPlastics.png",
                            Name="Jowaida Plastic Recycling Factory",
                            Poster="JowaidaPlastics_Location.png",
                            NameStreet="Al+Jowaida+Plastics+Recycling+Factory,+Wadi+Um+Al+Orouq+St+8,+Amman",
                            letudeLocation=31.875298,
                            longtudeLoacation=35.9714273,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Any plastic item."}
                            }
                        }
                    }
                },
                new HomeDataModel(){
                    Name="Metal" ,
                    ImageName="ic_metal",
                    factoryDataModels=new System.Collections.Generic.List<FactoryDataModel>
                    {
                        new FactoryDataModel()
                        {
                            Icon="BE_Environmental_Services.png",
                            Name="BE Environmental Services",
                            Poster="BE_Environmental_Services_location.png",
                            NameStreet="BE+Environmental+Services,+Amman",
                            letudeLocation=31.9901922,
                            longtudeLoacation=35.8486464,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){ NameDetails="•	Paper of any kind (e.g. newspapers, magazines, office paper whole or shredded, cardboard."},
                                new Details(){ NameDetails="•	Any metal, including aluminum (e.g. soda cans), steel and other scrap."},
                                new Details(){ NameDetails="•	Polyethylene terephthalate (PET) bottles (e.g. plastic water and soda bottles)."},
                                new Details(){ NameDetails="•	All other plastic materials, including wrappings, bags, containers, boxes, Styrofoam etc."},
                                new Details(){ NameDetails="•	Wood scraps including broken furniture, pallets, cable rolls etc."},
                                new Details(){ NameDetails="•	Printer and copier toner cartridges, batteries of any size and kind."},
                                new Details(){ NameDetails="•	Old bread and used cooking oil."}
                            }
                        } ,
                        new FactoryDataModel()
                        {
                            Icon="ic_GreenWheelz.png",
                            Name="GreenWheelz",
                            Poster="GreenWheelz_Location.png",
                            NameStreet="Green+Wheelz+Drop+Point,+no.+6,+May+Ziadah+St.,+Amman",
                            letudeLocation=31.9507776,
                            longtudeLoacation=35.9038108,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Aluminum cans (metal)."},
                                new Details(){NameDetails="•	Plastic caps (plastic)."}
                            }
                        },
                        new FactoryDataModel()
                        {
                            Icon="ic_GreenSpot.png",
                            Name="GreenSpot",
                            Poster="GreenSpot_Location.png",
                            NameStreet="Green+Spot+Recycling+Company+%7C+Amman+Jordan,+Abu+Abdo+Commercial+Complex,+Abbad+Bin+Bishr+St+3,+Amman,+Jordan",
                            letudeLocation=31.9118259,
                            longtudeLoacation=35.9359193,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Paper."},
                                new Details(){NameDetails="•	Metal: aluminum, brass, copper, lead, steel." },
                                new Details(){NameDetails="•	Cardboard" },
                                new Details(){NameDetails="•	Electric motors." }
                            }
                        }
                    }
                },
                new HomeDataModel(){
                    Name="Other" ,
                    ImageName="ic_other",
                    factoryDataModels=new System.Collections.Generic.List<FactoryDataModel>
                    {
                        new FactoryDataModel()
                        {
                            Icon="BE_Environmental_Services.png",
                            Name="BE Environmental Services",
                            Poster="BE_Environmental_Services_location.png",
                            NameStreet="BE+Environmental+Services,+Amman",
                            letudeLocation=31.9901922,
                            longtudeLoacation=35.8486464,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){ NameDetails="•	Paper of any kind (e.g. newspapers, magazines, office paper whole or shredded, cardboard."},
                                new Details(){ NameDetails="•	Any metal, including aluminum (e.g. soda cans), steel and other scrap."},
                                new Details(){ NameDetails="•	Polyethylene terephthalate (PET) bottles (e.g. plastic water and soda bottles)."},
                                new Details(){ NameDetails="•	All other plastic materials, including wrappings, bags, containers, boxes, Styrofoam etc."},
                                new Details(){ NameDetails="•	Wood scraps including broken furniture, pallets, cable rolls etc."},
                                new Details(){ NameDetails="•	Printer and copier toner cartridges, batteries of any size and kind."},
                                new Details(){ NameDetails="•	Old bread and used cooking oil."}
                            }
                        } ,
                        new FactoryDataModel()
                        {
                            Icon="ic_GreenSpot.png",
                            Name="GreenSpot",
                            Poster="GreenSpot_Location.png",
                            NameStreet="Green+Spot+Recycling+Company+%7C+Amman+Jordan,+Abu+Abdo+Commercial+Complex,+Abbad+Bin+Bishr+St+3,+Amman,+Jordan",
                            letudeLocation=31.9118259,
                            longtudeLoacation=35.9359193,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Paper."},
                                new Details(){NameDetails="•	Metal: aluminum, brass, copper, lead, steel." },
                                new Details(){NameDetails="•	Cardboard." },
                                new Details(){NameDetails="•	Electric motors" }
                            }
                        },
                        new FactoryDataModel()
                        {
                            Icon="ic_Ziadat4Recycling.png",
                            Name="Ziadat4recycling",
                            Poster="Ziadat4Recycling_Location.png",
                            NameStreet="Ziadat4Recycling,+Nemr+Al-Edwan+St.+21,+Amman",
                            letudeLocation=31.9553135,
                            longtudeLoacation=35.9286144,
                            details=new System.Collections.Generic.List<Details>()
                            {
                                new Details(){NameDetails="•	Glass."},
                                new Details(){NameDetails="•	Wood." },
                                new Details(){NameDetails="•	Furniture: broken chair, bed frame, mirror, shelf." }
                            }
                        } 
                    }
                }
            };
        }
    }
}