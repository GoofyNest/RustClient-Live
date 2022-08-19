public class FogMachine : StorageContainer // TypeDefIndex: 8280
{	// Fields
	public const BaseEntity.Flags FogFieldOn = 65536;
	public const BaseEntity.Flags MotionMode = 32768;
	public const BaseEntity.Flags Emitting = 16384;
	public const BaseEntity.Flags Flag_HasJuice = 2048;
	public float fogLength; // 0x3D0
	public float nozzleBlastDuration; // 0x3D4
	private Option __menuOption_Menu_FogOff; // 0x3D8
	private Option __menuOption_Menu_MotionOff; // 0x430
	private Option __menuOption_Menu_MotionOn; // 0x488
	private Option __menuOption_Menu_TurnOn; // 0x4E0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool IsEmitting() { }

	// RVA: 0x7518F0 Offset: 0x750CF0 VA: 0x1807518F0
	public bool HasJuice() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 155
	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	[BaseEntity.Menu.Description] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	[BaseEntity.Menu.Icon] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	// RVA: 0x792120 Offset: 0x791520 VA: 0x180792120
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x791F50 Offset: 0x791350 VA: 0x180791F50
	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	[BaseEntity.Menu.Description] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	[BaseEntity.Menu.Icon] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	// RVA: 0x791F10 Offset: 0x791310 VA: 0x180791F10
	public void Menu_FogOff(BasePlayer player) { }

	// RVA: 0x791EC0 Offset: 0x7912C0 VA: 0x180791EC0
	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	[BaseEntity.Menu.Description] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	[BaseEntity.Menu.Icon] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	// RVA: 0x7920D0 Offset: 0x7914D0 VA: 0x1807920D0
	public void Menu_MotionOn(BasePlayer player) { }

	// RVA: 0x792060 Offset: 0x791460 VA: 0x180792060
	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	[BaseEntity.Menu.Description] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	[BaseEntity.Menu.Icon] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	// RVA: 0x792010 Offset: 0x791410 VA: 0x180792010
	public void Menu_MotionOff(BasePlayer player) { }

	// RVA: 0x791FB0 Offset: 0x7913B0 VA: 0x180791FB0
	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	// RVA: 0x7914D0 Offset: 0x7908D0 VA: 0x1807914D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7922C0 Offset: 0x7916C0 VA: 0x1807922C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x792160 Offset: 0x791560 VA: 0x180792160 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x792250 Offset: 0x791650 VA: 0x180792250
	public void .ctor() { }

}

