using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DotStanConvertor
{
    public partial class MainPage : ContentPage
    {
        private string ConvertBase =
             $"<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <TargetFramework>netstandard2.0</TargetFramework>\r\n    <PackageTargetFallback>$(PackageTargetFallback);portable-win+net45+wp8+win81+wpa8</PackageTargetFallback>\r\n  </PropertyGroup>\r\n\r\n  <ItemGroup>\r\n    <EmbeddedResource Include=\"Videos\\crowd.mp4\" />\r\n  </ItemGroup>\r\n\r\n  <ItemGroup>\r\n    <PackageReference Include=\"Acr.UserDialogs\" Version=\"6.5.1\" />\r\n    <PackageReference Include=\"AWSSDK.CognitoIdentity\" Version=\"3.3.2.16\" />\r\n    <PackageReference Include=\"AWSSDK.Core\" Version=\"3.3.18.2\" />\r\n    <PackageReference Include=\"AWSSDK.S3\" Version=\"3.3.11.4\" />\r\n    <PackageReference Include=\"AWSSDK.SecurityToken\" Version=\"3.3.3.2\" />\r\n    <PackageReference Include=\"AWSSDK.SimpleNotificationService\" Version=\"3.3.0.23\" />\r\n    <PackageReference Include=\"CarouselView.FormsPlugin\" Version=\"4.4.6\" />\r\n    <PackageReference Include=\"Com.Airbnb.Xamarin.Forms.Lottie\" Version=\"2.3.4\" />\r\n    <PackageReference Include=\"Microsoft.Azure.Mobile\" Version=\"0.17.0-r0002-5c783ea\" />\r\n    <PackageReference Include=\"Microsoft.Azure.Mobile.Analytics\" Version=\"0.17.0-r0002-5c783ea\" />\r\n    <PackageReference Include=\"Microsoft.Azure.Mobile.Crashes\" Version=\"0.17.0-r0002-5c783ea\" />\r\n    <PackageReference Include=\"Microsoft.Bcl\" Version=\"1.1.10\" />\r\n    <PackageReference Include=\"Microsoft.Bcl.Build\" Version=\"1.0.21\" />\r\n    <PackageReference Include=\"Microsoft.NETCore.Portable.Compatibility\" Version=\"1.0.1\" />\r\n    <PackageReference Include=\"Newtonsoft.Json\" Version=\"10.0.3\" />\r\n    <PackageReference Include=\"Octane.Xam.VideoPlayer\" Version=\"1.2.3\" />\r\n    <PackageReference Include=\"PCLStorage\" Version=\"1.0.2\" />\r\n    <PackageReference Include=\"Plugin.Permissions\" Version=\"2.1.0\" />\r\n    <PackageReference Include=\"Plugin.Share\" Version=\"7.0.2-beta27\" />\r\n    <PackageReference Include=\"Rg.Plugins.Popup\" Version=\"1.1.0-pre3\" />\r\n    <PackageReference Include=\"SegmentedControl.FormsPlugin\" Version=\"1.3.4\" />\r\n    <PackageReference Include=\"SlideOverKit\" Version=\"2.1.5\" />\r\n    <PackageReference Include=\"VG.XFShapeView\" Version=\"1.0.5\" />\r\n    <PackageReference Include=\"Xam.Plugin.Connectivity\" Version=\"4.0.0-beta139\" />\r\n    <PackageReference Include=\"Xam.Plugin.ExternalMaps\" Version=\"4.0.1\" />\r\n    <PackageReference Include=\"Xam.Plugin.Media\" Version=\"3.0.2.129-beta\" />\r\n    <PackageReference Include=\"Xam.Plugin.Version\" Version=\"1.0.0\" />\r\n    <PackageReference Include=\"Xam.Plugins.Settings\" Version=\"3.1.1\" />\r\n    <PackageReference Include=\"Xamarin.Auth\" Version=\"1.5.0.3\" />\r\n    <PackageReference Include=\"Xamarin.FFImageLoading\" Version=\"2.2.22\" />\r\n    <PackageReference Include=\"Xamarin.FFImageLoading.Forms\" Version=\"2.2.22\" />\r\n    <PackageReference Include=\"Xamarin.FFImageLoading.Transformations\" Version=\"2.2.22\" />\r\n    <PackageReference Include=\"Xamarin.Forms\" Version=\"2.4.0.18342\" />\r\n  </ItemGroup>\r\n</Project>\r\n"
         ;



        public MainPage()
        {
            InitializeComponent();
            PasteHere.Text = ConvertBase;
        }
    }
}
