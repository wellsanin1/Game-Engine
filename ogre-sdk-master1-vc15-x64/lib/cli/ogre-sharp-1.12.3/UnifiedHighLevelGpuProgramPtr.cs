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

public class UnifiedHighLevelGpuProgramPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnifiedHighLevelGpuProgramPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnifiedHighLevelGpuProgramPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnifiedHighLevelGpuProgramPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_UnifiedHighLevelGpuProgramPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UnifiedHighLevelGpuProgramPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_UnifiedHighLevelGpuProgramPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public UnifiedHighLevelGpuProgramPtr() : this(OgrePINVOKE.new_UnifiedHighLevelGpuProgramPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public UnifiedHighLevelGpuProgramPtr(UnifiedHighLevelGpuProgramPtr r) : this(OgrePINVOKE.new_UnifiedHighLevelGpuProgramPtr__SWIG_2(UnifiedHighLevelGpuProgramPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public UnifiedHighLevelGpuProgram __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr___deref__(swigCPtr);
    UnifiedHighLevelGpuProgram ret = (cPtr == global::System.IntPtr.Zero) ? null : new UnifiedHighLevelGpuProgram(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPriority(string shaderLanguage, int priority) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setPriority(swigCPtr, shaderLanguage, priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public int getPriority(string shaderLanguage) {
    int ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getPriority(swigCPtr, shaderLanguage);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint calculateSize() {
    uint ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_calculateSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addDelegateProgram(string name) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_addDelegateProgram(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearDelegatePrograms() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_clearDelegatePrograms(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HighLevelGpuProgramPtr _getDelegate() {
    HighLevelGpuProgramPtr ret = new HighLevelGpuProgramPtr(OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__getDelegate(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getLanguage() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getLanguage(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t createParameters() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t(OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_createParameters(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GpuProgram _getBindingDelegate() {
    global::System.IntPtr cPtr = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__getBindingDelegate(swigCPtr);
    GpuProgram ret = (cPtr == global::System.IntPtr.Zero) ? null : new GpuProgram(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isSupported() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isSupported(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isSkeletalAnimationIncluded() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isSkeletalAnimationIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isMorphAnimationIncluded() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isMorphAnimationIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isPoseAnimationIncluded() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isPoseAnimationIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumberOfPosesIncluded() {
    ushort ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getNumberOfPosesIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isVertexTextureFetchRequired() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isVertexTextureFetchRequired(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t getDefaultParameters() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t(OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getDefaultParameters(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasDefaultParameters() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_hasDefaultParameters(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getPassSurfaceAndLightStates() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getPassSurfaceAndLightStates(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getPassFogStates() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getPassFogStates(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getPassTransformStates() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getPassTransformStates(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasCompileError() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_hasCompileError(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resetCompileError() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_resetCompileError(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load(bool backgroundThread) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_load__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_load__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload(Resource.LoadingFlags flags) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_reload__SWIG_0(swigCPtr, (int)flags);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_reload__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isReloadable() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isReloadable(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoaded() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoading() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Resource.LoadingState getLoadingState() {
    Resource.LoadingState ret = (Resource.LoadingState)OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getLoadingState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unload() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_unload(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSize() {
    uint ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void touch() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_touch(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isBackgroundLoaded() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isBackgroundLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBackgroundLoaded(bool bl) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setBackgroundLoaded(swigCPtr, bl);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void escalateLoading() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_escalateLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addListener(Resource.Listener lis) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_addListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(Resource.Listener lis) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_removeListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public GpuNamedConstants getConstantDefinitions() {
    GpuNamedConstants ret = new GpuNamedConstants(OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getConstantDefinitions(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPreprocessorDefines(string defines) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setPreprocessorDefines(swigCPtr, defines);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getPreprocessorDefines() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getPreprocessorDefines(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string _resolveIncludes(string source, Resource resourceBeingLoaded, string fileName) {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__resolveIncludes(swigCPtr, source, Resource.getCPtr(resourceBeingLoaded), fileName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getProgramTypeName(GpuProgramType programType) {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getProgramTypeName(swigCPtr, (int)programType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSourceFile(string filename) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setSourceFile(swigCPtr, filename);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSource(string source) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setSource(swigCPtr, source);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getSyntaxCode() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getSyntaxCode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSyntaxCode(string syntax) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setSyntaxCode(swigCPtr, syntax);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getSourceFile() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getSourceFile(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getSource() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getSource(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setType(GpuProgramType t) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setType(swigCPtr, (int)t);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public GpuProgramType getType() {
    GpuProgramType ret = (GpuProgramType)OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSkeletalAnimationIncluded(bool included) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setSkeletalAnimationIncluded(swigCPtr, included);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMorphAnimationIncluded(bool included) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setMorphAnimationIncluded(swigCPtr, included);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPoseAnimationIncluded(ushort poseCount) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setPoseAnimationIncluded(swigCPtr, poseCount);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVertexTextureFetchRequired(bool r) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setVertexTextureFetchRequired(swigCPtr, r);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAdjacencyInfoRequired(bool r) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setAdjacencyInfoRequired(swigCPtr, r);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isAdjacencyInfoRequired() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isAdjacencyInfoRequired(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setComputeGroupDimensions(Vector3 dimensions) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setComputeGroupDimensions(swigCPtr, Vector3.getCPtr(dimensions));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3 getComputeGroupDimensions() {
    Vector3 ret = new Vector3(OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getComputeGroupDimensions(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setManualNamedConstants(GpuNamedConstants namedConstants) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setManualNamedConstants(swigCPtr, GpuNamedConstants.getCPtr(namedConstants));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setManualNamedConstantsFile(string paramDefFile) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setManualNamedConstantsFile(swigCPtr, paramDefFile);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getManualNamedConstantsFile() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getManualNamedConstantsFile(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint _getHash(uint seed) {
    uint ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__getHash__SWIG_0(swigCPtr, seed);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint _getHash() {
    uint ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__getHash__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void prepare(bool backgroundThread) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_prepare__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_prepare__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isManuallyLoaded() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isManuallyLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getName() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong getHandle() {
    ulong ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isPrepared() {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_isPrepared(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getGroup() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void changeGroupOwnership(string newGroup) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_changeGroupOwnership(swigCPtr, newGroup);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ResourceManager getCreator() {
    global::System.IntPtr cPtr = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getCreator(swigCPtr);
    ResourceManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceManager(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getOrigin() {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getOrigin(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyOrigin(string origin) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__notifyOrigin(swigCPtr, origin);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getStateCount() {
    uint ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getStateCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _dirtyState() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__dirtyState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete(bool wasBackgroundLoaded) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__fireLoadingComplete(swigCPtr, wasBackgroundLoaded);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete(bool wasBackgroundLoaded) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__firePreparingComplete(swigCPtr, wasBackgroundLoaded);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireUnloadingComplete() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr__fireUnloadingComplete(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t getParameters() {
    SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t ret = new SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t(OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getParameters(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setParameter(swigCPtr, name, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValuePairList paramList) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_setParameterList(swigCPtr, NameValuePairList.getCPtr(paramList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_getParameter(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgrePINVOKE.UnifiedHighLevelGpuProgramPtr_cleanupDictionary(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
