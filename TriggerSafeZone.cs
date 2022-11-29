public class TriggerSafeZone : TriggerBase // TypeDefIndex: 11789
{
	public static List<TriggerSafeZone> allSafeZones; 
	public float maxDepth; 
	public float maxAltitude; 
	[CompilerGeneratedAttribute] 
	private Collider <triggerCollider>k__BackingField; 

	public Collider triggerCollider { get; set; }


	[CompilerGeneratedAttribute] 
	public Collider get_triggerCollider() { }

	[CompilerGeneratedAttribute] 
	private void set_triggerCollider(Collider value) { }

	protected void Awake() { }

	protected void OnEnable() { }

	protected override void OnDisable() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	public bool PassesHeightChecks(Vector3 entPos) { }

	public float GetSafeLevel(Vector3 pos) { }

	public void .ctor() { }

	private static void .cctor() { }

}

