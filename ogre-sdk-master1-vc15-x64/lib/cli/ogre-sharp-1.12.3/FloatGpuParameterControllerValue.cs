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

public class FloatGpuParameterControllerValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FloatGpuParameterControllerValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FloatGpuParameterControllerValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FloatGpuParameterControllerValue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_FloatGpuParameterControllerValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FloatGpuParameterControllerValue(SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t arg0, uint index) : this(OgrePINVOKE.new_FloatGpuParameterControllerValue(SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t.getCPtr(arg0), index), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ControllerValueRealPtr create(SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t arg0, uint index) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.FloatGpuParameterControllerValue_create(SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t.getCPtr(arg0), index), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getValue() {
    float ret = OgrePINVOKE.FloatGpuParameterControllerValue_getValue(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setValue(float value) {
    OgrePINVOKE.FloatGpuParameterControllerValue_setValue(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
