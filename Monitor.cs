public static class Monitor // TypeDefIndex: 788
{	// Methods

	// RVA: 0x1491910 Offset: 0x1490D10 VA: 0x181491910
	public static void Enter(object obj) { }

	// RVA: 0x1491920 Offset: 0x1490D20 VA: 0x181491920
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x1491E60 Offset: 0x1491260 VA: 0x181491E60
	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x14919B0 Offset: 0x1490DB0 VA: 0x1814919B0
	public static void Exit(object obj) { }

	// RVA: 0x1491ED0 Offset: 0x14912D0 VA: 0x181491ED0
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x1491F60 Offset: 0x1491360 VA: 0x181491F60
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1491F60 Offset: 0x1491360 VA: 0x181491F60
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x1491C60 Offset: 0x1491060 VA: 0x181491C60
	public static void Pulse(object obj) { }

	// RVA: 0x1491BA0 Offset: 0x1490FA0 VA: 0x181491BA0
	public static void PulseAll(object obj) { }

	// RVA: 0x14919E0 Offset: 0x1490DE0 VA: 0x1814919E0
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x14919D0 Offset: 0x1490DD0 VA: 0x1814919D0
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x1491A70 Offset: 0x1490E70 VA: 0x181491A70
	private static void ObjPulse(object obj) { }

	// RVA: 0x14919C0 Offset: 0x1490DC0 VA: 0x1814919C0
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1491A00 Offset: 0x1490E00 VA: 0x181491A00
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x14919F0 Offset: 0x1490DF0 VA: 0x1814919F0
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x1491AE0 Offset: 0x1490EE0 VA: 0x181491AE0
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1492070 Offset: 0x1491470 VA: 0x181492070
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1491D20 Offset: 0x1491120 VA: 0x181491D20
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x1491DE0 Offset: 0x14911E0 VA: 0x181491DE0
	private static void ReliableEnter(object obj, ref bool lockTaken) { }

}

public abstract class Monitor // TypeDefIndex: 11817
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RenderTexture <output>k__BackingField; // 0x10
	internal bool requested; // 0x18

	// Properties
	public RenderTexture output { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public RenderTexture get_output() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	protected void set_output(RenderTexture value) { }

	// RVA: 0x1014510 Offset: 0x1013910 VA: 0x181014510
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 5
	internal virtual bool NeedsHalfRes() { }

	// RVA: 0x1014380 Offset: 0x1013780 VA: 0x181014380
	protected void CheckOutput(int width, int height) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	internal virtual void OnEnable() { }

	// RVA: 0x10145B0 Offset: 0x10139B0 VA: 0x1810145B0 Slot: 7
	internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Render(PostProcessRenderContext context);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

