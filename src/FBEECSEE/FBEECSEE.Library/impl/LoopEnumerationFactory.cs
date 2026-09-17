namespace FBEECSEE.Library.impl;

internal class LoopEnumerationFactory : ILoopEnumerationFactory
{
    private IFizzBuzzCollectionFactory _fizzBuzzCollectionFactory;

    public LoopEnumerationFactory(IFizzBuzzCollectionFactory fizzBuzzCollectionFactory)
    {
        _fizzBuzzCollectionFactory = fizzBuzzCollectionFactory;
    }

    private static FizzBuzzArrayValue[] SeedArray = new[]
    {
        TypedFizzBuzzNumbers.One, TypedFizzBuzzNumbers.Two, TypedFizzBuzzNumbers.Three, TypedFizzBuzzNumbers.Four, TypedFizzBuzzNumbers.Five, TypedFizzBuzzNumbers.Six, TypedFizzBuzzNumbers.Seven, TypedFizzBuzzNumbers.Eight, TypedFizzBuzzNumbers.Nine, TypedFizzBuzzNumbers.Ten,
        TypedFizzBuzzNumbers.Eleven, TypedFizzBuzzNumbers.Twelve, TypedFizzBuzzNumbers.Thirteen, TypedFizzBuzzNumbers.Fourteen, TypedFizzBuzzNumbers.Fifteen, TypedFizzBuzzNumbers.Sixteen, TypedFizzBuzzNumbers.Seventeen, TypedFizzBuzzNumbers.Eighteen, TypedFizzBuzzNumbers.Nineteen,        TypedFizzBuzzNumbers.Twenty,
        TypedFizzBuzzNumbers.TwentyOne, TypedFizzBuzzNumbers.TwentyTwo, TypedFizzBuzzNumbers.TwentyThree, TypedFizzBuzzNumbers.TwentyFour, TypedFizzBuzzNumbers.TwentyFive, TypedFizzBuzzNumbers.TwentySix, TypedFizzBuzzNumbers.TwentySeven, TypedFizzBuzzNumbers.TwentyEight, TypedFizzBuzzNumbers.TwentyNine, TypedFizzBuzzNumbers.Thirty,
        TypedFizzBuzzNumbers.ThirtyOne, TypedFizzBuzzNumbers.ThirtyTwo, TypedFizzBuzzNumbers.ThirtyThree, TypedFizzBuzzNumbers.ThirtyFour, TypedFizzBuzzNumbers.ThirtyFive, TypedFizzBuzzNumbers.ThirtySix, TypedFizzBuzzNumbers.ThirtySeven, TypedFizzBuzzNumbers.ThirtyEight, TypedFizzBuzzNumbers.ThirtyNine, TypedFizzBuzzNumbers.Forty,
        TypedFizzBuzzNumbers.FortyOne, TypedFizzBuzzNumbers.FortyTwo, TypedFizzBuzzNumbers.FortyThree, TypedFizzBuzzNumbers.FortyFour, TypedFizzBuzzNumbers.FortyFive, TypedFizzBuzzNumbers.FortySix, TypedFizzBuzzNumbers.FortySeven, TypedFizzBuzzNumbers.FortyEight, TypedFizzBuzzNumbers.FortyNine, TypedFizzBuzzNumbers.Fifty,
        TypedFizzBuzzNumbers.FiftyOne, TypedFizzBuzzNumbers.FiftyTwo, TypedFizzBuzzNumbers.FiftyThree,TypedFizzBuzzNumbers.FiftyFour, TypedFizzBuzzNumbers.FiftyFive, TypedFizzBuzzNumbers.FiftySix, TypedFizzBuzzNumbers.FiftySeven, TypedFizzBuzzNumbers.FiftyEight, TypedFizzBuzzNumbers.FiftyNine,TypedFizzBuzzNumbers.Sixty,
        TypedFizzBuzzNumbers.SixtyOne, TypedFizzBuzzNumbers.SixtyTwo, TypedFizzBuzzNumbers.SixtyThree, TypedFizzBuzzNumbers.SixtyFour, TypedFizzBuzzNumbers.SixtyFive, TypedFizzBuzzNumbers.SixtySix, TypedFizzBuzzNumbers.SixtySeven, TypedFizzBuzzNumbers.SixtyEight, TypedFizzBuzzNumbers.SixtyNine, TypedFizzBuzzNumbers.Seventy, TypedFizzBuzzNumbers.SeventyOne,
        TypedFizzBuzzNumbers.SeventyTwo, TypedFizzBuzzNumbers.SeventyThree, TypedFizzBuzzNumbers.SeventyFour, TypedFizzBuzzNumbers.SeventyFive, TypedFizzBuzzNumbers.SeventySix, TypedFizzBuzzNumbers.SeventySeven, TypedFizzBuzzNumbers.SeventyEight, TypedFizzBuzzNumbers.SeventyNine, TypedFizzBuzzNumbers.Eighty, TypedFizzBuzzNumbers.EightyOne,
        TypedFizzBuzzNumbers.EightyTwo, TypedFizzBuzzNumbers.EightyThree, TypedFizzBuzzNumbers.EightyFour, TypedFizzBuzzNumbers.EightyFive, TypedFizzBuzzNumbers.EightySix, TypedFizzBuzzNumbers.EightySeven, TypedFizzBuzzNumbers.EightyEight, TypedFizzBuzzNumbers.EightyNine, TypedFizzBuzzNumbers.Ninety,
        TypedFizzBuzzNumbers.NinetyOne, TypedFizzBuzzNumbers.NinetyTwo, TypedFizzBuzzNumbers.NinetyThree, TypedFizzBuzzNumbers.NinetyFour, TypedFizzBuzzNumbers.NinetyFive, TypedFizzBuzzNumbers.NinetySix, TypedFizzBuzzNumbers.NinetySeven, TypedFizzBuzzNumbers.NinetyEight, TypedFizzBuzzNumbers.NinetyNine, TypedFizzBuzzNumbers.OneHundred
    };
    /// <summary>
    /// Optimized for top performance.
    /// </summary>
    /// <returns>Enumeration of the fizzbuzz sequence.</returns>
    public FizzBuzzCollection CreateLoopEnumeration() => _fizzBuzzCollectionFactory.Create(SeedArray.ToArray());

    internal static class TypedFizzBuzzNumbers
    {
        public static FizzBuzzArrayValue One = new(Numbers.One);
        public static FizzBuzzArrayValue Two = new(Numbers.Two);
        public static FizzBuzzArrayValue Three = new(Numbers.Three);
        public static FizzBuzzArrayValue Four = new(Numbers.Four);
        public static FizzBuzzArrayValue Five = new(Numbers.Five);
        public static FizzBuzzArrayValue Six = new(Numbers.Six);
        public static FizzBuzzArrayValue Seven = new(Numbers.Seven);
        public static FizzBuzzArrayValue Eight = new(Numbers.Eight);
        public static FizzBuzzArrayValue Nine = new(Numbers.Nine);
        public static FizzBuzzArrayValue Ten = new(Numbers.Ten);
        public static FizzBuzzArrayValue Eleven = new(Numbers.Eleven);
        public static FizzBuzzArrayValue Twelve = new(Numbers.Twelve);
        public static FizzBuzzArrayValue Thirteen = new(Numbers.Thirteen);
        public static FizzBuzzArrayValue Fourteen = new(Numbers.Fourteen);
        public static FizzBuzzArrayValue Fifteen = new(Numbers.Fifteen);
        public static FizzBuzzArrayValue Sixteen = new(Numbers.Sixteen);
        public static FizzBuzzArrayValue Seventeen = new(Numbers.Seventeen);
        public static FizzBuzzArrayValue Eighteen = new(Numbers.Eighteen);
        public static FizzBuzzArrayValue Nineteen = new(Numbers.Nineteen);
        public static FizzBuzzArrayValue Twenty = new(Numbers.Twenty);
        public static FizzBuzzArrayValue TwentyOne = new(Numbers.TwentyOne);
        public static FizzBuzzArrayValue TwentyTwo = new(Numbers.TwentyTwo);
        public static FizzBuzzArrayValue TwentyThree = new(Numbers.TwentyThree);
        public static FizzBuzzArrayValue TwentyFour = new(Numbers.TwentyFour);
        public static FizzBuzzArrayValue TwentyFive = new(Numbers.TwentyFive);
        public static FizzBuzzArrayValue TwentySix = new(Numbers.TwentySix);
        public static FizzBuzzArrayValue TwentySeven = new(Numbers.TwentySeven);
        public static FizzBuzzArrayValue TwentyEight = new(Numbers.TwentyEight);
        public static FizzBuzzArrayValue TwentyNine = new(Numbers.TwentyNine);
        public static FizzBuzzArrayValue Thirty = new(Numbers.Thirty);
        public static FizzBuzzArrayValue ThirtyOne = new(Numbers.ThirtyOne);
        public static FizzBuzzArrayValue ThirtyTwo = new(Numbers.ThirtyTwo);
        public static FizzBuzzArrayValue ThirtyThree = new(Numbers.ThirtyThree);
        public static FizzBuzzArrayValue ThirtyFour = new(Numbers.ThirtyFour);
        public static FizzBuzzArrayValue ThirtyFive = new(Numbers.ThirtyFive);
        public static FizzBuzzArrayValue ThirtySix = new(Numbers.ThirtySix);
        public static FizzBuzzArrayValue ThirtySeven = new(Numbers.ThirtySeven);
        public static FizzBuzzArrayValue ThirtyEight = new(Numbers.ThirtyEight);
        public static FizzBuzzArrayValue ThirtyNine = new(Numbers.ThirtyNine);
        public static FizzBuzzArrayValue Forty = new(Numbers.Forty);
        public static FizzBuzzArrayValue FortyOne = new(Numbers.FortyOne);
        public static FizzBuzzArrayValue FortyTwo = new(Numbers.FortyTwo);
        public static FizzBuzzArrayValue FortyThree = new(Numbers.FortyThree);
        public static FizzBuzzArrayValue FortyFour = new(Numbers.FortyFour);
        public static FizzBuzzArrayValue FortyFive = new(Numbers.FortyFive);
        public static FizzBuzzArrayValue FortySix = new(Numbers.FortySix);
        public static FizzBuzzArrayValue FortySeven = new(Numbers.FortySeven);
        public static FizzBuzzArrayValue FortyEight = new(Numbers.FortyEight);
        public static FizzBuzzArrayValue FortyNine = new(Numbers.FortyNine);
        public static FizzBuzzArrayValue Fifty = new(Numbers.Fifty);
        public static FizzBuzzArrayValue FiftyOne = new(Numbers.FiftyOne);
        public static FizzBuzzArrayValue FiftyTwo = new(Numbers.FiftyTwo);
        public static FizzBuzzArrayValue FiftyThree = new(Numbers.FiftyThree);
        public static FizzBuzzArrayValue FiftyFour = new(Numbers.FiftyFour);
        public static FizzBuzzArrayValue FiftyFive = new(Numbers.FiftyFive);
        public static FizzBuzzArrayValue FiftySix = new(Numbers.FiftySix);
        public static FizzBuzzArrayValue FiftySeven = new(Numbers.FiftySeven);
        public static FizzBuzzArrayValue FiftyEight = new(Numbers.FiftyEight);
        public static FizzBuzzArrayValue FiftyNine = new(Numbers.FiftyNine);
        public static FizzBuzzArrayValue Sixty = new(Numbers.Sixty);
        public static FizzBuzzArrayValue SixtyOne = new(Numbers.SixtyOne);
        public static FizzBuzzArrayValue SixtyTwo = new(Numbers.SixtyTwo);
        public static FizzBuzzArrayValue SixtyThree = new(Numbers.SixtyThree);
        public static FizzBuzzArrayValue SixtyFour = new(Numbers.SixtyFour);
        public static FizzBuzzArrayValue SixtyFive = new(Numbers.SixtyFive);
        public static FizzBuzzArrayValue SixtySix = new(Numbers.SixtySix);
        public static FizzBuzzArrayValue SixtySeven = new(Numbers.SixtySeven);
        public static FizzBuzzArrayValue SixtyEight = new(Numbers.SixtyEight);
        public static FizzBuzzArrayValue SixtyNine = new(Numbers.SixtyNine);
        public static FizzBuzzArrayValue Seventy = new(Numbers.Seventy);
        public static FizzBuzzArrayValue SeventyOne = new(Numbers.SeventyOne);
        public static FizzBuzzArrayValue SeventyTwo = new(Numbers.SeventyTwo);
        public static FizzBuzzArrayValue SeventyThree = new(Numbers.SeventyThree);
        public static FizzBuzzArrayValue SeventyFour = new(Numbers.SeventyFour);
        public static FizzBuzzArrayValue SeventyFive = new(Numbers.SeventyFive);
        public static FizzBuzzArrayValue SeventySix = new(Numbers.SeventySix);
        public static FizzBuzzArrayValue SeventySeven = new(Numbers.SeventySeven);
        public static FizzBuzzArrayValue SeventyEight = new(Numbers.SeventyEight);
        public static FizzBuzzArrayValue SeventyNine = new(Numbers.SeventyNine);
        public static FizzBuzzArrayValue Eighty = new(Numbers.Eighty);
        public static FizzBuzzArrayValue EightyOne = new(Numbers.EightyOne);
        public static FizzBuzzArrayValue EightyTwo = new(Numbers.EightyTwo);
        public static FizzBuzzArrayValue EightyThree = new(Numbers.EightyThree);
        public static FizzBuzzArrayValue EightyFour = new(Numbers.EightyFour);
        public static FizzBuzzArrayValue EightyFive = new(Numbers.EightyFive);
        public static FizzBuzzArrayValue EightySix = new(Numbers.EightySix);
        public static FizzBuzzArrayValue EightySeven = new(Numbers.EightySeven);
        public static FizzBuzzArrayValue EightyEight = new(Numbers.EightyEight);
        public static FizzBuzzArrayValue EightyNine = new(Numbers.EightyNine);
        public static FizzBuzzArrayValue Ninety = new(Numbers.Ninety);
        public static FizzBuzzArrayValue NinetyOne = new(Numbers.NinetyOne);
        public static FizzBuzzArrayValue NinetyTwo = new(Numbers.NinetyTwo);
        public static FizzBuzzArrayValue NinetyThree = new(Numbers.NinetyThree);
        public static FizzBuzzArrayValue NinetyFour = new(Numbers.NinetyFour);
        public static FizzBuzzArrayValue NinetyFive = new(Numbers.NinetyFive);
        public static FizzBuzzArrayValue NinetySix = new(Numbers.NinetySix);
        public static FizzBuzzArrayValue NinetySeven = new(Numbers.NinetySeven);
        public static FizzBuzzArrayValue NinetyEight = new(Numbers.NinetyEight);
        public static FizzBuzzArrayValue NinetyNine = new(Numbers.NinetyNine);
        public static FizzBuzzArrayValue OneHundred = new(Numbers.OneHundred);
    }
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