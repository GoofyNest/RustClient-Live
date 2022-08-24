internal class Deflater // TypeDefIndex: 5656
{
	public static int BEST_COMPRESSION; 
	public static int BEST_SPEED; 
	public static int DEFAULT_COMPRESSION; 
	public static int NO_COMPRESSION; 
	public static int DEFLATED; 
	private static int IS_SETDICT; 
	private static int IS_FLUSHING; 
	private static int IS_FINISHING; 
	private static int INIT_STATE; 
	private static int SETDICT_STATE; 
	private static int BUSY_STATE; 
	private static int FLUSHING_STATE; 
	private static int FINISHING_STATE; 
	private static int FINISHED_STATE; 
	private static int CLOSED_STATE; 
	private int level; 
	private bool noZlibHeaderOrFooter; 
	private int state; 
	private long totalOut; 
	private DeflaterPending pending; 
	private DeflaterEngine engine; 

	public int TotalIn { get; }
	public bool IsFinished { get; }
	public bool IsNeedingInput { get; }


	public void .ctor(int level, bool noZlibHeaderOrFooter) { }

	public void Reset() { }

	public int get_TotalIn() { }

	public void Flush() { }

	public void Finish() { }

	public bool get_IsFinished() { }

	public bool get_IsNeedingInput() { }

	public void SetInput(byte[] input, int off, int len) { }

	public void SetLevel(int lvl) { }

	public void SetStrategy(DeflateStrategy strategy) { }

	public int Deflate(byte[] output, int offset, int length) { }

	private static void .cctor() { }

}

