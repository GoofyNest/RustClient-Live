public class PlayingCard // TypeDefIndex: 13708
{
	public readonly Suit Suit; 
	public readonly Rank Rank; 
	public static PlayingCard[] cards; 


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

