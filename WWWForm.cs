public class WWWForm // TypeDefIndex: 4125
{	// Fields
	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }

	// Methods

	// RVA: 0x229CF20 Offset: 0x229C320 VA: 0x18229CF20
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x229CDB0 Offset: 0x229C1B0 VA: 0x18229CDB0
	public void .ctor() { }

	// RVA: 0x229CC90 Offset: 0x229C090 VA: 0x18229CC90
	public void AddField(string fieldName, string value) { }

	// RVA: 0x229CB80 Offset: 0x229BF80 VA: 0x18229CB80
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x229DF90 Offset: 0x229D390 VA: 0x18229DF90
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x229CF30 Offset: 0x229C330 VA: 0x18229CF30
	public byte[] get_data() { }

}

