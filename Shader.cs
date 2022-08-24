public sealed class Shader : Object // TypeDefIndex: 3405
{
	[NativePropertyAttribute] 
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public int passCount { get; }


	[FreeFunctionAttribute] 
	public static Shader Find(string name) { }

	public static int get_globalMaximumLOD() { }

	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] 
	public bool get_isSupported() { }

	[FreeFunctionAttribute] 
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] 
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] 
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] 
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] 
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] 
	public static int PropertyToID(string name) { }

	[FreeFunctionAttribute] 
	public int get_passCount() { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] 
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] 
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] 
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] 
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] 
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] 
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] 
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

	[FreeFunctionAttribute] 
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] 
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	public int GetPropertyCount() { }

	public string GetPropertyName(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

