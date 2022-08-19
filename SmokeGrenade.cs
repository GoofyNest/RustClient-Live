public class SmokeGrenade : TimedExplosive // TypeDefIndex: 9607
{	// Fields
	public float smokeDuration; // 0x1B8
	public GameObjectRef smokeEffectPrefab; // 0x1C0
	public GameObjectRef igniteSound; // 0x1C8
	public SoundPlayer soundLoop; // 0x1D0
	private GameObject smokeEffectInstance; // 0x1D8
	public static List<SmokeGrenade> activeGrenades; // 0x0
	public float fieldMin; // 0x1E0
	public float fieldMax; // 0x1E4

	// Methods

	// RVA: 0x5C9F70 Offset: 0x5C9370 VA: 0x1805C9F70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x5C9FF0 Offset: 0x5C93F0 VA: 0x1805C9FF0
	public void EnsureSmokeEffectEnabled() { }

	// RVA: 0x5C9E90 Offset: 0x5C9290 VA: 0x1805C9E90 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5C9E60 Offset: 0x5C9260 VA: 0x1805C9E60
	public void CheckFuse() { }

	// RVA: 0x5CA280 Offset: 0x5C9680 VA: 0x1805CA280 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5CA2E0 Offset: 0x5C96E0 VA: 0x1805CA2E0
	public void OnDestroy() { }

	// RVA: 0x5CA510 Offset: 0x5C9910 VA: 0x1805CA510
	public void Update() { }

	// RVA: 0x5CA760 Offset: 0x5C9B60 VA: 0x1805CA760
	public void .ctor() { }

	// RVA: 0x5CA700 Offset: 0x5C9B00 VA: 0x1805CA700
	private static void .cctor() { }

}

