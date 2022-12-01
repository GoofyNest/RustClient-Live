public class PlayingCard // TypeDefIndex: 13830
{
	public readonly bool IsUnknownCard;
	public readonly Suit Suit;
	public readonly Rank Rank;
	public static PlayingCard[] cards;
	public static PlayingCard unknownCard;


	private void .ctor(Suit suit, Rank rank) { }

	private void .ctor() { }

	public static PlayingCard GetCard(Suit suit, Rank rank) { }

	public static PlayingCard GetCard(int suit, int rank) { }

	public static PlayingCard GetCard(int index) { }

	public int GetIndex() { }

	public static int GetIndex(Suit suit, Rank rank) { }

	public int GetPokerEvaluationValue() { }

	private int GetPokerSuitCode() { }

	private static PlayingCard[] GenerateAllCards() { }

	private static void .cctor() { }

}

