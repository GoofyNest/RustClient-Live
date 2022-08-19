public class TriggerBase : BaseMonoBehaviour // TypeDefIndex: 10019
{	// Fields
	public LayerMask interestLayers; // 0x18
	public HashSet<GameObject> contents; // 0x20
	public HashSet<BaseEntity> entityContents; // 0x28

	// Properties
	public bool HasAnyContents { get; }
	public bool HasAnyEntityContents { get; }

	// Methods

	// RVA: 0x9FFE80 Offset: 0x9FF280 VA: 0x1809FFE80
	public bool get_HasAnyContents() { }

	// RVA: 0x9FFEC0 Offset: 0x9FF2C0 VA: 0x1809FFEC0
	public bool get_HasAnyEntityContents() { }

	// RVA: 0x9FE540 Offset: 0x9FD940 VA: 0x1809FE540 Slot: 6
	internal virtual GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x9FE5A0 Offset: 0x9FD9A0 VA: 0x1809FE5A0 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x9FE6D0 Offset: 0x9FDAD0 VA: 0x1809FE6D0 Slot: 8
	internal virtual void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x9FE7A0 Offset: 0x9FDBA0 VA: 0x1809FE7A0 Slot: 9
	internal virtual void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x9FE7F0 Offset: 0x9FDBF0 VA: 0x1809FE7F0 Slot: 10
	internal virtual void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0x9FE8D0 Offset: 0x9FDCD0 VA: 0x1809FE8D0 Slot: 11
	internal virtual void OnObjectRemoved(GameObject obj) { }

	// RVA: 0x9FF850 Offset: 0x9FEC50 VA: 0x1809FF850
	internal void RemoveInvalidEntities() { }

	// RVA: 0x9FE3B0 Offset: 0x9FD7B0 VA: 0x1809FE3B0
	internal bool CheckEntity(BaseEntity ent) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	internal virtual void OnObjects() { }

	// RVA: 0x9FE690 Offset: 0x9FDA90 VA: 0x1809FE690 Slot: 13
	internal virtual void OnEmpty() { }

	// RVA: 0x9FFDC0 Offset: 0x9FF1C0 VA: 0x1809FFDC0
	public void RemoveObject(GameObject obj) { }

	// RVA: 0x9FF4D0 Offset: 0x9FE8D0 VA: 0x1809FF4D0
	public void RemoveEntity(BaseEntity ent) { }

	// RVA: 0x9FEBA0 Offset: 0x9FDFA0 VA: 0x1809FEBA0
	public void OnTriggerEnter(Collider collider) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 14
	internal virtual bool SkipOnTriggerExit(Collider collider) { }

	// RVA: 0x9FF120 Offset: 0x9FE520 VA: 0x1809FF120
	public void OnTriggerExit(Collider collider) { }

	// RVA: 0x9FF070 Offset: 0x9FE470 VA: 0x1809FF070
	private void OnTriggerExit(GameObject targetObj) { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

