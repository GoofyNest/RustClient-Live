public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 3325
{	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E4C0 Offset: 0x20D8C0 VA: 0x18020E4C0
	|-NativeArray.Enumerator<BoneData>..ctor
	|-NativeArray.Enumerator<BoneState>..ctor
	|-NativeArray.Enumerator<ColliderData>..ctor
	|-NativeArray.Enumerator<ColliderState>..ctor
	|-NativeArray.Enumerator<byte>..ctor
	|-NativeArray.Enumerator<int>..ctor
	|-NativeArray.Enumerator<float>..ctor
	|-NativeArray.Enumerator<uint>..ctor
	|-NativeArray.Enumerator<JobHandle>..ctor
	|-NativeArray.Enumerator<float3>..ctor
	|-NativeArray.Enumerator<half2>..ctor
	|-NativeArray.Enumerator<Color32>..ctor
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|-NativeArray.Enumerator<Plane>..ctor
	|-NativeArray.Enumerator<RaycastCommand>..ctor
	|-NativeArray.Enumerator<RaycastHit>..ctor
	|-NativeArray.Enumerator<BatchVisibility>..ctor
	|-NativeArray.Enumerator<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	|-NativeArray.Enumerator<BoneData>.Dispose
	|-NativeArray.Enumerator<BoneState>.Dispose
	|-NativeArray.Enumerator<ColliderData>.Dispose
	|-NativeArray.Enumerator<ColliderState>.Dispose
	|-NativeArray.Enumerator<byte>.Dispose
	|-NativeArray.Enumerator<int>.Dispose
	|-NativeArray.Enumerator<float>.Dispose
	|-NativeArray.Enumerator<uint>.Dispose
	|-NativeArray.Enumerator<JobHandle>.Dispose
	|-NativeArray.Enumerator<float3>.Dispose
	|-NativeArray.Enumerator<half2>.Dispose
	|-NativeArray.Enumerator<Color32>.Dispose
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|-NativeArray.Enumerator<Plane>.Dispose
	|-NativeArray.Enumerator<RaycastCommand>.Dispose
	|-NativeArray.Enumerator<RaycastHit>.Dispose
	|-NativeArray.Enumerator<BatchVisibility>.Dispose
	|-NativeArray.Enumerator<Vector4>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20DCC0 Offset: 0x20D0C0 VA: 0x18020DCC0
	|-NativeArray.Enumerator<BoneData>.MoveNext
	|-NativeArray.Enumerator<BoneState>.MoveNext
	|-NativeArray.Enumerator<ColliderData>.MoveNext
	|-NativeArray.Enumerator<ColliderState>.MoveNext
	|-NativeArray.Enumerator<byte>.MoveNext
	|-NativeArray.Enumerator<int>.MoveNext
	|-NativeArray.Enumerator<float>.MoveNext
	|-NativeArray.Enumerator<uint>.MoveNext
	|-NativeArray.Enumerator<JobHandle>.MoveNext
	|-NativeArray.Enumerator<float3>.MoveNext
	|-NativeArray.Enumerator<half2>.MoveNext
	|-NativeArray.Enumerator<Color32>.MoveNext
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|-NativeArray.Enumerator<Plane>.MoveNext
	|-NativeArray.Enumerator<RaycastCommand>.MoveNext
	|-NativeArray.Enumerator<RaycastHit>.MoveNext
	|-NativeArray.Enumerator<BatchVisibility>.MoveNext
	|-NativeArray.Enumerator<Vector4>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20DCD0 Offset: 0x20D0D0 VA: 0x18020DCD0
	|-NativeArray.Enumerator<BoneData>.Reset
	|-NativeArray.Enumerator<BoneState>.Reset
	|-NativeArray.Enumerator<ColliderData>.Reset
	|-NativeArray.Enumerator<ColliderState>.Reset
	|-NativeArray.Enumerator<byte>.Reset
	|-NativeArray.Enumerator<int>.Reset
	|-NativeArray.Enumerator<float>.Reset
	|-NativeArray.Enumerator<uint>.Reset
	|-NativeArray.Enumerator<JobHandle>.Reset
	|-NativeArray.Enumerator<float3>.Reset
	|-NativeArray.Enumerator<half2>.Reset
	|-NativeArray.Enumerator<Color32>.Reset
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|-NativeArray.Enumerator<Plane>.Reset
	|-NativeArray.Enumerator<RaycastCommand>.Reset
	|-NativeArray.Enumerator<RaycastHit>.Reset
	|-NativeArray.Enumerator<BatchVisibility>.Reset
	|-NativeArray.Enumerator<Vector4>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E690 Offset: 0x20DA90 VA: 0x18020E690
	|-NativeArray.Enumerator<BoneData>.get_Current
	|
	|-RVA: 0x20E560 Offset: 0x20D960 VA: 0x18020E560
	|-NativeArray.Enumerator<BoneState>.get_Current
	|
	|-RVA: 0x20E4E0 Offset: 0x20D8E0 VA: 0x18020E4E0
	|-NativeArray.Enumerator<ColliderData>.get_Current
	|
	|-RVA: 0x20E660 Offset: 0x20DA60 VA: 0x18020E660
	|-NativeArray.Enumerator<ColliderState>.get_Current
	|
	|-RVA: 0x20E6F0 Offset: 0x20DAF0 VA: 0x18020E6F0
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x20E4D0 Offset: 0x20D8D0 VA: 0x18020E4D0
	|-NativeArray.Enumerator<int>.get_Current
	|-NativeArray.Enumerator<uint>.get_Current
	|-NativeArray.Enumerator<half2>.get_Current
	|-NativeArray.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x20E5C0 Offset: 0x20D9C0 VA: 0x18020E5C0
	|-NativeArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x20E5D0 Offset: 0x20D9D0 VA: 0x18020E5D0
	|-NativeArray.Enumerator<JobHandle>.get_Current
	|-NativeArray.Enumerator<Plane>.get_Current
	|-NativeArray.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x20E590 Offset: 0x20D990 VA: 0x18020E590
	|-NativeArray.Enumerator<float3>.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x20E510 Offset: 0x20D910 VA: 0x18020E510
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x20E5F0 Offset: 0x20D9F0 VA: 0x18020E5F0
	|-NativeArray.Enumerator<RaycastCommand>.get_Current
	|
	|-RVA: 0x20E620 Offset: 0x20DA20 VA: 0x18020E620
	|-NativeArray.Enumerator<RaycastHit>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E1F0 Offset: 0x20D5F0 VA: 0x18020E1F0
	|-NativeArray.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DEA0 Offset: 0x20D2A0 VA: 0x18020DEA0
	|-NativeArray.Enumerator<BoneState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E380 Offset: 0x20D780 VA: 0x18020E380
	|-NativeArray.Enumerator<ColliderData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DD70 Offset: 0x20D170 VA: 0x18020DD70
	|-NativeArray.Enumerator<ColliderState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DE10 Offset: 0x20D210 VA: 0x18020DE10
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E090 Offset: 0x20D490 VA: 0x18020E090
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<half2>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E430 Offset: 0x20D830 VA: 0x18020E430
	|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DCE0 Offset: 0x20D0E0 VA: 0x18020DCE0
	|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DF50 Offset: 0x20D350 VA: 0x18020DF50
	|-NativeArray.Enumerator<float3>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E120 Offset: 0x20D520 VA: 0x18020E120
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DFF0 Offset: 0x20D3F0 VA: 0x18020DFF0
	|-NativeArray.Enumerator<RaycastCommand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E2D0 Offset: 0x20D6D0 VA: 0x18020E2D0
	|-NativeArray.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	*/

}

