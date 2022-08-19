public struct BufferList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4795
{	// Fields
	private readonly BufferList<T> list; // 0x0
	private int index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F5390 Offset: 0x1F4790 VA: 0x1801F5390
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

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4DA0 Offset: 0x1F41A0 VA: 0x1801F4DA0
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

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4E40 Offset: 0x1F4240 VA: 0x1801F4E40
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

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F53C0 Offset: 0x1F47C0 VA: 0x1801F53C0
	|-BufferList.Enumerator<BasePlayer>.get_Current
	|-BufferList.Enumerator<Collider>.get_Current
	|-BufferList.Enumerator<FoliageKey>.get_Current
	|-BufferList.Enumerator<object>.get_Current
	|-BufferList.Enumerator<float>.get_Current
	|-BufferList.Enumerator<uint>.get_Current
	|-BufferList.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x1F53D0 Offset: 0x1F47D0 VA: 0x1801F53D0
	|-BufferList.Enumerator<InstancingKey>.get_Current
	|-BufferList.Enumerator<InvokeAction>.get_Current
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	|
	|-RVA: 0x1F53F0 Offset: 0x1F47F0 VA: 0x1801F53F0
	|-BufferList.Enumerator<RendererKey>.get_Current
	|
	|-RVA: 0x1F5430 Offset: 0x1F4830 VA: 0x1801F5430
	|-BufferList.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x1F5410 Offset: 0x1F4810 VA: 0x1801F5410
	|-BufferList.Enumerator<ViewModelDrawEvent>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4E50 Offset: 0x1F4250 VA: 0x1801F4E50
	|-BufferList.Enumerator<FoliageKey>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F4EF0 Offset: 0x1F42F0 VA: 0x1801F4EF0
	|-BufferList.Enumerator<InstancingKey>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F50E0 Offset: 0x1F44E0 VA: 0x1801F50E0
	|-BufferList.Enumerator<RendererKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F51F0 Offset: 0x1F45F0 VA: 0x1801F51F0
	|-BufferList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5230 Offset: 0x1F4630 VA: 0x1801F5230
	|-BufferList.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F4FA0 Offset: 0x1F43A0 VA: 0x1801F4FA0
	|-BufferList.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F52D0 Offset: 0x1F46D0 VA: 0x1801F52D0
	|-BufferList.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5030 Offset: 0x1F4430 VA: 0x1801F5030
	|-BufferList.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
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

