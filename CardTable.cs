public class CardTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6407
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<CardTable.CardPlayer> players; 
	public int pot; 
	public CardTable.TexasHoldEm texasHoldEm; 
	public int lastActionId; 
	public ulong lastActionTarget; 
	public int lastActionValue; 
	public uint potRef; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong userid; 
	public List<int> cards; 
	public int scrap; 
	public int state; 
	public int availableInputs; 
	public int betThisRound; 
	public int betThisTurn; 
	public int trueCardCount; 
	public bool leftRoundEarly; 
	public bool sendCardDetails; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int dealerIndex; 
	public List<int> communityCards; 
	public int activePlayerIndex; 
	public int biggestRaiseThisTurn; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<CardTable.WinnerBreakdown.Winner> winners; 
	public int winningScore; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong ID; 
	public int winnings; 
	public bool primaryWinner; 


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
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<int> cards; 


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
{
	private Option __menuOption_Menu_Open; 
	private Option __menuOption_Menu_Play; 
	public static CardTableUI clientUI; 
	private TimeSince showWinningsTipFor; 
	private Nullable<bool> localWasHoldingCards; 
	private int lastVisualScrap; 
	private static Dictionary<int, Sprite> tableCardImageDict; 
	private static Sprite blankCardStatic; 
	[CompilerGeneratedAttribute] 
	private string <recentlyLeftPlayerName>k__BackingField; 
	[HeaderAttribute] 
	[SerializeField] 
	private GameObjectRef uiPrefab; 
	[SerializeField] 
	private GameObjectRef playerStoragePrefab; 
	[SerializeField] 
	private GameObjectRef potPrefab; 
	[SerializeField] 
	private ViewModel viewModel; 
	[SerializeField] 
	private CardTableUI.PlayingCardImage[] tableCards; 
	[SerializeField] 
	private Renderer[] tableCardBackings; 
	[SerializeField] 
	private Canvas cardUICanvas; 
	[SerializeField] 
	private Image[] tableCardImages; 
	[SerializeField] 
	private Sprite blankCard; 
	[SerializeField] 
	private Transform chipStacksParent; 
	[SerializeField] 
	private CardTable.ChipStack[] chipStacks; 
	[SerializeField] 
	private CardTable.ChipStack[] fillerStacks; 
	public ItemDefinition scrapItemDef; 
	public CardTable.PlayerStorageInfo[] playerStoragePoints; 
	public CardTable.CardGameOption gameOption; 
	private CardGameController _gameCont; 
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

	[CompilerGeneratedAttribute] 
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] 
	private void set_recentlyLeftPlayerName(string value) { }

	protected override void ClientInit(Entity info) { }

	public void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	public void UIClosed() { }

	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Play(BasePlayer player) { }

	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
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

	[BaseEntity.RPC_Client] 
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] 
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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
{
	public int chipValue; 
	public GameObject[] chips; 


	public int CompareTo(CardTable.ChipStack other) { }

	public void .ctor() { }

}

public enum CardTable.CardGameOption // TypeDefIndex: 8369
{
	public int value__; 
	public const CardTable.CardGameOption TexasHoldEm = 0;

}

public class CardTable.PlayerStorageInfo // TypeDefIndex: 8370
{
	public Transform storagePos; 


	public void .ctor() { }

}

