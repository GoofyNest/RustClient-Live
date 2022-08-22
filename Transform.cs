public class Transform : Component, IEnumerable // TypeDefIndex: 3569
{	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; set; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativePropertyAttribute] // RVA: 0xD19F0 Offset: 0xD0DF0 VA: 0x1800D19F0
	public bool hasChanged { get; set; }


	protected void .ctor() { }

	public Vector3 get_position() { }

	public void set_position(Vector3 value) { }

	public Vector3 get_localPosition() { }

	public void set_localPosition(Vector3 value) { }

	public Vector3 get_eulerAngles() { }

	public void set_eulerAngles(Vector3 value) { }

	public Vector3 get_localEulerAngles() { }

	public void set_localEulerAngles(Vector3 value) { }

	public Vector3 get_right() { }

	public void set_right(Vector3 value) { }

	public Vector3 get_up() { }

	public void set_up(Vector3 value) { }

	public Vector3 get_forward() { }

	public void set_forward(Vector3 value) { }

	public Quaternion get_rotation() { }

	public void set_rotation(Quaternion value) { }

	public Quaternion get_localRotation() { }

	public void set_localRotation(Quaternion value) { }

	public Vector3 get_localScale() { }

	public void set_localScale(Vector3 value) { }

	public Transform get_parent() { }

	public void set_parent(Transform value) { }

	internal Transform get_parentInternal() { }

	internal void set_parentInternal(Transform value) { }

	private Transform GetParent() { }

	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD0CC0 Offset: 0xD00C0 VA: 0x1800D0CC0
	public void SetParent(Transform parent, bool worldPositionStays) { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	public Matrix4x4 get_localToWorldMatrix() { }

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	public void Translate(Vector3 translation, Space relativeTo) { }

	public void Translate(Vector3 translation) { }

	public void Translate(float x, float y, float z) { }

	public void Rotate(Vector3 eulers, Space relativeTo) { }

	public void Rotate(Vector3 eulers) { }

	[NativeMethodAttribute] // RVA: 0xD0F60 Offset: 0xD0360 VA: 0x1800D0F60
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	public void Rotate(Vector3 axis, float angle) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	public void LookAt(Transform target) { }

	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD1200 Offset: 0xD0600 VA: 0x1800D1200
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 TransformVector(Vector3 vector) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	public Vector3 TransformPoint(Vector3 position) { }

	public Vector3 InverseTransformPoint(Vector3 position) { }

	public Transform get_root() { }

	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD1330 Offset: 0xD0730 VA: 0x1800D1330
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD13B0 Offset: 0xD07B0 VA: 0x1800D13B0
	public void DetachChildren() { }

	public void SetAsFirstSibling() { }

	public void SetAsLastSibling() { }

	public void SetSiblingIndex(int index) { }

	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	public Transform Find(string n) { }

	[NativeMethodAttribute] // RVA: 0xD1530 Offset: 0xD0930 VA: 0x1800D1530
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD1650 Offset: 0xD0A50 VA: 0x1800D1650
	public bool IsChildOf(Transform parent) { }

	public bool get_hasChanged() { }

	public void set_hasChanged(bool value) { }

	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0xD18D0 Offset: 0xD0CD0 VA: 0x1800D18D0
	[NativeThrowsAttribute] // RVA: 0xD18D0 Offset: 0xD0CD0 VA: 0x1800D18D0
	public Transform GetChild(int index) { }

	private void get_position_Injected(out Vector3 ret) { }

	private void set_position_Injected(ref Vector3 value) { }

	private void get_localPosition_Injected(out Vector3 ret) { }

	private void set_localPosition_Injected(ref Vector3 value) { }

	private void get_rotation_Injected(out Quaternion ret) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	private void get_localRotation_Injected(out Quaternion ret) { }

	private void set_localRotation_Injected(ref Quaternion value) { }

	private void get_localScale_Injected(out Vector3 ret) { }

	private void set_localScale_Injected(ref Vector3 value) { }

	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	private void get_lossyScale_Injected(out Vector3 ret) { }

}

private class Transform.Enumerator : IEnumerator // TypeDefIndex: 3570
{	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	public object Current { get; }


	internal void .ctor(Transform outer) { }

	public object get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

}

