using FBEECSEE.Presentation.interfaces;

namespace FBEECSEE.Presentation.impl;

internal class DisplayService : IDisplayService
{
    public void Show(string msg) => Console.WriteLine(msg);
}