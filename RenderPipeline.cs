public abstract class RenderPipeline // TypeDefIndex: 3849
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: 0x19AA5B0 Offset: 0x19A99B0 VA: 0x1819AA5B0
	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	private void set_disposed(bool value) { }

	// RVA: 0x19AA540 Offset: 0x19A9940 VA: 0x1819AA540
	internal void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

}

