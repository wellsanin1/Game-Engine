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

public class GpuProgram : Resource {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal GpuProgram(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.GpuProgram_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GpuProgram obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GpuProgram() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_GpuProgram(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static string getProgramTypeName(GpuProgramType programType) {
    string ret = OgrePINVOKE.GpuProgram_getProgramTypeName((int)programType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSourceFile(string filename) {
    OgrePINVOKE.GpuProgram_setSourceFile(swigCPtr, filename);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSource(string source) {
    OgrePINVOKE.GpuProgram_setSource(swigCPtr, source);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getSyntaxCode() {
    string ret = OgrePINVOKE.GpuProgram_getSyntaxCode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSyntaxCode(string syntax) {
    OgrePINVOKE.GpuProgram_setSyntaxCode(swigCPtr, syntax);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getSourceFile() {
    string ret = OgrePINVOKE.GpuProgram_getSourceFile(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getSource() {
    string ret = OgrePINVOKE.GpuProgram_getSource(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setType(GpuProgramType t) {
    OgrePINVOKE.GpuProgram_setType(swigCPtr, (int)t);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public GpuProgramType getType() {
    GpuProgramType ret = (GpuProgramType)OgrePINVOKE.GpuProgram_getType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual GpuProgram _getBindingDelegate() {
    global::System.IntPtr cPtr = OgrePINVOKE.GpuProgram__getBindingDelegate(swigCPtr);
    GpuProgram ret = (cPtr == global::System.IntPtr.Zero) ? null : new GpuProgram(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isSupported() {
    bool ret = OgrePINVOKE.GpuProgram_isSupported(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t createParameters() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t(OgrePINVOKE.GpuProgram_createParameters(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setSkeletalAnimationIncluded(bool included) {
    OgrePINVOKE.GpuProgram_setSkeletalAnimationIncluded(swigCPtr, included);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isSkeletalAnimationIncluded() {
    bool ret = OgrePINVOKE.GpuProgram_isSkeletalAnimationIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setMorphAnimationIncluded(bool included) {
    OgrePINVOKE.GpuProgram_setMorphAnimationIncluded(swigCPtr, included);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setPoseAnimationIncluded(ushort poseCount) {
    OgrePINVOKE.GpuProgram_setPoseAnimationIncluded(swigCPtr, poseCount);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isMorphAnimationIncluded() {
    bool ret = OgrePINVOKE.GpuProgram_isMorphAnimationIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isPoseAnimationIncluded() {
    bool ret = OgrePINVOKE.GpuProgram_isPoseAnimationIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort getNumberOfPosesIncluded() {
    ushort ret = OgrePINVOKE.GpuProgram_getNumberOfPosesIncluded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setVertexTextureFetchRequired(bool r) {
    OgrePINVOKE.GpuProgram_setVertexTextureFetchRequired(swigCPtr, r);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isVertexTextureFetchRequired() {
    bool ret = OgrePINVOKE.GpuProgram_isVertexTextureFetchRequired(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setAdjacencyInfoRequired(bool r) {
    OgrePINVOKE.GpuProgram_setAdjacencyInfoRequired(swigCPtr, r);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isAdjacencyInfoRequired() {
    bool ret = OgrePINVOKE.GpuProgram_isAdjacencyInfoRequired(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setComputeGroupDimensions(Vector3 dimensions) {
    OgrePINVOKE.GpuProgram_setComputeGroupDimensions(swigCPtr, Vector3.getCPtr(dimensions));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Vector3 getComputeGroupDimensions() {
    Vector3 ret = new Vector3(OgrePINVOKE.GpuProgram_getComputeGroupDimensions(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t getDefaultParameters() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__GpuProgramParameters_t(OgrePINVOKE.GpuProgram_getDefaultParameters(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasDefaultParameters() {
    bool ret = OgrePINVOKE.GpuProgram_hasDefaultParameters(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getPassSurfaceAndLightStates() {
    bool ret = OgrePINVOKE.GpuProgram_getPassSurfaceAndLightStates(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getPassFogStates() {
    bool ret = OgrePINVOKE.GpuProgram_getPassFogStates(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getPassTransformStates() {
    bool ret = OgrePINVOKE.GpuProgram_getPassTransformStates(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string getLanguage() {
    string ret = OgrePINVOKE.GpuProgram_getLanguage(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasCompileError() {
    bool ret = OgrePINVOKE.GpuProgram_hasCompileError(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void resetCompileError() {
    OgrePINVOKE.GpuProgram_resetCompileError(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setManualNamedConstants(GpuNamedConstants namedConstants) {
    OgrePINVOKE.GpuProgram_setManualNamedConstants(swigCPtr, GpuNamedConstants.getCPtr(namedConstants));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setManualNamedConstantsFile(string paramDefFile) {
    OgrePINVOKE.GpuProgram_setManualNamedConstantsFile(swigCPtr, paramDefFile);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getManualNamedConstantsFile() {
    string ret = OgrePINVOKE.GpuProgram_getManualNamedConstantsFile(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual GpuNamedConstants getConstantDefinitions() {
    GpuNamedConstants ret = new GpuNamedConstants(OgrePINVOKE.GpuProgram_getConstantDefinitions(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint calculateSize() {
    uint ret = OgrePINVOKE.GpuProgram_calculateSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint _getHash(uint seed) {
    uint ret = OgrePINVOKE.GpuProgram__getHash__SWIG_0(swigCPtr, seed);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint _getHash() {
    uint ret = OgrePINVOKE.GpuProgram__getHash__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
