public sealed class Gizmos // TypeDefIndex: 3380
{	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }


	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	public static Color get_color() { }

	public static void set_color(Color value) { }

	public static Matrix4x4 get_matrix() { }

	public static void set_matrix(Matrix4x4 value) { }

	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	public static void DrawRay(Vector3 from, Vector3 direction) { }

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	private static void get_color_Injected(out Color ret) { }

	private static void set_color_Injected(ref Color value) { }

	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	private static void set_matrix_Injected(ref Matrix4x4 value) { }

	private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

