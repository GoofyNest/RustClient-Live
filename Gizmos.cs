public sealed class Gizmos // TypeDefIndex: 3380
{	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x1826AA0 Offset: 0x1825EA0 VA: 0x181826AA0
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x1826EB0 Offset: 0x18262B0 VA: 0x181826EB0
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x1826D70 Offset: 0x1826170 VA: 0x181826D70
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x1826E10 Offset: 0x1826210 VA: 0x181826E10
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x18267C0 Offset: 0x1825BC0 VA: 0x1818267C0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x1826BD0 Offset: 0x1825FD0 VA: 0x181826BD0
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x1826970 Offset: 0x1825D70 VA: 0x181826970
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x18269E0 Offset: 0x1825DE0 VA: 0x1818269E0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x1826F40 Offset: 0x1826340 VA: 0x181826F40
	public static Color get_color() { }

	// RVA: 0x1827050 Offset: 0x1826450 VA: 0x181827050
	public static void set_color(Color value) { }

	// RVA: 0x1826FC0 Offset: 0x18263C0 VA: 0x181826FC0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x18270D0 Offset: 0x18264D0 VA: 0x1818270D0
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1826880 Offset: 0x1825C80 VA: 0x181826880
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x1826C40 Offset: 0x1826040 VA: 0x181826C40
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x1826B50 Offset: 0x1825F50 VA: 0x181826B50
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x1826A50 Offset: 0x1825E50 VA: 0x181826A50
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x1826E60 Offset: 0x1826260 VA: 0x181826E60
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x1826D20 Offset: 0x1826120 VA: 0x181826D20
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x1826DC0 Offset: 0x18261C0 VA: 0x181826DC0
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x1826770 Offset: 0x1825B70 VA: 0x181826770
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x1826AF0 Offset: 0x1825EF0 VA: 0x181826AF0
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x1826900 Offset: 0x1825D00 VA: 0x181826900
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x1826F00 Offset: 0x1826300 VA: 0x181826F00
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1827010 Offset: 0x1826410 VA: 0x181827010
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1826F80 Offset: 0x1826380 VA: 0x181826F80
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1827090 Offset: 0x1826490 VA: 0x181827090
	private static void set_matrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x1826810 Offset: 0x1825C10 VA: 0x181826810
	private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

