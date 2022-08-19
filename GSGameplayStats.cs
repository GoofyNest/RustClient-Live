internal struct GSGameplayStats_t : ICallbackData // TypeDefIndex: 5495
{	// Fields
	internal Result Result; // 0x0
	internal int Rank; // 0x4
	internal uint TotalConnects; // 0x8
	internal uint TotalMinutesPlayed; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E74F0 Offset: 0x1E68F0 VA: 0x1801E74F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E74E0 Offset: 0x1E68E0 VA: 0x1801E74E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B550 Offset: 0x136A950 VA: 0x18136B550
	private static void .cctor() { }

}

