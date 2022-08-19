public class RealmedRemove : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9986
{	// Fields
	public GameObject[] removedFromClient; // 0x18
	public Component[] removedComponentFromClient; // 0x20
	public GameObject[] removedFromServer; // 0x28
	public Component[] removedComponentFromServer; // 0x30
	public Component[] doNotRemoveFromServer; // 0x38
	public Component[] doNotRemoveFromClient; // 0x40

	// Methods

	// RVA: 0x6AA990 Offset: 0x6A9D90 VA: 0x1806AA990 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6AABC0 Offset: 0x6A9FC0 VA: 0x1806AABC0
	public bool ShouldDelete(Component comp, bool client, bool server) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

