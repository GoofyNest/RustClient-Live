public class MeshLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9941
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public MeshLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private MeshRenderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private ShadowCastingMode meshShadowMode; // 0xA0
	private int curlod; // 0xA4
	private bool force; // 0xA8
	private bool isSmall; // 0xA9

	// Methods

	// RVA: 0x95E9E0 Offset: 0x95DDE0 VA: 0x18095E9E0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x95E750 Offset: 0x95DB50 VA: 0x18095E750 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x95EE00 Offset: 0x95E200 VA: 0x18095EE00 Slot: 13
	protected override void Show() { }

	// RVA: 0x95E960 Offset: 0x95DD60 VA: 0x18095E960 Slot: 14
	protected override void Hide() { }

	// RVA: 0x95E8E0 Offset: 0x95DCE0 VA: 0x18095E8E0 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x95EB80 Offset: 0x95DF80 VA: 0x18095EB80 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x95EC10 Offset: 0x95E010 VA: 0x18095EC10 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x95E760 Offset: 0x95DB60 VA: 0x18095E760 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x95E430 Offset: 0x95D830 VA: 0x18095E430 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x95EE80 Offset: 0x95E280 VA: 0x18095EE80
	public void .ctor() { }

}

public class MeshLOD.State // TypeDefIndex: 9942
{	// Fields
	public float distance; // 0x10
	public Mesh mesh; // 0x18

	// Methods

	// RVA: 0x96BFD0 Offset: 0x96B3D0 VA: 0x18096BFD0
	public void Show(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode) { }

	// RVA: 0x96BEA0 Offset: 0x96B2A0 VA: 0x18096BEA0
	public void Hide(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode, bool shadowsVisible = False) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

