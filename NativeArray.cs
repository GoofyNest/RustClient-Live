public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 3325
{
	private NativeArray<T> m_Array; 
	private int m_Index; 

public T Current { get; }
private object System.Collections.IEnumerator.Current { get; }


public void .ctor(ref NativeArray<T> array) { }
/* GenericInstMethod :
|
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

public void Dispose() { }
/* GenericInstMethod :
|
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

public bool MoveNext() { }
/* GenericInstMethod :
|
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

public void Reset() { }
/* GenericInstMethod :
|
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

public T get_Current() { }
/* GenericInstMethod :
|
|-NativeArray.Enumerator<BoneData>.get_Current
|
|-NativeArray.Enumerator<BoneState>.get_Current
|
|-NativeArray.Enumerator<ColliderData>.get_Current
|
|-NativeArray.Enumerator<ColliderState>.get_Current
|
|-NativeArray.Enumerator<byte>.get_Current
|
|-NativeArray.Enumerator<int>.get_Current
|-NativeArray.Enumerator<uint>.get_Current
|-NativeArray.Enumerator<half2>.get_Current
|-NativeArray.Enumerator<Color32>.get_Current
|
|-NativeArray.Enumerator<float>.get_Current
|
|-NativeArray.Enumerator<JobHandle>.get_Current
|-NativeArray.Enumerator<Plane>.get_Current
|-NativeArray.Enumerator<Vector4>.get_Current
|
|-NativeArray.Enumerator<float3>.get_Current
|-NativeArray.Enumerator<BatchVisibility>.get_Current
|
|-NativeArray.Enumerator<LightDataGI>.get_Current
|
|-NativeArray.Enumerator<RaycastCommand>.get_Current
|
|-NativeArray.Enumerator<RaycastHit>.get_Current
*/

private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-NativeArray.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<BoneState>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<ColliderData>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<ColliderState>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
|-NativeArray.Enumerator<half2>.System.Collections.IEnumerator.get_Current
|-NativeArray.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<float3>.System.Collections.IEnumerator.get_Current
|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<RaycastCommand>.System.Collections.IEnumerator.get_Current
|
|-NativeArray.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
*/

}

