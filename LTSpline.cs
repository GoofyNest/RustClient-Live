public class LTSpline // TypeDefIndex: 5584
{	// Fields
	public static int DISTANCE_COUNT; // 0x0
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

	// Methods

	// RVA: 0x21A5C40 Offset: 0x21A5040 VA: 0x1821A5C40
	public void .ctor(Vector3[] pts) { }

	// RVA: 0x21A5BF0 Offset: 0x21A4FF0 VA: 0x1821A5BF0
	public void .ctor(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21A64C0 Offset: 0x21A58C0 VA: 0x1821A64C0
	private void init(Vector3[] pts, bool constantSpeed) { }

	// RVA: 0x21A6F40 Offset: 0x21A6340 VA: 0x1821A6F40
	public Vector3 map(float u) { }

	// RVA: 0x21A6950 Offset: 0x21A5D50 VA: 0x1821A6950
	public Vector3 interp(float t) { }

	// RVA: 0x21A7BC0 Offset: 0x21A6FC0 VA: 0x1821A7BC0
	public float ratioAtPoint(Vector3 pt) { }

	// RVA: 0x21A7B70 Offset: 0x21A6F70 VA: 0x1821A7B70
	public Vector3 point(float ratio) { }

	// RVA: 0x21A71A0 Offset: 0x21A65A0 VA: 0x1821A71A0
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x21A73A0 Offset: 0x21A67A0 VA: 0x1821A73A0
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x21A7900 Offset: 0x21A6D00 VA: 0x1821A7900
	public void place(Transform transform, float ratio) { }

	// RVA: 0x21A7A60 Offset: 0x21A6E60 VA: 0x1821A7A60
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21A75F0 Offset: 0x21A69F0 VA: 0x1821A75F0
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x21A77A0 Offset: 0x21A6BA0 VA: 0x1821A77A0
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x21A63E0 Offset: 0x21A57E0 VA: 0x1821A63E0
	public void gizmoDraw(float t = -1) { }

	// RVA: 0x21A5EC0 Offset: 0x21A52C0 VA: 0x1821A5EC0
	public void drawGizmo(Color color) { }

	// RVA: 0x21A5C80 Offset: 0x21A5080 VA: 0x1821A5C80
	public static void drawGizmo(Transform[] arr, Color color) { }

	// RVA: 0x21A6000 Offset: 0x21A5400 VA: 0x1821A6000
	public static void drawLine(Transform[] arr, float width, Color color) { }

	// RVA: 0x21A6020 Offset: 0x21A5420 VA: 0x1821A6020
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	// RVA: 0x21A6260 Offset: 0x21A5660 VA: 0x1821A6260
	public Vector3[] generateVectors() { }

	// RVA: 0x21A5BA0 Offset: 0x21A4FA0 VA: 0x1821A5BA0
	private static void .cctor() { }

}

