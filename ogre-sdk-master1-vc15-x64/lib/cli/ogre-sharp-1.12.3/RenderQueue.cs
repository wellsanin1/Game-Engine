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

public class RenderQueue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RenderQueue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderQueue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderQueue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_RenderQueue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class RenderableListener : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal RenderableListener(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderableListener obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~RenderableListener() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            OgrePINVOKE.delete_RenderQueue_RenderableListener(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public virtual bool renderableQueued(Renderable rend, byte groupID, ushort priority, SWIGTYPE_p_p_Ogre__Technique ppTech, RenderQueue pQueue) {
      bool ret = OgrePINVOKE.RenderQueue_RenderableListener_renderableQueued(swigCPtr, Renderable.getCPtr(rend), groupID, priority, SWIGTYPE_p_p_Ogre__Technique.getCPtr(ppTech), RenderQueue.getCPtr(pQueue));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public RenderQueue() : this(OgrePINVOKE.new_RenderQueue(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear(bool destroyPassMaps) {
    OgrePINVOKE.RenderQueue_clear__SWIG_0(swigCPtr, destroyPassMaps);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    OgrePINVOKE.RenderQueue_clear__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RenderQueueGroup getQueueGroup(byte qid) {
    global::System.IntPtr cPtr = OgrePINVOKE.RenderQueue_getQueueGroup(swigCPtr, qid);
    RenderQueueGroup ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderQueueGroup(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addRenderable(Renderable pRend, byte groupID, ushort priority) {
    OgrePINVOKE.RenderQueue_addRenderable__SWIG_0(swigCPtr, Renderable.getCPtr(pRend), groupID, priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addRenderable(Renderable pRend, byte groupId) {
    OgrePINVOKE.RenderQueue_addRenderable__SWIG_1(swigCPtr, Renderable.getCPtr(pRend), groupId);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addRenderable(Renderable pRend) {
    OgrePINVOKE.RenderQueue_addRenderable__SWIG_2(swigCPtr, Renderable.getCPtr(pRend));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public byte getDefaultQueueGroup() {
    byte ret = OgrePINVOKE.RenderQueue_getDefaultQueueGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDefaultRenderablePriority(ushort priority) {
    OgrePINVOKE.RenderQueue_setDefaultRenderablePriority(swigCPtr, priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getDefaultRenderablePriority() {
    ushort ret = OgrePINVOKE.RenderQueue_getDefaultRenderablePriority(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDefaultQueueGroup(byte grp) {
    OgrePINVOKE.RenderQueue_setDefaultQueueGroup(swigCPtr, grp);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_a_Ogre__RENDER_QUEUE_MAX__std__unique_ptrT_Ogre__RenderQueueGroup_t _getQueueGroups() {
    SWIGTYPE_p_a_Ogre__RENDER_QUEUE_MAX__std__unique_ptrT_Ogre__RenderQueueGroup_t ret = new SWIGTYPE_p_a_Ogre__RENDER_QUEUE_MAX__std__unique_ptrT_Ogre__RenderQueueGroup_t(OgrePINVOKE.RenderQueue__getQueueGroups(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSplitPassesByLightingType(bool split) {
    OgrePINVOKE.RenderQueue_setSplitPassesByLightingType(swigCPtr, split);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSplitPassesByLightingType() {
    bool ret = OgrePINVOKE.RenderQueue_getSplitPassesByLightingType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSplitNoShadowPasses(bool split) {
    OgrePINVOKE.RenderQueue_setSplitNoShadowPasses(swigCPtr, split);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSplitNoShadowPasses() {
    bool ret = OgrePINVOKE.RenderQueue_getSplitNoShadowPasses(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setShadowCastersCannotBeReceivers(bool ind) {
    OgrePINVOKE.RenderQueue_setShadowCastersCannotBeReceivers(swigCPtr, ind);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getShadowCastersCannotBeReceivers() {
    bool ret = OgrePINVOKE.RenderQueue_getShadowCastersCannotBeReceivers(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRenderableListener(RenderQueue.RenderableListener listener) {
    OgrePINVOKE.RenderQueue_setRenderableListener(swigCPtr, RenderQueue.RenderableListener.getCPtr(listener));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RenderQueue.RenderableListener getRenderableListener() {
    global::System.IntPtr cPtr = OgrePINVOKE.RenderQueue_getRenderableListener(swigCPtr);
    RenderQueue.RenderableListener ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderQueue.RenderableListener(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void merge(RenderQueue rhs) {
    OgrePINVOKE.RenderQueue_merge(swigCPtr, RenderQueue.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void processVisibleObject(MovableObject mo, Camera cam, bool onlyShadowCasters, VisibleObjectsBoundsInfo visibleBounds) {
    OgrePINVOKE.RenderQueue_processVisibleObject(swigCPtr, MovableObject.getCPtr(mo), Camera.getCPtr(cam), onlyShadowCasters, VisibleObjectsBoundsInfo.getCPtr(visibleBounds));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
