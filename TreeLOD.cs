public class TreeLOD : LODComponent, IComparable<TreeLOD> // TypeDefIndex: 9955
{	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public TreeLOD.State[] States; // 0x80
	private int requestedlod; // 0x88
	private int curlod; // 0x8C
	private bool force; // 0x90
	public static Comparison<TreeLOD> Comparison; // 0x0

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

public class TreeLOD.State // TypeDefIndex: 9956
{	public float distance; // 0x10
	public Renderer renderer; // 0x18
	public MeshFilter filter; // 0x20
	public ShadowCastingMode shadowMode; // 0x28
	public bool isImpostor; // 0x2C


	public void Show() { }

	public void Hide(bool shadowsVisible = False) { }

	public void .ctor() { }

}

private sealed class TreeLOD.<>c // TypeDefIndex: 9957
{	public static readonly TreeLOD.<>c <>9; // 0x2B0AA90


	private static void .cctor() { }

	public void .ctor() { }

	internal int <.cctor>b__23_0(TreeLOD x, TreeLOD y) { }

}

