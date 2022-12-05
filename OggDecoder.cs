public class OggDecoder : IDisposable // TypeDefIndex: 10745
{
	private IntPtr _nativeDecoder;


	private static extern IntPtr OGG_CreateDecoder() { }

	private static extern void OGG_DestroyDecoder(IntPtr pDecoder) { }

	private static extern int OGG_DecodeFull(IntPtr pDecoder, byte* pOggData, int oggDataLength, out int channels, out int sampleRate, out float* pSamples) { }

	private static extern bool OGG_CleanupDecoder(IntPtr pDecoder) { }

	public void .ctor() { }

	protected override void Finalize() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public bool TryDecode(byte[] oggData, out int channels, out int sampleRate, out float[] samples) { }

}

