public class LTSpline // TypeDefIndex: 5584
{	public static int DISTANCE_COUNT; // 0x0
	public static int SUBLINE_COUNT; // 0x4
	public float distance; // 0x10
	public bool constantSpeed; // 0x14
	public Vector3[] pts; // 0x18
	public Vector3[] ptsAdj; // 0x20
	public int ptsAdjLength; // 0x28
	public bool orientToPath; // 0x2C
	public bool orientToPath2d; // 0x2D
	private int numSections; // 0x30
	private int currPt; // 0x34


	public void .ctor(Vector3[] pts) { }

	public void .ctor(Vector3[] pts, bool constantSpeed) { }

	private void init(Vector3[] pts, bool constantSpeed) { }

	public Vector3 map(float u) { }

	public Vector3 interp(float t) { }

	public float ratioAtPoint(Vector3 pt) { }

	public Vector3 point(float ratio) { }

	public void place2d(Transform transform, float ratio) { }

	public void placeLocal2d(Transform transform, float ratio) { }

	public void place(Transform transform, float ratio) { }

	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	public void placeLocal(Transform transform, float ratio) { }

	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	public void gizmoDraw(float t = -1) { }

	public void drawGizmo(Color color) { }

	public static void drawGizmo(Transform[] arr, Color color) { }

	public static void drawLine(Transform[] arr, float width, Color color) { }

	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	public Vector3[] generateVectors() { }

	private static void .cctor() { }

}

