# sensorpush-core
SensorPush API client for .NET Core

## What? Why?
This is a SensorPush API client for .NET Core built with the Swagger definition for SensorPush API v1. A few changes have been made to the generated code, mainly correcting datatypes and illegal type conversions.
The package comes with a minimal class, SensorPushClient, extending the generated API class, mainly for easy authentication. It's just a quick way to get started – use it if you want.

## Before you get started
You need to accept terms and conditions at https://dashboard.sensorpush.com/ before you can use the API.

## Code examples
    // Create client
    var client = new SensorPushClient("your@email.com", "password");

    // Display gateways
    client.Gateways().ToList().ForEach((gateway) => Console.WriteLine(JsonConvert.SerializeObject(gateway)));

    // Display sensors
    client.Sensors().ToList().ForEach((sensor) => Console.WriteLine(JsonConvert.SerializeObject(sensor)));

    // Get some data samples
    Console.WriteLine(JsonConvert.SerializeObject(client.Samples(new SamplesRequest(limit: 60))));

# API documentation
https://www.sensorpush.com/api/docs

# License
MIT License