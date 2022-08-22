public class CardTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6407
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.CardPlayer> players; // 0x18
	public int pot; // 0x20
	public CardTable.TexasHoldEm texasHoldEm; // 0x28
	public int lastActionId; // 0x30
	public ulong lastActionTarget; // 0x38
	public int lastActionValue; // 0x40
	public uint potRef; // 0x44


	public static void ResetToPool(CardTable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardTable instance) { }

	public CardTable Copy() { }

	public static CardTable Deserialize(Stream stream) { }

	public static CardTable DeserializeLengthDelimited(Stream stream) { }

	public static CardTable DeserializeLength(Stream stream, int length) { }

	public static CardTable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardTable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardTable Deserialize(byte[] buffer, CardTable instance, bool isDelta = False) { }

	public static CardTable Deserialize(Stream stream, CardTable instance, bool isDelta) { }

	public static CardTable DeserializeLengthDelimited(Stream stream, CardTable instance, bool isDelta) { }

	public static CardTable DeserializeLength(Stream stream, int length, CardTable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardTable instance, CardTable previous) { }

	public static void Serialize(Stream stream, CardTable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardTable instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardTable instance) { }

	public void .ctor() { }

}

public class CardTable.CardPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6408
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<int> cards; // 0x20
	public int scrap; // 0x28
	public int state; // 0x2C
	public int availableInputs; // 0x30
	public int betThisRound; // 0x34
	public int betThisTurn; // 0x38
	public int trueCardCount; // 0x3C
	public bool leftRoundEarly; // 0x40
	public bool sendCardDetails; // 0x41


	public static void ResetToPool(CardTable.CardPlayer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardTable.CardPlayer instance) { }

	public CardTable.CardPlayer Copy() { }

	public static CardTable.CardPlayer Deserialize(Stream stream) { }

	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length) { }

	public static CardTable.CardPlayer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardPlayer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardTable.CardPlayer Deserialize(byte[] buffer, CardTable.CardPlayer instance, bool isDelta = False) { }

	public static CardTable.CardPlayer Deserialize(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length, CardTable.CardPlayer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardTable.CardPlayer instance, CardTable.CardPlayer previous) { }

	public static void Serialize(Stream stream, CardTable.CardPlayer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardTable.CardPlayer instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardTable.CardPlayer instance) { }

	public void .ctor() { }

}

public class CardTable.TexasHoldEm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6409
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int dealerIndex; // 0x14
	public List<int> communityCards; // 0x18
	public int activePlayerIndex; // 0x20
	public int biggestRaiseThisTurn; // 0x24


	public static void ResetToPool(CardTable.TexasHoldEm instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardTable.TexasHoldEm instance) { }

	public CardTable.TexasHoldEm Copy() { }

	public static CardTable.TexasHoldEm Deserialize(Stream stream) { }

	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	public static CardTable.TexasHoldEm Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardTable.TexasHoldEm previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardTable.TexasHoldEm Deserialize(byte[] buffer, CardTable.TexasHoldEm instance, bool isDelta = False) { }

	public static CardTable.TexasHoldEm Deserialize(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length, CardTable.TexasHoldEm instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardTable.TexasHoldEm instance, CardTable.TexasHoldEm previous) { }

	public static void Serialize(Stream stream, CardTable.TexasHoldEm instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardTable.TexasHoldEm instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance) { }

	public void .ctor() { }

}

public class CardTable.WinnerBreakdown : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6410
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.WinnerBreakdown.Winner> winners; // 0x18
	public int winningScore; // 0x20


	public static void ResetToPool(CardTable.WinnerBreakdown instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardTable.WinnerBreakdown instance) { }

	public CardTable.WinnerBreakdown Copy() { }

	public static CardTable.WinnerBreakdown Deserialize(Stream stream) { }

	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream) { }

	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length) { }

	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer, CardTable.WinnerBreakdown instance, bool isDelta = False) { }

	public static CardTable.WinnerBreakdown Deserialize(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown instance, CardTable.WinnerBreakdown previous) { }

	public static void Serialize(Stream stream, CardTable.WinnerBreakdown instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance) { }

	public void .ctor() { }

}

public class CardTable.WinnerBreakdown.Winner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6411
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong ID; // 0x18
	public int winnings; // 0x20
	public bool primaryWinner; // 0x24


	public static void ResetToPool(CardTable.WinnerBreakdown.Winner instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardTable.WinnerBreakdown.Winner instance) { }

	public CardTable.WinnerBreakdown.Winner Copy() { }

	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream) { }

	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream) { }

	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length) { }

	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown.Winner previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer, CardTable.WinnerBreakdown.Winner instance, bool isDelta = False) { }

	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown.Winner instance, CardTable.WinnerBreakdown.Winner previous) { }

	public static void Serialize(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown.Winner instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	public void .ctor() { }

}

public class CardTable.CardList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6412
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> cards; // 0x18


	public static void ResetToPool(CardTable.CardList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardTable.CardList instance) { }

	public CardTable.CardList Copy() { }

	public static CardTable.CardList Deserialize(Stream stream) { }

	public static CardTable.CardList DeserializeLengthDelimited(Stream stream) { }

	public static CardTable.CardList DeserializeLength(Stream stream, int length) { }

	public static CardTable.CardList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardTable.CardList Deserialize(byte[] buffer, CardTable.CardList instance, bool isDelta = False) { }

	public static CardTable.CardList Deserialize(Stream stream, CardTable.CardList instance, bool isDelta) { }

	public static CardTable.CardList DeserializeLengthDelimited(Stream stream, CardTable.CardList instance, bool isDelta) { }

	public static CardTable.CardList DeserializeLength(Stream stream, int length, CardTable.CardList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardTable.CardList instance, CardTable.CardList previous) { }

	public static void Serialize(Stream stream, CardTable.CardList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardTable.CardList instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardTable.CardList instance) { }

	public void .ctor() { }

}

public class CardTable : BaseVehicle // TypeDefIndex: 8367
{	private Option __menuOption_Menu_Open; // 0x3B8
	private Option __menuOption_Menu_Play; // 0x410
	public static CardTableUI clientUI; // 0x0
	private TimeSince showWinningsTipFor; // 0x468
	private Nullable<bool> localWasHoldingCards; // 0x46C
	private int lastVisualScrap; // 0x470
	private static Dictionary<int, Sprite> tableCardImageDict; // 0x8
	private static Sprite blankCardStatic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <recentlyLeftPlayerName>k__BackingField; // 0x478
	[HeaderAttribute] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
	[SerializeField] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
	private GameObjectRef uiPrefab; // 0x480
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef playerStoragePrefab; // 0x488
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef potPrefab; // 0x490
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ViewModel viewModel; // 0x498
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTableUI.PlayingCardImage[] tableCards; // 0x4A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer[] tableCardBackings; // 0x4A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Canvas cardUICanvas; // 0x4B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image[] tableCardImages; // 0x4B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite blankCard; // 0x4C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform chipStacksParent; // 0x4C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTable.ChipStack[] chipStacks; // 0x4D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTable.ChipStack[] fillerStacks; // 0x4D8
	public ItemDefinition scrapItemDef; // 0x4E0
	public CardTable.PlayerStorageInfo[] playerStoragePoints; // 0x4E8
	public CardTable.CardGameOption gameOption; // 0x4F0
	private CardGameController _gameCont; // 0x4F8
	private const float MAX_STORAGE_INTERACTION_DIST = 1;

	public override bool HasMenuOptions { get; }
	public static bool LocalPlayerInCardsUI { get; }
	public bool ShowTakeWinningsTip { get; }
	public string recentlyLeftPlayerName { get; set; }
	public int ScrapItemID { get; }
	public CardGameController GameController { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static bool get_LocalPlayerInCardsUI() { }

	public bool get_ShowTakeWinningsTip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_recentlyLeftPlayerName(string value) { }

	protected override void ClientInit(Entity info) { }

	public void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	public void UIClosed() { }

	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	[BaseEntity.Menu] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	[BaseEntity.Menu.Description] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	[BaseEntity.Menu.Icon] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	[BaseEntity.Menu.ShowIf] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	public void Menu_Play(BasePlayer player) { }

	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Description] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Icon] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public void PlayerClosedUI(BasePlayer player) { }

	private void DelayedViewModelDeploy(float timeDelay) { }

	private void DeployViewModel() { }

	private void HolsterViewmodel() { }

	public bool RefreshPlayerCards() { }

	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap) { }

	private static Sprite GetImage(int cardIndex) { }

	private void ShowStack(CardTable.ChipStack stack, ref int remainingScrap) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientOnPlayerLeft(BaseEntity.RPCMessage msg) { }

	private void ClearRecentlyLeftPlayer() { }

	public int get_ScrapItemID() { }

	public CardGameController get_GameController() { }

	public override void DestroyShared() { }

	private CardGameController GetGameController() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CardTable.ChipStack : IComparable<CardTable.ChipStack> // TypeDefIndex: 8368
{	public int chipValue; // 0x10
	public GameObject[] chips; // 0x18


	public int CompareTo(CardTable.ChipStack other) { }

	public void .ctor() { }

}

public enum CardTable.CardGameOption // TypeDefIndex: 8369
{	public int value__; // 0x0
	public const CardTable.CardGameOption TexasHoldEm = 0;

}

public class CardTable.PlayerStorageInfo // TypeDefIndex: 8370
{	public Transform storagePos; // 0x10


	public void .ctor() { }

}

