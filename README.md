# MonkeyMask for NetStandard
Monkey Mask is a simple masking API designed for Xamarin.Forms, UWP, WPF and any platform that supports NetStandard.

## Built for User Entry
Monkey Mask was designed for masking strings as they are entered in an Entry field.

Suppose you have an Entry Field where you would like to support formatting a phone number (123-456-7890). The library is intended to call it's `MonkeyEntry.Mask()` method with each keystroke so the value appears formatted as they continue to type.

| Final Input    | Format         |
|----------------|----------------|
| `123-456-7890` | `###-###-####` |

 1. Input: `1`
 2. Input: `12`
 3. Input: `123-`
 4. Input: `123-4`
 5. Input: `123-45`
 6. Input: `123-456-`
 7. Input: `123-456-7`
 8. Input: `123-456-78`
 9. Input: `123-456-789`
 10. Input: `123-456-7890`

## Setup 

* Available on NuGet: [![NuGet](https://img.shields.io/nuget/v/MonkeyMask.svg?label=NuGet)](https://www.nuget.org/packages/MonkeyMask)
* Install into your NetStandard supported project

## Build

* [![Build status](https://ci.appveyor.com/api/projects/status/d5ug030xxvhiss1x?svg=true)](https://ci.appveyor.com/project/ahoefling/monkeymask)
* CI NuGet Feed: [https://ci.appveyor.com/nuget/monkeymask](https://ci.appveyor.com/nuget/monkeymask)
    
### Platform Support
TabStrip is available for use in *Xamarin.Forms* only targetting the following supported platforms.

| Platform         | Supported | Version          |
|------------------|-----------|------------------|
| Xamarin.Android  | Yes       | NetStandard1.0   |
| Xamarin.iOS      | Yes       | NetStandard1.0   |
| Xamarin 10 UWP   | Yes       | NetStandard1.0   |
| WPF              | Yes       | NetStandard1.0   |
| UWP              | Yes       | NetStandard1.0   |


## Usage ##

#### Static Method ####
```c#
// partial mask
var input = "123-4";
var format = "###-####";
MonkeyEntry.Mask(input, format);

// full mask
var input = "123-4567";
var format = "###-####";
MonkeyEntry.Mask(input, format);

// full mask and limit a max length
var input = "123-4567";
var format = "###-####";
MonkeyEntry.Mask(input, format, 7);
```

#### Extension Method ####
```c#
// partial mask
var input = "123-4";
var format = "###-####";
input.Mask(input, format);

// full mask
var input = "123-4567";
var format = "###-####";
input.Mask(input, format);

// full mask and limit a max length
var input = "123-4567";
var format = "###-####";
input.Mask(input, format, 7);
```

## Created By: [@Andrew_Hoefling](https://twitter.com/andrew_hoefling)

* Twitter: [@Andrew_Hoefling](https://twitter.com/andrew_hoefling)
* Blog: [andrewhoefling.com](http://www.andrewhoefling.com)

### License

The MIT License (MIT) see License File