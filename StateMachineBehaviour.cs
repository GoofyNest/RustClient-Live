public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 4478
{
// Namespace: UnityEngine
[AttributeUsageAttribute] // RVA: 0xB8CD0 Offset: 0xB80D0 VA: 0x1800B8CD0
[RequiredByNativeCodeAttribute] // RVA: 0xB8CD0 Offset: 0xB80D0 VA: 0x1800B8CD0
public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 4477

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 4478
	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	protected void .ctor() { }

}

