public class TriggerRadiation : TriggerBase // TypeDefIndex: 11717
{
	public TriggerRadiation.RadiationTier radiationTier; 
	public float RadiationAmountOverride; 
	public float falloff; 
	private SphereCollider sphereCollider; 


	public void Awake() { }

	private float GetRadiationSize() { }

	public float GetRadiationAmount() { }

	public void OnDrawGizmosSelected() { }

	public void .ctor() { }

}

public enum TriggerRadiation.RadiationTier // TypeDefIndex: 11718
{
	public int value__; 
	public const TriggerRadiation.RadiationTier MINIMAL = 0;
	public const TriggerRadiation.RadiationTier LOW = 1;
	public const TriggerRadiation.RadiationTier MEDIUM = 2;
	public const TriggerRadiation.RadiationTier HIGH = 3;

}

