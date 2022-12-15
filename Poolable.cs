public class Poolable : MonoBehaviour, IClientComponent, IPrefabPostProcess // TypeDefIndex: 13236
{
	[HideInInspector]
	public uint prefabID;
	[HideInInspector]
	public Behaviour[] behaviours;
	[HideInInspector]
	public Rigidbody[] rigidbodies;
	[HideInInspector]
	public Collider[] colliders;
	[HideInInspector]
	public LODGroup[] lodgroups;
	[HideInInspector]
	public Renderer[] renderers;
	[HideInInspector]
	public ParticleSystem[] particles;
	[HideInInspector]
	public bool[] behaviourStates;
	[HideInInspector]
	public bool[] rigidbodyStates;
	[HideInInspector]
	public bool[] colliderStates;
	[HideInInspector]
	public bool[] lodgroupStates;
	[HideInInspector]
	public bool[] rendererStates;

	public int ClientCount { get; }
	public int ServerCount { get; }


	public int get_ClientCount() { }

	public int get_ServerCount() { }

	public void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void Initialize(uint id) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void SetBehaviourEnabled(bool state) { }

	public void SetComponentEnabled(bool state) { }

	public void .ctor() { }

}

