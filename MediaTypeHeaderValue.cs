public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 5784
{	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x108D2F0 Offset: 0x108C6F0 VA: 0x18108D2F0
	public void .ctor(string mediaType) { }

	// RVA: 0x108D060 Offset: 0x108C460 VA: 0x18108D060
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x108D430 Offset: 0x108C830 VA: 0x18108D430
	public string get_CharSet() { }

	// RVA: 0x108D5B0 Offset: 0x108C9B0 VA: 0x18108D5B0
	public void set_CharSet(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_MediaType() { }

	// RVA: 0x108D770 Offset: 0x108CB70 VA: 0x18108D770
	public void set_MediaType(string value) { }

	// RVA: 0x108D540 Offset: 0x108C940 VA: 0x18108D540
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x108CBC0 Offset: 0x108BFC0 VA: 0x18108CBC0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x108CA80 Offset: 0x108BE80 VA: 0x18108CA80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x108CB40 Offset: 0x108BF40 VA: 0x18108CB40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x108CC20 Offset: 0x108C020 VA: 0x18108CC20 Slot: 3
	public override string ToString() { }

	// RVA: 0x108CEC0 Offset: 0x108C2C0 VA: 0x18108CEC0
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x108CC80 Offset: 0x108C080 VA: 0x18108CC80
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 5785
{	// Fields
	public static readonly MediaTypeHeaderValue.<>c <>9; // 0x0
	public static Predicate<NameValueHeaderValue> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x1095D30 Offset: 0x1095130 VA: 0x181095D30
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1095B60 Offset: 0x1094F60 VA: 0x181095B60
	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

}

