using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fams.Web.Services;
using Fams.Web;

namespace Fams
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void CompaniesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!LicsData.CanLoad) LicsData.CancelLoad();
            LicsData.Load();
        }

        private void LicsData_LoadedData(object sender, LoadedDataEventArgs e)
        {
            Boolean visibility = Convert.ToBoolean(LicsData.DataView.Count);
            LicPage.Visibility = visibility ? Visibility.Visible : Visibility.Collapsed;
        }

        private void LicencesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!FreqsData.CanLoad) FreqsData.CancelLoad();
            FreqsData.Load();
        }

    }
}