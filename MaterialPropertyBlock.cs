public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	internal IntPtr m_Ptr; // 0x10

	public bool isEmpty { get; }


	[NativeNameAttribute] // RVA: 0x8E550 Offset: 0x8D950 VA: 0x18008E550
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E660 Offset: 0x8DA60 VA: 0x18008E660
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E6C0 Offset: 0x8DAC0 VA: 0x18008E6C0
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E720 Offset: 0x8DB20 VA: 0x18008E720
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E7E0 Offset: 0x8DBE0 VA: 0x18008E7E0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8E8E0 Offset: 0x8DCE0 VA: 0x18008E8E0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8EB60 Offset: 0x8DF60 VA: 0x18008EB60
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8EB90 Offset: 0x8DF90 VA: 0x18008EB90
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EC40 Offset: 0x8E040 VA: 0x18008EC40
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EDB0 Offset: 0x8E1B0 VA: 0x18008EDB0
	public bool get_isEmpty() { }

	private void Clear(bool keepMemory) { }

	public void Clear() { }

	public void .ctor() { }

	protected override void Finalize() { }

	private void Dispose() { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	public Texture GetTexture(int nameID) { }

	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

