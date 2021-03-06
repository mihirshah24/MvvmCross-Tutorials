﻿using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using Microsoft.Phone.Controls;

namespace Collections.WP
{
    public class Setup
        : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame)
            : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override Cirrious.MvvmCross.ViewModels.IMvxNavigationSerializer CreateNavigationSerializer()
        {
            Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded(true);
            return new MvxJsonNavigationSerializer();
        }
    }
}