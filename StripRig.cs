public class StripRig : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 10012
{	// Fields
	public Transform root; // 0x18
	public bool fromClient; // 0x20
	public bool fromServer; // 0x21

	// Methods

	// RVA: 0x79CB50 Offset: 0x79BF50 VA: 0x18079CB50 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x79CDE0 Offset: 0x79C1E0 VA: 0x18079CDE0
	public void Strip(IPrefabProcessor preProcess, SkinnedMeshRenderer skinnedMeshRenderer) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

