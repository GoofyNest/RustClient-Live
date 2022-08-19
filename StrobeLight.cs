public class StrobeLight : BaseCombatEntity // TypeDefIndex: 8281
{	// Fields
	public float frequency; // 0x240
	public MeshRenderer lightMesh; // 0x248
	public Light strobeLight; // 0x250
	private float speedSlow; // 0x258
	private float speedMed; // 0x25C
	private float speedFast; // 0x260
	public float burnRate; // 0x264
	public float lifeTimeSeconds; // 0x268
	public const BaseEntity.Flags Flag_Slow = 16384;
	public const BaseEntity.Flags Flag_Med = 32768;
	public const BaseEntity.Flags Flag_Fast = 65536;
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool forceoff; // 0x0
	private float lastStrobeTime; // 0x26C
	private Option __menuOption_Menu_StrobeFast; // 0x270
	private Option __menuOption_Menu_StrobeMed; // 0x2C8
	private Option __menuOption_Menu_StrobeSlow; // 0x320
	private Option __menuOption_Menu_TurnOff; // 0x378
	private Option __menuOption_Menu_TurnOn; // 0x3D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x79D060 Offset: 0x79C460 VA: 0x18079D060
	public float GetFrequency() { }

	// RVA: 0x79E040 Offset: 0x79D440 VA: 0x18079E040
	public void Update() { }

	// RVA: 0x79CF70 Offset: 0x79C370 VA: 0x18079CF70
	public void ClientSetLights(bool wantsOn) { }

	// RVA: 0x79E000 Offset: 0x79D400 VA: 0x18079E000
	public void Toggle() { }

	[BaseEntity.Menu] // RVA: 0xA5CF0 Offset: 0xA50F0 VA: 0x1800A5CF0
	[BaseEntity.Menu.Description] // RVA: 0xA5CF0 Offset: 0xA50F0 VA: 0x1800A5CF0
	[BaseEntity.Menu.Icon] // RVA: 0xA5CF0 Offset: 0xA50F0 VA: 0x1800A5CF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA5CF0 Offset: 0xA50F0 VA: 0x1800A5CF0
	// RVA: 0x79DEC0 Offset: 0x79D2C0 VA: 0x18079DEC0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x79DDE0 Offset: 0x79D1E0 VA: 0x18079DDE0
	public bool Menu_StrobeOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7120 Offset: 0xA6520 VA: 0x1800A7120
	[BaseEntity.Menu.Description] // RVA: 0xA7120 Offset: 0xA6520 VA: 0x1800A7120
	[BaseEntity.Menu.Icon] // RVA: 0xA7120 Offset: 0xA6520 VA: 0x1800A7120
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7120 Offset: 0xA6520 VA: 0x1800A7120
	// RVA: 0x79DE70 Offset: 0x79D270 VA: 0x18079DE70
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x79DDA0 Offset: 0x79D1A0 VA: 0x18079DDA0
	public bool Menu_StrobeOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7280 Offset: 0xA6680 VA: 0x1800A7280
	[BaseEntity.Menu.Description] // RVA: 0xA7280 Offset: 0xA6680 VA: 0x1800A7280
	[BaseEntity.Menu.Icon] // RVA: 0xA7280 Offset: 0xA6680 VA: 0x1800A7280
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7280 Offset: 0xA6680 VA: 0x1800A7280
	// RVA: 0x79DE20 Offset: 0x79D220 VA: 0x18079DE20
	public void Menu_StrobeSlow(BasePlayer player) { }

	// RVA: 0x575940 Offset: 0x574D40 VA: 0x180575940
	public bool Menu_StrobeSlow_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7530 Offset: 0xA6930 VA: 0x1800A7530
	[BaseEntity.Menu.Description] // RVA: 0xA7530 Offset: 0xA6930 VA: 0x1800A7530
	[BaseEntity.Menu.Icon] // RVA: 0xA7530 Offset: 0xA6930 VA: 0x1800A7530
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7530 Offset: 0xA6930 VA: 0x1800A7530
	// RVA: 0x79DD50 Offset: 0x79D150 VA: 0x18079DD50
	public void Menu_StrobeMed(BasePlayer player) { }

	// RVA: 0x575940 Offset: 0x574D40 VA: 0x180575940
	public bool Menu_StrobeMed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA7980 Offset: 0xA6D80 VA: 0x1800A7980
	[BaseEntity.Menu.Description] // RVA: 0xA7980 Offset: 0xA6D80 VA: 0x1800A7980
	[BaseEntity.Menu.Icon] // RVA: 0xA7980 Offset: 0xA6D80 VA: 0x1800A7980
	[BaseEntity.Menu.ShowIf] // RVA: 0xA7980 Offset: 0xA6D80 VA: 0x1800A7980
	// RVA: 0x79DD00 Offset: 0x79D100 VA: 0x18079DD00
	public void Menu_StrobeFast(BasePlayer player) { }

	// RVA: 0x575940 Offset: 0x574D40 VA: 0x180575940
	public bool Menu_StrobeFast_ShowIf(BasePlayer player) { }

	// RVA: 0x79D0D0 Offset: 0x79C4D0 VA: 0x18079D0D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x79E1E0 Offset: 0x79D5E0 VA: 0x18079E1E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x79DF10 Offset: 0x79D310 VA: 0x18079DF10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79E1A0 Offset: 0x79D5A0 VA: 0x18079E1A0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

