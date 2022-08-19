public class BatchRendererGroup // TypeDefIndex: 3846
{	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199FEB0 Offset: 0x199F2B0 VA: 0x18199FEB0
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3847
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19A5450 Offset: 0x19A4850 VA: 0x1819A5450 Slot: 12
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x19A53C0 Offset: 0x19A47C0 VA: 0x1819A53C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x121B4C0 Offset: 0x121A8C0 VA: 0x18121B4C0 Slot: 14
	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

