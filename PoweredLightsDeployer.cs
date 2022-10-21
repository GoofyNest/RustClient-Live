public class PoweredLightsDeployer : HeldEntity // TypeDefIndex: 10334
{
	public GameObjectRef poweredLightsPrefab; 
	public EntityRef activeLights; 
	public MaterialReplacement guide; 
	public GameObject guideObject; 
	public float maxPlaceDistance; 
	public float lengthPerAmount; 
	private float nextClickTime; 

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

