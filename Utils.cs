internal static class Utils // TypeDefIndex: 1002
{
	private static RNGCryptoServiceProvider _rng; 

internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }


internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

internal static byte[] GenerateRandom(int keySize) { }

internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

internal static string DiscardWhiteSpaces(string inputBuffer) { }

internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

internal static int ConvertByteArrayToInt(byte[] input) { }

internal static byte[] ConvertIntToByteArray(int dwInput) { }

internal static byte[] FixupKeyParity(byte[] key) { }

internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

internal static bool _ProduceLegacyHmacValues() { }

}

public static class Utils // TypeDefIndex: 11549
{
	private static Utils.FloatPackingPrecision ms_FloatPackingPrecision; 
private const int kFloatPackingHighMinShaderLevel = 35;


public static string GetPath(Transform current) { }

public static T NewWithComponent<T>(string name) { }
/* GenericInstMethod :
|
|-Utils.NewWithComponent<object>
|-Utils.NewWithComponent<BeamGeometry>
*/

	[ExtensionAttribute] 
public static T GetOrAddComponent<T>(GameObject self) { }
/* GenericInstMethod :
|
|-Utils.GetOrAddComponent<object>
|-Utils.GetOrAddComponent<MeshCollider>
|-Utils.GetOrAddComponent<MeshFilter>
|-Utils.GetOrAddComponent<MeshRenderer>
*/

	[ExtensionAttribute] 
public static T GetOrAddComponent<T>(MonoBehaviour self) { }
/* GenericInstMethod :
|
|-Utils.GetOrAddComponent<object>
*/

	[ExtensionAttribute] 
public static bool HasFlag(Enum mask, Enum flags) { }

	[ExtensionAttribute] 
public static Vector2 xy(Vector3 aVector) { }

	[ExtensionAttribute] 
public static Vector2 xz(Vector3 aVector) { }

	[ExtensionAttribute] 
public static Vector2 yz(Vector3 aVector) { }

	[ExtensionAttribute] 
public static Vector2 yx(Vector3 aVector) { }

	[ExtensionAttribute] 
public static Vector2 zx(Vector3 aVector) { }

	[ExtensionAttribute] 
public static Vector2 zy(Vector3 aVector) { }

	[ExtensionAttribute] 
public static float GetVolumeCubic(Bounds self) { }

	[ExtensionAttribute] 
public static float GetMaxArea2D(Bounds self) { }

	[ExtensionAttribute] 
public static Color Opaque(Color self) { }

public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1) { }

	[ExtensionAttribute] 
public static Plane TranslateCustom(Plane plane, Vector3 translation) { }

	[ExtensionAttribute] 
public static bool IsValid(Plane plane) { }

	[ExtensionAttribute] 
public static Matrix4x4 SampleInMatrix(Gradient self, int floatPackingPrecision) { }

	[ExtensionAttribute] 
public static Color[] SampleInArray(Gradient self, int samplesCount) { }

private static Vector4 Vector4_Floor(Vector4 vec) { }

	[ExtensionAttribute] 
public static float PackToFloat(Color color, int floatPackingPrecision) { }

public static Utils.FloatPackingPrecision GetFloatPackingPrecision() { }

public static void MarkCurrentSceneDirty() { }

private static void .cctor() { }

}

public enum Utils.FloatPackingPrecision // TypeDefIndex: 11550
{
	public int value__; 
public const Utils.FloatPackingPrecision High = 64;
public const Utils.FloatPackingPrecision Low = 8;
public const Utils.FloatPackingPrecision Undef = 0;

}

