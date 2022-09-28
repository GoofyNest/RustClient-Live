public class StripRig : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11687
{
	public Transform root; 
	public bool fromClient; 
	public bool fromServer; 


	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void Strip(IPrefabProcessor preProcess, SkinnedMeshRenderer skinnedMeshRenderer) { }

	public void .ctor() { }

}

