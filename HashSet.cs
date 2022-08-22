internal struct HashSet.Slot<T> // TypeDefIndex: 3255
{	internal int hashCode; // 0x0
	internal int next; // 0x0
	internal T value; // 0x0

}

public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3256
{	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21E660 Offset: 0x21DA60 VA: 0x18021E660
	|-HashSet.Enumerator<Connection>..ctor
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x21E6B0 Offset: 0x21DAB0 VA: 0x18021E6B0
	|-HashSet.Enumerator<object>..ctor
	|-HashSet.Enumerator<ulong>..ctor
	|
	|-RVA: 0x21E700 Offset: 0x21DB00 VA: 0x18021E700
	|-HashSet.Enumerator<Vector3>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
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
	|-RVA: 0x21D920 Offset: 0x21CD20 VA: 0x18021D920
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
	|-RVA: 0x21DCD0 Offset: 0x21D0D0 VA: 0x18021DCD0
	|-HashSet.Enumerator<Connection>.MoveNext
	|
	|-RVA: 0x21DBF0 Offset: 0x21CFF0 VA: 0x18021DBF0
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21D840 Offset: 0x21CC40 VA: 0x18021D840
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x21DA10 Offset: 0x21CE10 VA: 0x18021DA10
	|-HashSet.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21DB00 Offset: 0x21CF00 VA: 0x18021DB00
	|-HashSet.Enumerator<Vector3>.MoveNext
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
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
	|-RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	|-HashSet.Enumerator<uint>.get_Current
	|-HashSet.Enumerator<Connection>.get_Current
	|-HashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x116920 Offset: 0x115D20 VA: 0x180116920
	|-HashSet.Enumerator<Vector3>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21E1C0 Offset: 0x21D5C0 VA: 0x18021E1C0
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E560 Offset: 0x21D960 VA: 0x18021E560
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E4C0 Offset: 0x21D8C0 VA: 0x18021E4C0
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E2C0 Offset: 0x21D6C0 VA: 0x18021E2C0
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E3C0 Offset: 0x21D7C0 VA: 0x18021E3C0
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E0C0 Offset: 0x21D4C0 VA: 0x18021E0C0
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21DDB0 Offset: 0x21D1B0 VA: 0x18021DDB0
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21DEB0 Offset: 0x21D2B0 VA: 0x18021DEB0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21DE30 Offset: 0x21D230 VA: 0x18021DE30
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E040 Offset: 0x21D440 VA: 0x18021E040
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21DF30 Offset: 0x21D330 VA: 0x18021DF30
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21DFB0 Offset: 0x21D3B0 VA: 0x18021DFB0
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	*/

}

