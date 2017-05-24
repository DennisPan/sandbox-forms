﻿using System;
using Xamarin.Forms;

namespace SandboxForms
{
    public partial class SandboxFormsPage : ContentPage
    {
        public SandboxFormsPage()
        {
            InitializeComponent();

            var p = new Plugin.Fingerprint.Abstractions.AuthenticationRequestConfiguration("reason");

            System.Diagnostics.Debug.WriteLine($"{p.Reason}");
        }
    }
}
