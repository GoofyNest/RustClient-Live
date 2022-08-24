public abstract class RegexRunner // TypeDefIndex: 2629
{
	protected internal int runtextbeg; 
	protected internal int runtextend; 
	protected internal int runtextstart; 
	protected internal string runtext; 
	protected internal int runtextpos; 
	protected internal int[] runtrack; 
	protected internal int runtrackpos; 
	protected internal int[] runstack; 
	protected internal int runstackpos; 
	protected internal int[] runcrawl; 
	protected internal int runcrawlpos; 
	protected internal int runtrackcount; 
	protected internal Match runmatch; 
	protected internal Regex runregex; 
	private int timeout; 
	private bool ignoreTimeout; 
	private int timeoutOccursAt; 
private const int TimeoutCheckFrequency = 1000;
	private int timeoutChecksToSkip; 


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

