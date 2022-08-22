public class ERSideWalk // TypeDefIndex: 7197
{	public string name; // 0x10
	public double id; // 0x18
	public double timestamp; // 0x20
	public float sidewalkWidth; // 0x28
	public float curbHeight; // 0x2C
	public float curbDepth; // 0x30
	public bool beveledCurb; // 0x34
	public float beveledHeight; // 0x38
	public float beveledDepth; // 0x3C
	public bool outerCurb; // 0x40
	public bool roadSideCurbUVControl; // 0x41
	public bool outerSideCurbUVControl; // 0x42
	public Material material; // 0x48
	public bool hardEdges; // 0x50
	public List<Vector2> shape; // 0x58
	public List<float> sidewalkUVs; // 0x60
	public List<float> curbUVs; // 0x68
	public List<bool> doConnectionTri; // 0x70
	public Rect tileRect; // 0x78
	public float tileSize; // 0x88
	public float tiling; // 0x8C
	public float uvRatio; // 0x90
	public float minEnd; // 0x94
	public float maxEnd; // 0x98
	public bool lockUVs; // 0x9C
	public float cornerRadius; // 0xA0
	public int cornerSegments; // 0xA4
	public float innerSegmentDistance; // 0xA8


	public static ERSideWalk CreateInstance(int count) { }

	public void UpdateTimestamp() { }

	public static string[] SidewalkNames(List<ERSideWalk> sidewalks) { }

	public static void CopySidewalk(ERSideWalk source, ERSideWalk target) { }

	public static void RefreshSidewalks(List<ERSideWalk> sidewalks) { }

	public void OOQQDCCDQO() { }

	public void .ctor() { }

}

