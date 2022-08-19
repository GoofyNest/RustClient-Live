public class TrainCoupling // TypeDefIndex: 9769
{	// Fields
	public readonly TrainCar owner; // 0x10
	public readonly bool isFrontCoupling; // 0x18
	public readonly TrainCouplingController controller; // 0x20
	public readonly Transform couplingPoint; // 0x28
	public readonly Transform couplingPivot; // 0x30
	public readonly BaseEntity.Flags flag; // 0x38
	public readonly bool isValid; // 0x3C
	public EntityRef<TrainCar> clientCoupledTo; // 0x40
	public bool clientCoupledToFront; // 0x50

	// Properties
	public bool IsCoupled { get; }
	public bool IsUncoupled { get; }

	// Methods

	// RVA: 0x9EFE20 Offset: 0x9EF220 VA: 0x1809EFE20
	public bool get_IsCoupled() { }

	// RVA: 0x9EFE50 Offset: 0x9EF250 VA: 0x1809EFE50
	public bool get_IsUncoupled() { }

	// RVA: 0x9EFD10 Offset: 0x9EF110 VA: 0x1809EFD10
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller) { }

	// RVA: 0x9EFD40 Offset: 0x9EF140 VA: 0x1809EFD40
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller, Transform couplingPoint, Transform couplingPivot, BaseEntity.Flags flag) { }

	// RVA: 0x9EFA20 Offset: 0x9EEE20 VA: 0x1809EFA20
	public void VisualTick() { }

}

