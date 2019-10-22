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

public class HighLevelGpuProgram : GpuProgram {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal HighLevelGpuProgram(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.HighLevelGpuProgram_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HighLevelGpuProgram obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HighLevelGpuProgram() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_HighLevelGpuProgram(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t createParameters() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t(OgrePINVOKE.HighLevelGpuProgram_createParameters(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override GpuProgram _getBindingDelegate() {
    global::System.IntPtr cPtr = OgrePINVOKE.HighLevelGpuProgram__getBindingDelegate(swigCPtr);
    GpuProgram ret = (cPtr == global::System.IntPtr.Zero) ? null : new GpuProgram(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override GpuNamedConstants getConstantDefinitions() {
    GpuNamedConstants ret = new GpuNamedConstants(OgrePINVOKE.HighLevelGpuProgram_getConstantDefinitions(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint calculateSize() {
    uint ret = OgrePINVOKE.HighLevelGpuProgram_calculateSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPreprocessorDefines(string defines) {
    OgrePINVOKE.HighLevelGpuProgram_setPreprocessorDefines(swigCPtr, defines);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getPreprocessorDefines() {
    string ret = OgrePINVOKE.HighLevelGpuProgram_getPreprocessorDefines(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string _resolveIncludes(string source, Resource resourceBeingLoaded, string fileName) {
    string ret = OgrePINVOKE.HighLevelGpuProgram__resolveIncludes(source, Resource.getCPtr(resourceBeingLoaded), fileName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
