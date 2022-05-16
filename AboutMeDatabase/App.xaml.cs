using System;
using System.Collections.Generic;
using AboutMeDatabase.Data;
using AboutMeDatabase.Models;
using Xamarin.Forms;


namespace AboutMeDatabase
{
    public partial class App : Application
    {
        static PersonalItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static PersonalItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonalItemDatabase(); 
                    prefillDatabase();

                }
                return database;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
                items.Add(new PersonalItem() { Title = "Red Fact", Detail = "I like the color red", Image = "https://images.freeimages.com/images/large-previews/607/red-photos-1172010.jpg" });
                items.Add(new PersonalItem() { Title = "Blue Fact", Detail = "I also like the color blue", Image = "https://www.kovifabrics.com/img/products/7737.JPG" });
                items.Add(new PersonalItem() { Title = "Green Fact", Detail = "I think the color green is okay", Image = "https://www.drodd.com/images16/green-color6.jpg" });
                items.Add(new PersonalItem() { Title = "Brown Fact", Detail = "I think brown is a bad color", Image = "https://149346020.v2.pressablecdn.com/wp-content/uploads/2010/10/brown_0_0-400x400.jpg" });
                items.Add(new PersonalItem() { Title = "Purple Fact", Detail = "I like the color purple", Image = "https://www.ortoped.ca/media/catalog/product/n/l/nlt_solid_purple.jpg" });
                database.InsertList(items);

        }
    }
}
