public class Animator : Behaviour // TypeDefIndex: 4487
{	// Properties
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

	// Methods

	[NativeMethodAttribute] // RVA: 0xCA2D0 Offset: 0xC96D0 VA: 0x1800CA2D0
	// RVA: 0x22D7BE0 Offset: 0x22D6FE0 VA: 0x1822D7BE0
	public bool get_isInitialized() { }

	// RVA: 0x22D6BA0 Offset: 0x22D5FA0 VA: 0x1822D6BA0
	public float GetFloat(string name) { }

	// RVA: 0x22D6B60 Offset: 0x22D5F60 VA: 0x1822D6B60
	public float GetFloat(int id) { }

	// RVA: 0x22D7310 Offset: 0x22D6710 VA: 0x1822D7310
	public void SetFloat(string name, float value) { }

	// RVA: 0x22D72A0 Offset: 0x22D66A0 VA: 0x1822D72A0
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22D7250 Offset: 0x22D6650 VA: 0x1822D7250
	public void SetFloat(int id, float value) { }

	// RVA: 0x22D71F0 Offset: 0x22D65F0 VA: 0x1822D71F0
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22D6A40 Offset: 0x22D5E40 VA: 0x1822D6A40
	public bool GetBool(int id) { }

	// RVA: 0x22D7190 Offset: 0x22D6590 VA: 0x1822D7190
	public void SetBool(string name, bool value) { }

	// RVA: 0x22D7130 Offset: 0x22D6530 VA: 0x1822D7130
	public void SetBool(int id, bool value) { }

	// RVA: 0x22D6C80 Offset: 0x22D6080 VA: 0x1822D6C80
	public int GetInteger(string name) { }

	// RVA: 0x22D7740 Offset: 0x22D6B40 VA: 0x1822D7740
	public void SetInteger(string name, int value) { }

	// RVA: 0x22D76F0 Offset: 0x22D6AF0 VA: 0x1822D76F0
	public void SetInteger(int id, int value) { }

	// RVA: 0x22D7A80 Offset: 0x22D6E80 VA: 0x1822D7A80
	public void SetTrigger(string name) { }

	// RVA: 0x22D7A40 Offset: 0x22D6E40 VA: 0x1822D7A40
	public void SetTrigger(int id) { }

	// RVA: 0x22D70E0 Offset: 0x22D64E0 VA: 0x1822D70E0
	public void ResetTrigger(string name) { }

	// RVA: 0x22D70A0 Offset: 0x22D64A0 VA: 0x1822D70A0
	public void ResetTrigger(int id) { }

	// RVA: 0x22D7CE0 Offset: 0x22D70E0 VA: 0x1822D7CE0
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x22D7EB0 Offset: 0x22D72B0 VA: 0x1822D7EB0
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x22D75B0 Offset: 0x22D69B0 VA: 0x1822D75B0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22D73C0 Offset: 0x22D67C0 VA: 0x1822D73C0
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22D7680 Offset: 0x22D6A80 VA: 0x1822D7680
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22D7460 Offset: 0x22D6860 VA: 0x1822D7460
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22D6C30 Offset: 0x22D6030 VA: 0x1822D6C30
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x22D6BF0 Offset: 0x22D5FF0 VA: 0x1822D6BF0
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x22D7550 Offset: 0x22D6950 VA: 0x1822D7550
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22D74B0 Offset: 0x22D68B0 VA: 0x1822D74B0
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x22D7620 Offset: 0x22D6A20 VA: 0x1822D7620
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22D7500 Offset: 0x22D6900 VA: 0x1822D7500
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x22D7890 Offset: 0x22D6C90 VA: 0x1822D7890
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA440 Offset: 0xC9840 VA: 0x1800CA440
	// RVA: 0x22D7840 Offset: 0x22D6C40 VA: 0x1822D7840
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x22D7960 Offset: 0x22D6D60 VA: 0x1822D7960
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x22D79D0 Offset: 0x22D6DD0 VA: 0x1822D79D0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA830 Offset: 0xC9C30 VA: 0x1800CA830
	// RVA: 0x22D78F0 Offset: 0x22D6CF0 VA: 0x1822D78F0
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x22D7C20 Offset: 0x22D7020 VA: 0x1822D7C20
	public int get_layerCount() { }

	// RVA: 0x22D6CD0 Offset: 0x22D60D0 VA: 0x1822D6CD0
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x22D6D20 Offset: 0x22D6120 VA: 0x1822D6D20
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x22D77A0 Offset: 0x22D6BA0 VA: 0x1822D77A0
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x22D69E0 Offset: 0x22D5DE0 VA: 0x1822D69E0
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22D6AC0 Offset: 0x22D5EC0 VA: 0x1822D6AC0
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x22D6DA0 Offset: 0x22D61A0 VA: 0x1822D6DA0
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCA8E0 Offset: 0xC9CE0 VA: 0x1800CA8E0
	// RVA: 0x22D6A80 Offset: 0x22D5E80 VA: 0x1822D6A80
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAAC0 Offset: 0xC9EC0 VA: 0x1800CAAC0
	// RVA: 0x22D6D60 Offset: 0x22D6160 VA: 0x1822D6D60
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x22D6ED0 Offset: 0x22D62D0 VA: 0x1822D6ED0
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x22D7E60 Offset: 0x22D7260 VA: 0x1822D7E60
	public void set_speed(float value) { }

	// RVA: 0x22D67F0 Offset: 0x22D5BF0 VA: 0x1822D67F0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22D66D0 Offset: 0x22D5AD0 VA: 0x1822D66D0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22D6950 Offset: 0x22D5D50 VA: 0x1822D6950
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCADA0 Offset: 0xCA1A0 VA: 0x1800CADA0
	// RVA: 0x22D6880 Offset: 0x22D5C80 VA: 0x1822D6880
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x22D68E0 Offset: 0x22D5CE0 VA: 0x1822D68E0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22D6770 Offset: 0x22D5B70 VA: 0x1822D6770
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22D7080 Offset: 0x22D6480 VA: 0x1822D7080
	public void Play(string stateName, int layer) { }

	// RVA: 0x22D7000 Offset: 0x22D6400 VA: 0x1822D7000
	public void Play(string stateName) { }

	// RVA: 0x22D6F10 Offset: 0x22D6310 VA: 0x1822D6F10
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB110 Offset: 0xCA510 VA: 0x1800CB110
	// RVA: 0x22D6FA0 Offset: 0x22D63A0 VA: 0x1822D6FA0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22D7030 Offset: 0x22D6430 VA: 0x1822D7030
	public void Play(int stateNameHash) { }

	// RVA: 0x22D7B60 Offset: 0x22D6F60 VA: 0x1822D7B60
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x22D7D80 Offset: 0x22D7180 VA: 0x1822D7D80
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x22D7CA0 Offset: 0x22D70A0 VA: 0x1822D7CA0
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x22D7E10 Offset: 0x22D7210 VA: 0x1822D7E10
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB380 Offset: 0xCA780 VA: 0x1800CB380
	// RVA: 0x22D7BA0 Offset: 0x22D6FA0 VA: 0x1822D7BA0
	public bool get_hasBoundPlayables() { }

	// RVA: 0x22D6E40 Offset: 0x22D6240 VA: 0x1822D6E40
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB510 Offset: 0xCA910 VA: 0x1800CB510
	// RVA: 0x22D7AD0 Offset: 0x22D6ED0 VA: 0x1822D7AD0
	public static int StringToHash(string name) { }

	// RVA: 0x22D7D30 Offset: 0x22D7130 VA: 0x1822D7D30
	public void set_avatar(Avatar value) { }

	// RVA: 0x22D6620 Offset: 0x22D5A20 VA: 0x1822D6620
	private void CheckIfInIKPass() { }

	// RVA: 0x22D6E90 Offset: 0x22D6290 VA: 0x1822D6E90
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB7C0 Offset: 0xCABC0 VA: 0x1800CB7C0
	// RVA: 0x22D7310 Offset: 0x22D6710 VA: 0x1822D7310
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBA40 Offset: 0xCAE40 VA: 0x1800CBA40
	// RVA: 0x22D7250 Offset: 0x22D6650 VA: 0x1822D7250
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBB80 Offset: 0xCAF80 VA: 0x1800CBB80
	// RVA: 0x22D6BA0 Offset: 0x22D5FA0 VA: 0x1822D6BA0
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBCB0 Offset: 0xCB0B0 VA: 0x1800CBCB0
	// RVA: 0x22D6B60 Offset: 0x22D5F60 VA: 0x1822D6B60
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBD20 Offset: 0xCB120 VA: 0x1800CBD20
	// RVA: 0x22D7190 Offset: 0x22D6590 VA: 0x1822D7190
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBDF0 Offset: 0xCB1F0 VA: 0x1800CBDF0
	// RVA: 0x22D7130 Offset: 0x22D6530 VA: 0x1822D7130
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	// RVA: 0x22D6A40 Offset: 0x22D5E40 VA: 0x1822D6A40
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC110 Offset: 0xCB510 VA: 0x1800CC110
	// RVA: 0x22D7740 Offset: 0x22D6B40 VA: 0x1822D7740
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC2B0 Offset: 0xCB6B0 VA: 0x1800CC2B0
	// RVA: 0x22D76F0 Offset: 0x22D6AF0 VA: 0x1822D76F0
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC370 Offset: 0xCB770 VA: 0x1800CC370
	// RVA: 0x22D6C80 Offset: 0x22D6080 VA: 0x1822D6C80
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC5B0 Offset: 0xCB9B0 VA: 0x1800CC5B0
	// RVA: 0x22D7A80 Offset: 0x22D6E80 VA: 0x1822D7A80
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC640 Offset: 0xCBA40 VA: 0x1800CC640
	// RVA: 0x22D7A40 Offset: 0x22D6E40 VA: 0x1822D7A40
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC7D0 Offset: 0xCBBD0 VA: 0x1800CC7D0
	// RVA: 0x22D70E0 Offset: 0x22D64E0 VA: 0x1822D70E0
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC930 Offset: 0xCBD30 VA: 0x1800CC930
	// RVA: 0x22D70A0 Offset: 0x22D64A0 VA: 0x1822D70A0
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCAA0 Offset: 0xCBEA0 VA: 0x1800CCAA0
	// RVA: 0x22D72A0 Offset: 0x22D66A0 VA: 0x1822D72A0
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCC80 Offset: 0xCC080 VA: 0x1800CCC80
	// RVA: 0x22D71F0 Offset: 0x22D65F0 VA: 0x1822D71F0
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCD10 Offset: 0xCC110 VA: 0x1800CCD10
	// RVA: 0x22D7B10 Offset: 0x22D6F10 VA: 0x1822D7B10
	public void Update(float deltaTime) { }

	// RVA: 0x22D7C60 Offset: 0x22D7060 VA: 0x1822D7C60
	public bool get_logWarnings() { }

	// RVA: 0x22D7DC0 Offset: 0x22D71C0 VA: 0x1822D7DC0
	public void set_fireEvents(bool value) { }

	// RVA: 0x22D7370 Offset: 0x22D6770 VA: 0x1822D7370
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x22D7410 Offset: 0x22D6810 VA: 0x1822D7410
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x22D77F0 Offset: 0x22D6BF0 VA: 0x1822D77F0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

