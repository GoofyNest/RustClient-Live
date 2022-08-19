public class SprayCanSpray : DecayEntity, ISplashable // TypeDefIndex: 8454
{	// Fields
	private Option __menuOption_Menu_WaterClear; // 0x258

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA7E990 Offset: 0xA7DD90 VA: 0x180A7E990 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA7EEB0 Offset: 0xA7E2B0 VA: 0x180A7EEB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA7EDC0 Offset: 0xA7E1C0 VA: 0x180A7EDC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	[BaseEntity.Menu.Description] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	[BaseEntity.Menu.Icon] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D8C0 Offset: 0x8CCC0 VA: 0x18008D8C0
	// RVA: 0xA7ED80 Offset: 0xA7E180 VA: 0x180A7ED80
	private void Menu_WaterClear(BasePlayer player) { }

	// RVA: 0xA7ECA0 Offset: 0xA7E0A0 VA: 0x180A7ECA0
	private bool Menu_WaterClear_ShowIf(BasePlayer player) { }

	// RVA: 0x911490 Offset: 0x910890 VA: 0x180911490
	public void .ctor() { }

}

public class SprayCanSpray_Freehand : SprayCanSpray // TypeDefIndex: 8649
{	// Fields
	public AlignedLineDrawer LineDrawer; // 0x2B0
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

	// Properties
	private bool CanDrawSpray { get; }

	// Methods

	// RVA: 0xA7E060 Offset: 0xA7D460 VA: 0x180A7E060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA7E150 Offset: 0xA7D550 VA: 0x180A7E150
	public static void RebuildAll() { }

	// RVA: 0xA7D9D0 Offset: 0xA7CDD0 VA: 0x180A7D9D0
	public void FinishEditing(bool allowNewSprayImmediately, List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA7E400 Offset: 0xA7D800 VA: 0x180A7E400
	private void UpdateMeshCollider() { }

	// RVA: 0xA7E440 Offset: 0xA7D840 VA: 0x180A7E440
	public void UpdatePointsMidSpray(List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA7E790 Offset: 0xA7DB90 VA: 0x180A7E790
	private bool get_CanDrawSpray() { }

	// RVA: 0xA7DCE0 Offset: 0xA7D0E0 VA: 0x180A7DCE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7D3A0 Offset: 0xA7C7A0 VA: 0x180A7D3A0
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<LinePoint> to) { }

	// RVA: 0xA7D840 Offset: 0xA7CC40 VA: 0x180A7D840
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<Vector3> to) { }

	// RVA: 0xA7D6B0 Offset: 0xA7CAB0 VA: 0x180A7D6B0
	private void CopyPoints(List<LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA7D550 Offset: 0xA7C950 VA: 0x180A7D550
	public static void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA7E3B0 Offset: 0xA7D7B0 VA: 0x180A7E3B0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA7E700 Offset: 0xA7DB00 VA: 0x180A7E700
	public void .ctor() { }

}

public class SprayCanSpray_Decal : SprayCanSpray, ICustomMaterialReplacer, IPropRenderNotify, INotifyLOD // TypeDefIndex: 8883
{	// Fields
	public DeferredDecal DecalComponent; // 0x2B0
	public GameObject IconPreviewRoot; // 0x2B8
	public Material DefaultMaterial; // 0x2C0

	// Methods

	// RVA: 0xA7D280 Offset: 0xA7C680 VA: 0x180A7D280
	public void WorkshopMode() { }

	// RVA: 0xA7D180 Offset: 0xA7C580 VA: 0x180A7D180 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA7D0C0 Offset: 0xA7C4C0 VA: 0x180A7D0C0 Slot: 145
	public void Replace(Material[] find, Material[] replace) { }

	// RVA: 0xA7D080 Offset: 0xA7C480 VA: 0x180A7D080 Slot: 146
	public void PreRender() { }

	// RVA: 0xA7D040 Offset: 0xA7C440 VA: 0x180A7D040 Slot: 147
	public void PostRender() { }

	// RVA: 0xA7D250 Offset: 0xA7C650 VA: 0x180A7D250 Slot: 148
	public void Show() { }

	// RVA: 0xA7D010 Offset: 0xA7C410 VA: 0x180A7D010 Slot: 149
	public void Hide() { }

	// RVA: 0x911490 Offset: 0x910890 VA: 0x180911490
	public void .ctor() { }

}

