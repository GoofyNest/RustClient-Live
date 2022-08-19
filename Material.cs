public class Material : Object // TypeDefIndex: 3406
{	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94CB0 Offset: 0x940B0 VA: 0x180094CB0
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x937F0 Offset: 0x92BF0 VA: 0x1800937F0
	// RVA: 0x18E7120 Offset: 0x18E6520 VA: 0x1818E7120
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93950 Offset: 0x92D50 VA: 0x180093950
	// RVA: 0x18E70D0 Offset: 0x18E64D0 VA: 0x1818E70D0
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93AC0 Offset: 0x92EC0 VA: 0x180093AC0
	// RVA: 0x18E7170 Offset: 0x18E6570 VA: 0x1818E7170
	private static void CreateWithString(Material self) { }

	// RVA: 0x18E86D0 Offset: 0x18E7AD0 VA: 0x1818E86D0
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18E85C0 Offset: 0x18E79C0 VA: 0x1818E85C0
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93D40 Offset: 0x93140 VA: 0x180093D40
	[ObsoleteAttribute] // RVA: 0x93D40 Offset: 0x93140 VA: 0x180093D40
	// RVA: 0x18E8650 Offset: 0x18E7A50 VA: 0x1818E8650
	public void .ctor(string contents) { }

	// RVA: 0x18E8990 Offset: 0x18E7D90 VA: 0x1818E8990
	public Shader get_shader() { }

	// RVA: 0x18E8B20 Offset: 0x18E7F20 VA: 0x1818E8B20
	public void set_shader(Shader value) { }

	// RVA: 0x18E8760 Offset: 0x18E7B60 VA: 0x1818E8760
	public Color get_color() { }

	// RVA: 0x18E89D0 Offset: 0x18E7DD0 VA: 0x1818E89D0
	public void set_color(Color value) { }

	// RVA: 0x18E8870 Offset: 0x18E7C70 VA: 0x1818E8870
	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93E20 Offset: 0x93220 VA: 0x180093E20
	// RVA: 0x18E7440 Offset: 0x18E6840 VA: 0x1818E7440
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x93F30 Offset: 0x93330 VA: 0x180093F30
	// RVA: 0x18E7950 Offset: 0x18E6D50 VA: 0x1818E7950
	public bool HasProperty(int nameID) { }

	// RVA: 0x18E7900 Offset: 0x18E6D00 VA: 0x1818E7900
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x93FA0 Offset: 0x933A0 VA: 0x180093FA0
	// RVA: 0x18E8950 Offset: 0x18E7D50 VA: 0x1818E8950
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94010 Offset: 0x93410 VA: 0x180094010
	// RVA: 0x18E8AE0 Offset: 0x18E7EE0 VA: 0x1818E8AE0
	public void set_renderQueue(int value) { }

	// RVA: 0x18E7200 Offset: 0x18E6600 VA: 0x1818E7200
	public void EnableKeyword(string keyword) { }

	// RVA: 0x18E71B0 Offset: 0x18E65B0 VA: 0x1818E71B0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x18E7990 Offset: 0x18E6D90 VA: 0x1818E7990
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x18E8830 Offset: 0x18E7C30 VA: 0x1818E8830
	public bool get_enableInstancing() { }

	// RVA: 0x18E8A90 Offset: 0x18E7E90 VA: 0x1818E8A90
	public void set_enableInstancing(bool value) { }

	// RVA: 0x18E8910 Offset: 0x18E7D10 VA: 0x1818E8910
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x940D0 Offset: 0x934D0 VA: 0x1800940D0
	// RVA: 0x18E7590 Offset: 0x18E6990 VA: 0x1818E7590
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x18E7510 Offset: 0x18E6910 VA: 0x1818E7510
	public string GetPassName(int pass) { }

	// RVA: 0x18E7250 Offset: 0x18E6650 VA: 0x1818E7250
	public int FindPass(string passName) { }

	// RVA: 0x18E8120 Offset: 0x18E7520 VA: 0x1818E8120
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x941C0 Offset: 0x935C0 VA: 0x1800941C0
	// RVA: 0x18E75E0 Offset: 0x18E69E0 VA: 0x1818E75E0
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x18E76E0 Offset: 0x18E6AE0 VA: 0x1818E76E0
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x18E7650 Offset: 0x18E6A50 VA: 0x1818E7650
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94230 Offset: 0x93630 VA: 0x180094230
	// RVA: 0x18E8180 Offset: 0x18E7580 VA: 0x1818E8180
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x94350 Offset: 0x93750 VA: 0x180094350
	// RVA: 0x18E7080 Offset: 0x18E6480 VA: 0x1818E7080
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x943E0 Offset: 0x937E0 VA: 0x1800943E0
	// RVA: 0x18E7550 Offset: 0x18E6950 VA: 0x1818E7550
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x944A0 Offset: 0x938A0 VA: 0x1800944A0
	// RVA: 0x18E81C0 Offset: 0x18E75C0 VA: 0x1818E81C0
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x18E7550 Offset: 0x18E6950 VA: 0x1818E7550
	public string[] get_shaderKeywords() { }

	// RVA: 0x18E81C0 Offset: 0x18E75C0 VA: 0x1818E81C0
	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	// RVA: 0x18E7E70 Offset: 0x18E7270 VA: 0x1818E7E70
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E6C0 Offset: 0x8DAC0 VA: 0x18008E6C0
	// RVA: 0x18E7AE0 Offset: 0x18E6EE0 VA: 0x1818E7AE0
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E720 Offset: 0x8DB20 VA: 0x18008E720
	// RVA: 0x18E7FE0 Offset: 0x18E73E0 VA: 0x1818E7FE0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E7E0 Offset: 0x8DBE0 VA: 0x18008E7E0
	// RVA: 0x18E8210 Offset: 0x18E7610 VA: 0x1818E8210
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8E8E0 Offset: 0x8DCE0 VA: 0x18008E8E0
	// RVA: 0x18E79E0 Offset: 0x18E6DE0 VA: 0x1818E79E0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x94890 Offset: 0x93C90 VA: 0x180094890
	// RVA: 0x18E7480 Offset: 0x18E6880 VA: 0x1818E7480
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94990 Offset: 0x93D90 VA: 0x180094990
	// RVA: 0x18E72F0 Offset: 0x18E66F0 VA: 0x1818E72F0
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E550 Offset: 0x8D950 VA: 0x18008E550
	// RVA: 0x18E7750 Offset: 0x18E6B50 VA: 0x1818E7750
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94A40 Offset: 0x93E40 VA: 0x180094A40
	// RVA: 0x18E7BE0 Offset: 0x18E6FE0 VA: 0x1818E7BE0
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94B70 Offset: 0x93F70 VA: 0x180094B70
	// RVA: 0x18E82B0 Offset: 0x18E76B0 VA: 0x1818E82B0
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94C00 Offset: 0x94000 VA: 0x180094C00
	// RVA: 0x18E83B0 Offset: 0x18E77B0 VA: 0x1818E83B0
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x18E7D40 Offset: 0x18E7140 VA: 0x1818E7D40
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x18E7EC0 Offset: 0x18E72C0 VA: 0x1818E7EC0
	public void SetFloat(string name, float value) { }

	// RVA: 0x18E7E70 Offset: 0x18E7270 VA: 0x1818E7E70
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18E7F20 Offset: 0x18E7320 VA: 0x1818E7F20
	public void SetInt(string name, int value) { }

	// RVA: 0x18E7B80 Offset: 0x18E6F80 VA: 0x1818E7B80
	public void SetColor(string name, Color value) { }

	// RVA: 0x18E7B30 Offset: 0x18E6F30 VA: 0x1818E7B30
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18E84C0 Offset: 0x18E78C0 VA: 0x1818E84C0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18E8550 Offset: 0x18E7950 VA: 0x1818E8550
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18E80A0 Offset: 0x18E74A0 VA: 0x1818E80A0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x18E8030 Offset: 0x18E7430 VA: 0x1818E8030
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18E8460 Offset: 0x18E7860 VA: 0x1818E8460
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18E8210 Offset: 0x18E7610 VA: 0x1818E8210
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18E7A30 Offset: 0x18E6E30 VA: 0x1818E7A30
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18E7C40 Offset: 0x18E7040 VA: 0x1818E7C40
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x18E74C0 Offset: 0x18E68C0 VA: 0x1818E74C0
	public float GetFloat(string name) { }

	// RVA: 0x18E7480 Offset: 0x18E6880 VA: 0x1818E7480
	public float GetFloat(int nameID) { }

	// RVA: 0x18E73C0 Offset: 0x18E67C0 VA: 0x1818E73C0
	public Color GetColor(string name) { }

	// RVA: 0x18E7350 Offset: 0x18E6750 VA: 0x1818E7350
	public Color GetColor(int nameID) { }

	// RVA: 0x18E77E0 Offset: 0x18E6BE0 VA: 0x1818E77E0
	public Vector4 GetVector(string name) { }

	// RVA: 0x18E7870 Offset: 0x18E6C70 VA: 0x1818E7870
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x18E7790 Offset: 0x18E6B90 VA: 0x1818E7790
	public Texture GetTexture(string name) { }

	// RVA: 0x18E7750 Offset: 0x18E6B50 VA: 0x1818E7750
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18E8300 Offset: 0x18E7700 VA: 0x1818E8300
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x18E8400 Offset: 0x18E7800 VA: 0x1818E8400
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x18E7A90 Offset: 0x18E6E90 VA: 0x1818E7A90
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18E7F90 Offset: 0x18E7390 VA: 0x1818E7F90
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x18E72A0 Offset: 0x18E66A0 VA: 0x1818E72A0
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x18E8260 Offset: 0x18E7660 VA: 0x1818E8260
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x18E8360 Offset: 0x18E7760 VA: 0x1818E8360
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

