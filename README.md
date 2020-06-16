# ImageAPI-SDK
.NET SDK for the GSCCCA Image API based on .NET Standard 2.0

## Basic Usage:
```C#
var client = new ImageApiClient("clientid", "secret");
var uploadResult = await client.UploadImageAsync(@"c:\DEED0442492000448.TIF","mybatchname");
```

## Download Image:
```C#
var client = new ImageApiClient("clientid", "secret");
var myImageId = 22123;
await client.DownloadImageAsync(myImageId, @"c:\downloadedimages\DEED0442492000448.TIF");
```

## Upload All Images in a Folder (3 at a time)
```C#
var client = new ImageApiClient("clientid", "secret");
var files = Directory.EnumerateFiles(@"c:\myimagesfolder","*.tif").ToArray();
var results = await client.UploadImagesAsync(files,"mybatchname");
```

## Download All Images in a Batch (3 at a time)
```C#
var client = new ImageApiClient("clientid", "secret");
var results = await client.DownloadBatchAsync("mybatchname", @"c:\downloadedimages\");
```
