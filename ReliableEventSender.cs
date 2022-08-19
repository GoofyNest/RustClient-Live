public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9119
{	// Fields
	[HeaderAttribute] // RVA: 0xD1130 Offset: 0xD0530 VA: 0x1800D1130
	public string StateEnter; // 0x18
	[HeaderAttribute] // RVA: 0xD1240 Offset: 0xD0640 VA: 0x1800D1240
	public string MidStateEvent; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float TargetEventTime; // 0x28
	private bool sentBeginEvent; // 0x2C
	private float lastTime; // 0x30
	private AnimationEvents eventComponent; // 0x38

	// Methods

	// RVA: 0x92B8E0 Offset: 0x92ACE0 VA: 0x18092B8E0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x92B980 Offset: 0x92AD80 VA: 0x18092B980 Slot: 7
	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x92BA40 Offset: 0x92AE40 VA: 0x18092BA40
	private void SendEvent(Animator animator, string eventName) { }

	// RVA: 0x92B930 Offset: 0x92AD30 VA: 0x18092B930 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7040 Offset: 0x6A6440 VA: 0x1806A7040
	public void .ctor() { }

}

