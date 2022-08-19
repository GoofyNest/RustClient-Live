public sealed class VideoPlayer : Behaviour // TypeDefIndex: 4783
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private VideoPlayer.EventHandler started; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Properties
	[NativeNameAttribute] // RVA: 0xCDD10 Offset: 0xCD110 VA: 0x1800CDD10
	public string url { set; }
	[NativeHeaderAttribute] // RVA: 0xCDF30 Offset: 0xCD330 VA: 0x1800CDF30
	public Texture texture { get; }
	public bool isPrepared { get; }
	[NativeNameAttribute] // RVA: 0xCDFA0 Offset: 0xCD3A0 VA: 0x1800CDFA0
	public long frame { get; }
	public uint width { get; }
	public uint height { get; }

	// Methods

	// RVA: 0x2317BF0 Offset: 0x2316FF0 VA: 0x182317BF0
	public void set_url(string value) { }

	// RVA: 0x2317AD0 Offset: 0x2316ED0 VA: 0x182317AD0
	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0xCD2D0 Offset: 0xCC6D0 VA: 0x1800CD2D0
	// RVA: 0x2317A90 Offset: 0x2316E90 VA: 0x182317A90
	public bool get_isPrepared() { }

	// RVA: 0x23178F0 Offset: 0x2316CF0 VA: 0x1823178F0
	public void Play() { }

	// RVA: 0x2317930 Offset: 0x2316D30 VA: 0x182317930
	public void Stop() { }

	// RVA: 0x2317A10 Offset: 0x2316E10 VA: 0x182317A10
	public long get_frame() { }

	// RVA: 0x2317B10 Offset: 0x2316F10 VA: 0x182317B10
	public uint get_width() { }

	// RVA: 0x2317A50 Offset: 0x2316E50 VA: 0x182317A50
	public uint get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317970 Offset: 0x2316D70 VA: 0x182317970
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317B50 Offset: 0x2316F50 VA: 0x182317B50
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317860 Offset: 0x2316C60 VA: 0x182317860
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23177F0 Offset: 0x2316BF0 VA: 0x1823177F0
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317830 Offset: 0x2316C30 VA: 0x182317830
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23178C0 Offset: 0x2316CC0 VA: 0x1823178C0
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23177C0 Offset: 0x2316BC0 VA: 0x1823177C0
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317780 Offset: 0x2316B80 VA: 0x182317780
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317890 Offset: 0x2316C90 VA: 0x182317890
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2317740 Offset: 0x2316B40 VA: 0x182317740
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

}

public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4784
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12DD910 Offset: 0x12DCD10 VA: 0x1812DD910 Slot: 12
	public virtual void Invoke(VideoPlayer source) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 4785
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(VideoPlayer source, string message) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4786
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2316C50 Offset: 0x2316050 VA: 0x182316C50 Slot: 12
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	// RVA: 0x2316BC0 Offset: 0x2315FC0 VA: 0x182316BC0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4787
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2317230 Offset: 0x2316630 VA: 0x182317230 Slot: 12
	public virtual void Invoke(VideoPlayer source, double seconds) { }

	// RVA: 0x23171A0 Offset: 0x23165A0 VA: 0x1823171A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

