public class MovementSoundTrigger : TriggerBase, IClientComponentEx, ILOD // TypeDefIndex: 8998
{	// Fields
	public SoundDefinition softSound; // 0x30
	public SoundDefinition medSound; // 0x38
	public SoundDefinition hardSound; // 0x40
	public Collider collider; // 0x48
	private const float maxDistance = 100;
	private const float tickRate = 2;
	private LODCell cell; // 0x50
	private Dictionary<GameObject, Vector3> lastPositionByObject; // 0x58

	// Methods

	// RVA: 0x7B9BA0 Offset: 0x7B8FA0 VA: 0x1807B9BA0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x7B9FC0 Offset: 0x7B93C0 VA: 0x1807B9FC0 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0x7B9D40 Offset: 0x7B9140 VA: 0x1807B9D40 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0x7B9F30 Offset: 0x7B9330 VA: 0x1807B9F30 Slot: 11
	internal override void OnObjectRemoved(GameObject obj) { }

	// RVA: 0x7B9E30 Offset: 0x7B9230 VA: 0x1807B9E30 Slot: 10
	internal override void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0x7BA040 Offset: 0x7B9440 VA: 0x1807BA040
	private void OnTick() { }

	// RVA: 0x7B9DB0 Offset: 0x7B91B0 VA: 0x1807B9DB0
	protected void OnEnable() { }

	// RVA: 0x7B9C80 Offset: 0x7B9080 VA: 0x1807B9C80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7BA510 Offset: 0x7B9910 VA: 0x1807BA510 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x7B9B40 Offset: 0x7B8F40 VA: 0x1807B9B40 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x7BA310 Offset: 0x7B9710 VA: 0x1807BA310
	private void PlaySound(GameObject obj, float speed = 0) { }

	// RVA: 0x7BA420 Offset: 0x7B9820 VA: 0x1807BA420 Slot: 18
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x4D0250 Offset: 0x4CF650 VA: 0x1804D0250
	public void .ctor() { }

}

