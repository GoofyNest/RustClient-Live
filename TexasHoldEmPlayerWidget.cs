public class TexasHoldEmPlayerWidget : MonoBehaviour // TypeDefIndex: 12561
{
	[SerializeField] 
	private RawImage avatar; 
	[SerializeField] 
	private RustText playerName; 
	[SerializeField] 
	private RustText scrapTotal; 
	[SerializeField] 
	private RustText betTotal; 
	[SerializeField] 
	private Image background; 
	[SerializeField] 
	private Color inactiveBackground; 
	[SerializeField] 
	private Color activeBackground; 
	[SerializeField] 
	private Color foldedBackground; 
	[SerializeField] 
	private Color winnerBackground; 
	[SerializeField] 
	private Animation actionShowAnimation; 
	[SerializeField] 
	private RustText actionText; 
	[SerializeField] 
	private Sprite dealerChip; 
	[SerializeField] 
	private Sprite smallBlindChip; 
	[SerializeField] 
	private Sprite bigBlindChip; 
	[SerializeField] 
	private Sprite canSeeIcon; 
	[SerializeField] 
	private Sprite cannotSeeIcon; 
	[SerializeField] 
	private Sprite noChip; 
	[SerializeField] 
	private Image chip; 
	[SerializeField] 
	private Image[] cardsDisplay; 
	[SerializeField] 
	private Translate.Phrase allInPhrase; 
	[SerializeField] 
	private Translate.Phrase foldPhrase; 
	[SerializeField] 
	private Translate.Phrase raisePhrase; 
	[SerializeField] 
	private Translate.Phrase betPhrase; 
	[SerializeField] 
	private Translate.Phrase checkPhrase; 
	[SerializeField] 
	private Translate.Phrase callPhrase; 
	private Color normalCardColour; 
	private Color fadedCardColour; 
	private TimeSince lastHandResultShow; 


	public void PopulateWidget(CardPlayerData pData, CardTableUI ui, TexasHoldEmPlayerWidget.PlayerUIState uiState, TexasHoldEmPlayerWidget.PlayerChipState chipState, bool isLocalPlayer, bool roundInProgress) { }

	public void DisplayInputAction(TexasHoldEmController.PokerInputOption input, int value) { }

	public void DisplayHandResult(PokerLib.PokerResult result, TexasHoldEmUI ui) { }

	public void .ctor() { }

}

public enum TexasHoldEmPlayerWidget.PlayerUIState // TypeDefIndex: 12562
{
	public int value__; 
	public const TexasHoldEmPlayerWidget.PlayerUIState Default = 0;
	public const TexasHoldEmPlayerWidget.PlayerUIState TheirTurn = 1;
	public const TexasHoldEmPlayerWidget.PlayerUIState Winner = 2;
	public const TexasHoldEmPlayerWidget.PlayerUIState Neutral = 3;
	public const TexasHoldEmPlayerWidget.PlayerUIState Loser = 4;
	public const TexasHoldEmPlayerWidget.PlayerUIState Folded = 5;

}

public enum TexasHoldEmPlayerWidget.PlayerChipState // TypeDefIndex: 12563
{
	public int value__; 
	public const TexasHoldEmPlayerWidget.PlayerChipState None = 0;
	public const TexasHoldEmPlayerWidget.PlayerChipState Dealer = 1;
	public const TexasHoldEmPlayerWidget.PlayerChipState SmallBlind = 2;
	public const TexasHoldEmPlayerWidget.PlayerChipState BigBlind = 3;

}

