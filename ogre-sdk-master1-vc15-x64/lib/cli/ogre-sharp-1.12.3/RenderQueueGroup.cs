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

public class RenderQueueGroup : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RenderQueueGroup(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderQueueGroup obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderQueueGroup() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_RenderQueueGroup(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RenderQueueGroup(RenderQueue parent, bool splitPassesByLightingType, bool splitNoShadowPasses, bool shadowCastersNotReceivers) : this(OgrePINVOKE.new_RenderQueueGroup(RenderQueue.getCPtr(parent), splitPassesByLightingType, splitNoShadowPasses, shadowCastersNotReceivers), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__MapIteratorT_std__mapT_unsigned_short_Ogre__RenderPriorityGroup_p_std__lessT_unsigned_short_t_t_t getIterator() {
    SWIGTYPE_p_Ogre__MapIteratorT_std__mapT_unsigned_short_Ogre__RenderPriorityGroup_p_std__lessT_unsigned_short_t_t_t ret = new SWIGTYPE_p_Ogre__MapIteratorT_std__mapT_unsigned_short_Ogre__RenderPriorityGroup_p_std__lessT_unsigned_short_t_t_t(OgrePINVOKE.RenderQueueGroup_getIterator__SWIG_0(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addRenderable(Renderable pRend, Technique pTech, ushort priority) {
    OgrePINVOKE.RenderQueueGroup_addRenderable(swigCPtr, Renderable.getCPtr(pRend), Technique.getCPtr(pTech), priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear(bool destroy) {
    OgrePINVOKE.RenderQueueGroup_clear__SWIG_0(swigCPtr, destroy);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    OgrePINVOKE.RenderQueueGroup_clear__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShadowsEnabled(bool enabled) {
    OgrePINVOKE.RenderQueueGroup_setShadowsEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getShadowsEnabled() {
    bool ret = OgrePINVOKE.RenderQueueGroup_getShadowsEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSplitPassesByLightingType(bool split) {
    OgrePINVOKE.RenderQueueGroup_setSplitPassesByLightingType(swigCPtr, split);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSplitNoShadowPasses(bool split) {
    OgrePINVOKE.RenderQueueGroup_setSplitNoShadowPasses(swigCPtr, split);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShadowCastersCannotBeReceivers(bool ind) {
    OgrePINVOKE.RenderQueueGroup_setShadowCastersCannotBeReceivers(swigCPtr, ind);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetOrganisationModes() {
    OgrePINVOKE.RenderQueueGroup_resetOrganisationModes(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addOrganisationMode(QueuedRenderableCollection.OrganisationMode om) {
    OgrePINVOKE.RenderQueueGroup_addOrganisationMode(swigCPtr, (int)om);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defaultOrganisationMode() {
    OgrePINVOKE.RenderQueueGroup_defaultOrganisationMode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void merge(RenderQueueGroup rhs) {
    OgrePINVOKE.RenderQueueGroup_merge(swigCPtr, RenderQueueGroup.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
