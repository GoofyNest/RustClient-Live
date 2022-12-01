public static class Monitor // TypeDefIndex: 788
{

	public static void Enter(object obj) { }

	public static void Enter(object obj, ref bool lockTaken) { }

	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute]
	public static void Exit(object obj) { }

	public static void TryEnter(object obj, ref bool lockTaken) { }

	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	public static bool Wait(object obj, int millisecondsTimeout) { }

	public static void Pulse(object obj) { }

	public static void PulseAll(object obj) { }

	private static bool Monitor_test_synchronised(object obj) { }

	private static void Monitor_pulse(object obj) { }

	private static void ObjPulse(object obj) { }

	private static void Monitor_pulse_all(object obj) { }

	private static void ObjPulseAll(object obj) { }

	private static bool Monitor_wait(object obj, int ms) { }

	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	private static void ReliableEnter(object obj, ref bool lockTaken) { }

}

public abstract class Monitor // TypeDefIndex: 13625
{
	[CompilerGeneratedAttribute]
	private RenderTexture <output>k__BackingField;
	internal bool requested;

	public RenderTexture output { get; set; }


	[CompilerGeneratedAttribute]
	public RenderTexture get_output() { }

	[CompilerGeneratedAttribute]
	protected void set_output(RenderTexture value) { }

	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	internal virtual bool NeedsHalfRes() { }

	protected void CheckOutput(int width, int height) { }

	internal virtual void OnEnable() { }

	internal virtual void OnDisable() { }

	internal abstract void Render(PostProcessRenderContext context);

	protected void .ctor() { }

}

