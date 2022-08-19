public class PlayingCard // TypeDefIndex: 12012
{	// Fields
	public readonly Suit Suit; // 0x10
	public readonly Rank Rank; // 0x14
	public static PlayingCard[] cards; // 0x0

	// Methods

	// RVA: 0x45B750 Offset: 0x45AB50 VA: 0x18045B750
	private void .ctor(Suit suit, Rank rank) { }

	// RVA: 0x8C6740 Offset: 0x8C5B40 VA: 0x1808C6740
	public static PlayingCard GetCard(Suit suit, Rank rank) { }

	// RVA: 0x8C6610 Offset: 0x8C5A10 VA: 0x1808C6610
	public static PlayingCard GetCard(int suit, int rank) { }

	// RVA: 0x8C66B0 Offset: 0x8C5AB0 VA: 0x1808C66B0
	public static PlayingCard GetCard(int index) { }

	// RVA: 0x8C68F0 Offset: 0x8C5CF0 VA: 0x1808C68F0
	public int GetIndex() { }

	// RVA: 0x8C6950 Offset: 0x8C5D50 VA: 0x1808C6950
	public static int GetIndex(Suit suit, Rank rank) { }

	// RVA: 0x8C6820 Offset: 0x8C5C20 VA: 0x1808C6820
	public int GetEvaluationValue() { }

	// RVA: 0x8C6960 Offset: 0x8C5D60 VA: 0x1808C6960
	private int GetSuitCode() { }

	// RVA: 0x8C6520 Offset: 0x8C5920 VA: 0x1808C6520
	private static PlayingCard[] GenerateAllCards() { }

	// RVA: 0x8C6990 Offset: 0x8C5D90 VA: 0x1808C6990
	private static void .cctor() { }

}

