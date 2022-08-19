public class ZiplineLaunchPoint : BaseEntity // TypeDefIndex: 8489
{	// Fields
	private Option __menuOption_Menu_MountZipline; // 0x168
	public Transform LineDeparturePoint; // 0x1C0
	public LineRenderer ZiplineRenderer; // 0x1C8
	public Collider MountCollider; // 0x1D0
	public BoxCollider[] BuildingBlocks; // 0x1D8
	public BoxCollider[] PointBuildingBlocks; // 0x1E0
	public GameObjectRef MountableRef; // 0x1E8
	public float LineSlackAmount; // 0x1F0
	public bool RegenLine; // 0x1F4
	private List<Vector3> ziplineTargets; // 0x1F8
	private List<Vector3> linePoints; // 0x200
	public GameObjectRef ArrivalPointRef; // 0x208
	private bool hasSetupLineRenderer; // 0x210

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x1A94A40 Offset: 0x1A93E40 VA: 0x181A94A40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x1A96130 Offset: 0x1A95530 VA: 0x181A96130 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x1A95220 Offset: 0x1A94620 VA: 0x181A95220 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x1A95310 Offset: 0x1A94710 VA: 0x181A95310 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A95E10 Offset: 0x1A95210 VA: 0x181A95E10
	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	[BaseEntity.Menu.Description] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	[BaseEntity.Menu.Icon] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	// RVA: 0x1A95030 Offset: 0x1A94430 VA: 0x181A95030
	private void Menu_MountZipline(BasePlayer player) { }

	// RVA: 0x1A95070 Offset: 0x1A94470 VA: 0x181A95070
	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x1A94E50 Offset: 0x1A94250 VA: 0x181A94E50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A946C0 Offset: 0x1A93AC0 VA: 0x181A946C0
	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	// RVA: 0x1A945D0 Offset: 0x1A939D0 VA: 0x181A945D0
	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	// RVA: 0x1A958D0 Offset: 0x1A94CD0 VA: 0x181A958D0
	private void UpdateBuildingBlocks() { }

	// RVA: 0x1A94D50 Offset: 0x1A94150 VA: 0x181A94D50
	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	// RVA: 0x1A948A0 Offset: 0x1A93CA0 VA: 0x181A948A0
	public float GetLineLength() { }

	// RVA: 0x1A96090 Offset: 0x1A95490 VA: 0x181A96090
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A953C0 Offset: 0x1A947C0 VA: 0x181A953C0
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|24_0(BoxCollider longCollider, BoxCollider pointCollider, int startIndex, int endIndex) { }

}

