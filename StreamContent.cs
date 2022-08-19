public class StreamContent : HttpContent // TypeDefIndex: 5756
{	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x23168A0 Offset: 0x2315CA0 VA: 0x1823168A0
	public void .ctor(Stream content) { }

	// RVA: 0x2316960 Offset: 0x2315D60 VA: 0x182316960
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x23167C0 Offset: 0x2315BC0 VA: 0x1823167C0
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x23165B0 Offset: 0x23159B0 VA: 0x1823165B0 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x2316610 Offset: 0x2315A10 VA: 0x182316610 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2316660 Offset: 0x2315A60 VA: 0x182316660 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x2316740 Offset: 0x2315B40 VA: 0x182316740 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

