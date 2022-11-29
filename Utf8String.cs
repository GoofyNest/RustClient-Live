public sealed class Utf8String // TypeDefIndex: 8277
{
	public static Utf8String EmptyString; 
	[CompilerGeneratedAttribute] 
	private int <Length>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private byte[] <Bytes>k__BackingField; 

	public int Length { get; set; }
	public byte[] Bytes { get; set; }
	private string Utf16 { get; set; }
	public byte Item { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_Length() { }

	[CompilerGeneratedAttribute] 
	private void set_Length(int value) { }

	[CompilerGeneratedAttribute] 
	public byte[] get_Bytes() { }

	[CompilerGeneratedAttribute] 
	private void set_Bytes(byte[] value) { }

	private string get_Utf16() { }

	private void set_Utf16(string value) { }

	public void .ctor() { }

	public void .ctor(byte[] bytes) { }

	public void .ctor(string value) { }

	public byte get_Item(int index) { }

	public void set_Item(int index, byte value) { }

	public static Utf8String op_Explicit(byte[] bytes) { }

	public static byte[] op_Explicit(Utf8String u8str) { }

	public static Utf8String op_Implicit(string str) { }

	public static string op_Implicit(Utf8String u8str) { }

	public static Utf8String op_Addition(Utf8String left, Utf8String right) { }

	public static bool op_Equality(Utf8String left, Utf8String right) { }

	public static bool op_Inequality(Utf8String left, Utf8String right) { }

	public override bool Equals(object obj) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

