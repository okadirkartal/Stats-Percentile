<div>
  <h1>Calculate n-th percentile</h1>
  <a href="https://www.nuget.org/packages/Stats-Percentile/"> 
   <img src="https://img.shields.io/nuget/dt/Stats-Percentile"
   alt="Nuget downloads" 
   data-canonical-src="https://img.shields.io/nuget/dt/Stats-Percentile?color=2da44e&amp;label=nuget%20downloads&amp;logo=nuget"
   style="max-width: 100%;">
  </a>
</div> 

## Dependencies

| Stats-Percentile | .NET 7 |
|------------------|---------|
| 1.0.0            |   

## Install

```nuget
with .NET CLI 

dotnet add package Stats-Percentile

with Package Manager

NuGet\Install-Package Stats-Percentile

with Package Reference

<PackageReference Include="Newtonsoft.Json" Version="1.0.1" />
```

## Setup

**Step 1:** Import the namespace

```cs
using Stats_Percentile;
```

## Use

```cs 
// calculate p75
StatsPercentile.Percentile(new int[]{3, 6, 7, 8, 8, 10, 13, 15, 16, 20},75); // → 15
```
See <a href='https://en.wikipedia.org/wiki/Percentile#The_Nearest_Rank_method' target='_blank'>Nearest Rank Method</a>
 
 
