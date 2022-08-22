public class Animator : Behaviour // TypeDefIndex: 4487
{	public bool isInitialized { get; }
	public bool applyRootMotion { set; }
	public AnimatorUpdateMode updateMode { set; }
	public int layerCount { get; }
	public float speed { set; }
	public AnimatorCullingMode cullingMode { get; set; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { set; }
	public bool logWarnings { get; }
	public bool fireEvents { set; }


	[NativeMethodAttribute] // RVA: 0xCA2D0 Offset: 0xC96D0 VA: 0x1800CA2D0
	public bool get_isInitialized() { }

	public float GetFloat(string name) { }

	public float GetFloat(int id) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	public bool GetBool(int id) { }

	public void SetBool(string name, bool value) { }

	public void SetBool(int id, bool value) { }

	public int GetInteger(string name) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int id) { }

	public void set_applyRootMotion(bool value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA440 Offset: 0xC9840 VA: 0x1800CA440
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA830 Offset: 0xC9C30 VA: 0x1800CA830
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public int get_layerCount() { }

	public int GetLayerIndex(string layerName) { }

	public float GetLayerWeight(int layerIndex) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCA8E0 Offset: 0xC9CE0 VA: 0x1800CA8E0
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAAC0 Offset: 0xC9EC0 VA: 0x1800CAAC0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public bool IsInTransition(int layerIndex) { }

	public void set_speed(float value) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCADA0 Offset: 0xCA1A0 VA: 0x1800CADA0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void Play(string stateName, int layer) { }

	public void Play(string stateName) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB110 Offset: 0xCA510 VA: 0x1800CB110
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(int stateNameHash) { }

	public AnimatorCullingMode get_cullingMode() { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB380 Offset: 0xCA780 VA: 0x1800CB380
	public bool get_hasBoundPlayables() { }

	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB510 Offset: 0xCA910 VA: 0x1800CB510
	public static int StringToHash(string name) { }

	public void set_avatar(Avatar value) { }

	private void CheckIfInIKPass() { }

	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB7C0 Offset: 0xCABC0 VA: 0x1800CB7C0
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBA40 Offset: 0xCAE40 VA: 0x1800CBA40
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBB80 Offset: 0xCAF80 VA: 0x1800CBB80
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBCB0 Offset: 0xCB0B0 VA: 0x1800CBCB0
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBD20 Offset: 0xCB120 VA: 0x1800CBD20
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBDF0 Offset: 0xCB1F0 VA: 0x1800CBDF0
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC110 Offset: 0xCB510 VA: 0x1800CC110
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC2B0 Offset: 0xCB6B0 VA: 0x1800CC2B0
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC370 Offset: 0xCB770 VA: 0x1800CC370
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC5B0 Offset: 0xCB9B0 VA: 0x1800CC5B0
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC640 Offset: 0xCBA40 VA: 0x1800CC640
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC7D0 Offset: 0xCBBD0 VA: 0x1800CC7D0
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC930 Offset: 0xCBD30 VA: 0x1800CC930
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCAA0 Offset: 0xCBEA0 VA: 0x1800CCAA0
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCC80 Offset: 0xCC080 VA: 0x1800CCC80
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCD10 Offset: 0xCC110 VA: 0x1800CCD10
	public void Update(float deltaTime) { }

	public bool get_logWarnings() { }

	public void set_fireEvents(bool value) { }

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

