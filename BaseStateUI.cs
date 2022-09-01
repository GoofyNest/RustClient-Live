public class BaseStateUI : MonoBehaviour // TypeDefIndex: 10800
{
	public Dropdown DropdownInputMemorySlot; 
	public Transform PrefabAddNewEvent; 
	public Transform PrefabTimerEvent; 
	public Transform PrefabPlayerDetectedEvent; 
	public Transform PrefabStateErrorEvent; 
	public Transform PrefabStateFinishedEvent; 
	public Transform PrefabAttackedEvent; 
	public Transform PrefabInAttackRangeEvent; 
	public Transform PrefabHealthBelowEvent; 
	public Transform PrefabInRangeEvent; 
	public Transform PrefabPerformedAttackEvent; 
	public Transform PrefabTirednessAboveEvent; 
	public Transform PrefabHungerAboveEvent; 
	public Transform PrefabThreatDetectevEvent; 
	public Transform PrefabTargetDetectevEvent; 
	public Transform PrefabAmmoBelowEvent; 
	public Transform PrefabBestTargetDetectedEvent; 
	public Transform PrefabIsVisibleEvent; 
	public Transform PrefabAttackTickEvent; 
	public Transform PrefabIsMountedEvent; 
	public Transform PrefabAndEvent; 
	public Transform PrefabChanceEvent; 
	public Transform PrefabTargetLostEvent; 
	public Transform PrefabTimeSinceThreatEvent; 
	public Transform PrefabOnPositionMemorySetEvent; 
	public Transform PrefabAggressionTimerEvent; 
	public Transform PrefabReloadingEvent; 
	public Transform PrefabInRangeOfHomeEvent; 
	public RustText TextStateName; 
	public Transform EventContainer; 
	public ScrollRect Scroll; 
	public AIState StateType; 
	public int StateContainerID; 
	[CompilerGeneratedAttribute] 
	private int <InputEntityMemorySlot>k__BackingField; 
	private Transform addNewEventButton; 

	public int InputEntityMemorySlot { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] 
	private void set_InputEntityMemorySlot(int value) { }

	public virtual void Init(AIState stateType, int stateContainerID) { }

	public void ClearEvents() { }

	public BaseEventUI AddNewEvent(AIEventType eventType) { }

	public void PingTriggeringEvent(int id) { }

	private BaseEventUI GetEvent(int id) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator ScrollToBottom() { }

	public void Load(AIStateContainer container) { }

	public void SetActiveDebugState(bool flag) { }

	public virtual AIStateContainer Save() { }

	private Transform GetEventPrefab(AIEventType eventType) { }

	private void AddNewEventButton() { }

	public void DeleteStateClicked() { }

	public void DeleteEvent(BaseEventUI eventUI) { }

	public void MoveEventUp(BaseEventUI eventUI) { }

	public void MoveEventDown(BaseEventUI eventUI) { }

	public void .ctor() { }

}

private sealed class BaseStateUI.<ScrollToBottom>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10801
{
	private int <>1__state; 
	private object <>2__current; 
	public BaseStateUI <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

