using Microsoft.Azure.Devices.Client;
using System.Text;

var deviceClient = DeviceClient.CreateFromConnectionString("<device-connection-string>", TransportType.Mqtt);
var messageString = "{\"temperature\":25.3,\"humidity\":60}";
var message = new Message(Encoding.ASCII.GetBytes(messageString));
await deviceClient.SendEventAsync(message);
Console.WriteLine("Message sent");
