public class TriggerRadiation : TriggerBase // TypeDefIndex: 10042
{	public TriggerRadiation.RadiationTier radiationTier; // 0x30
	public float RadiationAmountOverride; // 0x34
	public float falloff; // 0x38
	private SphereCollider sphereCollider; // 0x40


	public void Awake() { }

	private float GetRadiationSize() { }

	public float GetRadiationAmount() { }

	public void OnDrawGizmosSelected() { }

	public void .ctor() { }

}

public enum TriggerRadiation.RadiationTier // TypeDefIndex: 10043
{	public int value__; // 0x0
	public const TriggerRadiation.RadiationTier MINIMAL = 0;
	public const TriggerRadiation.RadiationTier LOW = 1;
	public const TriggerRadiation.RadiationTier MEDIUM = 2;
	public const TriggerRadiation.RadiationTier HIGH = 3;

}

