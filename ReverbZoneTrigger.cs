public class ReverbZoneTrigger : TriggerBase, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9018
{	// Fields
	public Collider trigger; // 0x30
	public AudioReverbZone reverbZone; // 0x38
	public float lodDistance; // 0x40
	public bool inRange; // 0x44
	public ReverbSettings reverbSettings; // 0x48
	private int initialReverbLevel; // 0x50
	private int targetReverbLevel; // 0x54
	private int currentReverbLevel; // 0x58
	private LODCell cell; // 0x60
	private AmbienceZone ambienceZone; // 0x68
	private float decayHFRatio; // 0x70
	private float decayTime; // 0x74
	private float density; // 0x78
	private float diffusion; // 0x7C
	private float HFReference; // 0x80
	private float LFReference; // 0x84
	private float maxDistance; // 0x88
	private float minDistance; // 0x8C
	private int reflections; // 0x90
	private float reflectionsDelay; // 0x94
	private int reverb; // 0x98
	private float reverbDelay; // 0x9C
	private int room; // 0xA0
	private int roomHF; // 0xA4
	private int roomLF; // 0xA8

	// Methods

	// RVA: 0x4C0CB0 Offset: 0x4C00B0 VA: 0x1804C0CB0
	protected void Awake() { }

	// RVA: 0x4C1630 Offset: 0x4C0A30 VA: 0x1804C1630
	protected void OnEnable() { }

	// RVA: 0x4C1570 Offset: 0x4C0970 VA: 0x1804C1570 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4C1130 Offset: 0x4C0530 VA: 0x1804C1130 Slot: 18
	public void DoUpdate() { }

	// RVA: 0x4C0880 Offset: 0x4BFC80 VA: 0x1804C0880
	private void ApplyReverbSettings() { }

	// RVA: 0x4C0ED0 Offset: 0x4C02D0 VA: 0x1804C0ED0
	private void DisableReverbZone() { }

	// RVA: 0x4C1360 Offset: 0x4C0760 VA: 0x1804C1360
	private void EnableReverbZone() { }

	// RVA: 0x4C1410 Offset: 0x4C0810 VA: 0x1804C1410 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x4C16B0 Offset: 0x4C0AB0 VA: 0x1804C16B0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x4C16C0 Offset: 0x4C0AC0 VA: 0x1804C16C0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x4C17D0 Offset: 0x4C0BD0 VA: 0x1804C17D0 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x4C0DD0 Offset: 0x4C01D0 VA: 0x1804C0DD0 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x4C16D0 Offset: 0x4C0AD0 VA: 0x1804C16D0 Slot: 20
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 19
	public bool IsSyncedToParent() { }

	// RVA: 0x4C1850 Offset: 0x4C0C50 VA: 0x1804C1850
	public void .ctor() { }

}

