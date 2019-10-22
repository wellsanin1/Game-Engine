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

public class FFPFogFactory : SubRenderStateFactory {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FFPFogFactory(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RTShaderPINVOKE.FFPFogFactory_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FFPFogFactory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FFPFogFactory() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_FFPFogFactory(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override string getType() {
    string ret = RTShaderPINVOKE.FFPFogFactory_getType(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SubRenderState createInstance(ScriptCompiler compiler, PropertyAbstractNode prop, Pass pass, SGScriptTranslator translator) {
    global::System.IntPtr cPtr = RTShaderPINVOKE.FFPFogFactory_createInstance(swigCPtr, ScriptCompiler.getCPtr(compiler), PropertyAbstractNode.getCPtr(prop), Pass.getCPtr(pass), SGScriptTranslator.getCPtr(translator));
    SubRenderState ret = (cPtr == global::System.IntPtr.Zero) ? null : new SubRenderState(cPtr, false);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void writeInstance(MaterialSerializer ser, SubRenderState subRenderState, Pass srcPass, Pass dstPass) {
    RTShaderPINVOKE.FFPFogFactory_writeInstance(swigCPtr, MaterialSerializer.getCPtr(ser), SubRenderState.getCPtr(subRenderState), Pass.getCPtr(srcPass), Pass.getCPtr(dstPass));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public FFPFogFactory() : this(RTShaderPINVOKE.new_FFPFogFactory(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

}

}