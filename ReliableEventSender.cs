public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9123
{
	[HeaderAttribute] 
	public string StateEnter; 
	[HeaderAttribute] 
	public string MidStateEvent; 
	[RangeAttribute] 
	public float TargetEventTime; 
	private bool sentBeginEvent; 
	private float lastTime; 
	private AnimationEvents eventComponent; 


	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	private void SendEvent(Animator animator, string eventName) { }

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

}

