public sealed class ComputeShader : Object // TypeDefIndex: 3550
{
	[NativeMethodAttribute] // RVA: 0xC9C30 Offset: 0xC9030 VA: 0x1800C9C30
	[RequiredByNativeCodeAttribute] // RVA: 0xC9C30 Offset: 0xC9030 VA: 0x1800C9C30
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9DB0 Offset: 0xC91B0 VA: 0x1800C9DB0
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9E20 Offset: 0xC9220 VA: 0x1800C9E20
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xC9F10 Offset: 0xC9310 VA: 0x1800C9F10
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xC9F80 Offset: 0xC9380 VA: 0x1800C9F80
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA0A0 Offset: 0xC94A0 VA: 0x1800CA0A0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA200 Offset: 0xC9600 VA: 0x1800CA200
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA3F0 Offset: 0xC97F0 VA: 0x1800CA3F0
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA4F0 Offset: 0xC98F0 VA: 0x1800CA4F0
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public void SetFloat(string name, float val) { }

	public void SetVector(string name, Vector4 val) { }

	public void SetFloats(string name, float[] values) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

