public class MeshLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9941
{	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public MeshLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private MeshRenderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private ShadowCastingMode meshShadowMode; // 0xA0
	private int curlod; // 0xA4
	private bool force; // 0xA8
	private bool isSmall; // 0xA9


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void Hide(bool shadowsVisible) { }

	protected override bool IsLODHiding() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	public void .ctor() { }

}

public class MeshLOD.State // TypeDefIndex: 9942
{	public float distance; // 0x10
	public Mesh mesh; // 0x18


	public void Show(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode) { }

	public void Hide(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode, bool shadowsVisible = False) { }

	public void .ctor() { }

}

