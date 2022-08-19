public class FishingBobber : BaseCombatEntity // TypeDefIndex: 8868
{	// Fields
	public Transform centerOfMass; // 0x240
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

	// Methods

	// RVA: 0x78AF90 Offset: 0x78A390 VA: 0x18078AF90
	public void UpdateWithCurrentState(BaseFishingRod.FishState state) { }

	// RVA: 0x78B110 Offset: 0x78A510 VA: 0x18078B110
	public void .ctor() { }

}

