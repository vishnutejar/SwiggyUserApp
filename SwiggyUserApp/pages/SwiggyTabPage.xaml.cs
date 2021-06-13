using SwiggyUserApp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwiggyUserApp.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwiggyTabPage : ContentPage
    {
        ObservableCollection<Category> lstOfCategories { get; set; }
        ObservableCollection<string> lstOfoffferCarosalData { get; set; }
        public SwiggyTabPage()
        {
            InitializeComponent();
            SetCategoriesData();
            listOfCategorys.ItemsSource = lstOfCategories;
            lstTopPicksforudata.ItemsSource = lstOfCategories;
            lstPopularbrandsdata.ItemsSource = lstOfCategories;
            lstPopularcurationsdata.ItemsSource = lstOfCategories;
            lstTrySomethingNewdata.ItemsSource = lstOfCategories;

            SetOfferCarosaleData();
        }

        private void SetOfferCarosaleData()
        {
            lstOfoffferCarosalData = new ObservableCollection<string>();
            lstOfoffferCarosalData.Add("* 100+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 200+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 400+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 600+ OUT LET WITH GREAT DISCOUNTS");
            lstofofferscarousel.ItemsSource = lstOfoffferCarosalData;

        }

        void SetCategoriesData() {
            lstOfCategories = new ObservableCollection<Category>();
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
            lstOfCategories.Add(new Category {CategoryTitle="Restaurant" ,CategoryImage= "fd18", CategoryDescription= "Enjoy your favourite treats" });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                lstofofferscarousel.Position = (lstofofferscarousel.Position + 1) % lstOfoffferCarosalData.Count;
                return true;
            }));
        }
    }
}