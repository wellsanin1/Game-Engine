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

public class ResourceBackgroundQueue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ResourceBackgroundQueue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResourceBackgroundQueue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ResourceBackgroundQueue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ResourceBackgroundQueue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
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
            OgrePINVOKE.delete_ResourceBackgroundQueue_Listener(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public virtual void operationCompleted(SWIGTYPE_p_Ogre__WorkQueue__RequestID ticket, BackgroundProcessResult result) {
      OgrePINVOKE.ResourceBackgroundQueue_Listener_operationCompleted(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__RequestID.getCPtr(ticket), BackgroundProcessResult.getCPtr(result));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Listener() : this(OgrePINVOKE.new_ResourceBackgroundQueue_Listener(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      SwigDirectorConnect();
    }
  
    private void SwigDirectorConnect() {
      if (SwigDerivedClassHasMethod("operationCompleted", swigMethodTypes0))
        swigDelegate0 = new SwigDelegateListener_0(SwigDirectoroperationCompleted);
      OgrePINVOKE.ResourceBackgroundQueue_Listener_director_connect(swigCPtr, swigDelegate0);
    }
  
    private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
      global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
      bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Listener));
      return hasDerivedMethod;
    }
  
    private void SwigDirectoroperationCompleted(global::System.IntPtr ticket, global::System.IntPtr result) {
      operationCompleted(new SWIGTYPE_p_Ogre__WorkQueue__RequestID(ticket, true), new BackgroundProcessResult(result, false));
    }
  
    public delegate void SwigDelegateListener_0(global::System.IntPtr ticket, global::System.IntPtr result);
  
    private SwigDelegateListener_0 swigDelegate0;
  
    private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(SWIGTYPE_p_Ogre__WorkQueue__RequestID), typeof(BackgroundProcessResult) };
  }

  public ResourceBackgroundQueue() : this(OgrePINVOKE.new_ResourceBackgroundQueue(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void initialise() {
    OgrePINVOKE.ResourceBackgroundQueue_initialise(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void shutdown() {
    OgrePINVOKE.ResourceBackgroundQueue_shutdown(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID initialiseResourceGroup(string name, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_initialiseResourceGroup__SWIG_0(swigCPtr, name, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID initialiseResourceGroup(string name) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_initialiseResourceGroup__SWIG_1(swigCPtr, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID initialiseAllResourceGroups(ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_initialiseAllResourceGroups__SWIG_0(swigCPtr, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID initialiseAllResourceGroups() {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_initialiseAllResourceGroups__SWIG_1(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepareResourceGroup(string name, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepareResourceGroup__SWIG_0(swigCPtr, name, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepareResourceGroup(string name) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepareResourceGroup__SWIG_1(swigCPtr, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID loadResourceGroup(string name, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_loadResourceGroup__SWIG_0(swigCPtr, name, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID loadResourceGroup(string name) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_loadResourceGroup__SWIG_1(swigCPtr, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID unload(string resType, string name, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_unload__SWIG_0(swigCPtr, resType, name, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID unload(string resType, string name) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_unload__SWIG_1(swigCPtr, resType, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID unload(string resType, ulong handle, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_unload__SWIG_2(swigCPtr, resType, handle, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID unload(string resType, ulong handle) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_unload__SWIG_3(swigCPtr, resType, handle), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID unloadResourceGroup(string name, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_unloadResourceGroup__SWIG_0(swigCPtr, name, ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID unloadResourceGroup(string name) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_unloadResourceGroup__SWIG_1(swigCPtr, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepare(string resType, string name, string group, bool isManual, ManualResourceLoader loader, NameValuePairList loadParams, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepare__SWIG_0(swigCPtr, resType, name, group, isManual, ManualResourceLoader.getCPtr(loader), NameValuePairList.getCPtr(loadParams), ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepare(string resType, string name, string group, bool isManual, ManualResourceLoader loader, NameValuePairList loadParams) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepare__SWIG_1(swigCPtr, resType, name, group, isManual, ManualResourceLoader.getCPtr(loader), NameValuePairList.getCPtr(loadParams)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepare(string resType, string name, string group, bool isManual, ManualResourceLoader loader) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepare__SWIG_2(swigCPtr, resType, name, group, isManual, ManualResourceLoader.getCPtr(loader)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepare(string resType, string name, string group, bool isManual) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepare__SWIG_3(swigCPtr, resType, name, group, isManual), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID prepare(string resType, string name, string group) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_prepare__SWIG_4(swigCPtr, resType, name, group), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID load(string resType, string name, string group, bool isManual, ManualResourceLoader loader, NameValuePairList loadParams, ResourceBackgroundQueue.Listener listener) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_load__SWIG_0(swigCPtr, resType, name, group, isManual, ManualResourceLoader.getCPtr(loader), NameValuePairList.getCPtr(loadParams), ResourceBackgroundQueue.Listener.getCPtr(listener)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID load(string resType, string name, string group, bool isManual, ManualResourceLoader loader, NameValuePairList loadParams) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_load__SWIG_1(swigCPtr, resType, name, group, isManual, ManualResourceLoader.getCPtr(loader), NameValuePairList.getCPtr(loadParams)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID load(string resType, string name, string group, bool isManual, ManualResourceLoader loader) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_load__SWIG_2(swigCPtr, resType, name, group, isManual, ManualResourceLoader.getCPtr(loader)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID load(string resType, string name, string group, bool isManual) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_load__SWIG_3(swigCPtr, resType, name, group, isManual), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__WorkQueue__RequestID load(string resType, string name, string group) {
    SWIGTYPE_p_Ogre__WorkQueue__RequestID ret = new SWIGTYPE_p_Ogre__WorkQueue__RequestID(OgrePINVOKE.ResourceBackgroundQueue_load__SWIG_4(swigCPtr, resType, name, group), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isProcessComplete(SWIGTYPE_p_Ogre__WorkQueue__RequestID ticket) {
    bool ret = OgrePINVOKE.ResourceBackgroundQueue_isProcessComplete(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__RequestID.getCPtr(ticket));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void abortRequest(SWIGTYPE_p_Ogre__WorkQueue__RequestID ticket) {
    OgrePINVOKE.ResourceBackgroundQueue_abortRequest(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__RequestID.getCPtr(ticket));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool canHandleRequest(SWIGTYPE_p_Ogre__WorkQueue__Request req, SWIGTYPE_p_Ogre__WorkQueue srcQ) {
    bool ret = OgrePINVOKE.ResourceBackgroundQueue_canHandleRequest(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__Request.getCPtr(req), SWIGTYPE_p_Ogre__WorkQueue.getCPtr(srcQ));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__WorkQueue__Response handleRequest(SWIGTYPE_p_Ogre__WorkQueue__Request req, SWIGTYPE_p_Ogre__WorkQueue srcQ) {
    global::System.IntPtr cPtr = OgrePINVOKE.ResourceBackgroundQueue_handleRequest(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__Request.getCPtr(req), SWIGTYPE_p_Ogre__WorkQueue.getCPtr(srcQ));
    SWIGTYPE_p_Ogre__WorkQueue__Response ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__WorkQueue__Response(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool canHandleResponse(SWIGTYPE_p_Ogre__WorkQueue__Response res, SWIGTYPE_p_Ogre__WorkQueue srcQ) {
    bool ret = OgrePINVOKE.ResourceBackgroundQueue_canHandleResponse(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__Response.getCPtr(res), SWIGTYPE_p_Ogre__WorkQueue.getCPtr(srcQ));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void handleResponse(SWIGTYPE_p_Ogre__WorkQueue__Response res, SWIGTYPE_p_Ogre__WorkQueue srcQ) {
    OgrePINVOKE.ResourceBackgroundQueue_handleResponse(swigCPtr, SWIGTYPE_p_Ogre__WorkQueue__Response.getCPtr(res), SWIGTYPE_p_Ogre__WorkQueue.getCPtr(srcQ));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ResourceBackgroundQueue getSingleton() {
    ResourceBackgroundQueue ret = new ResourceBackgroundQueue(OgrePINVOKE.ResourceBackgroundQueue_getSingleton(), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}