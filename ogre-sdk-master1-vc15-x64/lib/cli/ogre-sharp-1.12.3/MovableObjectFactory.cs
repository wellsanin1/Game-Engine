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

public class MovableObjectFactory : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MovableObjectFactory(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MovableObjectFactory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MovableObjectFactory() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_MovableObjectFactory(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string getType() {
    string ret = OgrePINVOKE.MovableObjectFactory_getType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MovableObject createInstance(string name, SceneManager manager, NameValuePairList arg2) {
    global::System.IntPtr cPtr = OgrePINVOKE.MovableObjectFactory_createInstance__SWIG_0(swigCPtr, name, SceneManager.getCPtr(manager), NameValuePairList.getCPtr(arg2));
    MovableObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MovableObject(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MovableObject createInstance(string name, SceneManager manager) {
    global::System.IntPtr cPtr = OgrePINVOKE.MovableObjectFactory_createInstance__SWIG_1(swigCPtr, name, SceneManager.getCPtr(manager));
    MovableObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MovableObject(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void destroyInstance(MovableObject obj) {
    OgrePINVOKE.MovableObjectFactory_destroyInstance(swigCPtr, MovableObject.getCPtr(obj));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool requestTypeFlags() {
    bool ret = OgrePINVOKE.MovableObjectFactory_requestTypeFlags(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyTypeFlags(uint flag) {
    OgrePINVOKE.MovableObjectFactory__notifyTypeFlags(swigCPtr, flag);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getTypeFlags() {
    uint ret = OgrePINVOKE.MovableObjectFactory_getTypeFlags(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
