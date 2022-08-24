public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8442
{
	private Option __menuOption_MenuDesignAI; 
	[CompilerGeneratedAttribute] 
	private BaseAIBrain<ScarecrowNPC> <Brain>k__BackingField; 
	public float BaseAttackRate; 
	public float BaseAttackDamge; 
	public DamageType AttackDamageType; 
	[HeaderAttribute] 
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; 

	public override bool HasMenuOptions { get; }
	public BaseAIBrain<ScarecrowNPC> Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] 
	public BaseAIBrain<ScarecrowNPC> get_Brain() { }

	[CompilerGeneratedAttribute] 
	protected void set_Brain(BaseAIBrain<ScarecrowNPC> value) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

