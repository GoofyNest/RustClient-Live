public class Reader // TypeDefIndex: 6649
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Reader <Active>k__BackingField; // 0x0
	private Stream stream; // 0x10
	private BinaryReader reader; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <CurrentTime>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Indexer <Index>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DemoHeader <Header>k__BackingField; // 0x38
	public Action<Indexer.Keyframe, HashSet<uint>> OnScrubToKeyframe; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <startPosition>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsPaused>k__BackingField; // 0x50

	// Properties
	public static Reader Active { get; set; }
	public string Name { get; set; }
	public long CurrentTime { get; set; }
	public Indexer Index { get; set; }
	public DemoHeader Header { get; set; }
	private long startPosition { get; set; }
	public bool IsFinished { get; }
	public bool IsPaused { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22C5D90 Offset: 0x22C5190 VA: 0x1822C5D90
	public static Reader get_Active() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22C5E30 Offset: 0x22C5230 VA: 0x1822C5E30
	internal static void set_Active(Reader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public long get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86650 Offset: 0xE85A50 VA: 0x180E86650
	private void set_CurrentTime(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public Indexer get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_Index(Indexer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public DemoHeader get_Header() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_Header(DemoHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	private long get_startPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEE12D0 Offset: 0xEE06D0 VA: 0x180EE12D0
	private void set_startPosition(long value) { }

	// RVA: 0x5F7B10 Offset: 0x5F6F10 VA: 0x1805F7B10
	public void Play() { }

	// RVA: 0x22C55C0 Offset: 0x22C49C0 VA: 0x1822C55C0
	public void Pause() { }

	// RVA: 0x22C5AC0 Offset: 0x22C4EC0 VA: 0x1822C5AC0
	public void .ctor(string name, Stream stream) { }

	// RVA: 0x22C59A0 Offset: 0x22C4DA0 VA: 0x1822C59A0
	public void SetActive() { }

	// RVA: 0x22C52E0 Offset: 0x22C46E0 VA: 0x1822C52E0
	public void JumpTo(long time) { }

	// RVA: 0x22C51E0 Offset: 0x22C45E0 VA: 0x1822C51E0
	public void CreateIndex() { }

	// RVA: 0x22C55E0 Offset: 0x22C49E0 VA: 0x1822C55E0
	private void ReadHeader() { }

	// RVA: 0x22C5DD0 Offset: 0x22C51D0 VA: 0x1822C5DD0
	public bool get_IsFinished() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	public bool get_IsPaused() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE63B70 Offset: 0xE62F70 VA: 0x180E63B70
	internal void set_IsPaused(bool value) { }

	// RVA: 0x22C5240 Offset: 0x22C4640 VA: 0x1822C5240
	public static Reader FromFile(string filename) { }

	// RVA: 0x22C59F0 Offset: 0x22C4DF0 VA: 0x1822C59F0
	public void Stop() { }

	// RVA: 0x22C55D0 Offset: 0x22C49D0 VA: 0x1822C55D0
	public void Progress(long timeAmountMs) { }

	// RVA: 0x22C5960 Offset: 0x22C4D60 VA: 0x1822C5960
	public void ResetToStart() { }

	// RVA: 0x22C5700 Offset: 0x22C4B00 VA: 0x1822C5700
	public Packet ReadPacket() { }

}

