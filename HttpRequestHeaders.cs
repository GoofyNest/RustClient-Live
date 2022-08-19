public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 5778
{	// Fields
	private Nullable<bool> expectContinue; // 0x20

	// Properties
	public HttpHeaderValueCollection<string> Connection { get; }
	public Nullable<bool> ConnectionClose { get; }
	internal bool ConnectionKeepAlive { get; }
	public Nullable<bool> ExpectContinue { get; }
	public string Host { get; }
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
	public Nullable<bool> TransferEncodingChunked { get; }

	// Methods

	// RVA: 0x108A1F0 Offset: 0x10895F0 VA: 0x18108A1F0
	internal void .ctor() { }

	// RVA: 0x108A530 Offset: 0x1089930 VA: 0x18108A530
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x108A250 Offset: 0x1089650 VA: 0x18108A250
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x108A3F0 Offset: 0x10897F0 VA: 0x18108A3F0
	internal bool get_ConnectionKeepAlive() { }

	// RVA: 0x108A570 Offset: 0x1089970 VA: 0x18108A570
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x108A6F0 Offset: 0x1089AF0 VA: 0x18108A6F0
	public string get_Host() { }

	// RVA: 0x108A8B0 Offset: 0x1089CB0 VA: 0x18108A8B0
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x108A730 Offset: 0x1089B30 VA: 0x18108A730
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x108A020 Offset: 0x1089420 VA: 0x18108A020
	internal void AddHeaders(HttpRequestHeaders headers) { }

}

private sealed class HttpRequestHeaders.<>c // TypeDefIndex: 5779
{	// Fields
	public static readonly HttpRequestHeaders.<>c <>9; // 0x0
	public static Predicate<string> <>9__19_0; // 0x8
	public static Predicate<string> <>9__22_0; // 0x10
	public static Predicate<TransferCodingHeaderValue> <>9__29_0; // 0x18
	public static Predicate<TransferCodingHeaderValue> <>9__71_0; // 0x20

	// Methods

	// RVA: 0x1095CD0 Offset: 0x10950D0 VA: 0x181095CD0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1095BB0 Offset: 0x1094FB0 VA: 0x181095BB0
	internal bool <get_ConnectionClose>b__19_0(string l) { }

	// RVA: 0x1095BF0 Offset: 0x1094FF0 VA: 0x181095BF0
	internal bool <get_ConnectionKeepAlive>b__22_0(string l) { }

	// RVA: 0x1095C30 Offset: 0x1095030 VA: 0x181095C30
	internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

	// RVA: 0x1095C80 Offset: 0x1095080 VA: 0x181095C80
	internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }

}

