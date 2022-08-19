public class Stopwatch // TypeDefIndex: 2657
{	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }

	// Methods

	// RVA: 0x1615830 Offset: 0x1614C30 VA: 0x181615830
	public static long GetTimestamp() { }

	// RVA: 0x172F190 Offset: 0x172E590 VA: 0x18172F190
	public static Stopwatch StartNew() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x172F5E0 Offset: 0x172E9E0 VA: 0x18172F5E0
	public TimeSpan get_Elapsed() { }

	// RVA: 0x172F360 Offset: 0x172E760 VA: 0x18172F360
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x172F570 Offset: 0x172E970 VA: 0x18172F570
	public long get_ElapsedTicks() { }

	// RVA: 0x172F120 Offset: 0x172E520 VA: 0x18172F120
	public void Reset() { }

	// RVA: 0x172F230 Offset: 0x172E630 VA: 0x18172F230
	public void Start() { }

	// RVA: 0x172F290 Offset: 0x172E690 VA: 0x18172F290
	public void Stop() { }

	// RVA: 0x172F130 Offset: 0x172E530 VA: 0x18172F130
	public void Restart() { }

	// RVA: 0x172F310 Offset: 0x172E710 VA: 0x18172F310
	private static void .cctor() { }

}

