public sealed class MaterialPropertyBlock // TypeDefIndex: 3403
{
	internal IntPtr m_Ptr; 

	public bool isEmpty { get; }


	[NativeNameAttribute] 
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] 
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] 
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] 
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] 
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] 
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] 
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] 
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] 
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] 
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] 
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

