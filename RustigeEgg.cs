public class RustigeEgg : BaseCombatEntity // TypeDefIndex: 8440
{	private Option __menuOption_Menu_Close; // 0x240
	private Option __menuOption_Menu_Open; // 0x298
	private Option __menuOption_Menu_Spin; // 0x2F0
	private Option __menuOption_Menu_StopSpin; // 0x348
	public const BaseEntity.Flags Flag_Spin = 128;
	public Transform eggRotationTransform; // 0x3A0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsSpinning() { }

	[BaseEntity.Menu] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	[BaseEntity.Menu.Description] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	[BaseEntity.Menu.Icon] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x809F0 Offset: 0x7FDF0 VA: 0x1800809F0
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	[BaseEntity.Menu.Description] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	[BaseEntity.Menu.Icon] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	[BaseEntity.Menu.ShowIf] // RVA: 0x80C50 Offset: 0x80050 VA: 0x180080C50
	public void Menu_StopSpin(BasePlayer player) { }

	public bool Menu_StopSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	[BaseEntity.Menu.Description] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	[BaseEntity.Menu.Icon] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	[BaseEntity.Menu.Description] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	[BaseEntity.Menu.Icon] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	[BaseEntity.Menu.ShowIf] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	public void Menu_Close(BasePlayer player) { }

	public bool Menu_Close_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void FaceEggPosition(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

