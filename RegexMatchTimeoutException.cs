public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 2624
{	// Fields
	private string regexInput; // 0x88
	private string regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0x16A9ED0 Offset: 0x16A92D0 VA: 0x1816A9ED0
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x16A9CC0 Offset: 0x16A90C0 VA: 0x1816A9CC0
	public void .ctor() { }

	// RVA: 0x16A9DB0 Offset: 0x16A91B0 VA: 0x1816A9DB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16A9C00 Offset: 0x16A9000 VA: 0x1816A9C00 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x16A9B10 Offset: 0x16A8F10 VA: 0x1816A9B10
	private void Init() { }

	// RVA: 0x16A9BB0 Offset: 0x16A8FB0 VA: 0x1816A9BB0
	private void Init(string input, string pattern, TimeSpan timeout) { }

}

