# Northwnd

Simple database Northwnd for Code First.

<br/>

## Install

**Package Manager**

> Install-Package Northwnd

**.NET CLI**

> dotnet add package Northwnd

<br/>

## How to use?

Regions are defined in database:

> **%userprofile%/.nuget/northwnd/{version}/content/@Resources/Northwnd/northwnd.db**

| RegionID | RegionDescription |
| -------- | ----------------- |
| 1        | Eastern           |
| 2        | Western           |
| 3        | Northern          |
| 4        | Southern          |

Output all regions using Code First:

```c#
using (var context = NorthwndContext.UseSqliteResource())
{
    var regions = context.Regions.ToArray();    
    foreach (var region in regions)
        Console.WriteLine($"{region.RegionID}\t{region.RegionDescription}");
}
```

Console output:

> 1       Eastern
> 2       Western
> 3       Northern
> 4       Southern

<br/>

## Database diagram

![](https://raw.githubusercontent.com/zmjack/Northwnd/master/Northwnd/%40Resources/Northwnd/Northwnd.png)

