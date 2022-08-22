public class RendererLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9951
{	public RendererLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool isSmall; // 0x95


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

public class RendererLOD.State // TypeDefIndex: 9952
{	public float distance; // 0x10
	public Renderer renderer; // 0x18
	public MeshFilter filter; // 0x20
	public ShadowCastingMode shadowMode; // 0x28
	public bool isImpostor; // 0x2C


	public void Show(RendererBatch batch, bool forceShadowsOff = False) { }

	public void Hide(RendererBatch batch, bool shadowsVisible = False) { }

	public void .ctor() { }

}

