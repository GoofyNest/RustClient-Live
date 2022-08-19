public class TriggerNotifyEntity : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10033
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyEntityTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA00B80 Offset: 0x9FFF80 VA: 0x180A00B80
	public bool get_HasContents() { }

	// RVA: 0xA00930 Offset: 0x9FFD30 VA: 0x180A00930 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA00A00 Offset: 0x9FFE00 VA: 0x180A00A00 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA00B00 Offset: 0x9FFF00 VA: 0x180A00B00 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA00B70 Offset: 0x9FFF70 VA: 0x180A00B70
	public void .ctor() { }

}

