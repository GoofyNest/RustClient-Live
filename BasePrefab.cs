public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 13033
{
	[HideInInspector] 
	public uint prefabID; 
	[HideInInspector] 
	public bool isClient; 

	public bool isServer { get; }


	public bool get_isServer() { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

