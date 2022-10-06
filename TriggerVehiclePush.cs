public class TriggerVehiclePush : TriggerBase, IServerComponent // TypeDefIndex: 9995
{
	public BaseEntity thisEntity; 
	public float maxPushVelocity; 
	public float minRadius; 
	public float maxRadius; 
	public bool snapToAxis; 
	public Vector3 axisToSnapTo; 
	public bool allowParentRigidbody; 
	public bool useRigidbodyPosition; 
	public bool useCentreOfMass; 


	public void .ctor() { }

}

