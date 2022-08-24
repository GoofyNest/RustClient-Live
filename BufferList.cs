public struct BufferList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4795
{
	private readonly BufferList<T> list; 
	private int index; 

public T Current { get; }
private object System.Collections.IEnumerator.Current { get; }


public void .ctor(BufferList<T> list) { }
/* GenericInstMethod :
|
|-BufferList.Enumerator<FoliageKey>..ctor
|-BufferList.Enumerator<InstancingKey>..ctor
|-BufferList.Enumerator<InvokeAction>..ctor
|-BufferList.Enumerator<RendererKey>..ctor
|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>..ctor
|-BufferList.Enumerator<object>..ctor
|-BufferList.Enumerator<float>..ctor
|-BufferList.Enumerator<uint>..ctor
|-BufferList.Enumerator<ulong>..ctor
|-BufferList.Enumerator<Matrix4x4>..ctor
|-BufferList.Enumerator<ViewModelDrawEvent>..ctor
*/

public bool MoveNext() { }
/* GenericInstMethod :
|
|-BufferList.Enumerator<BasePlayer>.MoveNext
|-BufferList.Enumerator<FoliageKey>.MoveNext
|-BufferList.Enumerator<InstancingKey>.MoveNext
|-BufferList.Enumerator<InvokeAction>.MoveNext
|-BufferList.Enumerator<RendererKey>.MoveNext
|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNext
|-BufferList.Enumerator<object>.MoveNext
|-BufferList.Enumerator<float>.MoveNext
|-BufferList.Enumerator<uint>.MoveNext
|-BufferList.Enumerator<ulong>.MoveNext
|-BufferList.Enumerator<Collider>.MoveNext
|-BufferList.Enumerator<Matrix4x4>.MoveNext
|-BufferList.Enumerator<ViewModelDrawEvent>.MoveNext
*/

public void Reset() { }
/* GenericInstMethod :
|
|-BufferList.Enumerator<FoliageKey>.Reset
|-BufferList.Enumerator<InstancingKey>.Reset
|-BufferList.Enumerator<InvokeAction>.Reset
|-BufferList.Enumerator<RendererKey>.Reset
|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.Reset
|-BufferList.Enumerator<object>.Reset
|-BufferList.Enumerator<float>.Reset
|-BufferList.Enumerator<uint>.Reset
|-BufferList.Enumerator<ulong>.Reset
|-BufferList.Enumerator<Matrix4x4>.Reset
|-BufferList.Enumerator<ViewModelDrawEvent>.Reset
*/

public T get_Current() { }
/* GenericInstMethod :
|
|-BufferList.Enumerator<BasePlayer>.get_Current
|-BufferList.Enumerator<Collider>.get_Current
|-BufferList.Enumerator<FoliageKey>.get_Current
|-BufferList.Enumerator<object>.get_Current
|-BufferList.Enumerator<float>.get_Current
|-BufferList.Enumerator<uint>.get_Current
|-BufferList.Enumerator<ulong>.get_Current
|
|-BufferList.Enumerator<InstancingKey>.get_Current
|-BufferList.Enumerator<InvokeAction>.get_Current
|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
|
|-BufferList.Enumerator<RendererKey>.get_Current
|
|-BufferList.Enumerator<Matrix4x4>.get_Current
|
|-BufferList.Enumerator<ViewModelDrawEvent>.get_Current
*/

private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-BufferList.Enumerator<FoliageKey>.System.Collections.IEnumerator.get_Current
|-BufferList.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<InstancingKey>.System.Collections.IEnumerator.get_Current
|-BufferList.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<RendererKey>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<object>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<float>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<uint>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
|
|-BufferList.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
*/

public void Dispose() { }
/* GenericInstMethod :
|
|-BufferList.Enumerator<BasePlayer>.Dispose
|-BufferList.Enumerator<FoliageKey>.Dispose
|-BufferList.Enumerator<InstancingKey>.Dispose
|-BufferList.Enumerator<InvokeAction>.Dispose
|-BufferList.Enumerator<RendererKey>.Dispose
|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.Dispose
|-BufferList.Enumerator<object>.Dispose
|-BufferList.Enumerator<float>.Dispose
|-BufferList.Enumerator<uint>.Dispose
|-BufferList.Enumerator<ulong>.Dispose
|-BufferList.Enumerator<Collider>.Dispose
|-BufferList.Enumerator<Matrix4x4>.Dispose
|-BufferList.Enumerator<ViewModelDrawEvent>.Dispose
*/

}

