private struct ThreadLocal.LinkedSlotVolatile<T> // TypeDefIndex: 768
{
	internal ThreadLocal.LinkedSlot<T> Value; 

}

private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 769
{
	internal ThreadLocal.LinkedSlot<T> Next; 
	internal ThreadLocal.LinkedSlot<T> Previous; 
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; 
	internal T Value; 


	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/

}

private class ThreadLocal.IdManager<T> // TypeDefIndex: 770
{
	private int m_nextIdToTry; 
	private List<bool> m_freeIds; 


	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-ThreadLocal.IdManager<object>.GetId
	*/

	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-ThreadLocal.IdManager<object>..ctor
	*/

}

private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 771
{
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; 
	private bool m_trackAllValues; 


	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/

}

