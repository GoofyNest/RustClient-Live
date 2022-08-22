public abstract class RegexRunner // TypeDefIndex: 2629
{	protected internal int runtextbeg; // 0x10
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


	protected internal void .ctor() { }

	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	private void StartTimeoutWatch() { }

	protected void CheckTimeout() { }

	private void DoCheckTimeout() { }

	protected abstract void Go();

	protected abstract bool FindFirstChar();

	protected abstract void InitTrackCount();

	private void InitMatch() { }

	private Match TidyMatch(bool quick) { }

	protected void EnsureStorage() { }

	protected bool IsBoundary(int index, int startpos, int endpos) { }

	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	protected void DoubleTrack() { }

	protected void DoubleStack() { }

	protected void DoubleCrawl() { }

	protected void Crawl(int i) { }

	protected int Popcrawl() { }

	protected int Crawlpos() { }

	protected void Capture(int capnum, int start, int end) { }

	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	protected void Uncapture() { }

	protected bool IsMatched(int cap) { }

	protected int MatchIndex(int cap) { }

	protected int MatchLength(int cap) { }

}

