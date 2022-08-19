public static class Vector3Ex // TypeDefIndex: 6612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC6B0 Offset: 0x1BABAB0 VA: 0x181BAC6B0
	public static Vector3 WithX(Vector3 v, float x) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14F4D90 Offset: 0x14F4190 VA: 0x1814F4D90
	public static Vector3 WithY(Vector3 v, float y) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC6F0 Offset: 0x1BABAF0 VA: 0x181BAC6F0
	public static Vector3 WithZ(Vector3 v, float z) { }

	// RVA: 0x1BAC770 Offset: 0x1BABB70 VA: 0x181BAC770
	public static Vector3 XZ(Vector3 v) { }

	// RVA: 0x1BAB5B0 Offset: 0x1BAA9B0 VA: 0x181BAB5B0
	public static float Distance2D(Vector3 a, Vector3 b) { }

	// RVA: 0x1BABB90 Offset: 0x1BAAF90 VA: 0x181BABB90
	public static float HeightDelta(Vector3 a, Vector3 b) { }

	// RVA: 0x1BAB3A0 Offset: 0x1BAA7A0 VA: 0x181BAB3A0
	public static Vector3 Direction2D(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BAB4E0 Offset: 0x1BAA8E0 VA: 0x181BAB4E0
	public static Vector3 Direction(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BAC1F0 Offset: 0x1BAB5F0 VA: 0x181BAC1F0
	public static Vector3 Range(float x, float y) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC290 Offset: 0x1BAB690 VA: 0x181BAC290
	public static Vector3 Scale(Vector3 vector, float x, float y, float z) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC440 Offset: 0x1BAB840 VA: 0x181BAC440
	public static Vector3 SnapTo(Vector3 vector, float snapValue) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABC10 Offset: 0x1BAB010 VA: 0x181BABC10
	public static Vector3 Inverse(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC2F0 Offset: 0x1BAB6F0 VA: 0x181BAC2F0
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABA50 Offset: 0x1BAAE50 VA: 0x181BABA50
	public static void FastRenormalize(Vector3 n, float scale = 1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC5C0 Offset: 0x1BAB9C0 VA: 0x181BAC5C0
	public static void ToDirectionAndMagnitude(Vector3 value, out Vector3 direction, out float magnitude) { }

	// RVA: 0x1BAB280 Offset: 0x1BAA680 VA: 0x181BAB280
	public static Vector3 BlendNormals(Vector3 n1, Vector3 n2) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABC60 Offset: 0x1BAB060 VA: 0x181BABC60
	public static bool IsNaNOrInfinity(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAB710 Offset: 0x1BAAB10 VA: 0x181BAB710
	public static float DotRadians(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAB6C0 Offset: 0x1BAAAC0 VA: 0x181BAB6C0
	public static float DotDegrees(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABD00 Offset: 0x1BAB100 VA: 0x181BABD00
	public static float Magnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC4F0 Offset: 0x1BAB8F0 VA: 0x181BAC4F0
	public static float SqrMagnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABD80 Offset: 0x1BAB180 VA: 0x181BABD80
	public static float MagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC520 Offset: 0x1BAB920 VA: 0x181BAC520
	public static float SqrMagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABE00 Offset: 0x1BAB200 VA: 0x181BABE00
	public static float MagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC550 Offset: 0x1BAB950 VA: 0x181BAC550
	public static float SqrMagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABE80 Offset: 0x1BAB280 VA: 0x181BABE80
	public static float MagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC580 Offset: 0x1BAB980 VA: 0x181BAC580
	public static float SqrMagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC730 Offset: 0x1BABB30 VA: 0x181BAC730
	public static Vector3 XY3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC770 Offset: 0x1BABB70 VA: 0x181BAC770
	public static Vector3 XZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC7F0 Offset: 0x1BABBF0 VA: 0x181BAC7F0
	public static Vector3 YZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6470 Offset: 0xAC5870 VA: 0x180AC6470
	public static Vector2 XY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC64A0 Offset: 0xAC58A0 VA: 0x180AC64A0
	public static Vector2 XZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6510 Offset: 0xAC5910 VA: 0x180AC6510
	public static Vector2 YZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC64E0 Offset: 0xAC58E0 VA: 0x180AC64E0
	public static Vector2 YX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6550 Offset: 0xAC5950 VA: 0x180AC6550
	public static Vector2 ZX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6590 Offset: 0xAC5990 VA: 0x180AC6590
	public static Vector2 ZY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAC7B0 Offset: 0x1BABBB0 VA: 0x181BAC7B0
	public static Vector3 XZ3D(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABFF0 Offset: 0x1BAB3F0 VA: 0x181BABFF0
	public static float Max(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABF10 Offset: 0x1BAB310 VA: 0x181BABF10
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABF90 Offset: 0x1BAB390 VA: 0x181BABF90
	public static float Max(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAB0A0 Offset: 0x1BAA4A0 VA: 0x181BAB0A0
	public static Vector4 Abs(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAB150 Offset: 0x1BAA550 VA: 0x181BAB150
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAB200 Offset: 0x1BAA600 VA: 0x181BAB200
	public static Vector2 Abs(Vector2 v) { }

	// RVA: 0x1BAC080 Offset: 0x1BAB480 VA: 0x181BAC080
	public static Vector3 Parse(string p) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BABA70 Offset: 0x1BAAE70 VA: 0x181BABA70
	public static Vector3 GetWithInaccuracy(Vector3 o, float maxAngle) { }

}

