public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 5752
{	// Fields
	private static readonly HttpMethod delete_method; // 0x0
	private static readonly HttpMethod get_method; // 0x8
	private static readonly HttpMethod head_method; // 0x10
	private static readonly HttpMethod options_method; // 0x18
	private static readonly HttpMethod post_method; // 0x20
	private static readonly HttpMethod put_method; // 0x28
	private static readonly HttpMethod trace_method; // 0x30
	private readonly string method; // 0x10

	// Properties
	public static HttpMethod Get { get; }
	public string Method { get; }
	public static HttpMethod Post { get; }

	// Methods

	// RVA: 0x1089D40 Offset: 0x1089140 VA: 0x181089D40
	public void .ctor(string method) { }

	// RVA: 0x1089DE0 Offset: 0x10891E0 VA: 0x181089DE0
	public static HttpMethod get_Get() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Method() { }

	// RVA: 0x1089E40 Offset: 0x1089240 VA: 0x181089E40
	public static HttpMethod get_Post() { }

	// RVA: 0x1089EA0 Offset: 0x10892A0 VA: 0x181089EA0
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x1089A90 Offset: 0x1088E90 VA: 0x181089A90 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x1089AC0 Offset: 0x1088EC0 VA: 0x181089AC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 3
	public override string ToString() { }

	// RVA: 0x1089B60 Offset: 0x1088F60 VA: 0x181089B60
	private static void .cctor() { }

}

