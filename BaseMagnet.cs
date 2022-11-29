public class BaseMagnet : MonoBehaviour // TypeDefIndex: 11465
{
	public BaseEntity entityOwner; 
	public BaseEntity.Flags magnetFlag; 
	public TriggerMagnet magnetTrigger; 
	public FixedJoint fixedJoint; 
	public Rigidbody kinematicAttachmentBody; 
	public float magnetForce; 
	public Transform attachDepthPoint; 
	public GameObjectRef attachEffect; 
	public bool isMagnetOn; 
	public GameObject colliderSource; 


	public void .ctor() { }

}

