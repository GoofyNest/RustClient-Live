public class CardGameUI : UIDialog // TypeDefIndex: 12650
{
	[HeaderAttribute]
	[SerializeField]
	private CardGameUI.InfoTextUI primaryInfo;
	[SerializeField]
	private CardGameUI.InfoTextUI secondaryInfo;
	[SerializeField]
	private CardGameUI.InfoTextUI playerLeaveInfo;
	[SerializeField]
	private GameObject playingUI;
	[SerializeField]
	private CardGameUI.PlayingCardImage[] cardImages;
	[SerializeField]
	private CardInputWidget[] inputWidgets;
	[SerializeField]
	private RustSlider dismountProgressSlider;
	[SerializeField]
	private Translate.Phrase phraseLoading;
	[SerializeField]
	private Translate.Phrase phraseWaitingForNextRound;
	[SerializeField]
	private Translate.Phrase phraseNotEnoughPlayers;
	[SerializeField]
	private Translate.Phrase phrasePlayerLeftGame;
	[SerializeField]
	private Translate.Phrase phraseNotEnoughBuyIn;
	[SerializeField]
	private Translate.Phrase phraseTooMuchBuyIn;
	public Translate.Phrase phraseYourTurn;
	public Translate.Phrase phraseYouWinTheRound;
	public Translate.Phrase phraseRoundWinner;
	public Translate.Phrase phraseRoundWinners;
	public Translate.Phrase phraseScrapWon;
	public Translate.Phrase phraseScrapReturned;
	public Translate.Phrase phraseChangeBetAmount;
	public Translate.Phrase phraseBet;
	public Translate.Phrase phraseBetAdd;
	public Translate.Phrase phraseAllIn;
	public GameObject amountChangeRoot;
	public RustText amountChangeText;
	public Color colourNeutralUI;
	public Color colourGoodUI;
	public Color colourBadUI;
	[SerializeField]
	private CanvasGroup timerCanvas;
	[SerializeField]
	private RustSlider timerSlider;
	[SerializeField]
	private UIChat chat;
	[SerializeField]
	private HudElement Hunger;
	[SerializeField]
	private HudElement Thirst;
	[SerializeField]
	private HudElement Health;
	[SerializeField]
	private HudElement PendingHealth;
	public Sprite cardNone;
	public Sprite cardBackLarge;
	public Sprite cardBackSmall;
	private static Sprite cardBackLargeStatic;
	private static Sprite cardBackSmallStatic;
	[SerializeField]
	private TexasHoldEmUI texasHoldEmUI;
	[SerializeField]
	private BlackjackUI blackjackUI;
	private BaseCardGameEntity owner;
	private CardGameUI.UIState uiState;
	[CompilerGeneratedAttribute]
	private CardGameUI.ICardGameSubUI <curGameTypeUI>k__BackingField;
	public TimeSince turnStartTimer;
	private int lastInputCount;
	private const float DismountTime = 1;
	private bool dismountInProgress;
	private TimeSince dismountStart;
	public CardGameUI.KeycodeWithAction dismountInput;
	public List<CardGameUI.KeycodeWithAction> availableInputs;
	private static Dictionary<int, Sprite> largeCardImageDict;
	private static Dictionary<int, Sprite> smallCardImageDict;
	private static Dictionary<int, Sprite> transparentCardImageDict;

	public CardGameUI.ICardGameSubUI curGameTypeUI { get; set; }
	private float dismountNormalisedProgress { get; }


	[CompilerGeneratedAttribute]
	public CardGameUI.ICardGameSubUI get_curGameTypeUI() { }

	[CompilerGeneratedAttribute]
	private void set_curGameTypeUI(CardGameUI.ICardGameSubUI value) { }

	private float get_dismountNormalisedProgress() { }

	protected void Awake() { }

	protected void Update() { }

	public void OnPlayerPressedEscape() { }

	public override void CloseDialog() { }

	protected override void OnDisable() { }

	public void SetOwner(BaseCardGameEntity owner) { }

	public override void OpenDialog() { }

	public static Sprite GetImage(int cardIndex, CardGameUI.CardType type) { }

	public void SetImage(Image image, int cardIndex, CardGameUI.CardType size) { }

	public void SetImage(Image image, Sprite sprite) { }

	public void ShowTimer(CardPlayerData pData) { }

	public void HideTimer() { }

	public string GetWinnerNameFromID(ulong playerID) { }

	public void PopulateCards(List<PlayingCard> cards, Image[] cardSlotImages, Image[] cardSlotBackings, CardGameUI ui, CardGameUI.CardType cardType, bool showEmptySlots) { }

	private void RefreshUIState(CardPlayerData localPlayerData, bool forced = False) { }

	private void SetUIState(CardGameUI.UIState newState, bool forced = False) { }

	private void UpdateVitals() { }

	private void SetInfoUI(CardGameUI.InfoTextUI infoTextUI, string text, CardGameUI.InfoTextUI.Attitude attitude) { }

	private void RefreshAvailableInputs(CardPlayerData localPlayerData) { }

	private void StartDismountTime() { }

	private void CheckDismount() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CardGameUI.PlayingCardImage // TypeDefIndex: 12651
{
	public Rank rank;
	public Suit suit;
	public Sprite image;
	public Sprite imageSmall;
	public Sprite imageTransparent;


	public void .ctor() { }

}

public class CardGameUI.InfoTextUI // TypeDefIndex: 12652
{
	public GameObject gameObj;
	public RustText rustText;
	public Image background;


	public void .ctor() { }

}

public enum CardGameUI.InfoTextUI.Attitude // TypeDefIndex: 12653
{
	public int value__;
	public const CardGameUI.InfoTextUI.Attitude Neutral = 0;
	public const CardGameUI.InfoTextUI.Attitude Good = 1;
	public const CardGameUI.InfoTextUI.Attitude Bad = 2;

}

public enum CardGameUI.UIState // TypeDefIndex: 12655
{
	public int value__;
	public const CardGameUI.UIState None = 0;
	public const CardGameUI.UIState Loading = 1;
	public const CardGameUI.UIState WaitingForNextRound = 2;
	public const CardGameUI.UIState Playing = 3;
	public const CardGameUI.UIState CannotJoin = 4;
	public const CardGameUI.UIState NotEnoughPlayers = 5;

}

public struct CardGameUI.KeycodeWithAction // TypeDefIndex: 12656
{
	public readonly string actionName;
	public readonly KeyCode keyCode;
	public readonly Action action;
	public readonly Translate.Phrase display;
	public readonly string extraString;


	public void .ctor(string actionName, KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString) { }

}

public enum CardGameUI.CardType // TypeDefIndex: 12657
{
	public int value__;
	public const CardGameUI.CardType Large = 0;
	public const CardGameUI.CardType Small = 1;
	public const CardGameUI.CardType LargeTransparent = 2;

}

