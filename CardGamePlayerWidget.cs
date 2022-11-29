public class CardGamePlayerWidget : MonoBehaviour // TypeDefIndex: 12634
{
	[SerializeField] 
	private GameObjectRef cardImageSmallPrefab; 
	[SerializeField] 
	private RawImage avatar; 
	[SerializeField] 
	private RustText playerName; 
	[SerializeField] 
	private RustText scrapTotal; 
	[SerializeField] 
	private RustText betText; 
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
	private Sprite canSeeIcon; 
	[SerializeField] 
	private Sprite cannotSeeIcon; 
	[SerializeField] 
	private Sprite blankSprite; 
	[SerializeField] 
	private Image cornerIcon; 
	[SerializeField] 
	private Transform cardDisplayParent; 
	[SerializeField] 
	private GridLayoutGroup cardDisplayGridLayout; 
	[SerializeField] 
	private GameObject circle; 
	[SerializeField] 
	private RustText circleText; 
	private Color normalCardColour; 
	private Color fadedCardColour; 
	private List<Image> cardImages; 
	private List<PlayingCard> emptyCardList; 
	private Vector2 cardSizeOneRow; 
	private Vector2 cardSizeTwoRows; 
	private TimeSince lastHandResultShow; 


	protected void Awake() { }

	protected void OnDisable() { }

	public void PopulateWidget(CardPlayerData pData, CardGamePlayerWidget.PlayerUIState uiState, bool isLocalPlayer, bool roundInProgress, Sprite iconSprite, string betString, string circleString = "") { }

	public void DisplayInputAction(Translate.Phrase phrase, int value) { }

	public void DisplayResultAnimation(Translate.Phrase phrase) { }

	private void SetCardCount(int mainCount, int secondaryCount) { }

	private void SetCardImages(List<PlayingCard> mainCards, List<PlayingCard> secondaryCards, bool leftRoundEarly) { }

	public void .ctor() { }

}

public enum CardGamePlayerWidget.PlayerUIState // TypeDefIndex: 12635
{
	public int value__; 
	public const CardGamePlayerWidget.PlayerUIState Default = 0;
	public const CardGamePlayerWidget.PlayerUIState TheirTurn = 1;
	public const CardGamePlayerWidget.PlayerUIState Winner = 2;
	public const CardGamePlayerWidget.PlayerUIState Neutral = 3;
	public const CardGamePlayerWidget.PlayerUIState Loser = 4;
	public const CardGamePlayerWidget.PlayerUIState OutOfRound = 5;

}

