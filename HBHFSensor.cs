public class HBHFSensor : BaseDetector // TypeDefIndex: 8397
{	// Fields
	private Option __menuOption_Menu_ExcludeAuth; // 0x290
	private Option __menuOption_Menu_ExcludeOthers; // 0x2E8
	private Option __menuOption_Menu_IncludeAuth; // 0x340
	private Option __menuOption_Menu_IncludeOthers; // 0x398
	public GameObjectRef detectUp; // 0x3F0
	public GameObjectRef detectDown; // 0x3F8
	public const BaseEntity.Flags Flag_IncludeOthers = 256;
	public const BaseEntity.Flags Flag_IncludeAuthed = 512;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x74B840 Offset: 0x74AC40 VA: 0x18074B840 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x74C6A0 Offset: 0x74BAA0 VA: 0x18074C6A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x74C5B0 Offset: 0x74B9B0 VA: 0x18074C5B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5264E0 Offset: 0x5258E0 VA: 0x1805264E0
	public bool ShouldIncludeAuthorized() { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	public bool ShouldIncludeOthers() { }

	[BaseEntity.Menu] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[BaseEntity.Menu.Description] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[BaseEntity.Menu.Icon] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	// RVA: 0x74C4A0 Offset: 0x74B8A0 VA: 0x18074C4A0
	public void Menu_IncludeAuth(BasePlayer player) { }

	// RVA: 0x74C430 Offset: 0x74B830 VA: 0x18074C430
	public bool Menu_IncludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	[BaseEntity.Menu.Description] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	[BaseEntity.Menu.Icon] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6E30 Offset: 0xE6230 VA: 0x1800E6E30
	// RVA: 0x74C320 Offset: 0x74B720 VA: 0x18074C320
	public void Menu_ExcludeAuth(BasePlayer player) { }

	// RVA: 0x74C2B0 Offset: 0x74B6B0 VA: 0x18074C2B0
	public bool Menu_ExcludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	[BaseEntity.Menu.Description] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	[BaseEntity.Menu.Icon] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE6FB0 Offset: 0xE63B0 VA: 0x1800E6FB0
	// RVA: 0x74C560 Offset: 0x74B960 VA: 0x18074C560
	public void Menu_IncludeOthers(BasePlayer player) { }

	// RVA: 0x74C4F0 Offset: 0x74B8F0 VA: 0x18074C4F0
	public bool Menu_IncludeOthers_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	[BaseEntity.Menu.Description] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	[BaseEntity.Menu.Icon] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	[BaseEntity.Menu.ShowIf] // RVA: 0xE7230 Offset: 0xE6630 VA: 0x1800E7230
	// RVA: 0x74C3E0 Offset: 0x74B7E0 VA: 0x18074C3E0
	public void Menu_ExcludeOthers(BasePlayer player) { }

	// RVA: 0x74C370 Offset: 0x74B770 VA: 0x18074C370
	public bool Menu_ExcludeOthers_ShowIf(BasePlayer player) { }

	// RVA: 0x6BF0C0 Offset: 0x6BE4C0 VA: 0x1806BF0C0
	public void .ctor() { }

}

