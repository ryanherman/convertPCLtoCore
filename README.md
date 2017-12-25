**6 Steps to Converting your PCL Library to .NET Standard**
-----------------------------------------------

1. Create new .NET Standard Library targeting 2.0 and name it NAME.Standard
2. Copy all files from PCL to .NET Standard Library
3. Re-install all NuGets
4. Delete PCL library and Delete the folder
5. Rename the .NET Standard Libary to the PCL's old name and rename the folder
6. Add references back

**Issues and Fixes**
1. Erroring on build w/ report on Xamarin.Forms.targets being null -> Remove all files in Properties (Assembly.cs, etc)
2. When you try and build and you get "Cannot find your net .NET Core dll" -> Restart VS and rebuild (Files might be in use)
3. You may have to delete the Obj and Bin directories of your new .NET Core a few times to get it to build...
4. Fody and Realm.io users, if you add or delete fody nuget packages like PropertyChanged.Fody, be prepared to delete Obj and Bin files for it to compile...  (Update) Turns out the latest version of Fody doesn't play nice.  Try 2.1.2 I believe.
5. Was having many problems w/ Microsoft.BCL.*; ended up removing them and it worked out fine.

***@ryanherman***
