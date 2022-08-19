public class TexasHoldEmUI : MonoBehaviour, CardTableUI.ICardGameSubUI // TypeDefIndex: 10885
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image[] holeCardImages; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x851C0 Offset: 0x845C0 VA: 0x1800851C0
	[SerializeField] // RVA: 0x851C0 Offset: 0x845C0 VA: 0x1800851C0
	private Image[] communityCardImages; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText potText; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TexasHoldEmPlayerWidget[] playerWidgets; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject raiseRoot; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseNotEnoughBuyIn; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseTooMuchBuyIn; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseYouWinTheRound; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseRoundWinner; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseRoundWinners; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseScrapWon; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseScrapReturned; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseWinningHand; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseRoyalFlush; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseStraightFlush; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseFourOfAKind; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseFullHouse; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseFlush; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseStraight; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseThreeOfAKind; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseTwoPair; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phrasePair; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseHighCard; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <DynamicBetAmount>k__BackingField; // 0xD0
	private ulong lastActionId; // 0xD8
	private int lastPotUpdate; // 0xE0
	private List<PlayingCard> localPlayerCards; // 0xE8

	// Properties
	public int DynamicBetAmount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x84C150 Offset: 0x84B550 VA: 0x18084C150 Slot: 4
	public int get_DynamicBetAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x75BD40 Offset: 0x75B140 VA: 0x18075BD40
	private void set_DynamicBetAmount(int value) { }

	// RVA: 0x84B530 Offset: 0x84A930 VA: 0x18084B530 Slot: 5
	public void UpdateInGameUI(CardTableUI ui, CardGameController game) { }

	// RVA: 0x84A790 Offset: 0x849B90 VA: 0x18084A790 Slot: 6
	public string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude) { }

	// RVA: 0x84B4F0 Offset: 0x84A8F0 VA: 0x18084B4F0 Slot: 7
	public void UpdateInGameUI_NoPlayer(CardTableUI ui) { }

	// RVA: 0x84B240 Offset: 0x84A640 VA: 0x18084B240
	private string GetWinnerNameFromID(ulong playerID) { }

	// RVA: 0x84B3C0 Offset: 0x84A7C0 VA: 0x18084B3C0
	private void PopulateCards(List<PlayingCard> cards, Image[] slots, CardTableUI ui) { }

	// RVA: 0x84B320 Offset: 0x84A720 VA: 0x18084B320
	public Translate.Phrase PokerResultToPhrase(PokerLib.PokerResult result) { }

	// RVA: 0x84C0E0 Offset: 0x84B4E0 VA: 0x18084C0E0
	public void .ctor() { }

}

private sealed class TexasHoldEmUI.<>c // TypeDefIndex: 10886
{	// Fields
	public static readonly TexasHoldEmUI.<>c <>9; // 0x0
	public static Predicate<CardTableUI.KeycodeWithAction> <>9__30_0; // 0x8

	// Methods

	// RVA: 0x854CC0 Offset: 0x8540C0 VA: 0x180854CC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x853B50 Offset: 0x852F50 VA: 0x180853B50
	internal bool <UpdateInGameUI>b__30_0(CardTableUI.KeycodeWithAction p) { }

}

