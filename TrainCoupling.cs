public class TrainCoupling // TypeDefIndex: 9769
{	public readonly TrainCar owner; // 0x10
	public readonly bool isFrontCoupling; // 0x18
	public readonly TrainCouplingController controller; // 0x20
	public readonly Transform couplingPoint; // 0x28
	public readonly Transform couplingPivot; // 0x30
	public readonly BaseEntity.Flags flag; // 0x38
	public readonly bool isValid; // 0x3C
	public EntityRef<TrainCar> clientCoupledTo; // 0x40
	public bool clientCoupledToFront; // 0x50

	public bool IsCoupled { get; }
	public bool IsUncoupled { get; }


	public bool get_IsCoupled() { }

	public bool get_IsUncoupled() { }

	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller) { }

	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller, Transform couplingPoint, Transform couplingPivot, BaseEntity.Flags flag) { }

	public void VisualTick() { }

}

