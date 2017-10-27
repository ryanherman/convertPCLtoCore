using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using Xamarin.Forms;

namespace DotStanConverter
{
    public partial class MainPage : ContentPage
    {
        private string ConvertBase =
             "<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <TargetFramework>netstandard2.0</TargetFramework>\r\n    <PackageTargetFallback>$(PackageTargetFallback);portable-win+net45+wp8+win81+wpa8</PackageTargetFallback>\r\n  </PropertyGroup>\r\n\r\n  <ItemGroup>\r\n {0}\r\n </ItemGroup>\r\n</Project>\r\n"
         ;

        private string ConvertPackage = "<PackageReference Include=\"{0}\" Version=\"{1}\" />";


        public MainPage()
        {
            InitializeComponent();
            Title = "@ryanherman PCL to .NET Standard Converter";
            PasteHere.Text = "Paste your packages.config PCL here";

        }

        private void ConvertButton_OnClicked(object sender, EventArgs e)
        {
            XDocument doc = null;
            try
            {
               doc = XDocument.Parse(PasteHere.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Incorrect file: " + ex);
                DisplayAlert("Incorrect format", "Check that the file is the packages.config PCL", "OK");
                return;
            }

            var findPackages = doc.Descendants();
            int i = 0;
            List<packageFormat> packages = new List<packageFormat>();
            
            foreach (var eachItem in findPackages)
            {
                if (i != 0) // Has entire XML in first slot
                {
                    try
                    {
                        var incomingId = eachItem.Attribute("id").Value;
                        var incomingVersion = eachItem.Attribute("version").Value;
                        var incomingFramework = eachItem.Attribute("targetFramework").Value;
                        packages.Add(new packageFormat
                        {
                            id = incomingId,
                            targetFramework = incomingVersion,
                            version = incomingFramework
                        });
                    }
                    catch
                    {
                        Debug.WriteLine("Incorrect file");
                        DisplayAlert("Incorrect format", "Check that the file is the packages.config PCL", "OK");
                        return;
                    }

                }
                    i++;
                
            }


            string convertPackageInsert = string.Empty;
            foreach (var eachPackage in packages)
            {
                var convertIt = String.Format(ConvertPackage, eachPackage.id, eachPackage.version);
                convertPackageInsert += convertIt + "\r\n";
            }

            var finalOutcome = String.Format(ConvertBase, convertPackageInsert);
            PasteHere.Text = finalOutcome;

            DisplayAlert("@ryanherman",
                "Edit your .csproj.NET Standard file and paste the text from the editor",
                "OK");

        }

        private class packageFormat
        {
            public string id { get; set; }
            public string version { get; set; }
            public string targetFramework { get; set; }
        }
    }
}
