public class Ragdoll : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9225
{	public Transform eyeTransform; // 0x18
	public Transform centerBone; // 0x20
	public Rigidbody primaryBody; // 0x28
	public PhysicMaterial physicMaterial; // 0x30
	public SpringJoint corpseJoint; // 0x38
	public Skeleton skeleton; // 0x40
	public Model model; // 0x48
	public List<Joint> joints; // 0x50
	public List<CharacterJoint> characterJoints; // 0x58
	public List<ConfigurableJoint> configurableJoints; // 0x60
	public List<Rigidbody> rigidbodies; // 0x68
	public GameObject GibEffect; // 0x70
	public Rigidbody pinTo; // 0x78
	private LODGroup _lodGroup; // 0x80
	private ArticulatedOccludee occludee; // 0x88
	protected bool IsSetup; // 0x90

	public LODGroup lodGroup { get; }


	public LODGroup get_lodGroup() { }

	public void Awake() { }

	private void RagdollSetup() { }

	public void CopyBonesFrom(Model otherModel) { }

	public void MoveRigidbodiesToRoot() { }

	public void CreatePinJoint() { }

	private void UpdateLODBounds() { }

	public void SetRagdollSkin(int iSkin) { }

	public void OnGibbed() { }

	public virtual void Init() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

