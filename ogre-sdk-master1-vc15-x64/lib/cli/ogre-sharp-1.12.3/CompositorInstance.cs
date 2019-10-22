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

public class CompositorInstance : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CompositorInstance(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CompositorInstance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CompositorInstance() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_CompositorInstance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CompositorInstance(CompositionTechnique technique, CompositorChain chain) : this(OgrePINVOKE.new_CompositorInstance(CompositionTechnique.getCPtr(technique), CompositorChain.getCPtr(chain)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public class Listener : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Listener(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Listener obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Listener() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            OgrePINVOKE.delete_CompositorInstance_Listener(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public virtual void notifyMaterialSetup(uint pass_id, MaterialPtr mat) {
      if (SwigDerivedClassHasMethod("notifyMaterialSetup", swigMethodTypes0)) OgrePINVOKE.CompositorInstance_Listener_notifyMaterialSetupSwigExplicitListener(swigCPtr, pass_id, MaterialPtr.getCPtr(mat)); else OgrePINVOKE.CompositorInstance_Listener_notifyMaterialSetup(swigCPtr, pass_id, MaterialPtr.getCPtr(mat));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public virtual void notifyMaterialRender(uint pass_id, MaterialPtr mat) {
      if (SwigDerivedClassHasMethod("notifyMaterialRender", swigMethodTypes1)) OgrePINVOKE.CompositorInstance_Listener_notifyMaterialRenderSwigExplicitListener(swigCPtr, pass_id, MaterialPtr.getCPtr(mat)); else OgrePINVOKE.CompositorInstance_Listener_notifyMaterialRender(swigCPtr, pass_id, MaterialPtr.getCPtr(mat));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public virtual void notifyResourcesCreated(bool forResizeOnly) {
      if (SwigDerivedClassHasMethod("notifyResourcesCreated", swigMethodTypes2)) OgrePINVOKE.CompositorInstance_Listener_notifyResourcesCreatedSwigExplicitListener(swigCPtr, forResizeOnly); else OgrePINVOKE.CompositorInstance_Listener_notifyResourcesCreated(swigCPtr, forResizeOnly);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public virtual void notifyResourcesReleased(bool forResizeOnly) {
      if (SwigDerivedClassHasMethod("notifyResourcesReleased", swigMethodTypes3)) OgrePINVOKE.CompositorInstance_Listener_notifyResourcesReleasedSwigExplicitListener(swigCPtr, forResizeOnly); else OgrePINVOKE.CompositorInstance_Listener_notifyResourcesReleased(swigCPtr, forResizeOnly);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Listener() : this(OgrePINVOKE.new_CompositorInstance_Listener(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      SwigDirectorConnect();
    }
  
    private void SwigDirectorConnect() {
      if (SwigDerivedClassHasMethod("notifyMaterialSetup", swigMethodTypes0))
        swigDelegate0 = new SwigDelegateListener_0(SwigDirectornotifyMaterialSetup);
      if (SwigDerivedClassHasMethod("notifyMaterialRender", swigMethodTypes1))
        swigDelegate1 = new SwigDelegateListener_1(SwigDirectornotifyMaterialRender);
      if (SwigDerivedClassHasMethod("notifyResourcesCreated", swigMethodTypes2))
        swigDelegate2 = new SwigDelegateListener_2(SwigDirectornotifyResourcesCreated);
      if (SwigDerivedClassHasMethod("notifyResourcesReleased", swigMethodTypes3))
        swigDelegate3 = new SwigDelegateListener_3(SwigDirectornotifyResourcesReleased);
      OgrePINVOKE.CompositorInstance_Listener_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
    }
  
    private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
      global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
      bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Listener));
      return hasDerivedMethod;
    }
  
    private void SwigDirectornotifyMaterialSetup(uint pass_id, global::System.IntPtr mat) {
      notifyMaterialSetup(pass_id, new MaterialPtr(mat, false));
    }
  
    private void SwigDirectornotifyMaterialRender(uint pass_id, global::System.IntPtr mat) {
      notifyMaterialRender(pass_id, new MaterialPtr(mat, false));
    }
  
    private void SwigDirectornotifyResourcesCreated(bool forResizeOnly) {
      notifyResourcesCreated(forResizeOnly);
    }
  
    private void SwigDirectornotifyResourcesReleased(bool forResizeOnly) {
      notifyResourcesReleased(forResizeOnly);
    }
  
    public delegate void SwigDelegateListener_0(uint pass_id, global::System.IntPtr mat);
    public delegate void SwigDelegateListener_1(uint pass_id, global::System.IntPtr mat);
    public delegate void SwigDelegateListener_2(bool forResizeOnly);
    public delegate void SwigDelegateListener_3(bool forResizeOnly);
  
    private SwigDelegateListener_0 swigDelegate0;
    private SwigDelegateListener_1 swigDelegate1;
    private SwigDelegateListener_2 swigDelegate2;
    private SwigDelegateListener_3 swigDelegate3;
  
    private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(uint), typeof(MaterialPtr) };
    private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(uint), typeof(MaterialPtr) };
    private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(bool) };
    private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(bool) };
  }

  public class RenderSystemOperation : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal RenderSystemOperation(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderSystemOperation obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~RenderSystemOperation() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            OgrePINVOKE.delete_CompositorInstance_RenderSystemOperation(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public virtual void execute(SceneManager sm, RenderSystem rs) {
      OgrePINVOKE.CompositorInstance_RenderSystemOperation_execute(swigCPtr, SceneManager.getCPtr(sm), RenderSystem.getCPtr(rs));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  public class TargetOperation : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal TargetOperation(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TargetOperation obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~TargetOperation() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            OgrePINVOKE.delete_CompositorInstance_TargetOperation(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public TargetOperation() : this(OgrePINVOKE.new_CompositorInstance_TargetOperation__SWIG_0(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public TargetOperation(RenderTarget inTarget) : this(OgrePINVOKE.new_CompositorInstance_TargetOperation__SWIG_1(RenderTarget.getCPtr(inTarget)), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public RenderTarget target {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_target_set(swigCPtr, RenderTarget.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = OgrePINVOKE.CompositorInstance_TargetOperation_target_get(swigCPtr);
        RenderTarget ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderTarget(cPtr, false);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public int currentQueueGroupID {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_currentQueueGroupID_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        int ret = OgrePINVOKE.CompositorInstance_TargetOperation_currentQueueGroupID_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public SWIGTYPE_p_std__vectorT_std__pairT_int_Ogre__CompositorInstance__RenderSystemOperation_p_t_t renderSystemOperations {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_renderSystemOperations_set(swigCPtr, SWIGTYPE_p_std__vectorT_std__pairT_int_Ogre__CompositorInstance__RenderSystemOperation_p_t_t.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = OgrePINVOKE.CompositorInstance_TargetOperation_renderSystemOperations_get(swigCPtr);
        SWIGTYPE_p_std__vectorT_std__pairT_int_Ogre__CompositorInstance__RenderSystemOperation_p_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_std__pairT_int_Ogre__CompositorInstance__RenderSystemOperation_p_t_t(cPtr, false);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public uint visibilityMask {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_visibilityMask_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = OgrePINVOKE.CompositorInstance_TargetOperation_visibilityMask_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public float lodBias {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_lodBias_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        float ret = OgrePINVOKE.CompositorInstance_TargetOperation_lodBias_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public SWIGTYPE_p_std__bitsetT_Ogre__RENDER_QUEUE_MAX_1_t renderQueues {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_renderQueues_set(swigCPtr, SWIGTYPE_p_std__bitsetT_Ogre__RENDER_QUEUE_MAX_1_t.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        SWIGTYPE_p_std__bitsetT_Ogre__RENDER_QUEUE_MAX_1_t ret = new SWIGTYPE_p_std__bitsetT_Ogre__RENDER_QUEUE_MAX_1_t(OgrePINVOKE.CompositorInstance_TargetOperation_renderQueues_get(swigCPtr), true);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public bool onlyInitial {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_onlyInitial_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        bool ret = OgrePINVOKE.CompositorInstance_TargetOperation_onlyInitial_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public bool hasBeenRendered {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_hasBeenRendered_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        bool ret = OgrePINVOKE.CompositorInstance_TargetOperation_hasBeenRendered_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public bool findVisibleObjects {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_findVisibleObjects_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        bool ret = OgrePINVOKE.CompositorInstance_TargetOperation_findVisibleObjects_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public string materialScheme {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_materialScheme_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        string ret = OgrePINVOKE.CompositorInstance_TargetOperation_materialScheme_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public bool shadowsEnabled {
      set {
        OgrePINVOKE.CompositorInstance_TargetOperation_shadowsEnabled_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        bool ret = OgrePINVOKE.CompositorInstance_TargetOperation_shadowsEnabled_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
  }

  public void setEnabled(bool value) {
    OgrePINVOKE.CompositorInstance_setEnabled(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getEnabled() {
    bool ret = OgrePINVOKE.CompositorInstance_getEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAlive(bool value) {
    OgrePINVOKE.CompositorInstance_setAlive(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAlive() {
    bool ret = OgrePINVOKE.CompositorInstance_getAlive(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getTextureInstanceName(string name, uint mrtIndex) {
    string ret = OgrePINVOKE.CompositorInstance_getTextureInstanceName(swigCPtr, name, mrtIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TexturePtr getTextureInstance(string name, uint mrtIndex) {
    TexturePtr ret = new TexturePtr(OgrePINVOKE.CompositorInstance_getTextureInstance(swigCPtr, name, mrtIndex), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RenderTarget getRenderTarget(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorInstance_getRenderTarget(swigCPtr, name);
    RenderTarget ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderTarget(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void _compileTargetOperations(SWIGTYPE_p_std__vectorT_Ogre__CompositorInstance__TargetOperation_t compiledState) {
    OgrePINVOKE.CompositorInstance__compileTargetOperations(swigCPtr, SWIGTYPE_p_std__vectorT_Ogre__CompositorInstance__TargetOperation_t.getCPtr(compiledState));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _compileOutputOperation(CompositorInstance.TargetOperation finalState) {
    OgrePINVOKE.CompositorInstance__compileOutputOperation(swigCPtr, CompositorInstance.TargetOperation.getCPtr(finalState));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Compositor getCompositor() {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorInstance_getCompositor(swigCPtr);
    Compositor ret = (cPtr == global::System.IntPtr.Zero) ? null : new Compositor(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CompositionTechnique getTechnique() {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorInstance_getTechnique(swigCPtr);
    CompositionTechnique ret = (cPtr == global::System.IntPtr.Zero) ? null : new CompositionTechnique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTechnique(CompositionTechnique tech, bool reuseTextures) {
    OgrePINVOKE.CompositorInstance_setTechnique__SWIG_0(swigCPtr, CompositionTechnique.getCPtr(tech), reuseTextures);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTechnique(CompositionTechnique tech) {
    OgrePINVOKE.CompositorInstance_setTechnique__SWIG_1(swigCPtr, CompositionTechnique.getCPtr(tech));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setScheme(string schemeName, bool reuseTextures) {
    OgrePINVOKE.CompositorInstance_setScheme__SWIG_0(swigCPtr, schemeName, reuseTextures);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setScheme(string schemeName) {
    OgrePINVOKE.CompositorInstance_setScheme__SWIG_1(swigCPtr, schemeName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getScheme() {
    string ret = OgrePINVOKE.CompositorInstance_getScheme(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void notifyResized() {
    OgrePINVOKE.CompositorInstance_notifyResized(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public CompositorChain getChain() {
    global::System.IntPtr cPtr = OgrePINVOKE.CompositorInstance_getChain(swigCPtr);
    CompositorChain ret = (cPtr == global::System.IntPtr.Zero) ? null : new CompositorChain(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addListener(CompositorInstance.Listener l) {
    OgrePINVOKE.CompositorInstance_addListener(swigCPtr, CompositorInstance.Listener.getCPtr(l));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(CompositorInstance.Listener l) {
    OgrePINVOKE.CompositorInstance_removeListener(swigCPtr, CompositorInstance.Listener.getCPtr(l));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireNotifyMaterialSetup(uint pass_id, MaterialPtr mat) {
    OgrePINVOKE.CompositorInstance__fireNotifyMaterialSetup(swigCPtr, pass_id, MaterialPtr.getCPtr(mat));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireNotifyMaterialRender(uint pass_id, MaterialPtr mat) {
    OgrePINVOKE.CompositorInstance__fireNotifyMaterialRender(swigCPtr, pass_id, MaterialPtr.getCPtr(mat));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireNotifyResourcesCreated(bool forResizeOnly) {
    OgrePINVOKE.CompositorInstance__fireNotifyResourcesCreated(swigCPtr, forResizeOnly);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireNotifyResourcesReleased(bool forResizeOnly) {
    OgrePINVOKE.CompositorInstance__fireNotifyResourcesReleased(swigCPtr, forResizeOnly);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}