public class StreamContent : HttpContent // TypeDefIndex: 5756
{	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50


	public void .ctor(Stream content) { }

	public void .ctor(Stream content, int bufferSize) { }

	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	protected override Task<Stream> CreateContentReadStreamAsync() { }

	protected override void Dispose(bool disposing) { }

	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected internal override bool TryComputeLength(out long length) { }

}

