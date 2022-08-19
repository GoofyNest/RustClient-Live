public class RHIB : MotorRowboat // TypeDefIndex: 8439
{	// Fields
	private Option __menuOption_Release; // 0x688
	public GameObject steeringWheel; // 0x6E0
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float rhibpopulation; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6A0A00 Offset: 0x69FE00 VA: 0x1806A0A00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6A1390 Offset: 0x6A0790 VA: 0x1806A1390 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6A0E10 Offset: 0x6A0210 VA: 0x1806A0E10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x80860 Offset: 0x7FC60 VA: 0x180080860
	[BaseEntity.Menu.Description] // RVA: 0x80860 Offset: 0x7FC60 VA: 0x180080860
	[BaseEntity.Menu.Icon] // RVA: 0x80860 Offset: 0x7FC60 VA: 0x180080860
	[BaseEntity.Menu.ShowIf] // RVA: 0x80860 Offset: 0x7FC60 VA: 0x180080860
	// RVA: 0x6A1010 Offset: 0x6A0410 VA: 0x1806A1010
	public void Release(BasePlayer player) { }

	// RVA: 0x6A0F00 Offset: 0x6A0300 VA: 0x1806A0F00
	public bool Release_ShowIf(BasePlayer player) { }

	// RVA: 0x6A0D10 Offset: 0x6A0110 VA: 0x1806A0D10 Slot: 198
	public override bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A0DF0 Offset: 0x6A01F0 VA: 0x1806A0DF0 Slot: 199
	public override bool LookingAtFuelArea(BasePlayer player) { }

	// RVA: 0x6A1050 Offset: 0x6A0450 VA: 0x1806A1050 Slot: 197
	public override void UpdateEngineRotation() { }

	// RVA: 0x6A1330 Offset: 0x6A0730 VA: 0x1806A1330
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

