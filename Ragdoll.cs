public class Ragdoll : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9229
{
	public Transform eyeTransform; 
	public Transform centerBone; 
	public Rigidbody primaryBody; 
	public PhysicMaterial physicMaterial; 
	public SpringJoint corpseJoint; 
	public Skeleton skeleton; 
	public Model model; 
	public List<Joint> joints; 
	public List<CharacterJoint> characterJoints; 
	public List<ConfigurableJoint> configurableJoints; 
	public List<Rigidbody> rigidbodies; 
	public GameObject GibEffect; 
	public Rigidbody pinTo; 
	private LODGroup _lodGroup; 
	private ArticulatedOccludee occludee; 
	protected bool IsSetup; 

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

