public class HumanNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 8399
{
	private Option __menuOption_MenuDesignAI; 
	[HeaderAttribute] 
	public int AdditionalLosBlockingLayer; 
	[HeaderAttribute] 
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; 
	[HeaderAttribute] 
	public float aimConeScale; 
	public float lastDismountTime; 
	[CompilerGeneratedAttribute] 
	private BaseAIBrain<HumanNPC> <Brain>k__BackingField; 

	public override bool HasMenuOptions { get; }
	public BaseAIBrain<HumanNPC> Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	[CompilerGeneratedAttribute] 
	public BaseAIBrain<HumanNPC> get_Brain() { }

	[CompilerGeneratedAttribute] 
	private void set_Brain(BaseAIBrain<HumanNPC> value) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public override bool IsOnGround() { }

	public void .ctor() { }

}

