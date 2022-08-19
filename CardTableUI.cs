public class CardTableUI : UIDialog // TypeDefIndex: 10874
{	// Fields
	[HeaderAttribute] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
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

	// Properties
	public CardTableUI.ICardGameSubUI curGameTypeUI { get; set; }
	private float dismountNormalisedProgress { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	public CardTableUI.ICardGameSubUI get_curGameTypeUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71B010 Offset: 0x71A410 VA: 0x18071B010
	private void set_curGameTypeUI(CardTableUI.ICardGameSubUI value) { }

	// RVA: 0x71AF90 Offset: 0x71A390 VA: 0x18071AF90
	private float get_dismountNormalisedProgress() { }

	// RVA: 0x718800 Offset: 0x717C00 VA: 0x180718800
	protected void Awake() { }

	// RVA: 0x71A700 Offset: 0x719B00 VA: 0x18071A700
	protected void Update() { }

	// RVA: 0x719180 Offset: 0x718580 VA: 0x180719180
	public void OnPlayerPressedEscape() { }

	// RVA: 0x718CC0 Offset: 0x7180C0 VA: 0x180718CC0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x719030 Offset: 0x718430 VA: 0x180719030 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x719CC0 Offset: 0x7190C0 VA: 0x180719CC0
	public void SetOwner(CardTable owner) { }

	// RVA: 0x7192D0 Offset: 0x7186D0 VA: 0x1807192D0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x718E80 Offset: 0x718280 VA: 0x180718E80
	public static Sprite GetImage(int cardIndex, CardTableUI.CardType type) { }

	// RVA: 0x719930 Offset: 0x718D30 VA: 0x180719930
	public void SetImage(Image image, int cardIndex, CardTableUI.CardType size) { }

	// RVA: 0x7197F0 Offset: 0x718BF0 VA: 0x1807197F0
	public void SetImage(Image image, Sprite sprite) { }

	// RVA: 0x71A090 Offset: 0x719490 VA: 0x18071A090
	public void ShowTimer() { }

	// RVA: 0x719000 Offset: 0x718400 VA: 0x180719000
	public void HideTimer() { }

	// RVA: 0x719730 Offset: 0x718B30 VA: 0x180719730
	private void RefreshUIState(CardPlayerData localPlayerData, bool forced = False) { }

	// RVA: 0x719D40 Offset: 0x719140 VA: 0x180719D40
	private void SetUIState(CardTableUI.UIState newState, bool forced = False) { }

	// RVA: 0x71A180 Offset: 0x719580 VA: 0x18071A180
	private void UpdateVitals() { }

	// RVA: 0x719BF0 Offset: 0x718FF0 VA: 0x180719BF0
	private void SetInfoUI(CardTableUI.InfoTextUI infoTextUI, string text, CardTableUI.InfoTextUI.Attitude attitude) { }

	// RVA: 0x7193A0 Offset: 0x7187A0 VA: 0x1807193A0
	private void RefreshAvailableInputs(CardPlayerData localPlayerData) { }

	// RVA: 0x719180 Offset: 0x718580 VA: 0x180719180
	private void StartDismountTime() { }

	// RVA: 0x718C10 Offset: 0x718010 VA: 0x180718C10
	private void CheckDismount() { }

	// RVA: 0x71AF10 Offset: 0x71A310 VA: 0x18071AF10
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class CardTableUI.PlayingCardImage // TypeDefIndex: 10875
{	// Fields
	public Rank rank; // 0x10
	public Suit suit; // 0x14
	public Sprite image; // 0x18
	public Sprite imageSmall; // 0x20
	public Sprite imageTransparent; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class CardTableUI.InfoTextUI // TypeDefIndex: 10876
{	// Fields
	public GameObject gameObj; // 0x10
	public RustText rustText; // 0x18
	public Image background; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum CardTableUI.InfoTextUI.Attitude // TypeDefIndex: 10877
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.InfoTextUI.Attitude Neutral = 0;
	public const CardTableUI.InfoTextUI.Attitude Good = 1;
	public const CardTableUI.InfoTextUI.Attitude Bad = 2;

}

public enum CardTableUI.UIState // TypeDefIndex: 10879
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.UIState None = 0;
	public const CardTableUI.UIState Loading = 1;
	public const CardTableUI.UIState WaitingForNextRound = 2;
	public const CardTableUI.UIState Playing = 3;
	public const CardTableUI.UIState CannotJoin = 4;
	public const CardTableUI.UIState NotEnoughPlayers = 5;

}

public struct CardTableUI.KeycodeWithAction // TypeDefIndex: 10880
{	// Fields
	public KeyCode keyCode; // 0x0
	public Action action; // 0x8
	public Translate.Phrase display; // 0x10
	public string extraString; // 0x18

	// Methods

	// RVA: 0xF2A70 Offset: 0xF1E70 VA: 0x1800F2A70
	public void .ctor(KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString) { }

}

public enum CardTableUI.CardType // TypeDefIndex: 10881
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.CardType Large = 0;
	public const CardTableUI.CardType Small = 1;
	public const CardTableUI.CardType LargeTransparent = 2;

}

