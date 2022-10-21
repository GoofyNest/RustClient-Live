public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses // TypeDefIndex: 10029
{
	private Option __menuOption_MenuDesignAI; 
	protected FishBrain brain; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

