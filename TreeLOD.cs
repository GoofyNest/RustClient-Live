public class TreeLOD : LODComponent, IComparable<TreeLOD> // TypeDefIndex: 9955
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public TreeLOD.State[] States; // 0x80
	private int requestedlod; // 0x88
	private int curlod; // 0x8C
	private bool force; // 0x90
	public static Comparison<TreeLOD> Comparison; // 0x0

	// Properties
	public int CulledLOD { get; }
	public int BillboardLOD { get; }

	// Methods

	// RVA: 0x9FB400 Offset: 0x9FA800 VA: 0x1809FB400
	public int get_CulledLOD() { }

	// RVA: 0x9FB3D0 Offset: 0x9FA7D0 VA: 0x1809FB3D0
	public int get_BillboardLOD() { }

	// RVA: 0x9FAFB0 Offset: 0x9FA3B0 VA: 0x1809FAFB0
	public bool IsMesh(int lod) { }

	// RVA: 0x9FAD70 Offset: 0x9FA170 VA: 0x1809FAD70 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x9FAA50 Offset: 0x9F9E50 VA: 0x1809FAA50 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x9FA9D0 Offset: 0x9F9DD0 VA: 0x1809FA9D0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x9FB210 Offset: 0x9FA610 VA: 0x1809FB210 Slot: 13
	protected override void Show() { }

	// RVA: 0x9FACB0 Offset: 0x9FA0B0 VA: 0x1809FACB0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x9FAC60 Offset: 0x9FA060 VA: 0x1809FAC60 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x9FAF20 Offset: 0x9FA320 VA: 0x1809FAF20 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x9FAFE0 Offset: 0x9FA3E0 VA: 0x1809FAFE0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x9FAAD0 Offset: 0x9F9ED0 VA: 0x1809FAAD0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9FA7F0 Offset: 0x9F9BF0 VA: 0x1809FA7F0 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x9FA7B0 Offset: 0x9F9BB0 VA: 0x1809FA7B0 Slot: 21
	public int CompareTo(TreeLOD other) { }

	// RVA: 0x9FB370 Offset: 0x9FA770 VA: 0x1809FB370
	public void .ctor() { }

	// RVA: 0x9FB2C0 Offset: 0x9FA6C0 VA: 0x1809FB2C0
	private static void .cctor() { }

}

public class TreeLOD.State // TypeDefIndex: 9956
{	// Fields
	public float distance; // 0x10
	public Renderer renderer; // 0x18
	public MeshFilter filter; // 0x20
	public ShadowCastingMode shadowMode; // 0x28
	public bool isImpostor; // 0x2C

	// Methods

	// RVA: 0x9E7040 Offset: 0x9E6440 VA: 0x1809E7040
	public void Show() { }

	// RVA: 0x9E6F70 Offset: 0x9E6370 VA: 0x1809E6F70
	public void Hide(bool shadowsVisible = False) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class TreeLOD.<>c // TypeDefIndex: 9957
{	// Fields
	public static readonly TreeLOD.<>c <>9; // 0x2B0AA90

	// Methods

	// RVA: 0xA01D40 Offset: 0xA01140 VA: 0x180A01D40
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA01D00 Offset: 0xA01100 VA: 0x180A01D00
	internal int <.cctor>b__23_0(TreeLOD x, TreeLOD y) { }

}

