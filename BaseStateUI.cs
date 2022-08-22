public class BaseStateUI : MonoBehaviour // TypeDefIndex: 10789
{	public Dropdown DropdownInputMemorySlot; // 0x18
	public Transform PrefabAddNewEvent; // 0x20
	public Transform PrefabTimerEvent; // 0x28
	public Transform PrefabPlayerDetectedEvent; // 0x30
	public Transform PrefabStateErrorEvent; // 0x38
	public Transform PrefabStateFinishedEvent; // 0x40
	public Transform PrefabAttackedEvent; // 0x48
	public Transform PrefabInAttackRangeEvent; // 0x50
	public Transform PrefabHealthBelowEvent; // 0x58
	public Transform PrefabInRangeEvent; // 0x60
	public Transform PrefabPerformedAttackEvent; // 0x68
	public Transform PrefabTirednessAboveEvent; // 0x70
	public Transform PrefabHungerAboveEvent; // 0x78
	public Transform PrefabThreatDetectevEvent; // 0x80
	public Transform PrefabTargetDetectevEvent; // 0x88
	public Transform PrefabAmmoBelowEvent; // 0x90
	public Transform PrefabBestTargetDetectedEvent; // 0x98
	public Transform PrefabIsVisibleEvent; // 0xA0
	public Transform PrefabAttackTickEvent; // 0xA8
	public Transform PrefabIsMountedEvent; // 0xB0
	public Transform PrefabAndEvent; // 0xB8
	public Transform PrefabChanceEvent; // 0xC0
	public Transform PrefabTargetLostEvent; // 0xC8
	public Transform PrefabTimeSinceThreatEvent; // 0xD0
	public Transform PrefabOnPositionMemorySetEvent; // 0xD8
	public Transform PrefabAggressionTimerEvent; // 0xE0
	public Transform PrefabReloadingEvent; // 0xE8
	public Transform PrefabInRangeOfHomeEvent; // 0xF0
	public RustText TextStateName; // 0xF8
	public Transform EventContainer; // 0x100
	public ScrollRect Scroll; // 0x108
	public AIState StateType; // 0x110
	public int StateContainerID; // 0x114
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <InputEntityMemorySlot>k__BackingField; // 0x118
	private Transform addNewEventButton; // 0x120

	public int InputEntityMemorySlot { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_InputEntityMemorySlot(int value) { }

	public virtual void Init(AIState stateType, int stateContainerID) { }

	public void ClearEvents() { }

	public BaseEventUI AddNewEvent(AIEventType eventType) { }

	public void PingTriggeringEvent(int id) { }

	private BaseEventUI GetEvent(int id) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C160 Offset: 0x7B560 VA: 0x18007C160
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

private sealed class BaseStateUI.<ScrollToBottom>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10790
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BaseStateUI <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

