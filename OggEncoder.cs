public class OggEncoder : IDisposable // TypeDefIndex: 10741
{
	private IntPtr _nativeEncoder; 


	private static extern IntPtr OGG_CreateEncoder(int sampleRate) { }

	private static extern void OGG_DestroyEncoder(IntPtr pEncoder) { }

	private static extern bool OGG_Encode(IntPtr pEncoder, float* pSamples, int sampleCount) { }

	private static extern bool OGG_FinishEncode(IntPtr pEncoder) { }

	private static extern int OGG_GetEncodedData(IntPtr pEncoder, out byte* pData) { }

	public void .ctor() { }

	protected override void Finalize() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public bool Encode(float[] samples) { }

	public bool Finish() { }

	public byte[] GetData() { }

}

