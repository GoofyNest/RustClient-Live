public class HBHFSensor : BaseDetector // TypeDefIndex: 8397
{	private Option __menuOption_Menu_ExcludeAuth; // 0x290
	private Option __menuOption_Menu_ExcludeOthers; // 0x2E8
	private Option __menuOption_Menu_IncludeAuth; // 0x340
	private Option __menuOption_Menu_IncludeOthers; // 0x398
	public GameObjectRef detectUp; // 0x3F0
	public GameObjectRef detectDown; // 0x3F8
	public const BaseEntity.Flags Flag_IncludeOthers = 256;
	public const BaseEntity.Flags Flag_IncludeAuthed = 512;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool ShouldIncludeAuthorized() { }

	public bool ShouldIncludeOthers() { }

	[BaseEntity.Menu] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[BaseEntity.Menu.Description] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[BaseEntity.Menu.Icon] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	public void Menu_IncludeAuth(BasePlayer player) { }

	public bool Menu_IncludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	[BaseEntity.Menu.Description] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	[BaseEntity.Menu.Icon] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	public void Menu_ExcludeAuth(BasePlayer player) { }

	public bool Menu_ExcludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	[BaseEntity.Menu.Description] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	[BaseEntity.Menu.Icon] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	public void Menu_IncludeOthers(BasePlayer player) { }

	public bool Menu_IncludeOthers_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	[BaseEntity.Menu.Description] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	[BaseEntity.Menu.Icon] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	public void Menu_ExcludeOthers(BasePlayer player) { }

	public bool Menu_ExcludeOthers_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

