public class ZiplineLaunchPoint : BaseEntity // TypeDefIndex: 10160
{
	private Option __menuOption_Menu_MountZipline; 
	public Transform LineDeparturePoint; 
	public LineRenderer ZiplineRenderer; 
	public Collider MountCollider; 
	public BoxCollider[] BuildingBlocks; 
	public BoxCollider[] PointBuildingBlocks; 
	public SpawnableBoundsBlocker[] SpawnableBoundsBlockers; 
	public GameObjectRef MountableRef; 
	public float LineSlackAmount; 
	public bool RegenLine; 
	private List<Vector3> ziplineTargets; 
	private List<Vector3> linePoints; 
	public GameObjectRef ArrivalPointRef; 
	private bool hasSetupLineRenderer; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	private void Menu_MountZipline(BasePlayer player) { }

	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	private void UpdateBuildingBlocks() { }

	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	public float GetLineLength() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|25_0(BoxCollider longCollider, BoxCollider pointCollider, SpawnableBoundsBlocker spawnBlocker, int startIndex, int endIndex) { }

}

