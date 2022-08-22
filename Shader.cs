public sealed class Shader : Object // TypeDefIndex: 3405
{	[NativePropertyAttribute] // RVA: 0x93560 Offset: 0x92960 VA: 0x180093560
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }


	[FreeFunctionAttribute] // RVA: 0x911F0 Offset: 0x905F0 VA: 0x1800911F0
	public static Shader Find(string name) { }

	public static int get_globalMaximumLOD() { }

	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x91290 Offset: 0x90690 VA: 0x180091290
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91300 Offset: 0x90700 VA: 0x180091300
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91370 Offset: 0x90770 VA: 0x180091370
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91470 Offset: 0x90870 VA: 0x180091470
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x915B0 Offset: 0x909B0 VA: 0x1800915B0
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x916D0 Offset: 0x90AD0 VA: 0x1800916D0
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91800 Offset: 0x90C00 VA: 0x180091800
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x91900 Offset: 0x90D00 VA: 0x180091900
	public int get_passCount() { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91A40 Offset: 0x90E40 VA: 0x180091A40
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92DA0 Offset: 0x921A0 VA: 0x180092DA0
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x92EC0 Offset: 0x922C0 VA: 0x180092EC0
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x92F20 Offset: 0x92320 VA: 0x180092F20
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x92F80 Offset: 0x92380 VA: 0x180092F80
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93080 Offset: 0x92480 VA: 0x180093080
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x93210 Offset: 0x92610 VA: 0x180093210
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	public static void SetGlobalFloat(string name, float value) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	public static void SetGlobalInt(string name, int value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	public static void SetGlobalVector(int nameID, Vector4 value) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	public static float GetGlobalFloat(string name) { }

	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x932F0 Offset: 0x926F0 VA: 0x1800932F0
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x93430 Offset: 0x92830 VA: 0x180093430
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	public int GetPropertyCount() { }

	public string GetPropertyName(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

