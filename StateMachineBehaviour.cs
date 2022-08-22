public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 4478
{
[AttributeUsageAttribute] // RVA: 0xB8CD0 Offset: 0xB80D0 VA: 0x1800B8CD0
[RequiredByNativeCodeAttribute] // RVA: 0xB8CD0 Offset: 0xB80D0 VA: 0x1800B8CD0
public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 4477

[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 4478

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	protected void .ctor() { }

}

