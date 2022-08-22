public class TexasHoldEmPlayerWidget : MonoBehaviour // TypeDefIndex: 10882
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RawImage avatar; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText playerName; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText scrapTotal; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText betTotal; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image background; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color inactiveBackground; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color activeBackground; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color foldedBackground; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color winnerBackground; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Animation actionShowAnimation; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText actionText; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite dealerChip; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite smallBlindChip; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite bigBlindChip; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite canSeeIcon; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite cannotSeeIcon; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite noChip; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image chip; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image[] cardsDisplay; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase allInPhrase; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase foldPhrase; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase raisePhrase; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase betPhrase; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase checkPhrase; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase callPhrase; // 0xF8
	private Color normalCardColour; // 0x100
	private Color fadedCardColour; // 0x110
	private TimeSince lastHandResultShow; // 0x120


	public void PopulateWidget(CardPlayerData pData, CardTableUI ui, TexasHoldEmPlayerWidget.PlayerUIState uiState, TexasHoldEmPlayerWidget.PlayerChipState chipState, bool isLocalPlayer, bool roundInProgress) { }

	public void DisplayInputAction(TexasHoldEmController.PokerInputOption input, int value) { }

	public void DisplayHandResult(PokerLib.PokerResult result, TexasHoldEmUI ui) { }

	public void .ctor() { }

}

public enum TexasHoldEmPlayerWidget.PlayerUIState // TypeDefIndex: 10883
{	public int value__; // 0x0
	public const TexasHoldEmPlayerWidget.PlayerUIState Default = 0;
	public const TexasHoldEmPlayerWidget.PlayerUIState TheirTurn = 1;
	public const TexasHoldEmPlayerWidget.PlayerUIState Winner = 2;
	public const TexasHoldEmPlayerWidget.PlayerUIState Neutral = 3;
	public const TexasHoldEmPlayerWidget.PlayerUIState Loser = 4;
	public const TexasHoldEmPlayerWidget.PlayerUIState Folded = 5;

}

public enum TexasHoldEmPlayerWidget.PlayerChipState // TypeDefIndex: 10884
{	public int value__; // 0x0
	public const TexasHoldEmPlayerWidget.PlayerChipState None = 0;
	public const TexasHoldEmPlayerWidget.PlayerChipState Dealer = 1;
	public const TexasHoldEmPlayerWidget.PlayerChipState SmallBlind = 2;
	public const TexasHoldEmPlayerWidget.PlayerChipState BigBlind = 3;

}

