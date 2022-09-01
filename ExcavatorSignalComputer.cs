public class ExcavatorSignalComputer : BaseCombatEntity // TypeDefIndex: 8393
{
	private Option __menuOption_Menu_Press_TrainTunnel; 
	public float chargePower; 
	public const BaseEntity.Flags Flag_Ready = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public GameObjectRef supplyPlanePrefab; 
	public Transform[] dropPoints; 
	public Text statusText; 
	public Text timerText; 
	public static readonly Translate.Phrase readyphrase; 
	public static readonly Translate.Phrase chargephrase; 
	public static float client_chargeNeeded; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPowered() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	public bool Menu_Request_Supplies_ShowIf(BasePlayer player) { }

	public override void PostNetworkUpdate() { }

	public void .ctor() { }

	private static void .cctor() { }

}

