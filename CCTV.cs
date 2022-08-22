public class CCTV_RC : PoweredRemoteControlEntity // TypeDefIndex: 8372
{	private Option __menuOption_Menu_SetDir; // 0x300
	public Transform pivotOrigin; // 0x358
	public Transform yaw; // 0x360
	public Transform pitch; // 0x368
	public Vector2 pitchClamp; // 0x370
	public Vector2 yawClamp; // 0x378
	public float turnSpeed; // 0x380
	public float serverLerpSpeed; // 0x384
	public float clientLerpSpeed; // 0x388
	private float pitchAmount; // 0x38C
	private float yawAmount; // 0x390
	public bool hasPTZ; // 0x394
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

	[BaseEntity.Menu] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	[BaseEntity.Menu.Description] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	[BaseEntity.Menu.Icon] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	[BaseEntity.Menu.ShowIf] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	public void Menu_SetDir(BasePlayer player) { }

	public bool Menu_SetDir_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

