public class SprayCanSpray : DecayEntity, ISplashable // TypeDefIndex: 8454
{	private Option __menuOption_Menu_WaterClear; // 0x258

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	[BaseEntity.Menu.Description] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	[BaseEntity.Menu.Icon] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	private void Menu_WaterClear(BasePlayer player) { }

	private bool Menu_WaterClear_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class SprayCanSpray_Freehand : SprayCanSpray // TypeDefIndex: 8649
{	public AlignedLineDrawer LineDrawer; // 0x2B0
	public List<AlignedLineDrawer.LinePoint> LinePoints; // 0x2B8
	private Color colour; // 0x2C0
	private float width; // 0x2D0
	private EntityRef<BasePlayer> editingPlayer; // 0x2D8
	public GroundWatch groundWatch; // 0x2E8
	public MeshCollider meshCollider; // 0x2F0
	public const int MaxLinePointLength = 60;
	public const float SimplifyTolerance = 0,008;
	private SprayCan attachedToCan; // 0x2F8
	private bool hasAttachedToSpray; // 0x300
	private TimeSince lastServerUpdate; // 0x304
	private bool firstSpray; // 0x308

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

public class SprayCanSpray_Decal : SprayCanSpray, ICustomMaterialReplacer, IPropRenderNotify, INotifyLOD // TypeDefIndex: 8883
{	public DeferredDecal DecalComponent; // 0x2B0
	public GameObject IconPreviewRoot; // 0x2B8
	public Material DefaultMaterial; // 0x2C0


	public void WorkshopMode() { }

	public override void ResetState() { }

	public void Replace(Material[] find, Material[] replace) { }

	public void PreRender() { }

	public void PostRender() { }

	public void Show() { }

	public void Hide() { }

	public void .ctor() { }

}

