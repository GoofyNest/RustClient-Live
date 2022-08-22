public class FogMachine : StorageContainer // TypeDefIndex: 8280
{	public const BaseEntity.Flags FogFieldOn = 65536;
	public const BaseEntity.Flags MotionMode = 32768;
	public const BaseEntity.Flags Emitting = 16384;
	public const BaseEntity.Flags Flag_HasJuice = 2048;
	public float fogLength; // 0x3D0
	public float nozzleBlastDuration; // 0x3D4
	private Option __menuOption_Menu_FogOff; // 0x3D8
	private Option __menuOption_Menu_MotionOff; // 0x430
	private Option __menuOption_Menu_MotionOn; // 0x488
	private Option __menuOption_Menu_TurnOn; // 0x4E0

	public override bool HasMenuOptions { get; }


	public bool IsEmitting() { }

	public bool HasJuice() { }

	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	[BaseEntity.Menu.Description] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	[BaseEntity.Menu.Icon] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	[BaseEntity.Menu.Description] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	[BaseEntity.Menu.Icon] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA52A0 Offset: 0xA46A0 VA: 0x1800A52A0
	public void Menu_FogOff(BasePlayer player) { }

	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	[BaseEntity.Menu.Description] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	[BaseEntity.Menu.Icon] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA56A0 Offset: 0xA4AA0 VA: 0x1800A56A0
	public void Menu_MotionOn(BasePlayer player) { }

	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	[BaseEntity.Menu.Description] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	[BaseEntity.Menu.Icon] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xA59D0 Offset: 0xA4DD0 VA: 0x1800A59D0
	public void Menu_MotionOff(BasePlayer player) { }

	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

