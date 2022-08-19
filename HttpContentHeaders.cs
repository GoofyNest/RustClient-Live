public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 5772
{	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x1085620 Offset: 0x1084A20 VA: 0x181085620
	internal void .ctor(HttpContent content) { }

	// RVA: 0x10856A0 Offset: 0x1084AA0 VA: 0x1810856A0
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x1085840 Offset: 0x1084C40 VA: 0x181085840
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x1085880 Offset: 0x1084C80 VA: 0x181085880
	public void set_ContentType(MediaTypeHeaderValue value) { }

}

