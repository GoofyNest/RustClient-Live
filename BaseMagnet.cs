public class BaseMagnet : MonoBehaviour // TypeDefIndex: 9729
{	// Fields
	public BaseEntity entityOwner; // 0x18
	public BaseEntity.Flags magnetFlag; // 0x20
	public TriggerMagnet magnetTrigger; // 0x28
	public FixedJoint fixedJoint; // 0x30
	public Rigidbody kinematicAttachmentBody; // 0x38
	public float magnetForce; // 0x40
	public Transform attachDepthPoint; // 0x48
	public GameObjectRef attachEffect; // 0x50
	public bool isMagnetOn; // 0x58
	public GameObject colliderSource; // 0x60

	// Methods

	// RVA: 0xA23BB0 Offset: 0xA22FB0 VA: 0x180A23BB0
	public void .ctor() { }

}
