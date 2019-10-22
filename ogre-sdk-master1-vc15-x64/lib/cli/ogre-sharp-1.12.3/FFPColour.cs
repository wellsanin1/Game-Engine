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

public class FFPColour : SubRenderState {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FFPColour(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RTShaderPINVOKE.FFPColour_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FFPColour obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FFPColour() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_FFPColour(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FFPColour() : this(RTShaderPINVOKE.new_FFPColour(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string getType() {
    string ret = RTShaderPINVOKE.FFPColour_getType(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getExecutionOrder() {
    int ret = RTShaderPINVOKE.FFPColour_getExecutionOrder(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void copyFrom(SubRenderState rhs) {
    RTShaderPINVOKE.FFPColour_copyFrom(swigCPtr, SubRenderState.getCPtr(rhs));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool preAddToRenderState(RenderState renderState, Pass srcPass, Pass dstPass) {
    bool ret = RTShaderPINVOKE.FFPColour_preAddToRenderState(swigCPtr, RenderState.getCPtr(renderState), Pass.getCPtr(srcPass), Pass.getCPtr(dstPass));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setResolveStageFlags(uint flags) {
    RTShaderPINVOKE.FFPColour_setResolveStageFlags(swigCPtr, flags);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getResolveStageFlags() {
    uint ret = RTShaderPINVOKE.FFPColour_getResolveStageFlags(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addResolveStageMask(uint mask) {
    RTShaderPINVOKE.FFPColour_addResolveStageMask(swigCPtr, mask);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeResolveStageMask(uint mask) {
    RTShaderPINVOKE.FFPColour_removeResolveStageMask(swigCPtr, mask);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string Type {
    set {
      RTShaderPINVOKE.FFPColour_Type_set(value);
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = RTShaderPINVOKE.FFPColour_Type_get();
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public enum StageFlags {
    SF_VS_INPUT_DIFFUSE = 1 << 1,
    SF_VS_OUTPUT_DIFFUSE = 1 << 2,
    SF_VS_OUTPUT_SPECULAR = 1 << 3,
    SF_PS_INPUT_DIFFUSE = 1 << 4,
    SF_PS_INPUT_SPECULAR = 1 << 5
  }

}

}