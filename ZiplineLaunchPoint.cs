public class ZiplineLaunchPoint : BaseEntity // TypeDefIndex: 8489
{	private Option __menuOption_Menu_MountZipline; // 0x168
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	[BaseEntity.Menu.Description] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	[BaseEntity.Menu.Icon] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D2D0 Offset: 0x9C6D0 VA: 0x18009D2D0
	private void Menu_MountZipline(BasePlayer player) { }

	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	private void UpdateBuildingBlocks() { }

	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	public float GetLineLength() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|24_0(BoxCollider longCollider, BoxCollider pointCollider, int startIndex, int endIndex) { }

}

