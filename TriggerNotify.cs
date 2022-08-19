public class TriggerNotify : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10031
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA00E20 Offset: 0xA00220 VA: 0x180A00E20
	public bool get_HasContents() { }

	// RVA: 0xA00C90 Offset: 0xA00090 VA: 0x180A00C90 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0xA00BC0 Offset: 0x9FFFC0 VA: 0x180A00BC0 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0xA00DB0 Offset: 0xA001B0 VA: 0x180A00DB0 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA00B70 Offset: 0x9FFF70 VA: 0x180A00B70
	public void .ctor() { }

}

