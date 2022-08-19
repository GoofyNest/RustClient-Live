private struct ThreadLocal.LinkedSlotVolatile<T> // TypeDefIndex: 768
{	// Fields
	internal ThreadLocal.LinkedSlot<T> Value; // 0x0

}

private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 769
{	// Fields
	internal ThreadLocal.LinkedSlot<T> Next; // 0x0
	internal ThreadLocal.LinkedSlot<T> Previous; // 0x0
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	internal T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A44DD0 Offset: 0x1A441D0 VA: 0x181A44DD0
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/

}

private class ThreadLocal.IdManager<T> // TypeDefIndex: 770
{	// Fields
	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A44B10 Offset: 0x1A43F10 VA: 0x181A44B10
	|-ThreadLocal.IdManager<object>.GetId
	*/

	// RVA: -1 Offset: -1
	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A44C60 Offset: 0x1A44060 VA: 0x181A44C60
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A44D60 Offset: 0x1A44160 VA: 0x181A44D60
	|-ThreadLocal.IdManager<object>..ctor
	*/

}

private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 771
{	// Fields
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A44AC0 Offset: 0x1A43EC0 VA: 0x181A44AC0
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A447A0 Offset: 0x1A43BA0 VA: 0x181A447A0
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/

}

