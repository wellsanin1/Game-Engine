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

public class HighLevelGpuProgramManager : ResourceManager {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal HighLevelGpuProgramManager(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.HighLevelGpuProgramManager_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HighLevelGpuProgramManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HighLevelGpuProgramManager() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_HighLevelGpuProgramManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HighLevelGpuProgramManager() : this(OgrePINVOKE.new_HighLevelGpuProgramManager(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addFactory(HighLevelGpuProgramFactory factory) {
    OgrePINVOKE.HighLevelGpuProgramManager_addFactory(swigCPtr, HighLevelGpuProgramFactory.getCPtr(factory));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeFactory(HighLevelGpuProgramFactory factory) {
    OgrePINVOKE.HighLevelGpuProgramManager_removeFactory(swigCPtr, HighLevelGpuProgramFactory.getCPtr(factory));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isLanguageSupported(string lang) {
    bool ret = OgrePINVOKE.HighLevelGpuProgramManager_isLanguageSupported(swigCPtr, lang);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HighLevelGpuProgramPtr getByName(string name, string groupName) {
    HighLevelGpuProgramPtr ret = new HighLevelGpuProgramPtr(OgrePINVOKE.HighLevelGpuProgramManager_getByName__SWIG_0(swigCPtr, name, groupName), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HighLevelGpuProgramPtr getByName(string name) {
    HighLevelGpuProgramPtr ret = new HighLevelGpuProgramPtr(OgrePINVOKE.HighLevelGpuProgramManager_getByName__SWIG_1(swigCPtr, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HighLevelGpuProgramPtr createProgram(string name, string groupName, string language, GpuProgramType gptype) {
    HighLevelGpuProgramPtr ret = new HighLevelGpuProgramPtr(OgrePINVOKE.HighLevelGpuProgramManager_createProgram(swigCPtr, name, groupName, language, (int)gptype), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static HighLevelGpuProgramManager getSingleton() {
    HighLevelGpuProgramManager ret = new HighLevelGpuProgramManager(OgrePINVOKE.HighLevelGpuProgramManager_getSingleton(), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
