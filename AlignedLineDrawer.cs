public class AlignedLineDrawer : MonoBehaviour, IClientComponent // TypeDefIndex: 8875
{	// Fields
	public MeshFilter Filter; // 0x18
	public MeshRenderer Renderer; // 0x20
	public float LineWidth; // 0x28
	public float SurfaceOffset; // 0x2C
	public float SprayThickness; // 0x30
	public float uvTilingFactor; // 0x34
	public bool DrawEndCaps; // 0x38
	public bool DrawSideMesh; // 0x39
	public bool DrawBackMesh; // 0x3A
	public SprayCanSpray_Freehand Spray; // 0x40
	private static MaterialPropertyBlock propertyBlock; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <CreatedMesh>k__BackingField; // 0x48
	private bool isQueued; // 0x50
	private bool queuedFinal; // 0x51
	public static AlignedLineDrawer.LineDrawerQueue WorkQueue; // 0x8
	private Action meshUpdateCompleteAction; // 0x58

	// Properties
	public Mesh CreatedMesh { get; set; }
	private List<AlignedLineDrawer.LinePoint> Points { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public Mesh get_CreatedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	private void set_CreatedMesh(Mesh value) { }

	// RVA: 0xAA1170 Offset: 0xAA0570 VA: 0x180AA1170
	private List<AlignedLineDrawer.LinePoint> get_Points() { }

	// RVA: 0xA9F9A0 Offset: 0xA9EDA0 VA: 0x180A9F9A0
	public void QueueMeshUpdate(bool isFinal, Action onComplete) { }

	// RVA: 0xA9E6C0 Offset: 0xA9DAC0 VA: 0x180A9E6C0
	public void ClearMesh() { }

	// RVA: 0xAA0870 Offset: 0xA9FC70 VA: 0x180AA0870 Slot: 4
	public virtual void UpdateMesh(bool isFinal = False) { }

	// RVA: 0xA9F360 Offset: 0xA9E760 VA: 0x180A9F360
	private void MakeEndCap(AlignedLineDrawer.LinePoint startPoint, AlignedLineDrawer.LinePoint oppositePoint, List<Vector3> verts, List<int> tris, List<Vector2> uvs, Matrix4x4 localToWorld, int startTriangle, int endTriangle) { }

	// RVA: 0xA9EAF0 Offset: 0xA9DEF0 VA: 0x180A9EAF0
	private void ExtrudePoints(List<AlignedLineDrawer.LinePoint> points, List<Vector3> verts, List<int> tris, List<Vector2> uvs, float extrudeDistance) { }

	// RVA: 0xA9E630 Offset: 0xA9DA30 VA: 0x180A9E630 Slot: 5
	protected virtual void AssignMesh() { }

	// RVA: 0xA9FA50 Offset: 0xA9EE50 VA: 0x180A9FA50 Slot: 6
	public virtual void SetColour(Color c) { }

	// RVA: 0x93F180 Offset: 0x93E580 VA: 0x18093F180 Slot: 7
	public virtual void SetWidth(float width) { }

	// RVA: 0xA9EFD0 Offset: 0xA9E3D0 VA: 0x180A9EFD0
	public static int GetCompressedPathLength(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	// RVA: 0xA9E750 Offset: 0xA9DB50 VA: 0x180A9E750
	public static void CompressPath(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	// RVA: 0xAA1140 Offset: 0xAA0540 VA: 0x180AA1140
	public void .ctor() { }

	// RVA: 0xAA10C0 Offset: 0xAA04C0 VA: 0x180AA10C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA9FBC0 Offset: 0xA9EFC0 VA: 0x180A9FBC0
	private void <UpdateMesh>g__GenerateLineSegment|24_0(int startPoint, int endPoint, ref AlignedLineDrawer.<>c__DisplayClass24_0 ) { }

}

public struct AlignedLineDrawer.LinePoint // TypeDefIndex: 8876
{	// Fields
	public Vector3 LocalPosition; // 0x0
	public Vector3 WorldNormal; // 0xC

}

public class AlignedLineDrawer.LineDrawerQueue : ObjectWorkQueue<AlignedLineDrawer> // TypeDefIndex: 8877
{	// Methods

	// RVA: 0xAA6760 Offset: 0xAA5B60 VA: 0x180AA6760 Slot: 6
	protected override void RunJob(AlignedLineDrawer entity) { }

	// RVA: 0xAA67B0 Offset: 0xAA5BB0 VA: 0x180AA67B0 Slot: 5
	protected override bool ShouldAdd(AlignedLineDrawer entity) { }

	// RVA: 0xAA6840 Offset: 0xAA5C40 VA: 0x180AA6840
	public void .ctor() { }

}

private struct AlignedLineDrawer.<>c__DisplayClass24_0 // TypeDefIndex: 8878
{	// Fields
	public List<Vector3> verts; // 0x0
	public AlignedLineDrawer <>4__this; // 0x8
	public float distanceTravelled; // 0x10
	public Vector3 leftVertOffset; // 0x14
	public Vector3 rightVertOffset; // 0x20
	public List<Vector2> uvs; // 0x30
	public List<int> tris; // 0x38
	public bool isFinal; // 0x40

}

