public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11294
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool isClient; // 0x1C

	public bool isServer { get; }


	public bool get_isServer() { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

