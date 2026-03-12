/*

FizzBuzz is a common programming interview task and child's word game. 
It requires printing numbers from 1 to 100, replacing multiples of 3 with "Fizz," 
multiples of 5 with "Buzz," and multiples of both with "FizzBuzz". 
The core logic checks if a number is divisible by 3 and 5.
*/

for (var i = 1; i <= 100; i++)
{
    if(i%3==0 && i%5==0) Console.WriteLine($"FizzBuzz");
    else if(i%3==0) Console.WriteLine($"Fizz");
    else if(i%5==0) Console.WriteLine($"Buzz");
    else Console.WriteLine(i);
}