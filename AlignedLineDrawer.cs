public class AlignedLineDrawer : MonoBehaviour, IClientComponent // TypeDefIndex: 8875
{	public MeshFilter Filter; // 0x18
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

	public Mesh CreatedMesh { get; set; }
	private List<AlignedLineDrawer.LinePoint> Points { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Mesh get_CreatedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CreatedMesh(Mesh value) { }

	private List<AlignedLineDrawer.LinePoint> get_Points() { }

	public void QueueMeshUpdate(bool isFinal, Action onComplete) { }

	public void ClearMesh() { }

	public virtual void UpdateMesh(bool isFinal = False) { }

	private void MakeEndCap(AlignedLineDrawer.LinePoint startPoint, AlignedLineDrawer.LinePoint oppositePoint, List<Vector3> verts, List<int> tris, List<Vector2> uvs, Matrix4x4 localToWorld, int startTriangle, int endTriangle) { }

	private void ExtrudePoints(List<AlignedLineDrawer.LinePoint> points, List<Vector3> verts, List<int> tris, List<Vector2> uvs, float extrudeDistance) { }

	protected virtual void AssignMesh() { }

	public virtual void SetColour(Color c) { }

	public virtual void SetWidth(float width) { }

	public static int GetCompressedPathLength(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	public static void CompressPath(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <UpdateMesh>g__GenerateLineSegment|24_0(int startPoint, int endPoint, ref AlignedLineDrawer.<>c__DisplayClass24_0 ) { }

}

public struct AlignedLineDrawer.LinePoint // TypeDefIndex: 8876
{	public Vector3 LocalPosition; // 0x0
	public Vector3 WorldNormal; // 0xC

}

public class AlignedLineDrawer.LineDrawerQueue : ObjectWorkQueue<AlignedLineDrawer> // TypeDefIndex: 8877
{
	protected override void RunJob(AlignedLineDrawer entity) { }

	protected override bool ShouldAdd(AlignedLineDrawer entity) { }

	public void .ctor() { }

}

private struct AlignedLineDrawer.<>c__DisplayClass24_0 // TypeDefIndex: 8878
{	public List<Vector3> verts; // 0x0
	public AlignedLineDrawer <>4__this; // 0x8
	public float distanceTravelled; // 0x10
	public Vector3 leftVertOffset; // 0x14
	public Vector3 rightVertOffset; // 0x20
	public List<Vector2> uvs; // 0x30
	public List<int> tris; // 0x38
	public bool isFinal; // 0x40

}

