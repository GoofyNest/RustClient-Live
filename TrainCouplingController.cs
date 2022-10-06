public class TrainCouplingController // TypeDefIndex: 11481
{
	[CompilerGeneratedAttribute] 
	private float <PreChangeTrackSpeed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <PreChangeCoupledBackwards>k__BackingField; 
	public const BaseEntity.Flags Flag_CouplingFront = 256;
	public const BaseEntity.Flags Flag_CouplingRear = 512;
	public readonly TrainCoupling frontCoupling; 
	public readonly TrainCoupling rearCoupling; 
	private readonly TrainCar owner; 
	[ServerVar] 
	public static float max_couple_speed; 

	public bool IsCoupled { get; }
	public bool IsFrontCoupled { get; }
	public bool IsRearCoupled { get; }
	public float PreChangeTrackSpeed { get; set; }
	public bool PreChangeCoupledBackwards { get; set; }


	public bool get_IsCoupled() { }

	public bool get_IsFrontCoupled() { }

	public bool get_IsRearCoupled() { }

	[CompilerGeneratedAttribute] 
	public float get_PreChangeTrackSpeed() { }

	[CompilerGeneratedAttribute] 
	private void set_PreChangeTrackSpeed(float value) { }

	[CompilerGeneratedAttribute] 
	public bool get_PreChangeCoupledBackwards() { }

	[CompilerGeneratedAttribute] 
	private void set_PreChangeCoupledBackwards(bool value) { }

	public void .ctor(TrainCar owner) { }

	private static void .cctor() { }

}

