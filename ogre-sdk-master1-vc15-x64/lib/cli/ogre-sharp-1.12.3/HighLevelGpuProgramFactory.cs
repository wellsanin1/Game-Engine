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

public class HighLevelGpuProgramFactory : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HighLevelGpuProgramFactory(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HighLevelGpuProgramFactory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HighLevelGpuProgramFactory() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_HighLevelGpuProgramFactory(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string getLanguage() {
    string ret = OgrePINVOKE.HighLevelGpuProgramFactory_getLanguage(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HighLevelGpuProgram create(ResourceManager creator, string name, ulong handle, string group, bool isManual, ManualResourceLoader loader) {
    global::System.IntPtr cPtr = OgrePINVOKE.HighLevelGpuProgramFactory_create(swigCPtr, ResourceManager.getCPtr(creator), name, handle, group, isManual, ManualResourceLoader.getCPtr(loader));
    HighLevelGpuProgram ret = (cPtr == global::System.IntPtr.Zero) ? null : new HighLevelGpuProgram(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void destroy(HighLevelGpuProgram prog) {
    OgrePINVOKE.HighLevelGpuProgramFactory_destroy(swigCPtr, HighLevelGpuProgram.getCPtr(prog));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
