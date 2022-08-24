public sealed class ParticleSystemJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 4556
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>..ctor
	*/

	public virtual void Invoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.EndInvoke
	*/

}

