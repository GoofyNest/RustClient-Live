public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isEmpty { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8E550 Offset: 0x8D950 VA: 0x18008E550
	// RVA: 0x18E6990 Offset: 0x18E5D90 VA: 0x1818E6990
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	// RVA: 0x18E6C40 Offset: 0x18E6040 VA: 0x1818E6C40
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E660 Offset: 0x8DA60 VA: 0x18008E660
	// RVA: 0x18E6F00 Offset: 0x18E6300 VA: 0x1818E6F00
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E6C0 Offset: 0x8DAC0 VA: 0x18008E6C0
	// RVA: 0x18E6B40 Offset: 0x18E5F40 VA: 0x1818E6B40
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E720 Offset: 0x8DB20 VA: 0x18008E720
	// RVA: 0x18E6D40 Offset: 0x18E6140 VA: 0x1818E6D40
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E7E0 Offset: 0x8DBE0 VA: 0x18008E7E0
	// RVA: 0x18E6E00 Offset: 0x18E6200 VA: 0x1818E6E00
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8E8E0 Offset: 0x8DCE0 VA: 0x18008E8E0
	// RVA: 0x18E6A40 Offset: 0x18E5E40 VA: 0x1818E6A40
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8EB60 Offset: 0x8DF60 VA: 0x18008EB60
	// RVA: 0x18E69D0 Offset: 0x18E5DD0 VA: 0x1818E69D0
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8EB90 Offset: 0x8DF90 VA: 0x18008EB90
	// RVA: 0x18E6770 Offset: 0x18E5B70 VA: 0x1818E6770
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EC40 Offset: 0x8E040 VA: 0x18008EC40
	// RVA: 0x18E67A0 Offset: 0x18E5BA0 VA: 0x1818E67A0
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EDB0 Offset: 0x8E1B0 VA: 0x18008EDB0
	// RVA: 0x18E7040 Offset: 0x18E6440 VA: 0x1818E7040
	public bool get_isEmpty() { }

	// RVA: 0x18E6420 Offset: 0x18E5820 VA: 0x1818E6420
	private void Clear(bool keepMemory) { }

	// RVA: 0x18E63E0 Offset: 0x18E57E0 VA: 0x1818E63E0
	public void Clear() { }

	// RVA: 0x18E7000 Offset: 0x18E6400 VA: 0x1818E7000
	public void .ctor() { }

	// RVA: 0x18E6880 Offset: 0x18E5C80 VA: 0x1818E6880 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18E67E0 Offset: 0x18E5BE0 VA: 0x1818E67E0
	private void Dispose() { }

	// RVA: 0x18E6C90 Offset: 0x18E6090 VA: 0x1818E6C90
	public void SetFloat(string name, float value) { }

	// RVA: 0x18E6C40 Offset: 0x18E6040 VA: 0x1818E6C40
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18E6FA0 Offset: 0x18E63A0 VA: 0x1818E6FA0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18E6F50 Offset: 0x18E6350 VA: 0x1818E6F50
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18E6B90 Offset: 0x18E5F90 VA: 0x1818E6B90
	public void SetColor(string name, Color value) { }

	// RVA: 0x18E6BF0 Offset: 0x18E5FF0 VA: 0x1818E6BF0
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18E6D90 Offset: 0x18E6190 VA: 0x1818E6D90
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18E6A90 Offset: 0x18E5E90 VA: 0x1818E6A90
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18E6A40 Offset: 0x18E5E40 VA: 0x1818E6A40
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x18E6E50 Offset: 0x18E6250 VA: 0x1818E6E50
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18E6E00 Offset: 0x18E6200 VA: 0x1818E6E00
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18E6990 Offset: 0x18E5D90 VA: 0x1818E6990
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18E6630 Offset: 0x18E5A30 VA: 0x1818E6630
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	// RVA: 0x18E6470 Offset: 0x18E5870 VA: 0x1818E6470
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	// RVA: 0x18E6EB0 Offset: 0x18E62B0 VA: 0x1818E6EB0
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x18E6AF0 Offset: 0x18E5EF0 VA: 0x1818E6AF0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18E6CF0 Offset: 0x18E60F0 VA: 0x1818E6CF0
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

