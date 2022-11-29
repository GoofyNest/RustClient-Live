public class SurveyCrater : BaseCombatEntity // TypeDefIndex: 10179
{
	private Option __menuOption_Menu_AnalysisComplete; 
	private ResourceDispenser resourceDispenser; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override float BoundsPadding() { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_AnalysisComplete(BasePlayer player) { }

	public void Menu_Analysis_Start() { }

	public bool Menu_PerformAnalysis_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

