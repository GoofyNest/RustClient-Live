public class FluidSwitch : ElectricSwitch // TypeDefIndex: 11536
{
	private BaseEntity.Flags Flag_PumpPowered; 
	public Animator PumpAnimator; 
	private static int SwitchOnParam; 
	private static int PowerParam; 

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

