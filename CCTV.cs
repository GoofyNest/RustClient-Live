public class CCTV_RC : PoweredRemoteControlEntity // TypeDefIndex: 10078
{
	private Option __menuOption_Menu_SetDir; 
	public Transform pivotOrigin; 
	public Transform yaw; 
	public Transform pitch; 
	public Vector2 pitchClamp; 
	public Vector2 yawClamp; 
	public float turnSpeed; 
	public float serverLerpSpeed; 
	public float clientLerpSpeed; 
	private float pitchAmount; 
	private float yawAmount; 
	public bool hasPTZ; 
	public const BaseEntity.Flags Flag_HasViewer = 2048;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override int ConsumptionAmount() { }

	public void UpdateRotation(float delta) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetDir(BasePlayer player) { }

	public bool Menu_SetDir_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

