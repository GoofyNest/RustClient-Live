public abstract class RenderPipeline // TypeDefIndex: 3849
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <disposed>k__BackingField; // 0x10

	public bool disposed { get; set; }


	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_disposed(bool value) { }

	internal void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

}

