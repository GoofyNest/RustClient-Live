public class FluidSwitch : ElectricSwitch // TypeDefIndex: 9800
{	private BaseEntity.Flags Flag_PumpPowered; // 0x398
	public Animator PumpAnimator; // 0x3A0
	private static int SwitchOnParam; // 0x0
	private static int PowerParam; // 0x4

	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }


	public override void ResetState() { }

	public override bool get_IsGravitySource() { }

	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	public override bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

