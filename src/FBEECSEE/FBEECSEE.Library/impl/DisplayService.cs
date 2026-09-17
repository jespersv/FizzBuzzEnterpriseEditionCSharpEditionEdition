namespace FBEECSEE.Library.impl;

internal class DisplayService : IDisplayService
{
    public void Show(string msg) => Console.WriteLine(msg);
}