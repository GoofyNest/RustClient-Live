public class RustigeEgg : BaseCombatEntity // TypeDefIndex: 8440
{	// Fields
	private Option __menuOption_Menu_Close; // 0x240
	private Option __menuOption_Menu_Open; // 0x298
	private Option __menuOption_Menu_Spin; // 0x2F0
	private Option __menuOption_Menu_StopSpin; // 0x348
	public const BaseEntity.Flags Flag_Spin = 128;
	public Transform eggRotationTransform; // 0x3A0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x4982F0 Offset: 0x4976F0 VA: 0x1804982F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x499130 Offset: 0x498530 VA: 0x180499130 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x498B80 Offset: 0x497F80 VA: 0x180498B80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsSpinning() { }

	[BaseEntity.Menu] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	[BaseEntity.Menu.Description] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	[BaseEntity.Menu.Icon] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	// RVA: 0x498AE0 Offset: 0x497EE0 VA: 0x180498AE0
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	[BaseEntity.Menu.Description] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	[BaseEntity.Menu.Icon] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	[BaseEntity.Menu.ShowIf] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	// RVA: 0x498B30 Offset: 0x497F30 VA: 0x180498B30
	public void Menu_StopSpin(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool Menu_StopSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	[BaseEntity.Menu.Description] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	[BaseEntity.Menu.Icon] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	// RVA: 0x498A80 Offset: 0x497E80 VA: 0x180498A80
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x498A60 Offset: 0x497E60 VA: 0x180498A60
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	[BaseEntity.Menu.Description] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	[BaseEntity.Menu.Icon] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	[BaseEntity.Menu.ShowIf] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	// RVA: 0x498A10 Offset: 0x497E10 VA: 0x180498A10
	public void Menu_Close(BasePlayer player) { }

	// RVA: 0x498A00 Offset: 0x497E00 VA: 0x180498A00
	public bool Menu_Close_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x498160 Offset: 0x497560 VA: 0x180498160
	public void FaceEggPosition(BaseEntity.RPCMessage msg) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

