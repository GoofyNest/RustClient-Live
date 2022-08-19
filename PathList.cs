internal class PathList // TypeDefIndex: 2945
{	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x13435F0 Offset: 0x13429F0 VA: 0x1813435F0
	public void .ctor() { }

	// RVA: 0x13436C0 Offset: 0x1342AC0 VA: 0x1813436C0
	public int get_Count() { }

	// RVA: 0x1343330 Offset: 0x1342730 VA: 0x181343330
	public int GetCookiesCount() { }

	// RVA: 0x1343750 Offset: 0x1342B50 VA: 0x181343750
	public ICollection get_Values() { }

	// RVA: 0x13436F0 Offset: 0x1342AF0 VA: 0x1813436F0
	public object get_Item(string s) { }

	// RVA: 0x1343780 Offset: 0x1342B80 VA: 0x181343780
	public void set_Item(string s, object value) { }

	// RVA: 0xB9A640 Offset: 0xB99A40 VA: 0x180B9A640
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1343720 Offset: 0x1342B20 VA: 0x181343720
	public object get_SyncRoot() { }

}

private class PathList.PathListComparer : IComparer // TypeDefIndex: 2946
{	// Fields
	internal static readonly PathList.PathListComparer StaticInstance; // 0x13890

	// Methods

	// RVA: 0x1343160 Offset: 0x1342560 VA: 0x181343160 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13432D0 Offset: 0x13426D0 VA: 0x1813432D0
	private static void .cctor() { }

}

public class PathList // TypeDefIndex: 10291
{	// Fields
	private static Quaternion rot90; // 0x0
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

	// Methods

	// RVA: 0x946390 Offset: 0x945790 VA: 0x180946390
	public void .ctor(string name, Vector3[] points) { }

	// RVA: 0x944C70 Offset: 0x944070 VA: 0x180944C70
	private void SpawnObjectsNeighborAligned(ref uint seed, Prefab[] prefabs, List<Vector3> positions, SpawnFilter filter) { }

	// RVA: 0x9443E0 Offset: 0x9437E0 VA: 0x1809443E0
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x944A70 Offset: 0x943E70 VA: 0x180944A70
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, List<Prefab> previousSpawns, out Prefab spawned, int pathLength, int index, SpawnFilter filter) { }

	// RVA: 0x942140 Offset: 0x941540 VA: 0x180942140
	private bool CheckObjects(Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x944570 Offset: 0x943970 VA: 0x180944570
	private void SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x941C40 Offset: 0x941040 VA: 0x180941C40
	private bool CheckObjects(Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x944FC0 Offset: 0x9443C0 VA: 0x180944FC0
	public void SpawnSide(ref uint seed, PathList.SideObject obj) { }

	// RVA: 0x943490 Offset: 0x942890 VA: 0x180943490
	public void SpawnAlong(ref uint seed, PathList.PathObject obj) { }

	// RVA: 0x943C50 Offset: 0x943050 VA: 0x180943C50
	public void SpawnBridge(ref uint seed, PathList.BridgeObject obj) { }

	// RVA: 0x9459A0 Offset: 0x944DA0 VA: 0x1809459A0
	public void SpawnStart(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x9441C0 Offset: 0x9435C0 VA: 0x1809441C0
	public void SpawnEnd(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x945E10 Offset: 0x945210 VA: 0x180945E10
	public void TrimStart(PathList.BasicObject obj) { }

	// RVA: 0x945B60 Offset: 0x944F60 VA: 0x180945B60
	public void TrimEnd(PathList.BasicObject obj) { }

	// RVA: 0x946030 Offset: 0x945430 VA: 0x180946030
	public void TrimTopology(int topology) { }

	// RVA: 0x943450 Offset: 0x942850 VA: 0x180943450
	public void ResetTrims() { }

	// RVA: 0x93F9C0 Offset: 0x93EDC0 VA: 0x18093F9C0
	public void AdjustTerrainHeight(float intensity = 1, float fade = 1) { }

	// RVA: 0x940760 Offset: 0x93FB60 VA: 0x180940760
	public void AdjustTerrainTexture() { }

	// RVA: 0x9411D0 Offset: 0x9405D0 VA: 0x1809411D0
	public void AdjustTerrainTopology() { }

	// RVA: 0x93F1A0 Offset: 0x93E5A0 VA: 0x18093F1A0
	public void AdjustPlacementMap(float width) { }

	// RVA: 0x942280 Offset: 0x941680 VA: 0x180942280
	public List<PathList.MeshObject> CreateMesh(Mesh[] meshes, float normalSmoothing, bool snapToTerrain, bool snapStartToTerrain, bool snapEndToTerrain) { }

	// RVA: 0x946230 Offset: 0x945630 VA: 0x180946230
	private static void .cctor() { }

}

public enum PathList.Side // TypeDefIndex: 10292
{	// Fields
	public int value__; // 0x0
	public const PathList.Side Both = 0;
	public const PathList.Side Left = 1;
	public const PathList.Side Right = 2;
	public const PathList.Side Any = 3;

}

public enum PathList.Placement // TypeDefIndex: 10293
{	// Fields
	public int value__; // 0x0
	public const PathList.Placement Center = 0;
	public const PathList.Placement Side = 1;

}

public enum PathList.Alignment // TypeDefIndex: 10294
{	// Fields
	public int value__; // 0x0
	public const PathList.Alignment None = 0;
	public const PathList.Alignment Neighbor = 1;
	public const PathList.Alignment Forward = 2;
	public const PathList.Alignment Inward = 3;

}

public class PathList.BasicObject // TypeDefIndex: 10295
{	// Fields
	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Placement Placement; // 0x20
	public bool AlignToNormal; // 0x24
	public bool HeightToTerrain; // 0x25
	public float Offset; // 0x28

	// Methods

	// RVA: 0x936950 Offset: 0x935D50 VA: 0x180936950
	public void .ctor() { }

}

public class PathList.SideObject // TypeDefIndex: 10296
{	// Fields
	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Side Side; // 0x20
	public PathList.Alignment Alignment; // 0x24
	public float Density; // 0x28
	public float Distance; // 0x2C
	public float Offset; // 0x30

	// Methods

	// RVA: 0x951A80 Offset: 0x950E80 VA: 0x180951A80
	public void .ctor() { }

}

public class PathList.PathObject // TypeDefIndex: 10297
{	// Fields
	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Alignment Alignment; // 0x20
	public float Density; // 0x24
	public float Distance; // 0x28
	public float Dithering; // 0x2C

	// Methods

	// RVA: 0x946420 Offset: 0x945820 VA: 0x180946420
	public void .ctor() { }

}

public class PathList.BridgeObject // TypeDefIndex: 10298
{	// Fields
	public string Folder; // 0x10
	public float Distance; // 0x18

	// Methods

	// RVA: 0x936960 Offset: 0x935D60 VA: 0x180936960
	public void .ctor() { }

}

public class PathList.MeshObject // TypeDefIndex: 10299
{	// Fields
	public Vector3 Position; // 0x10
	public Mesh[] Meshes; // 0x20

	// Methods

	// RVA: 0x936970 Offset: 0x935D70 VA: 0x180936970
	public void .ctor(Vector3 meshPivot, MeshData[] meshData) { }

}

private sealed class PathList.<>c__DisplayClass47_0 // TypeDefIndex: 10300
{	// Fields
	public TerrainHeightMap heightmap; // 0x10
	public Line prev_line; // 0x18
	public Line cur_line; // 0x30
	public float outerPadding; // 0x48
	public float outerFade; // 0x4C
	public float innerPadding; // 0x50
	public float innerFade; // 0x54
	public float offset01; // 0x58
	public float intensity; // 0x5C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass47_1 // TypeDefIndex: 10301
{	// Fields
	public float yn; // 0x10
	public Line next_line; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass47_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x951B10 Offset: 0x950F10 VA: 0x180951B10
	internal void <AdjustTerrainHeight>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass48_0 // TypeDefIndex: 10302
{	// Fields
	public TerrainSplatMap splatmap; // 0x10
	public float outerPadding; // 0x18
	public float innerPadding; // 0x1C
	public PathList <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass48_1 // TypeDefIndex: 10303
{	// Fields
	public float yn; // 0x10
	public Ray ray; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass48_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x951F30 Offset: 0x951330 VA: 0x180951F30
	internal void <AdjustTerrainTexture>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass49_0 // TypeDefIndex: 10304
{	// Fields
	public TerrainTopologyMap topomap; // 0x10
	public float outerPadding; // 0x18
	public float innerPadding; // 0x1C
	public PathList <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass49_1 // TypeDefIndex: 10305
{	// Fields
	public float yn; // 0x10
	public Ray ray; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass49_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9521B0 Offset: 0x9515B0 VA: 0x1809521B0
	internal void <AdjustTerrainTopology>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass50_0 // TypeDefIndex: 10306
{	// Fields
	public TerrainPlacementMap placementmap; // 0x10
	public float radius; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass50_1 // TypeDefIndex: 10307
{	// Fields
	public float yn; // 0x10
	public Ray ray; // 0x14
	public PathList.<>c__DisplayClass50_0 CS$<>8__locals1; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x952430 Offset: 0x951830 VA: 0x180952430
	internal void <AdjustPlacementMap>b__0(int x, int z) { }

}

