public sealed class ComputeShader : Object // TypeDefIndex: 3553
{

	[RequiredByNativeCodeAttribute]
	[NativeMethodAttribute]
	public int FindKernel(string name) { }

	[FreeFunctionAttribute]
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute]
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute]
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute]
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute]
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute]
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute]
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public void SetFloat(string name, float val) { }

	public void SetVector(string name, Vector4 val) { }

	public void SetFloats(string name, float[] values) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

