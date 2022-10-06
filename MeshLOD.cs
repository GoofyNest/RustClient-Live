public class MeshLOD : LODComponent, IBatchingHandler // TypeDefIndex: 11654
{
	[HorizontalAttribute] 
	public MeshLOD.State[] States; 
	private RendererBatch meshBatch; 
	private MeshRenderer meshRenderer; 
	private MeshFilter meshFilter; 
	private ShadowCastingMode meshShadowMode; 
	private int curlod; 
	private bool force; 
	private bool isSmall; 


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

public class MeshLOD.State // TypeDefIndex: 11655
{
	public float distance; 
	public Mesh mesh; 


	public void Show(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode) { }

	public void Hide(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode, bool shadowsVisible = False) { }

	public void .ctor() { }

}

