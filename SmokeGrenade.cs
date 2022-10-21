public class SmokeGrenade : TimedExplosive // TypeDefIndex: 11329
{
	public float smokeDuration; 
	public GameObjectRef smokeEffectPrefab; 
	public GameObjectRef igniteSound; 
	public SoundPlayer soundLoop; 
	private GameObject smokeEffectInstance; 
	public static List<SmokeGrenade> activeGrenades; 
	public float fieldMin; 
	public float fieldMax; 


	public override void DestroyShared() { }

	public void EnsureSmokeEffectEnabled() { }

	protected override void ClientInit(Entity info) { }

	public void CheckFuse() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void OnDestroy() { }

	public void Update() { }

	public void .ctor() { }

	private static void .cctor() { }

}

