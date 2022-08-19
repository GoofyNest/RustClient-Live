public class FluidSwitch : ElectricSwitch // TypeDefIndex: 9800
{	// Fields
	private BaseEntity.Flags Flag_PumpPowered; // 0x398
	public Animator PumpAnimator; // 0x3A0
	private static int SwitchOnParam; // 0x0
	private static int PowerParam; // 0x4

	// Properties
	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }

	// Methods

	// RVA: 0x791140 Offset: 0x790540 VA: 0x180791140 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 146
	public override bool get_IsGravitySource() { }

	// RVA: 0x7912A0 Offset: 0x7906A0 VA: 0x1807912A0 Slot: 157
	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x790F40 Offset: 0x790340 VA: 0x180790F40 Slot: 158
	public override bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x790FC0 Offset: 0x7903C0 VA: 0x180790FC0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x791280 Offset: 0x790680 VA: 0x180791280
	public void .ctor() { }

	// RVA: 0x791210 Offset: 0x790610 VA: 0x180791210
	private static void .cctor() { }

}

