public struct ListHashSet.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4814
{
	private readonly BufferList<T> list;
	private int index;

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	public void .ctor(ListHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-ListHashSet.Enumerator<InvokeAction>..ctor
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>..ctor
	|-ListHashSet.Enumerator<object>..ctor
	|-ListHashSet.Enumerator<ViewModelDrawEvent>..ctor
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-ListHashSet.Enumerator<DecayEntity>.MoveNext
	|-ListHashSet.Enumerator<Gib>.MoveNext
	|-ListHashSet.Enumerator<NeedsKeyboard>.MoveNext
	|-ListHashSet.Enumerator<Group>.MoveNext
	|-ListHashSet.Enumerator<PlayerModel>.MoveNext
	|-ListHashSet.Enumerator<PositionLerp>.MoveNext
	|-ListHashSet.Enumerator<ScrollRectDisable>.MoveNext
	|-ListHashSet.Enumerator<object>.MoveNext
	|-ListHashSet.Enumerator<UIBlueprints>.MoveNext
	|-ListHashSet.Enumerator<UIChat>.MoveNext
	|-ListHashSet.Enumerator<UIEscapeCapture>.MoveNext
	|-ListHashSet.Enumerator<UI_LocalVoice>.MoveNext
	|
	|-ListHashSet.Enumerator<InvokeAction>.MoveNext
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNext
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.MoveNext
	*/

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-ListHashSet.Enumerator<InvokeAction>.Reset
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.Reset
	|-ListHashSet.Enumerator<object>.Reset
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.Reset
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-ListHashSet.Enumerator<DecayEntity>.get_Current
	|-ListHashSet.Enumerator<Gib>.get_Current
	|-ListHashSet.Enumerator<NeedsKeyboard>.get_Current
	|-ListHashSet.Enumerator<Group>.get_Current
	|-ListHashSet.Enumerator<PlayerModel>.get_Current
	|-ListHashSet.Enumerator<PositionLerp>.get_Current
	|-ListHashSet.Enumerator<ScrollRectDisable>.get_Current
	|-ListHashSet.Enumerator<UIBlueprints>.get_Current
	|-ListHashSet.Enumerator<UIChat>.get_Current
	|-ListHashSet.Enumerator<UIEscapeCapture>.get_Current
	|-ListHashSet.Enumerator<UI_LocalVoice>.get_Current
	|-ListHashSet.Enumerator<object>.get_Current
	|
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.get_Current
	|
	|-ListHashSet.Enumerator<InvokeAction>.get_Current
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-ListHashSet.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|
	|-ListHashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-ListHashSet.Enumerator<DecayEntity>.Dispose
	|-ListHashSet.Enumerator<Gib>.Dispose
	|-ListHashSet.Enumerator<InvokeAction>.Dispose
	|-ListHashSet.Enumerator<NeedsKeyboard>.Dispose
	|-ListHashSet.Enumerator<Group>.Dispose
	|-ListHashSet.Enumerator<PlayerModel>.Dispose
	|-ListHashSet.Enumerator<PositionLerp>.Dispose
	|-ListHashSet.Enumerator<ScrollRectDisable>.Dispose
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.Dispose
	|-ListHashSet.Enumerator<object>.Dispose
	|-ListHashSet.Enumerator<UIBlueprints>.Dispose
	|-ListHashSet.Enumerator<UIChat>.Dispose
	|-ListHashSet.Enumerator<UIEscapeCapture>.Dispose
	|-ListHashSet.Enumerator<UI_LocalVoice>.Dispose
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.Dispose
	*/

}

