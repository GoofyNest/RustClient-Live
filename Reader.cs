public class Reader // TypeDefIndex: 6661
{
	[CompilerGeneratedAttribute]
	private static Reader <Active>k__BackingField;
	private Stream stream;
	private BinaryReader reader;
	[CompilerGeneratedAttribute]
	private string <Name>k__BackingField;
	[CompilerGeneratedAttribute]
	private long <CurrentTime>k__BackingField;
	[CompilerGeneratedAttribute]
	private Indexer <Index>k__BackingField;
	[CompilerGeneratedAttribute]
	private DemoHeader <Header>k__BackingField;
	public Action<Indexer.Keyframe, HashSet<uint>> OnScrubToKeyframe;
	[CompilerGeneratedAttribute]
	private long <startPosition>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IsPaused>k__BackingField;

	public static Reader Active { get; set; }
	public string Name { get; set; }
	public long CurrentTime { get; set; }
	public Indexer Index { get; set; }
	public DemoHeader Header { get; set; }
	private long startPosition { get; set; }
	public bool IsFinished { get; }
	public bool IsPaused { get; set; }


	[CompilerGeneratedAttribute]
	public static Reader get_Active() { }

	[CompilerGeneratedAttribute]
	internal static void set_Active(Reader value) { }

	[CompilerGeneratedAttribute]
	public string get_Name() { }

	[CompilerGeneratedAttribute]
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute]
	public long get_CurrentTime() { }

	[CompilerGeneratedAttribute]
	private void set_CurrentTime(long value) { }

	[CompilerGeneratedAttribute]
	public Indexer get_Index() { }

	[CompilerGeneratedAttribute]
	private void set_Index(Indexer value) { }

	[CompilerGeneratedAttribute]
	public DemoHeader get_Header() { }

	[CompilerGeneratedAttribute]
	private void set_Header(DemoHeader value) { }

	[CompilerGeneratedAttribute]
	private long get_startPosition() { }

	[CompilerGeneratedAttribute]
	private void set_startPosition(long value) { }

	public void Play() { }

	public void Pause() { }

	public void .ctor(string name, Stream stream) { }

	public void SetActive() { }

	public void JumpTo(long time) { }

	public void CreateIndex() { }

	private void ReadHeader() { }

	public bool get_IsFinished() { }

	[CompilerGeneratedAttribute]
	public bool get_IsPaused() { }

	[CompilerGeneratedAttribute]
	internal void set_IsPaused(bool value) { }

	public static Reader FromFile(string filename) { }

	public void Stop() { }

	public void Progress(long timeAmountMs) { }

	public void ResetToStart() { }

	public Packet ReadPacket() { }

}

