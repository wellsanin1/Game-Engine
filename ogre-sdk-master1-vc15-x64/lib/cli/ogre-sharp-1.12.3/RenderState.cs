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

public class RenderState : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RenderState(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderState() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_RenderState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RenderState() : this(RTShaderPINVOKE.new_RenderState(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    RTShaderPINVOKE.RenderState_reset(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addTemplateSubRenderState(SubRenderState subRenderState) {
    RTShaderPINVOKE.RenderState_addTemplateSubRenderState(swigCPtr, SubRenderState.getCPtr(subRenderState));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeTemplateSubRenderState(SubRenderState subRenderState) {
    RTShaderPINVOKE.RenderState_removeTemplateSubRenderState(swigCPtr, SubRenderState.getCPtr(subRenderState));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_Ogre__RTShader__SubRenderState_p_t getTemplateSubRenderStateList() {
    SWIGTYPE_p_std__vectorT_Ogre__RTShader__SubRenderState_p_t ret = new SWIGTYPE_p_std__vectorT_Ogre__RTShader__SubRenderState_p_t(RTShaderPINVOKE.RenderState_getTemplateSubRenderStateList(swigCPtr), false);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLightCount(SWIGTYPE_p_Ogre__VectorT_3_int_t lightCount) {
    RTShaderPINVOKE.RenderState_setLightCount(swigCPtr, SWIGTYPE_p_Ogre__VectorT_3_int_t.getCPtr(lightCount));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__VectorT_3_int_t getLightCount() {
    SWIGTYPE_p_Ogre__VectorT_3_int_t ret = new SWIGTYPE_p_Ogre__VectorT_3_int_t(RTShaderPINVOKE.RenderState_getLightCount(swigCPtr), false);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLightCountAutoUpdate(bool autoUpdate) {
    RTShaderPINVOKE.RenderState_setLightCountAutoUpdate(swigCPtr, autoUpdate);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getLightCountAutoUpdate() {
    bool ret = RTShaderPINVOKE.RenderState_getLightCountAutoUpdate(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}