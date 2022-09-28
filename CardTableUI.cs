public class CardTableUI : UIDialog // TypeDefIndex: 12553
{
	[HeaderAttribute] 
	[SerializeField] 
	private CardTableUI.InfoTextUI primaryInfo; 
	[SerializeField] 
	private CardTableUI.InfoTextUI secondaryInfo; 
	[SerializeField] 
	private CardTableUI.InfoTextUI playerLeaveInfo; 
	[SerializeField] 
	private GameObject playingUI; 
	[SerializeField] 
	private GameObject availableInputsUI; 
	[SerializeField] 
	private CardTableUI.PlayingCardImage[] cardImages; 
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
	private Translate.Phrase phraseYourTurn; 
	[SerializeField] 
	private Translate.Phrase phrasePlayerLeftGame; 
	[SerializeField] 
	private Color colourNeutralUI; 
	[SerializeField] 
	private Color colourGoodUI; 
	[SerializeField] 
	private Color colourBadUI; 
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
	private CardTable owner; 
	private CardTableUI.UIState uiState; 
	[CompilerGeneratedAttribute] 
	private CardTableUI.ICardGameSubUI <curGameTypeUI>k__BackingField; 
	private int lastInputCount; 
	private TimeSince showInputTimer; 
	private const float DismountTime = 1;
	private bool dismountInProgress; 
	private TimeSince dismountStart; 
	public CardTableUI.KeycodeWithAction dismountInput; 
	public List<CardTableUI.KeycodeWithAction> availableInputs; 
	private static Dictionary<int, Sprite> largeCardImageDict; 
	private static Dictionary<int, Sprite> smallCardImageDict; 
	private static Dictionary<int, Sprite> transparentCardImageDict; 

	public CardTableUI.ICardGameSubUI curGameTypeUI { get; set; }
	private float dismountNormalisedProgress { get; }


	[CompilerGeneratedAttribute] 
	public CardTableUI.ICardGameSubUI get_curGameTypeUI() { }

	[CompilerGeneratedAttribute] 
	private void set_curGameTypeUI(CardTableUI.ICardGameSubUI value) { }

	private float get_dismountNormalisedProgress() { }

	protected void Awake() { }

	protected void Update() { }

	public void OnPlayerPressedEscape() { }

	public override void CloseDialog() { }

	protected override void OnDisable() { }

	public void SetOwner(CardTable owner) { }

	public override void OpenDialog() { }

	public static Sprite GetImage(int cardIndex, CardTableUI.CardType type) { }

	public void SetImage(Image image, int cardIndex, CardTableUI.CardType size) { }

	public void SetImage(Image image, Sprite sprite) { }

	public void ShowTimer() { }

	public void HideTimer() { }

	private void RefreshUIState(CardPlayerData localPlayerData, bool forced = False) { }

	private void SetUIState(CardTableUI.UIState newState, bool forced = False) { }

	private void UpdateVitals() { }

	private void SetInfoUI(CardTableUI.InfoTextUI infoTextUI, string text, CardTableUI.InfoTextUI.Attitude attitude) { }

	private void RefreshAvailableInputs(CardPlayerData localPlayerData) { }

	private void StartDismountTime() { }

	private void CheckDismount() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CardTableUI.PlayingCardImage // TypeDefIndex: 12554
{
	public Rank rank; 
	public Suit suit; 
	public Sprite image; 
	public Sprite imageSmall; 
	public Sprite imageTransparent; 


	public void .ctor() { }

}

public class CardTableUI.InfoTextUI // TypeDefIndex: 12555
{
	public GameObject gameObj; 
	public RustText rustText; 
	public Image background; 


	public void .ctor() { }

}

public enum CardTableUI.InfoTextUI.Attitude // TypeDefIndex: 12556
{
	public int value__; 
	public const CardTableUI.InfoTextUI.Attitude Neutral = 0;
	public const CardTableUI.InfoTextUI.Attitude Good = 1;
	public const CardTableUI.InfoTextUI.Attitude Bad = 2;

}

public enum CardTableUI.UIState // TypeDefIndex: 12558
{
	public int value__; 
	public const CardTableUI.UIState None = 0;
	public const CardTableUI.UIState Loading = 1;
	public const CardTableUI.UIState WaitingForNextRound = 2;
	public const CardTableUI.UIState Playing = 3;
	public const CardTableUI.UIState CannotJoin = 4;
	public const CardTableUI.UIState NotEnoughPlayers = 5;

}

public struct CardTableUI.KeycodeWithAction // TypeDefIndex: 12559
{
	public KeyCode keyCode; 
	public Action action; 
	public Translate.Phrase display; 
	public string extraString; 


	public void .ctor(KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString) { }

}

public enum CardTableUI.CardType // TypeDefIndex: 12560
{
	public int value__; 
	public const CardTableUI.CardType Large = 0;
	public const CardTableUI.CardType Small = 1;
	public const CardTableUI.CardType LargeTransparent = 2;

}

