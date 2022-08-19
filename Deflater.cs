internal class Deflater // TypeDefIndex: 5656
{	// Fields
	public static int BEST_COMPRESSION; // 0x0
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

	// Properties
	public int TotalIn { get; }
	public bool IsFinished { get; }
	public bool IsNeedingInput { get; }

	// Methods

	// RVA: 0x13AADA0 Offset: 0x13AA1A0 VA: 0x1813AADA0
	public void .ctor(int level, bool noZlibHeaderOrFooter) { }

	// RVA: 0x13AA7B0 Offset: 0x13A9BB0 VA: 0x1813AA7B0
	public void Reset() { }

	// RVA: 0x13AB100 Offset: 0x13AA500 VA: 0x1813AB100
	public int get_TotalIn() { }

	// RVA: 0x13AA740 Offset: 0x13A9B40 VA: 0x1813AA740
	public void Flush() { }

	// RVA: 0x13AA6D0 Offset: 0x13A9AD0 VA: 0x1813AA6D0
	public void Finish() { }

	// RVA: 0x13AB040 Offset: 0x13AA440 VA: 0x1813AB040
	public bool get_IsFinished() { }

	// RVA: 0x13AB0D0 Offset: 0x13AA4D0 VA: 0x1813AB0D0
	public bool get_IsNeedingInput() { }

	// RVA: 0x13AA970 Offset: 0x13A9D70 VA: 0x1813AA970
	public void SetInput(byte[] input, int off, int len) { }

	// RVA: 0x13AAB00 Offset: 0x13A9F00 VA: 0x1813AAB00
	public void SetLevel(int lvl) { }

	// RVA: 0x13AAC20 Offset: 0x13AA020 VA: 0x1813AAC20
	public void SetStrategy(DeflateStrategy strategy) { }

	// RVA: 0x13AA170 Offset: 0x13A9570 VA: 0x1813AA170
	public int Deflate(byte[] output, int offset, int length) { }

	// RVA: 0x13AAC40 Offset: 0x13AA040 VA: 0x1813AAC40
	private static void .cctor() { }

}

