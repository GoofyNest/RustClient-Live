public class RendererLOD : LODComponent, IBatchingHandler // TypeDefIndex: 11710
{
	public RendererLOD.State[] States;
	private RendererBatch meshBatch;
	private int curlod;
	private bool force;
	private bool isSmall;
	private bool isBeingForcedOff;


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void PrepareForForceVisible() { }

	protected override void Hide(bool shadowsVisible) { }

	protected override bool IsLODHiding() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	public void .ctor() { }

}

public class RendererLOD.State // TypeDefIndex: 11711
{
	public float distance;
	public Renderer renderer;
	public MeshFilter filter;
	public ShadowCastingMode shadowMode;
	public bool isImpostor;


	public void Show(RendererBatch batch, bool forceShadowsOff = False) { }

	public void Hide(RendererBatch batch, bool shadowsVisible = False) { }

	public void .ctor() { }

}

