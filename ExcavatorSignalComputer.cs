public class ExcavatorSignalComputer : BaseCombatEntity // TypeDefIndex: 8391
{	// Fields
	private Option __menuOption_Menu_Press_TrainTunnel; // 0x240
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8BDE70 Offset: 0x8BD270 VA: 0x1808BDE70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8BE610 Offset: 0x8BDA10 VA: 0x1808BE610 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8BE290 Offset: 0x8BD690 VA: 0x1808BE290 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0
	public bool IsPowered() { }

	// RVA: 0x8BE170 Offset: 0x8BD570 VA: 0x1808BE170 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	[BaseEntity.Menu.Description] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	[BaseEntity.Menu.Icon] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF720 Offset: 0xDEB20 VA: 0x1800DF720
	// RVA: 0x8BE240 Offset: 0x8BD640 VA: 0x1808BE240
	public void Menu_Press_TrainTunnel(BasePlayer player) { }

	// RVA: 0x8BE280 Offset: 0x8BD680 VA: 0x1808BE280
	public bool Menu_Request_Supplies_ShowIf(BasePlayer player) { }

	// RVA: 0x8BE380 Offset: 0x8BD780 VA: 0x1808BE380 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

	// RVA: 0x8BE540 Offset: 0x8BD940 VA: 0x1808BE540
	private static void .cctor() { }

}

