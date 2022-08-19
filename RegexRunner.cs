public abstract class RegexRunner // TypeDefIndex: 2629
{	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int timeout; // 0x70
	private bool ignoreTimeout; // 0x74
	private int timeoutOccursAt; // 0x78
	private const int TimeoutCheckFrequency = 1000;
	private int timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected internal void .ctor() { }

	// RVA: 0x16B3760 Offset: 0x16B2B60 VA: 0x1816B3760
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x16B3B10 Offset: 0x16B2F10 VA: 0x1816B3B10
	private void StartTimeoutWatch() { }

	// RVA: 0x16B2BC0 Offset: 0x16B1FC0 VA: 0x1816B2BC0
	protected void CheckTimeout() { }

	// RVA: 0x16B2DE0 Offset: 0x16B21E0 VA: 0x1816B2DE0
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x16B3240 Offset: 0x16B2640 VA: 0x1816B3240
	private void InitMatch() { }

	// RVA: 0x16B3B40 Offset: 0x16B2F40 VA: 0x1816B3B40
	private Match TidyMatch(bool quick) { }

	// RVA: 0x16B30F0 Offset: 0x16B24F0 VA: 0x1816B30F0
	protected void EnsureStorage() { }

	// RVA: 0x16B34B0 Offset: 0x16B28B0 VA: 0x1816B34B0
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B35A0 Offset: 0x16B29A0 VA: 0x1816B35A0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B3040 Offset: 0x16B2440 VA: 0x1816B3040
	protected void DoubleTrack() { }

	// RVA: 0x16B2F90 Offset: 0x16B2390 VA: 0x1816B2F90
	protected void DoubleStack() { }

	// RVA: 0x16B2EE0 Offset: 0x16B22E0 VA: 0x1816B2EE0
	protected void DoubleCrawl() { }

	// RVA: 0x16B2CD0 Offset: 0x16B20D0 VA: 0x1816B2CD0
	protected void Crawl(int i) { }

	// RVA: 0x16B3720 Offset: 0x16B2B20 VA: 0x1816B3720
	protected int Popcrawl() { }

	// RVA: 0x16B2DC0 Offset: 0x16B21C0 VA: 0x1816B2DC0
	protected int Crawlpos() { }

	// RVA: 0x16B2B30 Offset: 0x16B1F30 VA: 0x1816B2B30
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x16B3BA0 Offset: 0x16B2FA0 VA: 0x1816B3BA0
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x16B3CC0 Offset: 0x16B30C0 VA: 0x1816B3CC0
	protected void Uncapture() { }

	// RVA: 0x16B3690 Offset: 0x16B2A90 VA: 0x1816B3690
	protected bool IsMatched(int cap) { }

	// RVA: 0x16B36C0 Offset: 0x16B2AC0 VA: 0x1816B36C0
	protected int MatchIndex(int cap) { }

	// RVA: 0x16B36F0 Offset: 0x16B2AF0 VA: 0x1816B36F0
	protected int MatchLength(int cap) { }

}

