public class SurveyCrater : BaseCombatEntity // TypeDefIndex: 8461
{	// Fields
	private Option __menuOption_Menu_AnalysisComplete; // 0x240
	private ResourceDispenser resourceDispenser; // 0x298

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7A3CA0 Offset: 0x7A30A0 VA: 0x1807A3CA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A4100 Offset: 0x7A3500 VA: 0x1807A4100 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A4010 Offset: 0x7A3410 VA: 0x1807A4010 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7A3AD0 Offset: 0x7A2ED0 VA: 0x1807A3AD0 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x7A3AE0 Offset: 0x7A2EE0 VA: 0x1807A3AE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	[BaseEntity.Menu.Description] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	[BaseEntity.Menu.Icon] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	// RVA: 0x7A3FD0 Offset: 0x7A33D0 VA: 0x1807A3FD0
	public void Menu_AnalysisComplete(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Analysis_Start() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool Menu_PerformAnalysis_ShowIf(BasePlayer player) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

