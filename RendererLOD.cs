public class RendererLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9951
{	// Fields
	public RendererLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool isSmall; // 0x95

	// Methods

	// RVA: 0x930A10 Offset: 0x92FE10 VA: 0x180930A10 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C46B0 Offset: 0x4C3AB0 VA: 0x1804C46B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x930EE0 Offset: 0x9302E0 VA: 0x180930EE0 Slot: 13
	protected override void Show() { }

	// RVA: 0x9309B0 Offset: 0x92FDB0 VA: 0x1809309B0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x930950 Offset: 0x92FD50 VA: 0x180930950 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x930CA0 Offset: 0x9300A0 VA: 0x180930CA0 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x930D30 Offset: 0x930130 VA: 0x180930D30 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x9307D0 Offset: 0x92FBD0 VA: 0x1809307D0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9305C0 Offset: 0x92F9C0 VA: 0x1809305C0 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x930F40 Offset: 0x930340 VA: 0x180930F40
	public void .ctor() { }

}

public class RendererLOD.State // TypeDefIndex: 9952
{	// Fields
	public float distance; // 0x10
	public Renderer renderer; // 0x18
	public MeshFilter filter; // 0x20
	public ShadowCastingMode shadowMode; // 0x28
	public bool isImpostor; // 0x2C

	// Methods

	// RVA: 0x935650 Offset: 0x934A50 VA: 0x180935650
	public void Show(RendererBatch batch, bool forceShadowsOff = False) { }

	// RVA: 0x935500 Offset: 0x934900 VA: 0x180935500
	public void Hide(RendererBatch batch, bool shadowsVisible = False) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

