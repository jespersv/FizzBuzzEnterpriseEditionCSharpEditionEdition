using FBEECSEE.Library.interfaces;

namespace FBEECSEE.Library.impl;

internal class LoopEnumerationFactory : ILoopEnumerationFactory
{
    private static int[] SeedArray = new[]
    {
        Numbers.One, Numbers.Two, Numbers.Three, Numbers.Four, Numbers.Five, Numbers.Six, Numbers.Seven, Numbers.Eight, Numbers.Nine, Numbers.Ten,
        Numbers.Eleven, Numbers.Twelve, Numbers.Thirteen, Numbers.Fourteen, Numbers.Fifteen, Numbers.Sixteen, Numbers.Seventeen, Numbers.Eighteen, Numbers.Nineteen,        Numbers.Twenty,
        Numbers.TwentyOne, Numbers.TwentyTwo, Numbers.TwentyThree, Numbers.TwentyFour, Numbers.TwentyFive, Numbers.TwentySix, Numbers.TwentySeven, Numbers.TwentyEight, Numbers.TwentyNine, Numbers.Thirty,
        Numbers.ThirtyOne, Numbers.ThirtyTwo, Numbers.ThirtyThree, Numbers.ThirtyFour, Numbers.ThirtyFive, Numbers.ThirtySix, Numbers.ThirtySeven, Numbers.ThirtyEight, Numbers.ThirtyNine, Numbers.Forty,
        Numbers.FortyOne, Numbers.FortyTwo, Numbers.FortyThree, Numbers.FortyFour, Numbers.FortyFive, Numbers.FortySix, Numbers.FortySeven, Numbers.FortyEight, Numbers.FortyNine, Numbers.Fifty,
        Numbers.FiftyOne, Numbers.FiftyTwo, Numbers.FiftyThree,Numbers.FiftyFour, Numbers.FiftyFive, Numbers.FiftySix, Numbers.FiftySeven, Numbers.FiftyEight, Numbers.FiftyNine,Numbers.Sixty,
        Numbers.SixtyOne, Numbers.SixtyTwo, Numbers.SixtyThree, Numbers.SixtyFour, Numbers.SixtyFive, Numbers.SixtySix, Numbers.SixtySeven, Numbers.SixtyEight, Numbers.SixtyNine, Numbers.Seventy, Numbers.SeventyOne,
        Numbers.SeventyTwo, Numbers.SeventyThree, Numbers.SeventyFour, Numbers.SeventyFive, Numbers.SeventySix, Numbers.SeventySeven, Numbers.SeventyEight, Numbers.SeventyNine, Numbers.Eighty, Numbers.EightyOne,
        Numbers.EightyTwo, Numbers.EightyThree, Numbers.EightyFour, Numbers.EightyFive, Numbers.EightySix, Numbers.EightySeven, Numbers.EightyEight, Numbers.EightyNine, Numbers.Ninety,
        Numbers.NinetyOne, Numbers.NinetyTwo, Numbers.NinetyThree, Numbers.NinetyFour, Numbers.NinetyFive, Numbers.NinetySix, Numbers.NinetySeven, Numbers.NinetyEight, Numbers.NinetyNine, Numbers.OneHundred
    };
    /// <summary>
    /// Optimized for top performance.
    /// </summary>
    /// <returns>Enumeration of the fizzbuzz sequence.</returns>
    public IEnumerable<int> CreateLoopEnumeration() => SeedArray.ToArray();

    internal static class Numbers
    {
        public const int One = 1;
        public const int Two = 2;
        public const int Three = 3;
        public const int Four = 4;
        public const int Five = 5;
        public const int Six = 6;
        public const int Seven = 7;
        public const int Eight = 8;
        public const int Nine = 9;
        public const int Ten = 10;
        public const int Eleven = 11;
        public const int Twelve = 12;
        public const int Thirteen = 13;
        public const int Fourteen = 14;
        public const int Fifteen = 15;
        public const int Sixteen = 16;
        public const int Seventeen = 17;
        public const int Eighteen = 18;
        public const int Nineteen = 19;
        public const int Twenty = 20;
        public const int TwentyOne = 21;
        public const int TwentyTwo = 22;
        public const int TwentyThree = 23;
        public const int TwentyFour = 24;
        public const int TwentyFive = 25;
        public const int TwentySix = 26;
        public const int TwentySeven = 27;
        public const int TwentyEight = 28;
        public const int TwentyNine = 29;
        public const int Thirty = 30;
        public const int ThirtyOne = 31;
        public const int ThirtyTwo = 32;
        public const int ThirtyThree = 33;
        public const int ThirtyFour = 34;
        public const int ThirtyFive = 35;
        public const int ThirtySix = 36;
        public const int ThirtySeven = 37;
        public const int ThirtyEight = 38;
        public const int ThirtyNine = 39;
        public const int Forty = 40;
        public const int FortyOne = 41;
        public const int FortyTwo = 42;
        public const int FortyThree = 43;
        public const int FortyFour = 44;
        public const int FortyFive = 45;
        public const int FortySix = 46;
        public const int FortySeven = 47;
        public const int FortyEight = 48;
        public const int FortyNine = 49;
        public const int Fifty = 50;
        public const int FiftyOne = 51;
        public const int FiftyTwo = 52;
        public const int FiftyThree = 53;
        public const int FiftyFour = 54;
        public const int FiftyFive = 55;
        public const int FiftySix = 56;
        public const int FiftySeven = 57;
        public const int FiftyEight = 58;
        public const int FiftyNine = 59;
        public const int Sixty = 60;
        public const int SixtyOne = 61;
        public const int SixtyTwo = 62;
        public const int SixtyThree = 63;
        public const int SixtyFour = 64;
        public const int SixtyFive = 65;
        public const int SixtySix = 66;
        public const int SixtySeven = 67;
        public const int SixtyEight = 68;
        public const int SixtyNine = 69;
        public const int Seventy = 70;
        public const int SeventyOne = 71;
        public const int SeventyTwo = 72;
        public const int SeventyThree = 73;
        public const int SeventyFour = 74;
        public const int SeventyFive = 75;
        public const int SeventySix = 76;
        public const int SeventySeven = 77;
        public const int SeventyEight = 78;
        public const int SeventyNine = 79;
        public const int Eighty = 80;
        public const int EightyOne = 81;
        public const int EightyTwo = 82;
        public const int EightyThree = 83;
        public const int EightyFour = 84;
        public const int EightyFive = 85;
        public const int EightySix = 86;
        public const int EightySeven = 87;
        public const int EightyEight = 88;
        public const int EightyNine = 89;
        public const int Ninety = 90;
        public const int NinetyOne = 91;
        public const int NinetyTwo = 92;
        public const int NinetyThree = 93;
        public const int NinetyFour = 94;
        public const int NinetyFive = 95;
        public const int NinetySix = 96;
        public const int NinetySeven = 97;
        public const int NinetyEight = 98;
        public const int NinetyNine = 99;
        public const int OneHundred = 100;
    }

}


