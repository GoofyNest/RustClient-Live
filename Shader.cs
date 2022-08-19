public sealed class Shader : Object // TypeDefIndex: 3405
{	// Properties
	[NativePropertyAttribute] // RVA: 0x93560 Offset: 0x92960 VA: 0x180093560
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x911F0 Offset: 0x905F0 VA: 0x1800911F0
	// RVA: 0x19B0170 Offset: 0x19AF570 VA: 0x1819B0170
	public static Shader Find(string name) { }

	// RVA: 0x19B0E60 Offset: 0x19B0260 VA: 0x1819B0E60
	public static int get_globalMaximumLOD() { }

	// RVA: 0x19B0F10 Offset: 0x19B0310 VA: 0x1819B0F10
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x91290 Offset: 0x90690 VA: 0x180091290
	// RVA: 0x19B0E90 Offset: 0x19B0290 VA: 0x1819B0E90
	public bool get_isSupported() { }

	[FreeFunctionAttribute] // RVA: 0x91300 Offset: 0x90700 VA: 0x180091300
	// RVA: 0x19B0060 Offset: 0x19AF460 VA: 0x1819B0060
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91370 Offset: 0x90770 VA: 0x180091370
	// RVA: 0x19B0020 Offset: 0x19AF420 VA: 0x1819B0020
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x91470 Offset: 0x90870 VA: 0x180091470
	// RVA: 0x19B0540 Offset: 0x19AF940 VA: 0x1819B0540
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x915B0 Offset: 0x909B0 VA: 0x1800915B0
	// RVA: 0x19B0DC0 Offset: 0x19B01C0 VA: 0x1819B0DC0
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x916D0 Offset: 0x90AD0 VA: 0x1800916D0
	// RVA: 0x19B04B0 Offset: 0x19AF8B0 VA: 0x1819B04B0
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x91800 Offset: 0x90C00 VA: 0x180091800
	// RVA: 0x19B0580 Offset: 0x19AF980 VA: 0x1819B0580
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x91900 Offset: 0x90D00 VA: 0x180091900
	// RVA: 0x19B0ED0 Offset: 0x19B02D0 VA: 0x1819B0ED0
	public int get_passCount() { }

	// RVA: 0x19B00A0 Offset: 0x19AF4A0 VA: 0x1819B00A0
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x91A40 Offset: 0x90E40 VA: 0x180091A40
	// RVA: 0x19B04F0 Offset: 0x19AF8F0 VA: 0x1819B04F0
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x92DA0 Offset: 0x921A0 VA: 0x180092DA0
	// RVA: 0x19B06B0 Offset: 0x19AFAB0 VA: 0x1819B06B0
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x92EC0 Offset: 0x922C0 VA: 0x180092EC0
	// RVA: 0x19B0CC0 Offset: 0x19B00C0 VA: 0x1819B0CC0
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x92F20 Offset: 0x92320 VA: 0x180092F20
	// RVA: 0x19B0820 Offset: 0x19AFC20 VA: 0x1819B0820
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x92F80 Offset: 0x92380 VA: 0x180092F80
	// RVA: 0x19B0950 Offset: 0x19AFD50 VA: 0x1819B0950
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x93080 Offset: 0x92480 VA: 0x180093080
	// RVA: 0x19B01B0 Offset: 0x19AF5B0 VA: 0x1819B01B0
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x93210 Offset: 0x92610 VA: 0x180093210
	// RVA: 0x19B0A00 Offset: 0x19AFE00 VA: 0x1819B0A00
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x19B0B60 Offset: 0x19AFF60 VA: 0x1819B0B60
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x19B0700 Offset: 0x19AFB00 VA: 0x1819B0700
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19B06B0 Offset: 0x19AFAB0 VA: 0x1819B06B0
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x19B0770 Offset: 0x19AFB70 VA: 0x1819B0770
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x19B0D00 Offset: 0x19B0100 VA: 0x1819B0D00
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19B0D80 Offset: 0x19B0180 VA: 0x1819B0D80
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x19B0620 Offset: 0x19AFA20 VA: 0x1819B0620
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19B05C0 Offset: 0x19AF9C0 VA: 0x1819B05C0
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x19B0860 Offset: 0x19AFC60 VA: 0x1819B0860
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19B08F0 Offset: 0x19AFCF0 VA: 0x1819B08F0
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x19B0990 Offset: 0x19AFD90 VA: 0x1819B0990
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x19B0950 Offset: 0x19AFD50 VA: 0x1819B0950
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x19B0A50 Offset: 0x19AFE50 VA: 0x1819B0A50
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x19B01F0 Offset: 0x19AF5F0 VA: 0x1819B01F0
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x19B0E00 Offset: 0x19B0200 VA: 0x1819B0E00
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x932F0 Offset: 0x926F0 VA: 0x1800932F0
	// RVA: 0x19B0290 Offset: 0x19AF690 VA: 0x1819B0290
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x93430 Offset: 0x92830 VA: 0x180093430
	// RVA: 0x19B03A0 Offset: 0x19AF7A0 VA: 0x1819B03A0
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	// RVA: 0x19AFF80 Offset: 0x19AF380 VA: 0x1819AFF80
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x19B0250 Offset: 0x19AF650 VA: 0x1819B0250
	public int GetPropertyCount() { }

	// RVA: 0x19B02D0 Offset: 0x19AF6D0 VA: 0x1819B02D0
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x19B03E0 Offset: 0x19AF7E0 VA: 0x1819B03E0
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x19B0C80 Offset: 0x19B0080 VA: 0x1819B0C80
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x19B07E0 Offset: 0x19AFBE0 VA: 0x1819B07E0
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

