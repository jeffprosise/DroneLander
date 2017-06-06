﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

    public static class MobileCenterConstants
    {
        public const string AndroidAppId = "816754e0-786a-4a33-ae7e-6e71d97b9a22";
        public const string iOSAppId = "";
    }

    public static class MobileServiceConstants
    {
        public const string AppUrl = "https://dronelandermobile0010.azurewebsites.net";
    }

    public static class TelemetryConstants
    {
        public const string DisplayName = "Neil Armstrong";
        public const string Tagline = "Nailed it!";
    }
}
