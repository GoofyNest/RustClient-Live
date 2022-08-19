public class TriggerSafeZone : TriggerBase // TypeDefIndex: 10045
{	// Fields
	public static List<TriggerSafeZone> allSafeZones; // 0x0
	public float maxDepth; // 0x30
	public float maxAltitude; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Collider <triggerCollider>k__BackingField; // 0x38

	// Properties
	public Collider triggerCollider { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Collider get_triggerCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_triggerCollider(Collider value) { }

	// RVA: 0xA01690 Offset: 0xA00A90 VA: 0x180A01690
	protected void Awake() { }

	// RVA: 0xA01A60 Offset: 0xA00E60 VA: 0x180A01A60
	protected void OnEnable() { }

	// RVA: 0xA01900 Offset: 0xA00D00 VA: 0x180A01900 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA017E0 Offset: 0xA00BE0 VA: 0x180A017E0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA01AE0 Offset: 0xA00EE0 VA: 0x180A01AE0
	public bool PassesHeightChecks(Vector3 entPos) { }

	// RVA: 0xA016E0 Offset: 0xA00AE0 VA: 0x180A016E0
	public float GetSafeLevel(Vector3 pos) { }

	// RVA: 0xA01C40 Offset: 0xA01040 VA: 0x180A01C40
	public void .ctor() { }

	// RVA: 0xA01BE0 Offset: 0xA00FE0 VA: 0x180A01BE0
	private static void .cctor() { }

}

