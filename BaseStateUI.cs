public class BaseStateUI : MonoBehaviour // TypeDefIndex: 10789
{	// Fields
	public Dropdown DropdownInputMemorySlot; // 0x18
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

	// Properties
	public int InputEntityMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90CEB0 Offset: 0x90C2B0 VA: 0x18090CEB0
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90CEC0 Offset: 0x90C2C0 VA: 0x18090CEC0
	private void set_InputEntityMemorySlot(int value) { }

	// RVA: 0x90C310 Offset: 0x90B710 VA: 0x18090C310 Slot: 4
	public virtual void Init(AIState stateType, int stateContainerID) { }

	// RVA: 0x90BC40 Offset: 0x90B040 VA: 0x18090BC40
	public void ClearEvents() { }

	// RVA: 0x90B8E0 Offset: 0x90ACE0 VA: 0x18090B8E0
	public BaseEventUI AddNewEvent(AIEventType eventType) { }

	// RVA: 0x90C7B0 Offset: 0x90BBB0 VA: 0x18090C7B0
	public void PingTriggeringEvent(int id) { }

	// RVA: 0x90C0B0 Offset: 0x90B4B0 VA: 0x18090C0B0
	private BaseEventUI GetEvent(int id) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C160 Offset: 0x7B560 VA: 0x18007C160
	// RVA: 0x90CD10 Offset: 0x90C110 VA: 0x18090CD10
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x90C500 Offset: 0x90B900 VA: 0x18090C500
	public void Load(AIStateContainer container) { }

	// RVA: 0x90CD80 Offset: 0x90C180 VA: 0x18090CD80
	public void SetActiveDebugState(bool flag) { }

	// RVA: 0x90C9D0 Offset: 0x90BDD0 VA: 0x18090C9D0 Slot: 5
	public virtual AIStateContainer Save() { }

	// RVA: 0x90BF70 Offset: 0x90B370 VA: 0x18090BF70
	private Transform GetEventPrefab(AIEventType eventType) { }

	// RVA: 0x90B7D0 Offset: 0x90ABD0 VA: 0x18090B7D0
	private void AddNewEventButton() { }

	// RVA: 0x90BEA0 Offset: 0x90B2A0 VA: 0x18090BEA0
	public void DeleteStateClicked() { }

	// RVA: 0x90BE30 Offset: 0x90B230 VA: 0x18090BE30
	public void DeleteEvent(BaseEventUI eventUI) { }

	// RVA: 0x90C750 Offset: 0x90BB50 VA: 0x18090C750
	public void MoveEventUp(BaseEventUI eventUI) { }

	// RVA: 0x90C6C0 Offset: 0x90BAC0 VA: 0x18090C6C0
	public void MoveEventDown(BaseEventUI eventUI) { }

	// RVA: 0x90CE90 Offset: 0x90C290 VA: 0x18090CE90
	public void .ctor() { }

}

private sealed class BaseStateUI.<ScrollToBottom>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10790
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BaseStateUI <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x91A360 Offset: 0x919760 VA: 0x18091A360 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x91A470 Offset: 0x919870 VA: 0x18091A470 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

