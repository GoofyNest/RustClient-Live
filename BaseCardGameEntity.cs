public abstract class BaseCardGameEntity : BaseVehicle // TypeDefIndex: 10035
{
	private Option __menuOption_Menu_Open;
	[HeaderAttribute]
	[SerializeField]
	private GameObjectRef uiPrefab;
	public ItemDefinition scrapItemDef;
	[SerializeField]
	private GameObjectRef potPrefab;
	public BaseCardGameEntity.PlayerStorageInfo[] playerStoragePoints;
	[SerializeField]
	private GameObjectRef playerStoragePrefab;
	private CardGameController _gameCont;
	public BaseCardGameEntity.CardGameOption gameOption;
	[CompilerGeneratedAttribute]
	private string <recentlyLeftPlayerName>k__BackingField;
	public static CardGameUI localClientUI;
	private TimeSince showWinningsTipFor;

	public override bool HasMenuOptions { get; }
	public int ScrapItemID { get; }
	public CardGameController GameController { get; }
	protected abstract float MaxStorageInteractionDist { get; }
	public string recentlyLeftPlayerName { get; set; }
	public bool ShowTakeWinningsTip { get; }
	public static bool LocalPlayerInCardsUI { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int get_ScrapItemID() { }

	public CardGameController get_GameController() { }

	protected abstract float get_MaxStorageInteractionDist();

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private CardGameController GetGameController() { }

	public override void DestroyShared() { }

	[CompilerGeneratedAttribute]
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute]
	private void set_recentlyLeftPlayerName(string value) { }

	public bool get_ShowTakeWinningsTip() { }

	public static bool get_LocalPlayerInCardsUI() { }

	public virtual void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardGameUI.KeycodeWithAction> targetList) { }

	public void ClientInput(int inputType, int inputValue = 0) { }

	public void PlayerClosedUI(BasePlayer player) { }

	public virtual void UIClosed() { }

	public CardGameUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public abstract void Menu_Play(BasePlayer player);

	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client]
	private void OnResultsDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ClientOnPlayerLeft(BaseEntity.RPCMessage msg) { }

	private void ClearRecentlyLeftPlayer() { }

	protected void .ctor() { }

}

public class BaseCardGameEntity.PlayerStorageInfo // TypeDefIndex: 10036
{
	public Transform storagePos;


	public void .ctor() { }

}

public enum BaseCardGameEntity.CardGameOption // TypeDefIndex: 10037
{
	public int value__;
	public const BaseCardGameEntity.CardGameOption TexasHoldEm = 0;
	public const BaseCardGameEntity.CardGameOption Blackjack = 1;

}

