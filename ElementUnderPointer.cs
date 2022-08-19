internal class ElementUnderPointer // TypeDefIndex: 4639
{	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0xEBEFD0 Offset: 0xEBE3D0 VA: 0x180EBEFD0
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0xEBEE10 Offset: 0xEBE210 VA: 0x180EBEE10
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0xEBF490 Offset: 0xEBE890 VA: 0x180EBF490
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEBF070 Offset: 0xEBE470 VA: 0x180EBF070
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEBF090 Offset: 0xEBE490 VA: 0x180EBF090
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary) { }

	// RVA: 0xEBDCB0 Offset: 0xEBD0B0 VA: 0x180EBDCB0
	internal void CommitElementUnderPointers(EventDispatcher dispatcher) { }

}

