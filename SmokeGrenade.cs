public class SmokeGrenade : TimedExplosive // TypeDefIndex: 9607
{	public float smokeDuration; // 0x1B8
	public GameObjectRef smokeEffectPrefab; // 0x1C0
	public GameObjectRef igniteSound; // 0x1C8
	public SoundPlayer soundLoop; // 0x1D0
	private GameObject smokeEffectInstance; // 0x1D8
	public static List<SmokeGrenade> activeGrenades; // 0x0
	public float fieldMin; // 0x1E0
	public float fieldMax; // 0x1E4


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

