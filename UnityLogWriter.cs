internal class UnityLogWriter : TextWriter // TypeDefIndex: 3459
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x217B760 Offset: 0x217AB60 VA: 0x18217B760
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x217B720 Offset: 0x217AB20 VA: 0x18217B720
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x217B680 Offset: 0x217AA80 VA: 0x18217B680
	public static void Init() { }

	// RVA: 0x217B8E0 Offset: 0x217ACE0 VA: 0x18217B8E0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x217B7A0 Offset: 0x217ABA0 VA: 0x18217B7A0 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x217B840 Offset: 0x217AC40 VA: 0x18217B840 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x217B7F0 Offset: 0x217ABF0 VA: 0x18217B7F0 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x217B880 Offset: 0x217AC80 VA: 0x18217B880
	public void .ctor() { }

}

