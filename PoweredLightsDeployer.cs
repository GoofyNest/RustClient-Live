public class PoweredLightsDeployer : HeldEntity // TypeDefIndex: 8625
{	// Fields
	public GameObjectRef poweredLightsPrefab; // 0x1F8
	public EntityRef activeLights; // 0x200
	public MaterialReplacement guide; // 0x210
	public GameObject guideObject; // 0x218
	public float maxPlaceDistance; // 0x220
	public float lengthPerAmount; // 0x224
	private float nextClickTime; // 0x228

	// Properties
	public AdvancedChristmasLights active { get; set; }

	// Methods

	// RVA: 0x97FE70 Offset: 0x97F270 VA: 0x18097FE70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97F3B0 Offset: 0x97E7B0 VA: 0x18097F3B0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x97F270 Offset: 0x97E670 VA: 0x18097F270
	public static bool CanPlayerUse(BasePlayer player) { }

	// RVA: 0x97FFD0 Offset: 0x97F3D0 VA: 0x18097FFD0
	public AdvancedChristmasLights get_active() { }

	// RVA: 0x980070 Offset: 0x97F470 VA: 0x180980070
	public void set_active(AdvancedChristmasLights value) { }

	// RVA: 0x97F340 Offset: 0x97E740 VA: 0x18097F340 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x97FF60 Offset: 0x97F360 VA: 0x18097FF60
	public void .ctor() { }

}

