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

public class TexCoordModifierControllerValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TexCoordModifierControllerValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TexCoordModifierControllerValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TexCoordModifierControllerValue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_TexCoordModifierControllerValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TexCoordModifierControllerValue(TextureUnitState t, bool translateU, bool translateV, bool scaleU, bool scaleV, bool rotate) : this(OgrePINVOKE.new_TexCoordModifierControllerValue__SWIG_0(TextureUnitState.getCPtr(t), translateU, translateV, scaleU, scaleV, rotate), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexCoordModifierControllerValue(TextureUnitState t, bool translateU, bool translateV, bool scaleU, bool scaleV) : this(OgrePINVOKE.new_TexCoordModifierControllerValue__SWIG_1(TextureUnitState.getCPtr(t), translateU, translateV, scaleU, scaleV), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexCoordModifierControllerValue(TextureUnitState t, bool translateU, bool translateV, bool scaleU) : this(OgrePINVOKE.new_TexCoordModifierControllerValue__SWIG_2(TextureUnitState.getCPtr(t), translateU, translateV, scaleU), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexCoordModifierControllerValue(TextureUnitState t, bool translateU, bool translateV) : this(OgrePINVOKE.new_TexCoordModifierControllerValue__SWIG_3(TextureUnitState.getCPtr(t), translateU, translateV), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexCoordModifierControllerValue(TextureUnitState t, bool translateU) : this(OgrePINVOKE.new_TexCoordModifierControllerValue__SWIG_4(TextureUnitState.getCPtr(t), translateU), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexCoordModifierControllerValue(TextureUnitState t) : this(OgrePINVOKE.new_TexCoordModifierControllerValue__SWIG_5(TextureUnitState.getCPtr(t)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ControllerValueRealPtr create(TextureUnitState t, bool translateU, bool translateV, bool scaleU, bool scaleV, bool rotate) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.TexCoordModifierControllerValue_create__SWIG_0(TextureUnitState.getCPtr(t), translateU, translateV, scaleU, scaleV, rotate), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ControllerValueRealPtr create(TextureUnitState t, bool translateU, bool translateV, bool scaleU, bool scaleV) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.TexCoordModifierControllerValue_create__SWIG_1(TextureUnitState.getCPtr(t), translateU, translateV, scaleU, scaleV), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ControllerValueRealPtr create(TextureUnitState t, bool translateU, bool translateV, bool scaleU) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.TexCoordModifierControllerValue_create__SWIG_2(TextureUnitState.getCPtr(t), translateU, translateV, scaleU), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ControllerValueRealPtr create(TextureUnitState t, bool translateU, bool translateV) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.TexCoordModifierControllerValue_create__SWIG_3(TextureUnitState.getCPtr(t), translateU, translateV), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ControllerValueRealPtr create(TextureUnitState t, bool translateU) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.TexCoordModifierControllerValue_create__SWIG_4(TextureUnitState.getCPtr(t), translateU), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ControllerValueRealPtr create(TextureUnitState t) {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.TexCoordModifierControllerValue_create__SWIG_5(TextureUnitState.getCPtr(t)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getValue() {
    float ret = OgrePINVOKE.TexCoordModifierControllerValue_getValue(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setValue(float value) {
    OgrePINVOKE.TexCoordModifierControllerValue_setValue(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
