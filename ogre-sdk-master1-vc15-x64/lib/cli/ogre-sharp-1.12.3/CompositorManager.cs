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

public class CompositorManager : ResourceManager {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CompositorManager(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.CompositorManager_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CompositorManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CompositorManager() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_CompositorManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CompositorManager() : this(OgrePINVOKE.new_CompositorManager(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Resource createImpl(string name, ulong handle, string group, bool isManual, ManualResourceLoader loader, NameValuePairList arg5) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager_createImpl(swigCPtr, name, handle, group, isManual, ManualResourceLoader.getCPtr(loader), NameValuePairList.getCPtr(arg5));
    Resource ret = (cPtr == global::System.IntPtr.Zero) ? null : new Resource(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void initialise() {
    OgrePINVOKE.CompositorManager_initialise(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public CompositorPtr create(string name, string group, bool isManual, ManualResourceLoader loader, NameValuePairList createParams) {
    CompositorPtr ret = new CompositorPtr(OgrePINVOKE.CompositorManager_create__SWIG_0(swigCPtr, name, group, isManual, ManualResourceLoader.getCPtr(loader), NameValuePairList.getCPtr(createParams)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositorPtr create(string name, string group, bool isManual, ManualResourceLoader loader) {
    CompositorPtr ret = new CompositorPtr(OgrePINVOKE.CompositorManager_create__SWIG_1(swigCPtr, name, group, isManual, ManualResourceLoader.getCPtr(loader)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositorPtr create(string name, string group, bool isManual) {
    CompositorPtr ret = new CompositorPtr(OgrePINVOKE.CompositorManager_create__SWIG_2(swigCPtr, name, group, isManual), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositorPtr create(string name, string group) {
    CompositorPtr ret = new CompositorPtr(OgrePINVOKE.CompositorManager_create__SWIG_3(swigCPtr, name, group), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositorPtr getByName(string name, string groupName) {
    CompositorPtr ret = new CompositorPtr(OgrePINVOKE.CompositorManager_getByName__SWIG_0(swigCPtr, name, groupName), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositorPtr getByName(string name) {
    CompositorPtr ret = new CompositorPtr(OgrePINVOKE.CompositorManager_getByName__SWIG_1(swigCPtr, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void parseScript(DataStreamPtr stream, string groupName) {
    OgrePINVOKE.CompositorManager_parseScript(swigCPtr, DataStreamPtr.getCPtr(stream), groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public CompositorChain getCompositorChain(Viewport vp) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager_getCompositorChain(swigCPtr, Viewport.getCPtr(vp));
    CompositorChain ret = (cPtr == global::System.IntPtr.Zero) ? null : new CompositorChain(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasCompositorChain(Viewport vp) {
    bool ret = OgrePINVOKE.CompositorManager_hasCompositorChain(swigCPtr, Viewport.getCPtr(vp));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeCompositorChain(Viewport vp) {
    OgrePINVOKE.CompositorManager_removeCompositorChain(swigCPtr, Viewport.getCPtr(vp));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public CompositorInstance addCompositor(Viewport vp, string compositor, int addPosition) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager_addCompositor__SWIG_0(swigCPtr, Viewport.getCPtr(vp), compositor, addPosition);
    CompositorInstance ret = (cPtr == global::System.IntPtr.Zero) ? null : new CompositorInstance(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositorInstance addCompositor(Viewport vp, string compositor) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager_addCompositor__SWIG_1(swigCPtr, Viewport.getCPtr(vp), compositor);
    CompositorInstance ret = (cPtr == global::System.IntPtr.Zero) ? null : new CompositorInstance(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeCompositor(Viewport vp, string compositor) {
    OgrePINVOKE.CompositorManager_removeCompositor(swigCPtr, Viewport.getCPtr(vp), compositor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCompositorEnabled(Viewport vp, string compositor, bool value) {
    OgrePINVOKE.CompositorManager_setCompositorEnabled(swigCPtr, Viewport.getCPtr(vp), compositor, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Renderable _getTexturedRectangle2D() {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager__getTexturedRectangle2D(swigCPtr);
    Renderable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Renderable(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void removeAll() {
    OgrePINVOKE.CompositorManager_removeAll(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _reconstructAllCompositorResources() {
    OgrePINVOKE.CompositorManager__reconstructAllCompositorResources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexturePtr getPooledTexture(string name, string localName, uint w, uint h, PixelFormat f, uint aa, string aaHint, bool srgb, SWIGTYPE_p_std__setT_Ogre__Texture_p_t texturesAlreadyAssigned, CompositorInstance inst, CompositionTechnique.TextureScope scope) {
    TexturePtr ret = new TexturePtr(OgrePINVOKE.CompositorManager_getPooledTexture(swigCPtr, name, localName, w, h, (int)f, aa, aaHint, srgb, SWIGTYPE_p_std__setT_Ogre__Texture_p_t.getCPtr(texturesAlreadyAssigned), CompositorInstance.getCPtr(inst), (int)scope), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void freePooledTextures(bool onlyIfUnreferenced) {
    OgrePINVOKE.CompositorManager_freePooledTextures__SWIG_0(swigCPtr, onlyIfUnreferenced);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void freePooledTextures() {
    OgrePINVOKE.CompositorManager_freePooledTextures__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void registerCompositorLogic(string name, SWIGTYPE_p_Ogre__CompositorLogic logic) {
    OgrePINVOKE.CompositorManager_registerCompositorLogic(swigCPtr, name, SWIGTYPE_p_Ogre__CompositorLogic.getCPtr(logic));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void unregisterCompositorLogic(string name) {
    OgrePINVOKE.CompositorManager_unregisterCompositorLogic(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__CompositorLogic getCompositorLogic(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager_getCompositorLogic(swigCPtr, name);
    SWIGTYPE_p_Ogre__CompositorLogic ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__CompositorLogic(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasCompositorLogic(string name) {
    bool ret = OgrePINVOKE.CompositorManager_hasCompositorLogic(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void registerCustomCompositionPass(string name, SWIGTYPE_p_Ogre__CustomCompositionPass customPass) {
    OgrePINVOKE.CompositorManager_registerCustomCompositionPass(swigCPtr, name, SWIGTYPE_p_Ogre__CustomCompositionPass.getCPtr(customPass));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void unregisterCustomCompositionPass(string name) {
    OgrePINVOKE.CompositorManager_unregisterCustomCompositionPass(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__CustomCompositionPass getCustomCompositionPass(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorManager_getCustomCompositionPass(swigCPtr, name);
    SWIGTYPE_p_Ogre__CustomCompositionPass ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__CustomCompositionPass(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasCustomCompositionPass(string name) {
    bool ret = OgrePINVOKE.CompositorManager_hasCustomCompositionPass(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _relocateChain(Viewport sourceVP, Viewport destVP) {
    OgrePINVOKE.CompositorManager__relocateChain(swigCPtr, Viewport.getCPtr(sourceVP), Viewport.getCPtr(destVP));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static CompositorManager getSingleton() {
    CompositorManager ret = new CompositorManager(OgrePINVOKE.CompositorManager_getSingleton(), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
