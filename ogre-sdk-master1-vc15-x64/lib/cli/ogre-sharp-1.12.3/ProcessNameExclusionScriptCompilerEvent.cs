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

public class ProcessNameExclusionScriptCompilerEvent : ScriptCompilerEvent {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ProcessNameExclusionScriptCompilerEvent(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ProcessNameExclusionScriptCompilerEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProcessNameExclusionScriptCompilerEvent() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ProcessNameExclusionScriptCompilerEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public string mClass {
    set {
      OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_mClass_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_mClass_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public AbstractNode mParent {
    set {
      OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_mParent_set(swigCPtr, AbstractNode.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_mParent_get(swigCPtr);
      AbstractNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new AbstractNode(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static string eventType {
    set {
      OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_eventType_set(value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = OgrePINVOKE.ProcessNameExclusionScriptCompilerEvent_eventType_get();
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ProcessNameExclusionScriptCompilerEvent(string cls, AbstractNode parent) : this(OgrePINVOKE.new_ProcessNameExclusionScriptCompilerEvent(cls, AbstractNode.getCPtr(parent)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
