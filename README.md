**17 Steps to Converting your PCL to .NetCore**
-----------------------------------------------

1. Git New Branch
2. Un-Reference PCL from iOS/Droid
3. Remove PCL Project
4. Move OLD PCL to another location
5. Add New Project - Class Library
6. Name it Just like your old PCL to Preserve Namespace or your going to have to be editing a TON of files...
7. Place it where your old PCL was
8. Re-Add Files from Old.PCL (MINUS BIN AND OBJ), Copy Folders from File Explorer to Project inside Visual Studio
9. Edit .csproj of new project and add replace this:

  ``<PropertyGroup>
  <TargetFramework>netstandard2.0</TargetFramework>
  </PropertyGroup>``
  
with:

  ``<PropertyGroup>
  <TargetFramework>netstandard2.0</TargetFramework>
    <PackageTargetFallback>$(PackageTargetFallback);portable-win+net45+wp8+win81+wpa8</PackageTargetFallback>
  </PropertyGroup>``
  
9. Open Packages.config in PCL.OLD in Editor
10. Re-Add Nuget Packages manually, and you need to add every single one because it doesn't seem to add extras that are needed.
11. Add Nuget Package Microsoft.NETCore.Portable.Compatibility
12. Try a Re-build - Remove any incorrect Using; add any Nuget-'s you didn't see to add
13. You may need to restart Visual Studio after this and try another clean and Rebuild.  I had some weird error that went away.
Duplicate 'System.Reflection.AssemblyCompanyAttribute' attribute
14. Delete Assembly.cs in your Properties Fly-out in Solution Explorer
15. Rebuild and you will see some ambiguous references, correct them all.
16. Manage Nuget Packages for Solution -> Head over to Consolidate to make sure all package version is matched up
17. Add refrence from your iOS/Droid to your new .NetCore Library!

**Issues and Fixes**
1. Erroring on build w/ report on Xamarin.Forms.targets being null -> Remove all files in Properties (Assembly.cs, etc)
2. When you try and build and you get Cannot find your net .Net Core dll -> Restart VS and rebuild (Files might be in use)
3. You may have to delete the Obj and Bin directories of your new .NetCore a few times to get it to build...
4. Fody and Realm.io Users, if you add or delete fody nuget packages like PropertyChanged.Fody, be prepared to delete Obj and Bin files for it to compile...

***@ryanherman***
