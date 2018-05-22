using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace tptAppKodutoo.ViewModels
{
    public class LinkideViewModel : BaseViewModel
    {
        public LinkideViewModel()
        {
            Title = "Kasulikud lingid";
            
            OpenLinkSiseveeb = new Command(() => Device.OpenUri(new Uri("https://tpt.siseveeb.ee/")));
            OpenLinkRaamatukogu = new Command(() => Device.OpenUri(new Uri("https://www.tptlive.ee/kool/raamatukogu/")));
            OpenLinkToetused = new Command(() => Device.OpenUri(new Uri("https://www.tptlive.ee/oppetoo/oppekorralduseeskiri/")));
            OpenLinkEeskiri = new Command(() => Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/Documents/WWW/OPPEKORRALDUS/Sisekorraeeskiri_2015_eesti.pdf?slrid=97a5699e-8016-5000-d1a2-4c3737308e1e")));
            
        }
        
        public ICommand OpenLinkSiseveeb { get; }
        public ICommand OpenLinkRaamatukogu { get; }
        public ICommand OpenLinkToetused { get; }
        public ICommand OpenLinkEeskiri { get; }
    }
}