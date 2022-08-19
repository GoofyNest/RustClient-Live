public class OggDecoder : IDisposable // TypeDefIndex: 9013
{	// Fields
	private IntPtr _nativeDecoder; // 0x10

	// Methods

	// RVA: 0xA47BD0 Offset: 0xA46FD0 VA: 0x180A47BD0
	private static extern IntPtr OGG_CreateDecoder() { }

	// RVA: 0xA47D20 Offset: 0xA47120 VA: 0x180A47D20
	private static extern void OGG_DestroyDecoder(IntPtr pDecoder) { }

	// RVA: 0xA47C40 Offset: 0xA47040 VA: 0x180A47C40
	private static extern int OGG_DecodeFull(IntPtr pDecoder, byte* pOggData, int oggDataLength, out int channels, out int sampleRate, out float* pSamples) { }

	// RVA: 0xA47B50 Offset: 0xA46F50 VA: 0x180A47B50
	private static extern bool OGG_CleanupDecoder(IntPtr pDecoder) { }

	// RVA: 0xA480A0 Offset: 0xA474A0 VA: 0x180A480A0
	public void .ctor() { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xA479F0 Offset: 0xA46DF0 VA: 0x180A479F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xA47980 Offset: 0xA46D80 VA: 0x180A47980 Slot: 4
	public void Dispose() { }

	// RVA: 0xA47DA0 Offset: 0xA471A0 VA: 0x180A47DA0
	public bool TryDecode(byte[] oggData, out int channels, out int sampleRate, out float[] samples) { }

}

