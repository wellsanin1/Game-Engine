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

public class LodListener : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LodListener(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LodListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LodListener() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_LodListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool prequeueMovableObjectLodChanged(MovableObjectLodChangedEvent evt) {
    bool ret = OgrePINVOKE.LodListener_prequeueMovableObjectLodChanged(swigCPtr, MovableObjectLodChangedEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void postqueueMovableObjectLodChanged(MovableObjectLodChangedEvent evt) {
    OgrePINVOKE.LodListener_postqueueMovableObjectLodChanged(swigCPtr, MovableObjectLodChangedEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool prequeueEntityMeshLodChanged(EntityMeshLodChangedEvent evt) {
    bool ret = OgrePINVOKE.LodListener_prequeueEntityMeshLodChanged(swigCPtr, EntityMeshLodChangedEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void postqueueEntityMeshLodChanged(EntityMeshLodChangedEvent evt) {
    OgrePINVOKE.LodListener_postqueueEntityMeshLodChanged(swigCPtr, EntityMeshLodChangedEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool prequeueEntityMaterialLodChanged(EntityMaterialLodChangedEvent evt) {
    bool ret = OgrePINVOKE.LodListener_prequeueEntityMaterialLodChanged(swigCPtr, EntityMaterialLodChangedEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void postqueueEntityMaterialLodChanged(EntityMaterialLodChangedEvent evt) {
    OgrePINVOKE.LodListener_postqueueEntityMaterialLodChanged(swigCPtr, EntityMaterialLodChangedEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public LodListener() : this(OgrePINVOKE.new_LodListener(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}