public class TreeLOD : LODComponent, IComparable<TreeLOD> // TypeDefIndex: 11697
{
	[HorizontalAttribute] 
	public TreeLOD.State[] States; 
	private int requestedlod; 
	private int curlod; 
	private bool force; 
	public static Comparison<TreeLOD> Comparison; 

	public int CulledLOD { get; }
	public int BillboardLOD { get; }


	public int get_CulledLOD() { }

	public int get_BillboardLOD() { }

	public bool IsMesh(int lod) { }

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

	public int CompareTo(TreeLOD other) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TreeLOD.State // TypeDefIndex: 11698
{
	public float distance; 
	public Renderer renderer; 
	public MeshFilter filter; 
	public ShadowCastingMode shadowMode; 
	public bool isImpostor; 


	public void Show() { }

	public void Hide(bool shadowsVisible = False) { }

	public void .ctor() { }

}

private sealed class TreeLOD.<>c // TypeDefIndex: 11699
{
	public static readonly TreeLOD.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <.cctor>

}

