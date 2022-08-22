public class RealmedRemove : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9986
{	public GameObject[] removedFromClient; // 0x18
	public Component[] removedComponentFromClient; // 0x20
	public GameObject[] removedFromServer; // 0x28
	public Component[] removedComponentFromServer; // 0x30
	public Component[] doNotRemoveFromServer; // 0x38
	public Component[] doNotRemoveFromClient; // 0x40


	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public bool ShouldDelete(Component comp, bool client, bool server) { }

	public void .ctor() { }

}

