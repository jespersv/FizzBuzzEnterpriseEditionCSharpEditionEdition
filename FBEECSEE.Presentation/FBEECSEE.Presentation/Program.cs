/*
FizzBuzz is a common programming task and _serious_ word game.
It requires printing numbers from 1 to 100, replacing multiples of 3 with "Fizz,"
multiples of 5 with "Buzz," and multiples of both with "FizzBuzz".
The core logic checks if a number is divisible by 3 and 5.
*/

using Autofac;

var builder = new ContainerBuilder();
builder.RegisterModule<FizzBuzzModule>();
var container = builder.Build();
var service = container.Resolve<IFizzBuzzService>();

await service.Run();