public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11294
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool isClient; // 0x1C

	// Properties
	public bool isServer { get; }

	// Methods

	// RVA: 0x900310 Offset: 0x8FF710 VA: 0x180900310
	public bool get_isServer() { }

	// RVA: 0x9002A0 Offset: 0x8FF6A0 VA: 0x1809002A0 Slot: 7
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

