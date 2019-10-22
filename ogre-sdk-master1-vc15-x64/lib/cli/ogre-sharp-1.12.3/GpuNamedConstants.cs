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

public class GpuNamedConstants : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GpuNamedConstants(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GpuNamedConstants obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GpuNamedConstants() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_GpuNamedConstants(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint floatBufferSize {
    set {
      OgrePINVOKE.GpuNamedConstants_floatBufferSize_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.GpuNamedConstants_floatBufferSize_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint doubleBufferSize {
    set {
      OgrePINVOKE.GpuNamedConstants_doubleBufferSize_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.GpuNamedConstants_doubleBufferSize_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint intBufferSize {
    set {
      OgrePINVOKE.GpuNamedConstants_intBufferSize_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.GpuNamedConstants_intBufferSize_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_Ogre__GpuConstantDefinition_std__lessT_std__string_t_t map {
    set {
      OgrePINVOKE.GpuNamedConstants_map_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_Ogre__GpuConstantDefinition_std__lessT_std__string_t_t.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.GpuNamedConstants_map_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_Ogre__GpuConstantDefinition_std__lessT_std__string_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_Ogre__GpuConstantDefinition_std__lessT_std__string_t_t(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public GpuNamedConstants() : this(OgrePINVOKE.new_GpuNamedConstants(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void generateConstantDefinitionArrayEntries(string paramName, GpuConstantDefinition baseDef) {
    OgrePINVOKE.GpuNamedConstants_generateConstantDefinitionArrayEntries(swigCPtr, paramName, GpuConstantDefinition.getCPtr(baseDef));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool getGenerateAllConstantDefinitionArrayEntries() {
    bool ret = OgrePINVOKE.GpuNamedConstants_getGenerateAllConstantDefinitionArrayEntries();
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setGenerateAllConstantDefinitionArrayEntries(bool generateAll) {
    OgrePINVOKE.GpuNamedConstants_setGenerateAllConstantDefinitionArrayEntries(generateAll);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void save(string filename) {
    OgrePINVOKE.GpuNamedConstants_save(swigCPtr, filename);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load(DataStreamPtr stream) {
    OgrePINVOKE.GpuNamedConstants_load(swigCPtr, DataStreamPtr.getCPtr(stream));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint calculateSize() {
    uint ret = OgrePINVOKE.GpuNamedConstants_calculateSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}