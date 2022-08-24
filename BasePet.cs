public class BasePet : NPCPlayer // TypeDefIndex: 8335
{
	private Option __menuOption_MenuDesignAI; 
	[ServerVar] 
	public static bool queuedMovementsAllowed; 
	[ServerVar] 
	public static bool onlyQueueBaseNavMovements; 
	[ServerVar] 
	[HelpAttribute] 
	public static float movementupdatebudgetms; 
	public float BaseAttackRate; 
	public float BaseAttackDamge; 
	public DamageType AttackDamageType; 
	[CompilerGeneratedAttribute] 
	private BaseAIBrain<BasePet> <Brain>k__BackingField; 
	public GameObjectRef mapMarkerPrefab; 
	private BaseEntity _mapMarkerInstance; 

public override bool HasMenuOptions { get; }
public BaseAIBrain<BasePet> Brain { get; set; }


public override void GetMenuOptions(List<Option> list) { }

public override bool get_HasMenuOptions() { }

	[CompilerGeneratedAttribute] 
public BaseAIBrain<BasePet> get_Brain() { }

	[CompilerGeneratedAttribute] 
protected void set_Brain(BaseAIBrain<BasePet> value) { }

public override float StartHealth() { }

public override float StartMaxHealth() { }

public override float MaxHealth() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
public void MenuDesignAI(BasePlayer ply) { }

public bool CanDesignAI(BasePlayer player) { }

public void .ctor() { }

private static void .cctor() { }

}

