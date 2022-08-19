public class ElectricWindmill : IOEntity // TypeDefIndex: 8740
{	// Fields
	public Animator animator; // 0x288
	public int maxPowerGeneration; // 0x290
	public Transform vaneRot; // 0x298
	public SoundDefinition wooshSound; // 0x2A0
	public Transform wooshOrigin; // 0x2A8
	public float targetSpeed; // 0x2B0
	private float serverWindSpeed; // 0x2B4
	private float lastServerTime; // 0x2B8
	protected static int speedIndex; // 0x0

	// Methods

	// RVA: 0x5D92B0 Offset: 0x5D86B0 VA: 0x1805D92B0 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0xABC0A0 Offset: 0xABB4A0 VA: 0x180ABC0A0
	public float GetWindSpeedScale() { }

	// RVA: 0xABC2C0 Offset: 0xABB6C0 VA: 0x180ABC2C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABBFB0 Offset: 0xABB3B0 VA: 0x180ABBFB0
	public Vector3 GetWindAimDir(float time) { }

	// RVA: 0xABC630 Offset: 0xABBA30 VA: 0x180ABC630
	public void Woosh() { }

	// RVA: 0xABC350 Offset: 0xABB750 VA: 0x180ABC350
	public void Update() { }

	// RVA: 0xABC6E0 Offset: 0xABBAE0 VA: 0x180ABC6E0
	public void .ctor() { }

	// RVA: 0xABC690 Offset: 0xABBA90 VA: 0x180ABC690
	private static void .cctor() { }

}

