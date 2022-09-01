public class SprayCanSpray : DecayEntity, ISplashable // TypeDefIndex: 8456
{
	private Option __menuOption_Menu_WaterClear; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	private void Menu_WaterClear(BasePlayer player) { }

	private bool Menu_WaterClear_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class SprayCanSpray_Freehand : SprayCanSpray // TypeDefIndex: 8652
{
	public AlignedLineDrawer LineDrawer; 
	public List<AlignedLineDrawer.LinePoint> LinePoints; 
	private Color colour; 
	private float width; 
	private EntityRef<BasePlayer> editingPlayer; 
	public GroundWatch groundWatch; 
	public MeshCollider meshCollider; 
	public const int MaxLinePointLength = 60;
	public const float SimplifyTolerance = 0,008;
	private SprayCan attachedToCan; 
	private bool hasAttachedToSpray; 
	private TimeSince lastServerUpdate; 
	private bool firstSpray; 

	private bool CanDrawSpray { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static void RebuildAll() { }

	public void FinishEditing(bool allowNewSprayImmediately, List<AlignedLineDrawer.LinePoint> points) { }

	private void UpdateMeshCollider() { }

	public void UpdatePointsMidSpray(List<AlignedLineDrawer.LinePoint> points) { }

	private bool get_CanDrawSpray() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<LinePoint> to) { }

	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<Vector3> to) { }

	private void CopyPoints(List<LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	public static void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	public override void ResetState() { }

	public void .ctor() { }

}

public class SprayCanSpray_Decal : SprayCanSpray, ICustomMaterialReplacer, IPropRenderNotify, INotifyLOD // TypeDefIndex: 8886
{
	public DeferredDecal DecalComponent; 
	public GameObject IconPreviewRoot; 
	public Material DefaultMaterial; 


	public void WorkshopMode() { }

	public override void ResetState() { }

	public void Replace(Material[] find, Material[] replace) { }

	public void PreRender() { }

	public void PostRender() { }

	public void Show() { }

	public void Hide() { }

	public void .ctor() { }

}

