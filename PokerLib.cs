public static class PokerLib // TypeDefIndex: 8226
{
public const int CLUB = 32768;
public const int DIAMOND = 16384;
public const int HEART = 8192;
public const int SPADE = 4096;


public static int FindIt(int key) { }

public static void InitDeck(int[] deck) { }

public static int FindCard(int rank, int suit, int[] deck) { }

public static ushort Eval5Cards(int c1, int c2, int c3, int c4, int c5) { }

public static ushort Eval5Hand(int[] hand) { }

public static ushort Eval7Hand(int[] hand) { }

public static PokerLib.PokerResult EvalToResultName(ushort eval) { }

public static string HandToString(int[] hand) { }

	[CompilerGeneratedAttribute] 
internal static int <FindCard>g__Rank|6_0(int card) { }

}

public enum PokerLib.PokerResult // TypeDefIndex: 8227
{
	public int value__; 
public const PokerLib.PokerResult RoyalFlush = 0;
public const PokerLib.PokerResult StraightFlush = 1;
public const PokerLib.PokerResult FourOfAKind = 2;
public const PokerLib.PokerResult FullHouse = 3;
public const PokerLib.PokerResult Flush = 4;
public const PokerLib.PokerResult Straight = 5;
public const PokerLib.PokerResult ThreeOfAKind = 6;
public const PokerLib.PokerResult TwoPair = 7;
public const PokerLib.PokerResult Pair = 8;
public const PokerLib.PokerResult HighCard = 9;

}

