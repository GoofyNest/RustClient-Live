public class TriggerRadiation : TriggerBase // TypeDefIndex: 10042
{	// Fields
	public TriggerRadiation.RadiationTier radiationTier; // 0x30
	public float RadiationAmountOverride; // 0x34
	public float falloff; // 0x38
	private SphereCollider sphereCollider; // 0x40

	// Methods

	// RVA: 0xA00EB0 Offset: 0xA002B0 VA: 0x180A00EB0
	public void Awake() { }

	// RVA: 0xA00F70 Offset: 0xA00370 VA: 0x180A00F70
	private float GetRadiationSize() { }

	// RVA: 0xA00F10 Offset: 0xA00310 VA: 0x180A00F10
	public float GetRadiationAmount() { }

	// RVA: 0xA01060 Offset: 0xA00460 VA: 0x180A01060
	public void OnDrawGizmosSelected() { }

	// RVA: 0xA01240 Offset: 0xA00640 VA: 0x180A01240
	public void .ctor() { }

}

public enum TriggerRadiation.RadiationTier // TypeDefIndex: 10043
{	// Fields
	public int value__; // 0x0
	public const TriggerRadiation.RadiationTier MINIMAL = 0;
	public const TriggerRadiation.RadiationTier LOW = 1;
	public const TriggerRadiation.RadiationTier MEDIUM = 2;
	public const TriggerRadiation.RadiationTier HIGH = 3;

}

