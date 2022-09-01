public class Animator : Behaviour // TypeDefIndex: 4487
{
	public bool isInitialized { get; }
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


	[NativeMethodAttribute] 
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

	[NativeMethodAttribute] 
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] 
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public int get_layerCount() { }

	public int GetLayerIndex(string layerName) { }

	public float GetLayerWeight(int layerIndex) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] 
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] 
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public bool IsInTransition(int layerIndex) { }

	public void set_speed(float value) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] 
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void Play(string stateName, int layer) { }

	public void Play(string stateName) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] 
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(int stateNameHash, int layer) { }

	public void Play(int stateNameHash) { }

	public AnimatorCullingMode get_cullingMode() { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] 
	public bool get_hasBoundPlayables() { }

	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] 
	public static int StringToHash(string name) { }

	public void set_avatar(Avatar value) { }

	private void CheckIfInIKPass() { }

	private bool IsInIKPass() { }

	[FreeFunctionAttribute] 
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] 
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] 
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] 
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] 
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] 
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] 
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] 
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] 
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] 
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] 
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] 
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] 
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] 
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] 
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] 
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] 
	public void Update(float deltaTime) { }

	public bool get_logWarnings() { }

	public void set_fireEvents(bool value) { }

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

