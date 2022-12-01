public class LTSpline // TypeDefIndex: 5593
{
	public static int DISTANCE_COUNT;
	public static int SUBLINE_COUNT;
	public float distance;
	public bool constantSpeed;
	public Vector3[] pts;
	public Vector3[] ptsAdj;
	public int ptsAdjLength;
	public bool orientToPath;
	public bool orientToPath2d;
	private int numSections;
	private int currPt;


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

