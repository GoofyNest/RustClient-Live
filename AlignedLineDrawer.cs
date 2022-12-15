public class AlignedLineDrawer : MonoBehaviour, IClientComponent // TypeDefIndex: 10610
{
	public MeshFilter Filter;
	public MeshRenderer Renderer;
	public float LineWidth;
	public float SurfaceOffset;
	public float SprayThickness;
	public float uvTilingFactor;
	public bool DrawEndCaps;
	public bool DrawSideMesh;
	public bool DrawBackMesh;
	public SprayCanSpray_Freehand Spray;
	private static MaterialPropertyBlock propertyBlock;
	[CompilerGeneratedAttribute]
	private Mesh <CreatedMesh>k__BackingField;
	private bool isQueued;
	private bool queuedFinal;
	public static AlignedLineDrawer.LineDrawerQueue WorkQueue;
	private Action meshUpdateCompleteAction;

	public Mesh CreatedMesh { get; set; }
	private List<AlignedLineDrawer.LinePoint> Points { get; }


	[CompilerGeneratedAttribute]
	public Mesh get_CreatedMesh() { }

	[CompilerGeneratedAttribute]
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

	[CompilerGeneratedAttribute]
	private void <UpdateMesh>g__GenerateLineSegment|24_0(int startPoint, int endPoint, ref AlignedLineDrawer.<>c

}

public struct AlignedLineDrawer.LinePoint // TypeDefIndex: 10611
{
	public Vector3 LocalPosition;
	public Vector3 WorldNormal;

}

public class AlignedLineDrawer.LineDrawerQueue : ObjectWorkQueue<AlignedLineDrawer> // TypeDefIndex: 10612
{

	protected override void RunJob(AlignedLineDrawer entity) { }

	protected override bool ShouldAdd(AlignedLineDrawer entity) { }

	public void .ctor() { }

}

private struct AlignedLineDrawer.<>c__DisplayClass24_0 // TypeDefIndex: 10613
{
	public List<Vector3> verts;
	public AlignedLineDrawer <>4__this;
	public float distanceTravelled;
	public Vector3 leftVertOffset;
	public Vector3 rightVertOffset;
	public List<Vector2> uvs;
	public List<int> tris;
	public bool isFinal;

}

