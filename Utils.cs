internal static class Utils // TypeDefIndex: 1002
{	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x13100

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x17C4940 Offset: 0x17C3D40 VA: 0x1817C4940
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x17C45D0 Offset: 0x17C39D0 VA: 0x1817C45D0
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x17C4380 Offset: 0x17C3780 VA: 0x1817C4380
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x17C4200 Offset: 0x17C3600 VA: 0x1817C4200
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17C3CE0 Offset: 0x17C30E0 VA: 0x1817C3CE0
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x17C3D40 Offset: 0x17C3140 VA: 0x1817C3D40
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x17C44E0 Offset: 0x17C38E0 VA: 0x1817C44E0
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x17C3EE0 Offset: 0x17C32E0 VA: 0x1817C3EE0
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C40A0 Offset: 0x17C34A0 VA: 0x1817C40A0
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C3E80 Offset: 0x17C3280 VA: 0x1817C3E80
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x17C3F40 Offset: 0x17C3340 VA: 0x1817C3F40
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x17C4640 Offset: 0x17C3A40 VA: 0x1817C4640
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x17C46D0 Offset: 0x17C3AD0 VA: 0x1817C46D0
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal static bool _ProduceLegacyHmacValues() { }

}

public static class Utils // TypeDefIndex: 11549
{	// Fields
	private static Utils.FloatPackingPrecision ms_FloatPackingPrecision; // 0x1F312
	private const int kFloatPackingHighMinShaderLevel = 35;

	// Methods

	// RVA: 0xAC56B0 Offset: 0xAC4AB0 VA: 0x180AC56B0
	public static string GetPath(Transform current) { }

	// RVA: -1 Offset: -1
	public static T NewWithComponent<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C13E0 Offset: 0x14C07E0 VA: 0x1814C13E0
	|-Utils.NewWithComponent<object>
	|-Utils.NewWithComponent<BeamGeometry>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C12B0 Offset: 0x14C06B0 VA: 0x1814C12B0
	|-Utils.GetOrAddComponent<object>
	|-Utils.GetOrAddComponent<MeshCollider>
	|-Utils.GetOrAddComponent<MeshFilter>
	|-Utils.GetOrAddComponent<MeshRenderer>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(MonoBehaviour self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1360 Offset: 0x14C0760 VA: 0x1814C1360
	|-Utils.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC5D10 Offset: 0xAC5110 VA: 0x180AC5D10
	public static bool HasFlag(Enum mask, Enum flags) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6470 Offset: 0xAC5870 VA: 0x180AC6470
	public static Vector2 xy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC64A0 Offset: 0xAC58A0 VA: 0x180AC64A0
	public static Vector2 xz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6510 Offset: 0xAC5910 VA: 0x180AC6510
	public static Vector2 yz(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC64E0 Offset: 0xAC58E0 VA: 0x180AC64E0
	public static Vector2 yx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6550 Offset: 0xAC5950 VA: 0x180AC6550
	public static Vector2 zx(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6590 Offset: 0xAC5990 VA: 0x180AC6590
	public static Vector2 zy(Vector3 aVector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC57B0 Offset: 0xAC4BB0 VA: 0x180AC57B0
	public static float GetVolumeCubic(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC5580 Offset: 0xAC4980 VA: 0x180AC5580
	public static float GetMaxArea2D(Bounds self) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC5E30 Offset: 0xAC5230 VA: 0x180AC5E30
	public static Color Opaque(Color self) { }

	// RVA: 0xAC5830 Offset: 0xAC4C30 VA: 0x180AC5830
	public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6260 Offset: 0xAC5660 VA: 0x180AC6260
	public static Plane TranslateCustom(Plane plane, Vector3 translation) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC5DF0 Offset: 0xAC51F0 VA: 0x180AC5DF0
	public static bool IsValid(Plane plane) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6130 Offset: 0xAC5530 VA: 0x180AC6130
	public static Matrix4x4 SampleInMatrix(Gradient self, int floatPackingPrecision) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC6030 Offset: 0xAC5430 VA: 0x180AC6030
	public static Color[] SampleInArray(Gradient self, int samplesCount) { }

	// RVA: 0xAC6390 Offset: 0xAC5790 VA: 0x180AC6390
	private static Vector4 Vector4_Floor(Vector4 vec) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC5E80 Offset: 0xAC5280 VA: 0x180AC5E80
	public static float PackToFloat(Color color, int floatPackingPrecision) { }

	// RVA: 0xAC5490 Offset: 0xAC4890 VA: 0x180AC5490
	public static Utils.FloatPackingPrecision GetFloatPackingPrecision() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void MarkCurrentSceneDirty() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public enum Utils.FloatPackingPrecision // TypeDefIndex: 11550
{	// Fields
	public int value__; // 0x0
	public const Utils.FloatPackingPrecision High = 64;
	public const Utils.FloatPackingPrecision Low = 8;
	public const Utils.FloatPackingPrecision Undef = 0;

}

