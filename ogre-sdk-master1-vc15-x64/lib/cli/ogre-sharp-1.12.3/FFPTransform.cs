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

public class FFPTransform : SubRenderState {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FFPTransform(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RTShaderPINVOKE.FFPTransform_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FFPTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FFPTransform() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_FFPTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override string getType() {
    string ret = RTShaderPINVOKE.FFPTransform_getType(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getExecutionOrder() {
    int ret = RTShaderPINVOKE.FFPTransform_getExecutionOrder(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void copyFrom(SubRenderState rhs) {
    RTShaderPINVOKE.FFPTransform_copyFrom(swigCPtr, SubRenderState.getCPtr(rhs));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool createCpuSubPrograms(SWIGTYPE_p_Ogre__RTShader__ProgramSet programSet) {
    bool ret = RTShaderPINVOKE.FFPTransform_createCpuSubPrograms(swigCPtr, SWIGTYPE_p_Ogre__RTShader__ProgramSet.getCPtr(programSet));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool preAddToRenderState(RenderState renderState, Pass srcPass, Pass dstPass) {
    bool ret = RTShaderPINVOKE.FFPTransform_preAddToRenderState(swigCPtr, RenderState.getCPtr(renderState), Pass.getCPtr(srcPass), Pass.getCPtr(dstPass));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string Type {
    set {
      RTShaderPINVOKE.FFPTransform_Type_set(value);
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = RTShaderPINVOKE.FFPTransform_Type_get();
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FFPTransform() : this(RTShaderPINVOKE.new_FFPTransform(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
