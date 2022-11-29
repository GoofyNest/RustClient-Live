public class BatchRendererGroup // TypeDefIndex: 3849
{
	private IntPtr m_GroupHandle; 
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; 


	[RequiredByNativeCodeAttribute] 
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3850
{

	public void .ctor(object object, IntPtr method) { }

	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

