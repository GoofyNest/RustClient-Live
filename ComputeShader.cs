public sealed class ComputeShader : Object // TypeDefIndex: 3550
{	// Methods

	[NativeMethodAttribute] // RVA: 0xC9C30 Offset: 0xC9030 VA: 0x1800C9C30
	[RequiredByNativeCodeAttribute] // RVA: 0xC9C30 Offset: 0xC9030 VA: 0x1800C9C30
	// RVA: 0x1821190 Offset: 0x1820590 VA: 0x181821190
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9DB0 Offset: 0xC91B0 VA: 0x1800C9DB0
	// RVA: 0x1821240 Offset: 0x1820640 VA: 0x181821240
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9E20 Offset: 0xC9220 VA: 0x1800C9E20
	// RVA: 0x1821410 Offset: 0x1820810 VA: 0x181821410
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xC9F10 Offset: 0xC9310 VA: 0x1800C9F10
	// RVA: 0x18215F0 Offset: 0x18209F0 VA: 0x1818215F0
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xC9F80 Offset: 0xC9380 VA: 0x1800C9F80
	// RVA: 0x1821360 Offset: 0x1820760 VA: 0x181821360
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA0A0 Offset: 0xC94A0 VA: 0x1800CA0A0
	// RVA: 0x1821540 Offset: 0x1820940 VA: 0x181821540
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA200 Offset: 0xC9600 VA: 0x1800CA200
	// RVA: 0x1821290 Offset: 0x1820690 VA: 0x181821290
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA3F0 Offset: 0xC97F0 VA: 0x1800CA3F0
	// RVA: 0x18211E0 Offset: 0x18205E0 VA: 0x1818211E0
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA4F0 Offset: 0xC98F0 VA: 0x1800CA4F0
	// RVA: 0x1821130 Offset: 0x1820530 VA: 0x181821130
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x18213B0 Offset: 0x18207B0 VA: 0x1818213B0
	public void SetFloat(string name, float val) { }

	// RVA: 0x1821640 Offset: 0x1820A40 VA: 0x181821640
	public void SetVector(string name, Vector4 val) { }

	// RVA: 0x1821460 Offset: 0x1820860 VA: 0x181821460
	public void SetFloats(string name, float[] values) { }

	// RVA: 0x18214C0 Offset: 0x18208C0 VA: 0x1818214C0
	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	// RVA: 0x18212F0 Offset: 0x18206F0 VA: 0x1818212F0
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x18215A0 Offset: 0x18209A0 VA: 0x1818215A0
	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

