public static class PokerLib // TypeDefIndex: 8226
{	// Fields
	public const int CLUB = 32768;
	public const int DIAMOND = 16384;
	public const int HEART = 8192;
	public const int SPADE = 4096;

	// Methods

	// RVA: 0x106E5D0 Offset: 0x106D9D0 VA: 0x18106E5D0
	public static int FindIt(int key) { }

	// RVA: 0x106E870 Offset: 0x106DC70 VA: 0x18106E870
	public static void InitDeck(int[] deck) { }

	// RVA: 0x106E570 Offset: 0x106D970 VA: 0x18106E570
	public static int FindCard(int rank, int suit, int[] deck) { }

	// RVA: 0x106DFE0 Offset: 0x106D3E0 VA: 0x18106DFE0
	public static ushort Eval5Cards(int c1, int c2, int c3, int c4, int c5) { }

	// RVA: 0x106E2F0 Offset: 0x106D6F0 VA: 0x18106E2F0
	public static ushort Eval5Hand(int[] hand) { }

	// RVA: 0x106E3A0 Offset: 0x106D7A0 VA: 0x18106E3A0
	public static ushort Eval7Hand(int[] hand) { }

	// RVA: 0x106E4E0 Offset: 0x106D8E0 VA: 0x18106E4E0
	public static PokerLib.PokerResult EvalToResultName(ushort eval) { }

	// RVA: 0x106E740 Offset: 0x106DB40 VA: 0x18106E740
	public static string HandToString(int[] hand) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x106E980 Offset: 0x106DD80 VA: 0x18106E980
	internal static int <FindCard>g__Rank|6_0(int card) { }

}

public enum PokerLib.PokerResult // TypeDefIndex: 8227
{	// Fields
	public int value__; // 0x0
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

