internal class PathList // TypeDefIndex: 2945
{	private SortedList m_list; // 0x10

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
{	internal static readonly PathList.PathListComparer StaticInstance; // 0x13890


	private int System.Collections.IComparer.Compare(object ol, object or) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PathList // TypeDefIndex: 10291
{	private static Quaternion rot90; // 0x0
	private static Quaternion rot180; // 0x10
	private static Quaternion rot270; // 0x20
	public string Name; // 0x10
	public PathInterpolator Path; // 0x18
	public bool Spline; // 0x20
	public bool Start; // 0x21
	public bool End; // 0x22
	public float Width; // 0x24
	public float InnerPadding; // 0x28
	public float OuterPadding; // 0x2C
	public float InnerFade; // 0x30
	public float OuterFade; // 0x34
	public float RandomScale; // 0x38
	public float MeshOffset; // 0x3C
	public float TerrainOffset; // 0x40
	public int Topology; // 0x44
	public int Splat; // 0x48
	public int Hierarchy; // 0x4C
	public PathFinder.Node ProcgenStartNode; // 0x50
	public PathFinder.Node ProcgenEndNode; // 0x58
	public const float StepSize = 1;
	private static float[] placements; // 0x30


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

public enum PathList.Side // TypeDefIndex: 10292
{	public int value__; // 0x0
	public const PathList.Side Both = 0;
	public const PathList.Side Left = 1;
	public const PathList.Side Right = 2;
	public const PathList.Side Any = 3;

}

public enum PathList.Placement // TypeDefIndex: 10293
{	public int value__; // 0x0
	public const PathList.Placement Center = 0;
	public const PathList.Placement Side = 1;

}

public enum PathList.Alignment // TypeDefIndex: 10294
{	public int value__; // 0x0
	public const PathList.Alignment None = 0;
	public const PathList.Alignment Neighbor = 1;
	public const PathList.Alignment Forward = 2;
	public const PathList.Alignment Inward = 3;

}

public class PathList.BasicObject // TypeDefIndex: 10295
{	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Placement Placement; // 0x20
	public bool AlignToNormal; // 0x24
	public bool HeightToTerrain; // 0x25
	public float Offset; // 0x28


	public void .ctor() { }

}

public class PathList.SideObject // TypeDefIndex: 10296
{	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Side Side; // 0x20
	public PathList.Alignment Alignment; // 0x24
	public float Density; // 0x28
	public float Distance; // 0x2C
	public float Offset; // 0x30


	public void .ctor() { }

}

public class PathList.PathObject // TypeDefIndex: 10297
{	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Alignment Alignment; // 0x20
	public float Density; // 0x24
	public float Distance; // 0x28
	public float Dithering; // 0x2C


	public void .ctor() { }

}

public class PathList.BridgeObject // TypeDefIndex: 10298
{	public string Folder; // 0x10
	public float Distance; // 0x18


	public void .ctor() { }

}

public class PathList.MeshObject // TypeDefIndex: 10299
{	public Vector3 Position; // 0x10
	public Mesh[] Meshes; // 0x20


	public void .ctor(Vector3 meshPivot, MeshData[] meshData) { }

}

private sealed class PathList.<>c__DisplayClass47_0 // TypeDefIndex: 10300
{	public TerrainHeightMap heightmap; // 0x10
	public Line prev_line; // 0x18
	public Line cur_line; // 0x30
	public float outerPadding; // 0x48
	public float outerFade; // 0x4C
	public float innerPadding; // 0x50
	public float innerFade; // 0x54
	public float offset01; // 0x58
	public float intensity; // 0x5C


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass47_1 // TypeDefIndex: 10301
{	public float yn; // 0x10
	public Line next_line; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass47_0 CS$<>8__locals1; // 0x38


	public void .ctor() { }

	internal void <AdjustTerrainHeight>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass48_0 // TypeDefIndex: 10302
{	public TerrainSplatMap splatmap; // 0x10
	public float outerPadding; // 0x18
	public float innerPadding; // 0x1C
	public PathList <>4__this; // 0x20


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass48_1 // TypeDefIndex: 10303
{	public float yn; // 0x10
	public Ray ray; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass48_0 CS$<>8__locals1; // 0x38


	public void .ctor() { }

	internal void <AdjustTerrainTexture>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass49_0 // TypeDefIndex: 10304
{	public TerrainTopologyMap topomap; // 0x10
	public float outerPadding; // 0x18
	public float innerPadding; // 0x1C
	public PathList <>4__this; // 0x20


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass49_1 // TypeDefIndex: 10305
{	public float yn; // 0x10
	public Ray ray; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass49_0 CS$<>8__locals1; // 0x38


	public void .ctor() { }

	internal void <AdjustTerrainTopology>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass50_0 // TypeDefIndex: 10306
{	public TerrainPlacementMap placementmap; // 0x10
	public float radius; // 0x18


	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass50_1 // TypeDefIndex: 10307
{	public float yn; // 0x10
	public Ray ray; // 0x14
	public PathList.<>c__DisplayClass50_0 CS$<>8__locals1; // 0x30


	public void .ctor() { }

	internal void <AdjustPlacementMap>b__0(int x, int z) { }

}

