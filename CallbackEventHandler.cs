public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 4650
{	// Fields
	private EventCallbackRegistry m_CallbackRegistry; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendEvent(EventBase e);

	// RVA: 0xEBCC90 Offset: 0xEBC090 VA: 0x180EBCC90
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0xEBCCF0 Offset: 0xEBC0F0 VA: 0x180EBCCF0 Slot: 7
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0xEBCFA0 Offset: 0xEBC3A0 VA: 0x180EBCFA0 Slot: 8
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEBCF80 Offset: 0xEBC380 VA: 0x180EBCF80 Slot: 9
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

}

