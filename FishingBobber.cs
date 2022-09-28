public class FishingBobber : BaseCombatEntity // TypeDefIndex: 10540
{
	public Transform centerOfMass; 
	public Rigidbody myRigidBody; 
	public Transform lineAttachPoint; 
	public Transform bobberRoot; 
	public const BaseEntity.Flags CaughtFish = 128;
	public float HorizontalMoveSpeed; 
	public float PullAwayMoveSpeed; 
	public float SidewaysInputForce; 
	public float ReelInMoveSpeed; 
	private float fishLerp; 
	private Vector3 lastPosition; 


	public void UpdateWithCurrentState(BaseFishingRod.FishState state) { }

	public void .ctor() { }

}

