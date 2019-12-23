using iGreen.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace iGreen.ViewModel
{
    public class AboutViewModel : BaseViewModel
    {
        private ObservableCollection<AboutModel> _AboutCollection;
        public ObservableCollection<AboutModel> AboutCollection
        {
            get { return _AboutCollection; }
            set { SetProperty(ref _AboutCollection, value); }
        }

        public AboutViewModel()
        {
            AboutCollection = new ObservableCollection<AboutModel>()
            {
                new AboutModel()
                {
                    NameItem="Glass",
                    DetailItem="Can be reused as a container for storage.",
                    IconItem="ic_glassColor.png"
                },
                new AboutModel()
                {
                    NameItem="Paper",
                    DetailItem="Can be reused to create an origami.",
                    IconItem="ic_paperColor.png"
                },
                new AboutModel()
                {
                    NameItem="Paper",
                    DetailItem="Can be reused to create an origami.",
                    IconItem="ic_paperColor.png"
                },
                new AboutModel()
                {
                    NameItem="Palstic",
                    DetailItem="Can be reused to create an origami.",
                    IconItem="ic_palsticColor.png"
                },
                new AboutModel()
                {
                    NameItem="Metal",
                    DetailItem="Can be reused as a plant tin can.",
                    IconItem="ic_metalColor.png"
                }
            };
        }
    }
}
