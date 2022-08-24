public class Material : Object // TypeDefIndex: 3406
{
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] 
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }


	[FreeFunctionAttribute] 
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] 
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] 
	private static void CreateWithString(Material self) { }

	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] 
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public void .ctor(string contents) { }

	public Shader get_shader() { }

	public void set_shader(Shader value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public Texture get_mainTexture() { }

	[NativeNameAttribute] 
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] 
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeNameAttribute] 
	public int get_renderQueue() { }

	[NativeNameAttribute] 
	public void set_renderQueue(int value) { }

	public void EnableKeyword(string keyword) { }

	public void DisableKeyword(string keyword) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool get_enableInstancing() { }

	public void set_enableInstancing(bool value) { }

	public int get_passCount() { }

	[FreeFunctionAttribute] 
	public bool GetShaderPassEnabled(string passName) { }

	public string GetPassName(int pass) { }

	public int FindPass(string passName) { }

	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] 
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] 
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] 
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] 
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] 
	private void SetShaderKeywords(string[] names) { }

	public string[] get_shaderKeywords() { }

	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] 
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] 
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] 
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] 
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] 
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] 
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] 
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] 
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] 
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] 
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] 
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private void SetFloatArray(int name, float[] values, int count) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetInt(string name, int value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetFloatArray(int nameID, float[] values) { }

	public float GetFloat(string name) { }

	public float GetFloat(int nameID) { }

	public Color GetColor(string name) { }

	public Color GetColor(int nameID) { }

	public Vector4 GetVector(string name) { }

	public Vector4 GetVector(int nameID) { }

	public Texture GetTexture(string name) { }

	public Texture GetTexture(int nameID) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	public void SetTextureScale(string name, Vector2 value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

