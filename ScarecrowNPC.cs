public class ScarecrowNPC : NPCPlayer, IAISenses, IAIAttack // TypeDefIndex: 10162
{
	private Option __menuOption_MenuDesignAI;
	[CompilerGeneratedAttribute]
	private ScarecrowBrain <Brain>k__BackingField;
	public float BaseAttackRate;
	public float BaseAttackDamge;
	public DamageType AttackDamageType;
	[HeaderAttribute]
	public LootContainer.LootSpawnSlot[] LootSpawnSlots;
	public static float NextBeanCanAllowedTime;
	public bool RoamAroundHomePoint;

	public override bool HasMenuOptions { get; }
	public ScarecrowBrain Brain { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	[CompilerGeneratedAttribute]
	public ScarecrowBrain get_Brain() { }

	[CompilerGeneratedAttribute]
	protected void set_Brain(ScarecrowBrain value) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void MenuDesignAI(BasePlayer ply) { }

	public bool CanDesignAI(BasePlayer player) { }

	public void .ctor() { }

}

