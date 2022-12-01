public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 4655
{
	private EventCallbackRegistry m_CallbackRegistry;


	public abstract void SendEvent(EventBase e);

	internal void HandleEventAtTargetPhase(EventBase evt) { }

	public virtual void HandleEvent(EventBase evt) { }

	public bool HasTrickleDownHandlers() { }

	public bool HasBubbleUpHandlers() { }

	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	protected virtual void ExecuteDefaultAction(EventBase evt) { }

}

