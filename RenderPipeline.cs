public abstract class RenderPipeline // TypeDefIndex: 3851
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <disposed>k__BackingField; 

	public bool disposed { get; set; }


	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] 
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] 
	private void set_disposed(bool value) { }

	internal void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

}

