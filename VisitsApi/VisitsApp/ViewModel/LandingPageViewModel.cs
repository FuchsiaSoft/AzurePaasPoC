using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VisitsApp.View;

namespace VisitsApp.ViewModel
{
    class LandingPageViewModel : GalaSoft.MvvmLight.ViewModelBase
    {


        public ICommand NewVisitCommand { get { return new RelayCommand(NewVisit); } }

        private void NewVisit()
        {
            NavigationService service = new NavigationService();
            service.Configure("NewVisitPage", typeof(NewVisitPage));
            service.NavigateTo("NewVisitPage");
        }
    }
}
