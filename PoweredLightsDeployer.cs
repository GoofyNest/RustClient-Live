public class PoweredLightsDeployer : HeldEntity // TypeDefIndex: 8625
{	public GameObjectRef poweredLightsPrefab; // 0x1F8
	public EntityRef activeLights; // 0x200
	public MaterialReplacement guide; // 0x210
	public GameObject guideObject; // 0x218
	public float maxPlaceDistance; // 0x220
	public float lengthPerAmount; // 0x224
	private float nextClickTime; // 0x228

	public AdvancedChristmasLights active { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnInput() { }

	public override bool NeedsCrosshair() { }

	public static bool CanPlayerUse(BasePlayer player) { }

	public AdvancedChristmasLights get_active() { }

	public void set_active(AdvancedChristmasLights value) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

