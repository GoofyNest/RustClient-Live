public static class BoundsEx // TypeDefIndex: 13158
{
	private static Vector3[] pts;


	[ExtensionAttribute]
	public static Bounds XZ3D(Bounds bounds) { }

	[ExtensionAttribute]
	public static Bounds Transform(Bounds bounds, Matrix4x4 matrix) { }

	[ExtensionAttribute]
	public static Rect ToScreenRect(Bounds b, Camera cam) { }

	[ExtensionAttribute]
	public static Rect ToCanvasRect(Bounds b, RectTransform target, Camera cam) { }

	private static void .cctor() { }

}

