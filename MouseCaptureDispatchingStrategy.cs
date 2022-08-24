internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 4665
{

public bool CanDispatchEvent(EventBase evt) { }

public void DispatchEvent(EventBase evt, IPanel panel) { }

public void .ctor() { }

}

private enum MouseCaptureDispatchingStrategy.EventBehavior // TypeDefIndex: 4666
{
	public int value__; 
public const MouseCaptureDispatchingStrategy.EventBehavior None = 0;
public const MouseCaptureDispatchingStrategy.EventBehavior IsCapturable = 1;
public const MouseCaptureDispatchingStrategy.EventBehavior IsSentExclusivelyToCapturingElement = 2;

}

