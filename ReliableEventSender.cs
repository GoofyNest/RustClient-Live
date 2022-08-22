public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9119
{	[HeaderAttribute] // RVA: 0xD1130 Offset: 0xD0530 VA: 0x1800D1130
	public string StateEnter; // 0x18
	[HeaderAttribute] // RVA: 0xD1240 Offset: 0xD0640 VA: 0x1800D1240
	public string MidStateEvent; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float TargetEventTime; // 0x28
	private bool sentBeginEvent; // 0x2C
	private float lastTime; // 0x30
	private AnimationEvents eventComponent; // 0x38


	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	private void SendEvent(Animator animator, string eventName) { }

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

}

