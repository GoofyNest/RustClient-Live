public class RealmedRemove : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9986
{
	public GameObject[] removedFromClient; 
	public Component[] removedComponentFromClient; 
	public GameObject[] removedFromServer; 
	public Component[] removedComponentFromServer; 
	public Component[] doNotRemoveFromServer; 
	public Component[] doNotRemoveFromClient; 


public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

public bool ShouldDelete(Component comp, bool client, bool server) { }

public void .ctor() { }

}

