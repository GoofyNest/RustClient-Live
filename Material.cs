public class Material : Object // TypeDefIndex: 3406
{	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94CB0 Offset: 0x940B0 VA: 0x180094CB0
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }


	[FreeFunctionAttribute] // RVA: 0x937F0 Offset: 0x92BF0 VA: 0x1800937F0
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93950 Offset: 0x92D50 VA: 0x180093950
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93AC0 Offset: 0x92EC0 VA: 0x180093AC0
	private static void CreateWithString(Material self) { }

	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93D40 Offset: 0x93140 VA: 0x180093D40
	[ObsoleteAttribute] // RVA: 0x93D40 Offset: 0x93140 VA: 0x180093D40
	public void .ctor(string contents) { }

	public Shader get_shader() { }

	public void set_shader(Shader value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93E20 Offset: 0x93220 VA: 0x180093E20
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x93F30 Offset: 0x93330 VA: 0x180093F30
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x93FA0 Offset: 0x933A0 VA: 0x180093FA0
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94010 Offset: 0x93410 VA: 0x180094010
	public void set_renderQueue(int value) { }

	public void EnableKeyword(string keyword) { }

	public void DisableKeyword(string keyword) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool get_enableInstancing() { }

	public void set_enableInstancing(bool value) { }

	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x940D0 Offset: 0x934D0 VA: 0x1800940D0
	public bool GetShaderPassEnabled(string passName) { }

	public string GetPassName(int pass) { }

	public int FindPass(string passName) { }

	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x941C0 Offset: 0x935C0 VA: 0x1800941C0
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94230 Offset: 0x93630 VA: 0x180094230
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x94350 Offset: 0x93750 VA: 0x180094350
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x943E0 Offset: 0x937E0 VA: 0x1800943E0
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x944A0 Offset: 0x938A0 VA: 0x1800944A0
	private void SetShaderKeywords(string[] names) { }

	public string[] get_shaderKeywords() { }

	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E6C0 Offset: 0x8DAC0 VA: 0x18008E6C0
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E720 Offset: 0x8DB20 VA: 0x18008E720
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E7E0 Offset: 0x8DBE0 VA: 0x18008E7E0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8E8E0 Offset: 0x8DCE0 VA: 0x18008E8E0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x94890 Offset: 0x93C90 VA: 0x180094890
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94990 Offset: 0x93D90 VA: 0x180094990
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E550 Offset: 0x8D950 VA: 0x18008E550
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94A40 Offset: 0x93E40 VA: 0x180094A40
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94B70 Offset: 0x93F70 VA: 0x180094B70
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94C00 Offset: 0x94000 VA: 0x180094C00
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

