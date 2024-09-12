﻿namespace AppShoppingCenter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("stores/detail", typeof(Views.Stores.DetailPage));
            Routing.RegisterRoute("cinemas/detail", typeof(Views.Cinemas.DetailPage));
            Routing.RegisterRoute("cinemas/detaildesktop", typeof(Views.Cinemas.DetailPageDesktop));
        }
    }
}
