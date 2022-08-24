public class StrobeLight : BaseCombatEntity // TypeDefIndex: 8281
{
	public float frequency; 
	public MeshRenderer lightMesh; 
	public Light strobeLight; 
	private float speedSlow; 
	private float speedMed; 
	private float speedFast; 
	public float burnRate; 
	public float lifeTimeSeconds; 
public const BaseEntity.Flags Flag_Slow = 16384;
public const BaseEntity.Flags Flag_Med = 32768;
public const BaseEntity.Flags Flag_Fast = 65536;
	[ClientVar] 
	public static bool forceoff; 
	private float lastStrobeTime; 
	private Option __menuOption_Menu_StrobeFast; 
	private Option __menuOption_Menu_StrobeMed; 
	private Option __menuOption_Menu_StrobeSlow; 
	private Option __menuOption_Menu_TurnOff; 
	private Option __menuOption_Menu_TurnOn; 

public override bool HasMenuOptions { get; }


public float GetFrequency() { }

public void Update() { }

public void ClientSetLights(bool wantsOn) { }

public void Toggle() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_TurnOn(BasePlayer player) { }

public bool Menu_StrobeOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_TurnOff(BasePlayer player) { }

public bool Menu_StrobeOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_StrobeSlow(BasePlayer player) { }

public bool Menu_StrobeSlow_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_StrobeMed(BasePlayer player) { }

public bool Menu_StrobeMed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_StrobeFast(BasePlayer player) { }

public bool Menu_StrobeFast_ShowIf(BasePlayer player) { }

public override void GetMenuOptions(List<Option> list) { }

public override bool get_HasMenuOptions() { }

public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

public void .ctor() { }

private static void .cctor() { }

}

