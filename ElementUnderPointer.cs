internal class ElementUnderPointer // TypeDefIndex: 4639
{
	private VisualElement[] m_PendingTopElementUnderPointer; 
	private VisualElement[] m_TopElementUnderPointer; 
	private IPointerEvent[] m_TriggerPointerEvent; 
	private IMouseEvent[] m_TriggerMouseEvent; 
	private Vector2[] m_PickingPointerPositions; 
	private bool[] m_IsPickingPointerTemporaries; 


internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

internal VisualElement GetTopElementUnderPointer(int pointerId) { }

private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

private void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary) { }

internal void CommitElementUnderPointers(EventDispatcher dispatcher) { }

}

