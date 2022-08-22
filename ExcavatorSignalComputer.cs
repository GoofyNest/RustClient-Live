public class ExcavatorSignalComputer : BaseCombatEntity // TypeDefIndex: 8391
{	private Option __menuOption_Menu_Press_TrainTunnel; // 0x240
	public float chargePower; // 0x298
	public const BaseEntity.Flags Flag_Ready = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public GameObjectRef supplyPlanePrefab; // 0x2A0
	public Transform[] dropPoints; // 0x2A8
	public Text statusText; // 0x2B0
	public Text timerText; // 0x2B8
	public static readonly Translate.Phrase readyphrase; // 0x0
	public static readonly Translate.Phrase chargephrase; // 0x8
	public static float client_chargeNeeded; // 0x10

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPowered() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	[BaseEntity.Menu.Description] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	[BaseEntity.Menu.Icon] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	public bool Menu_Request_Supplies_ShowIf(BasePlayer player) { }

	public override void PostNetworkUpdate() { }

	public void .ctor() { }

	private static void .cctor() { }

}

