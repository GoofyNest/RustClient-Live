internal struct HashSet.Slot<T> // TypeDefIndex: 3255
{
	internal int hashCode;
	internal int next;
	internal T value;

}

public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3256
{
	private HashSet<T> _set;
	private int _index;
	private int _version;
	private T _current;

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-HashSet.Enumerator<Connection>..ctor
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|
	|-HashSet.Enumerator<object>..ctor
	|-HashSet.Enumerator<ulong>..ctor
	|
	|-HashSet.Enumerator<Vector3>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-HashSet.Enumerator<AICoverPoint>.Dispose
	|-HashSet.Enumerator<AIMovePoint>.Dispose
	|-HashSet.Enumerator<AmbienceEmitter>.Dispose
	|-HashSet.Enumerator<AtmosphereVolume>.Dispose
	|-HashSet.Enumerator<BaseEntity>.Dispose
	|-HashSet.Enumerator<DeferredMeshDecal>.Dispose
	|-HashSet.Enumerator<Impostor>.Dispose
	|-HashSet.Enumerator<ImpostorShadows>.Dispose
	|-HashSet.Enumerator<LODComponent>.Dispose
	|-HashSet.Enumerator<ShoutcastStreamer>.Dispose
	|-HashSet.Enumerator<Connection>.Dispose
	|-HashSet.Enumerator<int>.Dispose
	|-HashSet.Enumerator<object>.Dispose
	|-HashSet.Enumerator<string>.Dispose
	|-HashSet.Enumerator<uint>.Dispose
	|-HashSet.Enumerator<ulong>.Dispose
	|-HashSet.Enumerator<GameObject>.Dispose
	|-HashSet.Enumerator<IClippable>.Dispose
	|-HashSet.Enumerator<MaskableGraphic>.Dispose
	|-HashSet.Enumerator<Text>.Dispose
	|-HashSet.Enumerator<Vector3>.Dispose
	|-HashSet.Enumerator<WaterBody>.Dispose
	|-HashSet.Enumerator<WaterCullingVolume>.Dispose
	|-HashSet.Enumerator<WaterDepthMask>.Dispose
	|-HashSet.Enumerator<WaterInteraction>.Dispose
	|-HashSet.Enumerator<WindZoneEx>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-HashSet.Enumerator<AICoverPoint>.MoveNext
	|-HashSet.Enumerator<AIMovePoint>.MoveNext
	|-HashSet.Enumerator<AmbienceEmitter>.MoveNext
	|-HashSet.Enumerator<AtmosphereVolume>.MoveNext
	|-HashSet.Enumerator<BaseEntity>.MoveNext
	|-HashSet.Enumerator<DeferredExtensionMesh>.MoveNext
	|-HashSet.Enumerator<DeferredMeshDecal>.MoveNext
	|-HashSet.Enumerator<Impostor>.MoveNext
	|-HashSet.Enumerator<ImpostorShadows>.MoveNext
	|-HashSet.Enumerator<LODComponent>.MoveNext
	|-HashSet.Enumerator<ShoutcastStreamer>.MoveNext
	|-HashSet.Enumerator<object>.MoveNext
	|-HashSet.Enumerator<string>.MoveNext
	|-HashSet.Enumerator<Collider>.MoveNext
	|-HashSet.Enumerator<GameObject>.MoveNext
	|-HashSet.Enumerator<IClippable>.MoveNext
	|-HashSet.Enumerator<MaskableGraphic>.MoveNext
	|-HashSet.Enumerator<Text>.MoveNext
	|-HashSet.Enumerator<WaterBody>.MoveNext
	|-HashSet.Enumerator<WaterCullingVolume>.MoveNext
	|-HashSet.Enumerator<WaterDepthMask>.MoveNext
	|-HashSet.Enumerator<WaterInteraction>.MoveNext
	|-HashSet.Enumerator<WindZoneEx>.MoveNext
	|
	|-HashSet.Enumerator<Connection>.MoveNext
	|
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-HashSet.Enumerator<ulong>.MoveNext
	|
	|-HashSet.Enumerator<Vector3>.MoveNext
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-HashSet.Enumerator<AICoverPoint>.get_Current
	|-HashSet.Enumerator<AIMovePoint>.get_Current
	|-HashSet.Enumerator<AmbienceEmitter>.get_Current
	|-HashSet.Enumerator<AtmosphereVolume>.get_Current
	|-HashSet.Enumerator<BaseEntity>.get_Current
	|-HashSet.Enumerator<DeferredExtensionMesh>.get_Current
	|-HashSet.Enumerator<DeferredMeshDecal>.get_Current
	|-HashSet.Enumerator<Impostor>.get_Current
	|-HashSet.Enumerator<ImpostorShadows>.get_Current
	|-HashSet.Enumerator<LODComponent>.get_Current
	|-HashSet.Enumerator<ShoutcastStreamer>.get_Current
	|-HashSet.Enumerator<string>.get_Current
	|-HashSet.Enumerator<ulong>.get_Current
	|-HashSet.Enumerator<Collider>.get_Current
	|-HashSet.Enumerator<GameObject>.get_Current
	|-HashSet.Enumerator<IClippable>.get_Current
	|-HashSet.Enumerator<MaskableGraphic>.get_Current
	|-HashSet.Enumerator<Text>.get_Current
	|-HashSet.Enumerator<WaterBody>.get_Current
	|-HashSet.Enumerator<WaterCullingVolume>.get_Current
	|-HashSet.Enumerator<WaterDepthMask>.get_Current
	|-HashSet.Enumerator<WaterInteraction>.get_Current
	|-HashSet.Enumerator<WindZoneEx>.get_Current
	|-HashSet.Enumerator<object>.get_Current
	|
	|-HashSet.Enumerator<uint>.get_Current
	|-HashSet.Enumerator<Connection>.get_Current
	|-HashSet.Enumerator<int>.get_Current
	|
	|-HashSet.Enumerator<Vector3>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.get_Current
	|
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.Reset
	|
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	*/

}

