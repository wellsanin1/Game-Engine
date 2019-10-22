//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace org.ogre {

public class GpuSharedParametersUsage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GpuSharedParametersUsage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GpuSharedParametersUsage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GpuSharedParametersUsage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_GpuSharedParametersUsage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GpuSharedParametersUsage(SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuSharedParameters_t sharedParams, GpuProgramParameters arg1) : this(OgrePINVOKE.new_GpuSharedParametersUsage(SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuSharedParameters_t.getCPtr(sharedParams), GpuProgramParameters.getCPtr(arg1)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _copySharedParamsToTargetParams() {
    OgrePINVOKE.GpuSharedParametersUsage__copySharedParamsToTargetParams(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = OgrePINVOKE.GpuSharedParametersUsage_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuSharedParameters_t getSharedParams() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuSharedParameters_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuSharedParameters_t(OgrePINVOKE.GpuSharedParametersUsage_getSharedParams(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GpuProgramParameters getTargetParams() {
    global::System.IntPtr cPtr = OgrePINVOKE.GpuSharedParametersUsage_getTargetParams(swigCPtr);
    GpuProgramParameters ret = (cPtr == global::System.IntPtr.Zero) ? null : new GpuProgramParameters(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _setRenderSystemData(Any data) {
    OgrePINVOKE.GpuSharedParametersUsage__setRenderSystemData(swigCPtr, Any.getCPtr(data));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Any _getRenderSystemData() {
    Any ret = new Any(OgrePINVOKE.GpuSharedParametersUsage__getRenderSystemData(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
