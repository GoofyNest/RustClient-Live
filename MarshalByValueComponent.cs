public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 2728
{	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x10
	private EventHandlerList events; // 0x18

	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	public virtual ISite Site { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x15A3EB0 Offset: 0x15A32B0 VA: 0x1815A3EB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public virtual ISite get_Site() { }

	// RVA: 0x15A3C60 Offset: 0x15A3060 VA: 0x1815A3C60 Slot: 5
	public void Dispose() { }

	// RVA: 0x15A3CD0 Offset: 0x15A30D0 VA: 0x1815A3CD0 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15A3F50 Offset: 0x15A3350 VA: 0x1815A3F50 Slot: 9
	public virtual object GetService(Type service) { }

	// RVA: 0x15A3FB0 Offset: 0x15A33B0 VA: 0x1815A3FB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x15A4080 Offset: 0x15A3480 VA: 0x1815A4080
	private static void .cctor() { }

}

