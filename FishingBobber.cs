public class FishingBobber : BaseCombatEntity // TypeDefIndex: 8868
{	public Transform centerOfMass; // 0x240
	public Rigidbody myRigidBody; // 0x248
	public Transform lineAttachPoint; // 0x250
	public Transform bobberRoot; // 0x258
	public const BaseEntity.Flags CaughtFish = 128;
	public float HorizontalMoveSpeed; // 0x260
	public float PullAwayMoveSpeed; // 0x264
	public float SidewaysInputForce; // 0x268
	public float ReelInMoveSpeed; // 0x26C
	private float fishLerp; // 0x270
	private Vector3 lastPosition; // 0x274


	public void UpdateWithCurrentState(BaseFishingRod.FishState state) { }

	public void .ctor() { }

}

