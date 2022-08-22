internal class Deflater // TypeDefIndex: 5656
{	public static int BEST_COMPRESSION; // 0x0
	public static int BEST_SPEED; // 0x4
	public static int DEFAULT_COMPRESSION; // 0x8
	public static int NO_COMPRESSION; // 0xC
	public static int DEFLATED; // 0x10
	private static int IS_SETDICT; // 0x14
	private static int IS_FLUSHING; // 0x18
	private static int IS_FINISHING; // 0x1C
	private static int INIT_STATE; // 0x20
	private static int SETDICT_STATE; // 0x24
	private static int BUSY_STATE; // 0x28
	private static int FLUSHING_STATE; // 0x2C
	private static int FINISHING_STATE; // 0x30
	private static int FINISHED_STATE; // 0x34
	private static int CLOSED_STATE; // 0x38
	private int level; // 0x10
	private bool noZlibHeaderOrFooter; // 0x14
	private int state; // 0x18
	private long totalOut; // 0x20
	private DeflaterPending pending; // 0x28
	private DeflaterEngine engine; // 0x30

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

