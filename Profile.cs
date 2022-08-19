public class Profile // TypeDefIndex: 9375
{	// Fields
	public Stopwatch watch; // 0x10
	public string category; // 0x18
	public string name; // 0x20
	public float warnTime; // 0x28

	// Methods

	// RVA: 0x6917F0 Offset: 0x690BF0 VA: 0x1806917F0
	public void .ctor(string cat, string nam, float WarnTime = 1) { }

	// RVA: 0x691450 Offset: 0x690850 VA: 0x180691450
	public void Start() { }

	// RVA: 0x691490 Offset: 0x690890 VA: 0x180691490
	public void Stop() { }

}

public class Profile : ConsoleSystem // TypeDefIndex: 11953
{	// Methods

	// RVA: 0x368F20 Offset: 0x368320 VA: 0x180368F20
	private static void NeedProfileFolder() { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void start(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void stop(ConsoleSystem.Arg arg) { }

	// RVA: 0x368F70 Offset: 0x368370 VA: 0x180368F70
	public void .ctor() { }

}

