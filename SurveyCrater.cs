public class SurveyCrater : BaseCombatEntity // TypeDefIndex: 8461
{	private Option __menuOption_Menu_AnalysisComplete; // 0x240
	private ResourceDispenser resourceDispenser; // 0x298

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override float BoundsPadding() { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	[BaseEntity.Menu.Description] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	[BaseEntity.Menu.Icon] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	public void Menu_AnalysisComplete(BasePlayer player) { }

	public void Menu_Analysis_Start() { }

	public bool Menu_PerformAnalysis_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

