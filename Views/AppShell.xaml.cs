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

            Routing.RegisterRoute("tickets/pay", typeof(Views.Tickets.PayPage));
            Routing.RegisterRoute("tickets/list", typeof(Views.Tickets.ListPage));
            Routing.RegisterRoute("tickets/result", typeof(Views.Tickets.ResultPage));
            Routing.RegisterRoute("tickets/camera", typeof(Views.Tickets.CameraPage));
        }
    }
}
