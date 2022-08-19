public class Transform : Component, IEnumerable // TypeDefIndex: 3569
{	// Properties
	public Vector3 position { get; set; }
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

	// Methods

	// RVA: 0x18F27E0 Offset: 0x18F1BE0 VA: 0x1818F27E0
	protected void .ctor() { }

	// RVA: 0x217A560 Offset: 0x2179960 VA: 0x18217A560
	public Vector3 get_position() { }

	// RVA: 0x217AEE0 Offset: 0x217A2E0 VA: 0x18217AEE0
	public void set_position(Vector3 value) { }

	// RVA: 0x217A230 Offset: 0x2179630 VA: 0x18217A230
	public Vector3 get_localPosition() { }

	// RVA: 0x217AC50 Offset: 0x217A050 VA: 0x18217AC50
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x2179F30 Offset: 0x2179330 VA: 0x182179F30
	public Vector3 get_eulerAngles() { }

	// RVA: 0x217A9A0 Offset: 0x2179DA0 VA: 0x18217A9A0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x217A150 Offset: 0x2179550 VA: 0x18217A150
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x217AB50 Offset: 0x2179F50 VA: 0x18217AB50
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x217A5B0 Offset: 0x21799B0 VA: 0x18217A5B0
	public Vector3 get_right() { }

	// RVA: 0x217AF30 Offset: 0x217A330 VA: 0x18217AF30
	public void set_right(Vector3 value) { }

	// RVA: 0x217A7A0 Offset: 0x2179BA0 VA: 0x18217A7A0
	public Vector3 get_up() { }

	// RVA: 0x217B120 Offset: 0x217A520 VA: 0x18217B120
	public void set_up(Vector3 value) { }

	// RVA: 0x2179FC0 Offset: 0x21793C0 VA: 0x182179FC0
	public Vector3 get_forward() { }

	// RVA: 0x217AA50 Offset: 0x2179E50 VA: 0x18217AA50
	public void set_forward(Vector3 value) { }

	// RVA: 0x217A750 Offset: 0x2179B50 VA: 0x18217A750
	public Quaternion get_rotation() { }

	// RVA: 0x217B0D0 Offset: 0x217A4D0 VA: 0x18217B0D0
	public void set_rotation(Quaternion value) { }

	// RVA: 0x217A2D0 Offset: 0x21796D0 VA: 0x18217A2D0
	public Quaternion get_localRotation() { }

	// RVA: 0x217ACF0 Offset: 0x217A0F0 VA: 0x18217ACF0
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x217A370 Offset: 0x2179770 VA: 0x18217A370
	public Vector3 get_localScale() { }

	// RVA: 0x217AD90 Offset: 0x217A190 VA: 0x18217AD90
	public void set_localScale(Vector3 value) { }

	// RVA: 0x2178950 Offset: 0x2177D50 VA: 0x182178950
	public Transform get_parent() { }

	// RVA: 0x217ADE0 Offset: 0x217A1E0 VA: 0x18217ADE0
	public void set_parent(Transform value) { }

	// RVA: 0x2178950 Offset: 0x2177D50 VA: 0x182178950
	internal Transform get_parentInternal() { }

	// RVA: 0x2179930 Offset: 0x2178D30 VA: 0x182179930
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x2178950 Offset: 0x2177D50 VA: 0x182178950
	private Transform GetParent() { }

	// RVA: 0x2179930 Offset: 0x2178D30 VA: 0x182179930
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD0CC0 Offset: 0xD00C0 VA: 0x1800D0CC0
	// RVA: 0x21798D0 Offset: 0x2178CD0 VA: 0x1821798D0
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x217A940 Offset: 0x2179D40 VA: 0x18217A940
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x217A410 Offset: 0x2179810 VA: 0x18217A410
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x21799E0 Offset: 0x2178DE0 VA: 0x1821799E0
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2179D20 Offset: 0x2179120 VA: 0x182179D20
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x2179CC0 Offset: 0x21790C0 VA: 0x182179CC0
	public void Translate(Vector3 translation) { }

	// RVA: 0x2179CF0 Offset: 0x21790F0 VA: 0x182179CF0
	public void Translate(float x, float y, float z) { }

	// RVA: 0x2179340 Offset: 0x2178740 VA: 0x182179340
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x2179600 Offset: 0x2178A00 VA: 0x182179600
	public void Rotate(Vector3 eulers) { }

	[NativeMethodAttribute] // RVA: 0xD0F60 Offset: 0xD0360 VA: 0x1800D0F60
	// RVA: 0x21790A0 Offset: 0x21784A0 VA: 0x1821790A0
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x2179710 Offset: 0x2178B10 VA: 0x182179710
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x2179630 Offset: 0x2178A30 VA: 0x182179630
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x2179100 Offset: 0x2178500 VA: 0x182179100
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x2178ED0 Offset: 0x21782D0 VA: 0x182178ED0
	public void LookAt(Transform target) { }

	// RVA: 0x2178D60 Offset: 0x2178160 VA: 0x182178D60
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2178DD0 Offset: 0x21781D0 VA: 0x182178DD0
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD1200 Offset: 0xD0600 VA: 0x1800D1200
	// RVA: 0x2178A70 Offset: 0x2177E70 VA: 0x182178A70
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2179AE0 Offset: 0x2178EE0 VA: 0x182179AE0
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x2178B30 Offset: 0x2177F30 VA: 0x182178B30
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x2179C60 Offset: 0x2179060 VA: 0x182179C60
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x2178CB0 Offset: 0x21780B0 VA: 0x182178CB0
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x2179BA0 Offset: 0x2178FA0 VA: 0x182179BA0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x2178BF0 Offset: 0x2177FF0 VA: 0x182178BF0
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x2178990 Offset: 0x2177D90 VA: 0x182178990
	public Transform get_root() { }

	// RVA: 0x2178990 Offset: 0x2177D90 VA: 0x182178990
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD1330 Offset: 0xD0730 VA: 0x1800D1330
	// RVA: 0x2179EF0 Offset: 0x21792F0 VA: 0x182179EF0
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD13B0 Offset: 0xD07B0 VA: 0x1800D13B0
	// RVA: 0x2178760 Offset: 0x2177B60 VA: 0x182178760
	public void DetachChildren() { }

	// RVA: 0x2179850 Offset: 0x2178C50 VA: 0x182179850
	public void SetAsFirstSibling() { }

	// RVA: 0x2179890 Offset: 0x2178C90 VA: 0x182179890
	public void SetAsLastSibling() { }

	// RVA: 0x2179A40 Offset: 0x2178E40 VA: 0x182179A40
	public void SetSiblingIndex(int index) { }

	// RVA: 0x21789D0 Offset: 0x2177DD0 VA: 0x1821789D0
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x21787A0 Offset: 0x2177BA0 VA: 0x1821787A0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x2178800 Offset: 0x2177C00 VA: 0x182178800
	public Transform Find(string n) { }

	[NativeMethodAttribute] // RVA: 0xD1530 Offset: 0xD0930 VA: 0x1800D1530
	// RVA: 0x217A4C0 Offset: 0x21798C0 VA: 0x18217A4C0
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD1650 Offset: 0xD0A50 VA: 0x1800D1650
	// RVA: 0x2178D10 Offset: 0x2178110 VA: 0x182178D10
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x217A110 Offset: 0x2179510 VA: 0x18217A110
	public bool get_hasChanged() { }

	// RVA: 0x217AB00 Offset: 0x2179F00 VA: 0x18217AB00
	public void set_hasChanged(bool value) { }

	// RVA: 0x21788E0 Offset: 0x2177CE0 VA: 0x1821788E0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0xD18D0 Offset: 0xD0CD0 VA: 0x1800D18D0
	[NativeThrowsAttribute] // RVA: 0xD18D0 Offset: 0xD0CD0 VA: 0x1800D18D0
	// RVA: 0x21788A0 Offset: 0x2177CA0 VA: 0x1821788A0
	public Transform GetChild(int index) { }

	// RVA: 0x217A510 Offset: 0x2179910 VA: 0x18217A510
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x217AE90 Offset: 0x217A290 VA: 0x18217AE90
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x217A1E0 Offset: 0x21795E0 VA: 0x18217A1E0
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x217AC00 Offset: 0x217A000 VA: 0x18217AC00
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x217A700 Offset: 0x2179B00 VA: 0x18217A700
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x217B080 Offset: 0x217A480 VA: 0x18217B080
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x217A280 Offset: 0x2179680 VA: 0x18217A280
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x217ACA0 Offset: 0x217A0A0 VA: 0x18217ACA0
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x217A320 Offset: 0x2179720 VA: 0x18217A320
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x217AD40 Offset: 0x217A140 VA: 0x18217AD40
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x217A8F0 Offset: 0x2179CF0 VA: 0x18217A8F0
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217A3C0 Offset: 0x21797C0 VA: 0x18217A3C0
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2179980 Offset: 0x2178D80 VA: 0x182179980
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x2179040 Offset: 0x2178440 VA: 0x182179040
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x2178A10 Offset: 0x2177E10 VA: 0x182178A10
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x2179A80 Offset: 0x2178E80 VA: 0x182179A80
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2178AD0 Offset: 0x2177ED0 VA: 0x182178AD0
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2179C00 Offset: 0x2179000 VA: 0x182179C00
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2178C50 Offset: 0x2178050 VA: 0x182178C50
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2179B40 Offset: 0x2178F40 VA: 0x182179B40
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2178B90 Offset: 0x2177F90 VA: 0x182178B90
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217A470 Offset: 0x2179870 VA: 0x18217A470
	private void get_lossyScale_Injected(out Vector3 ret) { }

}

private class Transform.Enumerator : IEnumerator // TypeDefIndex: 3570
{	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B44A0 Offset: 0x11B38A0 VA: 0x1811B44A0
	internal void .ctor(Transform outer) { }

	// RVA: 0x2172C30 Offset: 0x2172030 VA: 0x182172C30 Slot: 5
	public object get_Current() { }

	// RVA: 0x2172BD0 Offset: 0x2171FD0 VA: 0x182172BD0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1176E50 Offset: 0x1176250 VA: 0x181176E50 Slot: 6
	public void Reset() { }

}

