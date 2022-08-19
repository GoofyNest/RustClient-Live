public class TrainCouplingController // TypeDefIndex: 9770
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <PreChangeTrackSpeed>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <PreChangeCoupledBackwards>k__BackingField; // 0x14
	public const BaseEntity.Flags Flag_CouplingFront = 256;
	public const BaseEntity.Flags Flag_CouplingRear = 512;
	public readonly TrainCoupling frontCoupling; // 0x18
	public readonly TrainCoupling rearCoupling; // 0x20
	private readonly TrainCar owner; // 0x28
	[ServerVar] // RVA: 0x95720 Offset: 0x94B20 VA: 0x180095720
	public static float max_couple_speed; // 0x0

	// Properties
	public bool IsCoupled { get; }
	public bool IsFrontCoupled { get; }
	public bool IsRearCoupled { get; }
	public float PreChangeTrackSpeed { get; set; }
	public bool PreChangeCoupledBackwards { get; set; }

	// Methods

	// RVA: 0x9EF930 Offset: 0x9EED30 VA: 0x1809EF930
	public bool get_IsCoupled() { }

	// RVA: 0x9EF980 Offset: 0x9EED80 VA: 0x1809EF980
	public bool get_IsFrontCoupled() { }

	// RVA: 0x9EF9B0 Offset: 0x9EEDB0 VA: 0x1809EF9B0
	public bool get_IsRearCoupled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EF9F0 Offset: 0x9EEDF0 VA: 0x1809EF9F0
	public float get_PreChangeTrackSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EFA10 Offset: 0x9EEE10 VA: 0x1809EFA10
	private void set_PreChangeTrackSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	public bool get_PreChangeCoupledBackwards() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EFA00 Offset: 0x9EEE00 VA: 0x1809EFA00
	private void set_PreChangeCoupledBackwards(bool value) { }

	// RVA: 0x9EF800 Offset: 0x9EEC00 VA: 0x1809EF800
	public void .ctor(TrainCar owner) { }

	// RVA: 0x9EF7C0 Offset: 0x9EEBC0 VA: 0x1809EF7C0
	private static void .cctor() { }

}

