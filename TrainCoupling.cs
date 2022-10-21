public class TrainCoupling // TypeDefIndex: 11491
{
	public readonly TrainCar owner; 
	public readonly bool isFrontCoupling; 
	public readonly TrainCouplingController controller; 
	public readonly Transform couplingPoint; 
	public readonly Transform couplingPivot; 
	public readonly BaseEntity.Flags flag; 
	public readonly bool isValid; 
	public EntityRef<TrainCar> clientCoupledTo; 
	public bool clientCoupledToFront; 

	public bool IsCoupled { get; }
	public bool IsUncoupled { get; }


	public bool get_IsCoupled() { }

	public bool get_IsUncoupled() { }

	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller) { }

	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller, Transform couplingPoint, Transform couplingPivot, BaseEntity.Flags flag) { }

	public void VisualTick() { }

}

