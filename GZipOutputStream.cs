internal class GZipOutputStream : DeflaterOutputStream // TypeDefIndex: 5655
{	protected Crc32 crc; // 0x50


	public void .ctor(Stream baseOutputStream) { }

	public void .ctor(Stream baseOutputStream, int size) { }

	private void WriteHeader() { }

	public override void Write(byte[] buf, int off, int len) { }

	public override void Close() { }

	public override void Finish() { }

}

