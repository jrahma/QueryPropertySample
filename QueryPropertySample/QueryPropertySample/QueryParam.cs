using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace QueryPropertySample;

[QueryProperty(nameof(PackageId), nameof(PackageId))]
[QueryProperty(nameof(PackageName), nameof(PackageName))]
public partial class QueryParam : ObservableObject
{
    [ObservableProperty]
    string packageId;

    [ObservableProperty]
    string packageName;
}

