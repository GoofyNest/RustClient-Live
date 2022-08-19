internal class DeflaterOutputStream : Stream // TypeDefIndex: 5664
{	// Fields
	protected byte[] buf; // 0x28
	protected Deflater def; // 0x30
	protected Stream baseOutputStream; // 0x38
	private bool isClosed; // 0x40
	private bool isStreamOwner; // 0x41
	private uint[] keys; // 0x48

	// Properties
	public bool IsStreamOwner { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40
	public bool get_IsStreamOwner() { }

	// RVA: 0x22FC470 Offset: 0x22FB870 VA: 0x1822FC470 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x22FC4A0 Offset: 0x22FB8A0 VA: 0x1822FC4A0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x22FC4D0 Offset: 0x22FB8D0 VA: 0x1822FC4D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFDB890 Offset: 0xFDAC90 VA: 0x180FDB890 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22FC500 Offset: 0x22FB900 VA: 0x1822FC500 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x22FBFD0 Offset: 0x22FB3D0 VA: 0x1822FBFD0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x22FC030 Offset: 0x22FB430 VA: 0x1822FC030 Slot: 26
	public override void SetLength(long val) { }

	// RVA: 0x22FBF10 Offset: 0x22FB310 VA: 0x1822FBF10 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x22FBF70 Offset: 0x22FB370 VA: 0x1822FBF70 Slot: 27
	public override int Read(byte[] b, int off, int len) { }

	// RVA: 0x22FB8C0 Offset: 0x22FACC0 VA: 0x1822FB8C0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22FB920 Offset: 0x22FAD20 VA: 0x1822FB920 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22FB9E0 Offset: 0x22FADE0 VA: 0x1822FB9E0
	protected void Deflate() { }

	// RVA: 0x22FC2E0 Offset: 0x22FB6E0 VA: 0x1822FC2E0
	public void .ctor(Stream baseOutputStream, Deflater deflater, int bufsize) { }

	// RVA: 0x22FBEC0 Offset: 0x22FB2C0 VA: 0x1822FBEC0 Slot: 18
	public override void Flush() { }

	// RVA: 0x22FBCC0 Offset: 0x22FB0C0 VA: 0x1822FBCC0 Slot: 31
	public virtual void Finish() { }

	// RVA: 0x22FB980 Offset: 0x22FAD80 VA: 0x1822FB980 Slot: 16
	public override void Close() { }

	// RVA: 0x22FC200 Offset: 0x22FB600 VA: 0x1822FC200 Slot: 30
	public override void WriteByte(byte bval) { }

	// RVA: 0x22FC2A0 Offset: 0x22FB6A0 VA: 0x1822FC2A0 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x22FBC70 Offset: 0x22FB070 VA: 0x1822FBC70
	protected byte EncryptByte() { }

	// RVA: 0x22FBBB0 Offset: 0x22FAFB0 VA: 0x1822FBBB0
	protected void EncryptBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x22FC090 Offset: 0x22FB490 VA: 0x1822FC090
	protected void UpdateKeys(byte ch) { }

}

