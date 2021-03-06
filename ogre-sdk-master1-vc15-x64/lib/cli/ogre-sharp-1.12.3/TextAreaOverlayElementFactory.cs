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

public class TextAreaOverlayElementFactory : OverlayElementFactory {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TextAreaOverlayElementFactory(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgreOverlayPINVOKE.TextAreaOverlayElementFactory_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextAreaOverlayElementFactory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TextAreaOverlayElementFactory() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgreOverlayPINVOKE.delete_TextAreaOverlayElementFactory(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override OverlayElement createOverlayElement(string instanceName) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.TextAreaOverlayElementFactory_createOverlayElement(swigCPtr, instanceName);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, true);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string getTypeName() {
    string ret = OgreOverlayPINVOKE.TextAreaOverlayElementFactory_getTypeName(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TextAreaOverlayElementFactory() : this(OgreOverlayPINVOKE.new_TextAreaOverlayElementFactory(), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
