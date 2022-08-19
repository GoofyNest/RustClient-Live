public class Poolable : MonoBehaviour, IClientComponent, IPrefabPostProcess // TypeDefIndex: 11418
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Behaviour[] behaviours; // 0x20
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Rigidbody[] rigidbodies; // 0x28
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Collider[] colliders; // 0x30
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public LODGroup[] lodgroups; // 0x38
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Renderer[] renderers; // 0x40
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ParticleSystem[] particles; // 0x48
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool[] behaviourStates; // 0x50
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool[] rigidbodyStates; // 0x58
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool[] colliderStates; // 0x60
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool[] lodgroupStates; // 0x68
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool[] rendererStates; // 0x70

	// Properties
	public int ClientCount { get; }
	public int ServerCount { get; }

	// Methods

	// RVA: 0x978A60 Offset: 0x977E60 VA: 0x180978A60
	public int get_ClientCount() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public int get_ServerCount() { }

	// RVA: 0x977DC0 Offset: 0x9771C0 VA: 0x180977DC0 Slot: 4
	public void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x977970 Offset: 0x976D70 VA: 0x180977970
	public void Initialize(uint id) { }

	// RVA: 0x9777F0 Offset: 0x976BF0 VA: 0x1809777F0
	public void EnterPool() { }

	// RVA: 0x977D50 Offset: 0x977150 VA: 0x180977D50
	public void LeavePool() { }

	// RVA: 0x977E40 Offset: 0x977240 VA: 0x180977E40
	public void SetBehaviourEnabled(bool state) { }

	// RVA: 0x978300 Offset: 0x977700 VA: 0x180978300
	public void SetComponentEnabled(bool state) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

