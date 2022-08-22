public class CardTableUI : UIDialog // TypeDefIndex: 10874
{	[HeaderAttribute] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
	[SerializeField] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
	private CardTableUI.InfoTextUI primaryInfo; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTableUI.InfoTextUI secondaryInfo; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTableUI.InfoTextUI playerLeaveInfo; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject playingUI; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject availableInputsUI; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTableUI.PlayingCardImage[] cardImages; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardInputWidget[] inputWidgets; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustSlider dismountProgressSlider; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseLoading; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseWaitingForNextRound; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseNotEnoughPlayers; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseYourTurn; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phrasePlayerLeftGame; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color colourNeutralUI; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color colourGoodUI; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color colourBadUI; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CanvasGroup timerCanvas; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustSlider timerSlider; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UIChat chat; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HudElement Hunger; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HudElement Thirst; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HudElement Health; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HudElement PendingHealth; // 0xF8
	public Sprite cardNone; // 0x100
	public Sprite cardBackLarge; // 0x108
	public Sprite cardBackSmall; // 0x110
	private static Sprite cardBackLargeStatic; // 0x0
	private static Sprite cardBackSmallStatic; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TexasHoldEmUI texasHoldEmUI; // 0x118
	private CardTable owner; // 0x120
	private CardTableUI.UIState uiState; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTableUI.ICardGameSubUI <curGameTypeUI>k__BackingField; // 0x130
	private int lastInputCount; // 0x138
	private TimeSince showInputTimer; // 0x13C
	private const float DismountTime = 1;
	private bool dismountInProgress; // 0x140
	private TimeSince dismountStart; // 0x144
	public CardTableUI.KeycodeWithAction dismountInput; // 0x148
	public List<CardTableUI.KeycodeWithAction> availableInputs; // 0x168
	private static Dictionary<int, Sprite> largeCardImageDict; // 0x10
	private static Dictionary<int, Sprite> smallCardImageDict; // 0x18
	private static Dictionary<int, Sprite> transparentCardImageDict; // 0x20

	public CardTableUI.ICardGameSubUI curGameTypeUI { get; set; }
	private float dismountNormalisedProgress { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public CardTableUI.ICardGameSubUI get_curGameTypeUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class CardTableUI.PlayingCardImage // TypeDefIndex: 10875
{	public Rank rank; // 0x10
	public Suit suit; // 0x14
	public Sprite image; // 0x18
	public Sprite imageSmall; // 0x20
	public Sprite imageTransparent; // 0x28


	public void .ctor() { }

}

public class CardTableUI.InfoTextUI // TypeDefIndex: 10876
{	public GameObject gameObj; // 0x10
	public RustText rustText; // 0x18
	public Image background; // 0x20


	public void .ctor() { }

}

public enum CardTableUI.InfoTextUI.Attitude // TypeDefIndex: 10877
{	public int value__; // 0x0
	public const CardTableUI.InfoTextUI.Attitude Neutral = 0;
	public const CardTableUI.InfoTextUI.Attitude Good = 1;
	public const CardTableUI.InfoTextUI.Attitude Bad = 2;

}

public enum CardTableUI.UIState // TypeDefIndex: 10879
{	public int value__; // 0x0
	public const CardTableUI.UIState None = 0;
	public const CardTableUI.UIState Loading = 1;
	public const CardTableUI.UIState WaitingForNextRound = 2;
	public const CardTableUI.UIState Playing = 3;
	public const CardTableUI.UIState CannotJoin = 4;
	public const CardTableUI.UIState NotEnoughPlayers = 5;

}

public struct CardTableUI.KeycodeWithAction // TypeDefIndex: 10880
{	public KeyCode keyCode; // 0x0
	public Action action; // 0x8
	public Translate.Phrase display; // 0x10
	public string extraString; // 0x18


	public void .ctor(KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString) { }

}

public enum CardTableUI.CardType // TypeDefIndex: 10881
{	public int value__; // 0x0
	public const CardTableUI.CardType Large = 0;
	public const CardTableUI.CardType Small = 1;
	public const CardTableUI.CardType LargeTransparent = 2;

}

