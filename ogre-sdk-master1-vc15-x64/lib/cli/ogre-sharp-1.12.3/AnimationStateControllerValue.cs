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

public class AnimationStateControllerValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AnimationStateControllerValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AnimationStateControllerValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AnimationStateControllerValue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_AnimationStateControllerValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AnimationStateControllerValue(AnimationState targetAnimationState, bool addTime) : this(OgrePINVOKE.new_AnimationStateControllerValue__SWIG_0(AnimationState.getCPtr(targetAnimationState), addTime), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public AnimationStateControllerValue(AnimationState targetAnimationState) : this(OgrePINVOKE.new_AnimationStateControllerValue__SWIG_1(AnimationState.getCPtr(targetAnimationState)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ControllerValueRealPtr create(AnimationState targetAnimationState, bool addTime) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.AnimationStateControllerValue_create__SWIG_0(AnimationState.getCPtr(targetAnimationState), addTime), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ControllerValueRealPtr create(AnimationState targetAnimationState) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.AnimationStateControllerValue_create__SWIG_1(AnimationState.getCPtr(targetAnimationState)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getValue() {
    float ret = OgrePINVOKE.AnimationStateControllerValue_getValue(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setValue(float value) {
    OgrePINVOKE.AnimationStateControllerValue_setValue(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
