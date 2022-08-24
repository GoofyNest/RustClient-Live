public static class IJobParallelForTransformExtensions // TypeDefIndex: 3586
{

	[ExtensionAttribute] 
public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.Schedule<InitializeBoneStateJob>
|-IJobParallelForTransformExtensions.Schedule<InitializeColliderStateJob>
|-IJobParallelForTransformExtensions.Schedule<UpdateTransformsJob>
*/

}

internal struct IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T> // TypeDefIndex: 3587
{
	public static IntPtr jobReflectionData; 


public static IntPtr Initialize() { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Initialize
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Initialize
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Initialize
*/

public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Execute
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Execute
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Execute
*/

}

public sealed class IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3588
{

public void .ctor(object object, IntPtr method) { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>..ctor
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>..ctor
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>..ctor
*/

public virtual void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.Invoke
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.Invoke
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.Invoke
*/

public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.BeginInvoke
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.BeginInvoke
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.BeginInvoke
*/

public virtual void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }
/* GenericInstMethod :
|
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.EndInvoke
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.EndInvoke
|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.EndInvoke
*/

}

