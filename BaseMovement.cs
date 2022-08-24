public class BaseMovement : MonoBehaviour // TypeDefIndex: 9667
{
	public bool adminCheat; 
	public float adminSpeed; 
	[CompilerGeneratedAttribute] 
	private BasePlayer <Owner>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <InheritedVelocity>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <TargetMovement>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Running>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Ducking>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Crawling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Grounded>k__BackingField; 
	private const float RECENTLY_TELEPORTED_TIME = 1;
	private float lastTeleportedTime; 

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


	[CompilerGeneratedAttribute] 
	public BasePlayer get_Owner() { }

	[CompilerGeneratedAttribute] 
	private void set_Owner(BasePlayer value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_InheritedVelocity() { }

	[CompilerGeneratedAttribute] 
	public void set_InheritedVelocity(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_TargetMovement() { }

	[CompilerGeneratedAttribute] 
	protected void set_TargetMovement(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public float get_Running() { }

	[CompilerGeneratedAttribute] 
	protected void set_Running(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_Ducking() { }

	[CompilerGeneratedAttribute] 
	protected void set_Ducking(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_Crawling() { }

	[CompilerGeneratedAttribute] 
	protected void set_Crawling(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_Grounded() { }

	[CompilerGeneratedAttribute] 
	protected void set_Grounded(float value) { }

	public bool get_IsRunning() { }

	public bool get_IsDucked() { }

	public bool get_IsCrawling() { }

	public bool get_IsGrounded() { }

	public virtual Vector3 CurrentVelocity() { }

	public virtual float CurrentMoveSpeed() { }

	public virtual Collider GetCollider() { }

	public virtual void Init(BasePlayer player) { }

	public virtual void BlockJump(float duration) { }

	public virtual void BlockSprint(float duration) { }

	public bool get_RecentlyTeleported() { }

	public virtual void ClientInput(InputState state, ModelState modelState) { }

	public virtual void DoFixedUpdate(ModelState modelState) { }

	public virtual void FrameUpdate(BasePlayer player, ModelState modelState) { }

	public virtual void TeleportTo(Vector3 position, BasePlayer player) { }

	public virtual void Push(Vector3 velocity) { }

	public virtual void SetParent(Transform parent) { }

	public void FixedUpdate() { }

	public virtual void PlayerAttemptedMount() { }

	public virtual void PlayerCompletedMount() { }

	public void .ctor() { }

}

