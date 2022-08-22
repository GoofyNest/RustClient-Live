public class PlayingCard // TypeDefIndex: 12012
{	public readonly Suit Suit; // 0x10
	public readonly Rank Rank; // 0x14
	public static PlayingCard[] cards; // 0x0


	private void .ctor(Suit suit, Rank rank) { }

	public static PlayingCard GetCard(Suit suit, Rank rank) { }

	public static PlayingCard GetCard(int suit, int rank) { }

	public static PlayingCard GetCard(int index) { }

	public int GetIndex() { }

	public static int GetIndex(Suit suit, Rank rank) { }

	public int GetEvaluationValue() { }

	private int GetSuitCode() { }

	private static PlayingCard[] GenerateAllCards() { }

	private static void .cctor() { }

}

