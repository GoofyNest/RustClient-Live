public class BaseMovement : MonoBehaviour // TypeDefIndex: 9667
{	// Fields
	public bool adminCheat; // 0x18
	public float adminSpeed; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BasePlayer <Owner>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <InheritedVelocity>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <TargetMovement>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Running>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Ducking>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Crawling>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Grounded>k__BackingField; // 0x4C
	private const float RECENTLY_TELEPORTED_TIME = 1;
	private float lastTeleportedTime; // 0x50

	// Properties
	public BasePlayer Owner { get; set; }
	public Vector3 InheritedVelocity { get; set; }
	public Vector3 TargetMovement { get; set; }
	public float Running { get; set; }
	public float Ducking { get; set; }
	public float Crawling { get; set; }
	public float Grounded { get; set; }
	public bool IsRunning { get; }
	public bool IsDucked { get; }
	public bool IsCrawling { get; }
	public bool IsGrounded { get; }
	public bool RecentlyTeleported { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public BasePlayer get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_Owner(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E85E0 Offset: 0x7E79E0 VA: 0x1807E85E0
	public Vector3 get_InheritedVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9490 Offset: 0x4B8890 VA: 0x1804B9490
	public void set_InheritedVelocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BBE0 Offset: 0xA2AFE0 VA: 0x180A2BBE0
	public Vector3 get_TargetMovement() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9480 Offset: 0x4B8880 VA: 0x1804B9480
	protected void set_TargetMovement(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0
	public float get_Running() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6B0 Offset: 0x54CAB0 VA: 0x18054D6B0
	protected void set_Running(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E53E0 Offset: 0x7E47E0 VA: 0x1807E53E0
	public float get_Ducking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x84F290 Offset: 0x84E690 VA: 0x18084F290
	protected void set_Ducking(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x709DE0 Offset: 0x7091E0 VA: 0x180709DE0
	public float get_Crawling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x709DF0 Offset: 0x7091F0 VA: 0x180709DF0
	protected void set_Crawling(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9450 Offset: 0x4B8850 VA: 0x1804B9450
	public float get_Grounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94B0 Offset: 0x4B88B0 VA: 0x1804B94B0
	protected void set_Grounded(float value) { }

	// RVA: 0xA2BBA0 Offset: 0xA2AFA0 VA: 0x180A2BBA0
	public bool get_IsRunning() { }

	// RVA: 0xA2BB80 Offset: 0xA2AF80 VA: 0x180A2BB80
	public bool get_IsDucked() { }

	// RVA: 0xA2BB70 Offset: 0xA2AF70 VA: 0x180A2BB70
	public bool get_IsCrawling() { }

	// RVA: 0xA2BB90 Offset: 0xA2AF90 VA: 0x180A2BB90
	public bool get_IsGrounded() { }

	// RVA: 0xA2B8F0 Offset: 0xA2ACF0 VA: 0x180A2B8F0 Slot: 4
	public virtual Vector3 CurrentVelocity() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 5
	public virtual float CurrentMoveSpeed() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public virtual Collider GetCollider() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 7
	public virtual void Init(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void BlockJump(float duration) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void BlockSprint(float duration) { }

	// RVA: 0xA2BBB0 Offset: 0xA2AFB0 VA: 0x180A2BBB0
	public bool get_RecentlyTeleported() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public virtual void ClientInput(InputState state, ModelState modelState) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	public virtual void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0xA2B9E0 Offset: 0xA2ADE0 VA: 0x180A2B9E0 Slot: 12
	public virtual void FrameUpdate(BasePlayer player, ModelState modelState) { }

	// RVA: 0xA2BAD0 Offset: 0xA2AED0 VA: 0x180A2BAD0 Slot: 13
	public virtual void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	public virtual void Push(Vector3 velocity) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void SetParent(Transform parent) { }

	// RVA: 0xA2B960 Offset: 0xA2AD60 VA: 0x180A2B960
	public void FixedUpdate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public virtual void PlayerAttemptedMount() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	public virtual void PlayerCompletedMount() { }

	// RVA: 0x70F570 Offset: 0x70E970 VA: 0x18070F570
	public void .ctor() { }

}

