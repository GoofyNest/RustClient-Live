public class ERSideWalk // TypeDefIndex: 7213
{
	public string name;
	public double id;
	public double timestamp;
	public float sidewalkWidth;
	public float curbHeight;
	public float curbDepth;
	public bool beveledCurb;
	public float beveledHeight;
	public float beveledDepth;
	public bool outerCurb;
	public bool roadSideCurbUVControl;
	public bool outerSideCurbUVControl;
	public Material material;
	public bool hardEdges;
	public List<Vector2> shape;
	public List<float> sidewalkUVs;
	public List<float> curbUVs;
	public List<bool> doConnectionTri;
	public Rect tileRect;
	public float tileSize;
	public float tiling;
	public float uvRatio;
	public float minEnd;
	public float maxEnd;
	public bool lockUVs;
	public float cornerRadius;
	public int cornerSegments;
	public float innerSegmentDistance;


	public static ERSideWalk CreateInstance(int count) { }

	public void UpdateTimestamp() { }

	public static string[] SidewalkNames(List<ERSideWalk> sidewalks) { }

	public static void CopySidewalk(ERSideWalk source, ERSideWalk target) { }

	public static void RefreshSidewalks(List<ERSideWalk> sidewalks) { }

	public void OOQQDCCDQO() { }

	public void .ctor() { }

}

