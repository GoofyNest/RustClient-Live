internal class PathList // TypeDefIndex: 2945
{
	private SortedList m_list;

	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }


	public void .ctor() { }

	public int get_Count() { }

	public int GetCookiesCount() { }

	public ICollection get_Values() { }

	public object get_Item(string s) { }

	public void set_Item(string s, object value) { }

	public IEnumerator GetEnumerator() { }

	public object get_SyncRoot() { }

}

private class PathList.PathListComparer : IComparer // TypeDefIndex: 2946
{
	internal static readonly PathList.PathListComparer StaticInstance;


	private int System.Collections.IComparer.Compare(object ol, object or) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PathList // TypeDefIndex: 12049
{
	private static Quaternion rot90;
	private static Quaternion rot180;
	private static Quaternion rot270;
	public string Name;
	public PathInterpolator Path;
	public bool Spline;
	public bool Start;
	public bool End;
	public float Width;
	public float InnerPadding;
	public float OuterPadding;
	public float InnerFade;
	public float OuterFade;
	public float RandomScale;
	public float MeshOffset;
	public float TerrainOffset;
	public int Topology;
	public int Splat;
	public int Hierarchy;
	public PathFinder.Node ProcgenStartNode;
	public PathFinder.Node ProcgenEndNode;
	public const float StepSize = 1;
	private static float[] placements;


	public void .ctor(string name, Vector3[] points) { }

	private void SpawnObjectsNeighborAligned(ref uint seed, Prefab[] prefabs, List<Vector3> positions, SpawnFilter filter) { }

	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, List<Prefab> previousSpawns, out Prefab spawned, int pathLength, int index, SpawnFilter filter) { }

	private bool CheckObjects(Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	private void SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	private bool CheckObjects(Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	public void SpawnSide(ref uint seed, PathList.SideObject obj) { }

	public void SpawnAlong(ref uint seed, PathList.PathObject obj) { }

	public void SpawnBridge(ref uint seed, PathList.BridgeObject obj) { }

	public void SpawnStart(ref uint seed, PathList.BasicObject obj) { }

	public void SpawnEnd(ref uint seed, PathList.BasicObject obj) { }

	public void TrimStart(PathList.BasicObject obj) { }

	public void TrimEnd(PathList.BasicObject obj) { }

	public void TrimTopology(int topology) { }

	public void ResetTrims() { }

	public void AdjustTerrainHeight(float intensity = 1, float fade = 1) { }

	public void AdjustTerrainTexture() { }

	public void AdjustTerrainTopology() { }

	public void AdjustPlacementMap(float width) { }

	public List<PathList.MeshObject> CreateMesh(Mesh[] meshes, float normalSmoothing, bool snapToTerrain, bool snapStartToTerrain, bool snapEndToTerrain) { }

	private static void .cctor() { }

}

public enum PathList.Side // TypeDefIndex: 12050
{
	public int value__;
	public const PathList.Side Both = 0;
	public const PathList.Side Left = 1;
	public const PathList.Side Right = 2;
	public const PathList.Side Any = 3;

}

public enum PathList.Placement // TypeDefIndex: 12051
{
	public int value__;
	public const PathList.Placement Center = 0;
	public const PathList.Placement Side = 1;

}

public enum PathList.Alignment // TypeDefIndex: 12052
{
	public int value__;
	public const PathList.Alignment None = 0;
	public const PathList.Alignment Neighbor = 1;
	public const PathList.Alignment Forward = 2;
	public const PathList.Alignment Inward = 3;

}

public class PathList.BasicObject // TypeDefIndex: 12053
{
	public string Folder;
	public SpawnFilter Filter;
	public PathList.Placement Placement;
	public bool AlignToNormal;
	public bool HeightToTerrain;
	public float Offset;


	public void .ctor() { }

}

public class PathList.SideObject // TypeDefIndex: 12054
{
	public string Folder;
	public SpawnFilter Filter;
	public PathList.Side Side;
	public PathList.Alignment Alignment;
	public float Density;
	public float Distance;
	public float Offset;


	public void .ctor() { }

}

public class PathList.PathObject // TypeDefIndex: 12055
{
	public string Folder;
	public SpawnFilter Filter;
	public PathList.Alignment Alignment;
	public float Density;
	public float Distance;
	public float Dithering;


	public void .ctor() { }

}

public class PathList.BridgeObject // TypeDefIndex: 12056
{
	public string Folder;
	public float Distance;


	public void .ctor() { }

}

public class PathList.MeshObject // TypeDefIndex: 12057
{
	public Vector3 Position;
	public Mesh[] Meshes;


	public void .ctor(Vector3 meshPivot, MeshData[] meshData) { }

}

private sealed class PathList.<>c__DisplayClass47_0 // TypeDefIndex: 12058
{
	public TerrainHeightMap heightmap;
	public Line prev_line;
	public Line cur_line;
	public float outerPadding;
	public float outerFade;
	public float innerPadding;
	public float innerFade;
	public float offset01;
	public float intensity;


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass47_1 // TypeDefIndex: 12059
{
	public float yn;
	public Line next_line;
	public float radius;
	public float opacity;
	public PathList.<>c


	public void .ctor() { }

	internal void <AdjustTerrainHeight>

}

private sealed class PathList.<>c__DisplayClass48_0 // TypeDefIndex: 12060
{
	public TerrainSplatMap splatmap;
	public float outerPadding;
	public float innerPadding;
	public PathList <>4__this;


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass48_1 // TypeDefIndex: 12061
{
	public float yn;
	public Ray ray;
	public float radius;
	public float opacity;
	public PathList.<>c


	public void .ctor() { }

	internal void <AdjustTerrainTexture>

}

private sealed class PathList.<>c__DisplayClass49_0 // TypeDefIndex: 12062
{
	public TerrainTopologyMap topomap;
	public float outerPadding;
	public float innerPadding;
	public PathList <>4__this;


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass49_1 // TypeDefIndex: 12063
{
	public float yn;
	public Ray ray;
	public float radius;
	public float opacity;
	public PathList.<>c


	public void .ctor() { }

	internal void <AdjustTerrainTopology>

}

private sealed class PathList.<>c__DisplayClass50_0 // TypeDefIndex: 12064
{
	public TerrainPlacementMap placementmap;
	public float radius;


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass50_1 // TypeDefIndex: 12065
{
	public float yn;
	public Ray ray;
	public PathList.<>c


	public void .ctor() { }

	internal void <AdjustPlacementMap>

}

