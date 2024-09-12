﻿using AppShoppingCenter.Services;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AppShoppingCenter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                });

            builder.Services.AddSingleton<StoreService>();
            builder.Services.AddSingleton<CinemaService>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
