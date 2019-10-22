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

public class PatchSurface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PatchSurface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PatchSurface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PatchSurface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_PatchSurface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PatchSurface() : this(OgrePINVOKE.new_PatchSurface(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defineSurface(SWIGTYPE_p_void controlPointBuffer, VertexDeclaration declaration, uint width, uint height, PatchSurface.PatchSurfaceType pType, uint uMaxSubdivisionLevel, uint vMaxSubdivisionLevel, PatchSurface.VisibleSide visibleSide) {
    OgrePINVOKE.PatchSurface_defineSurface__SWIG_0(swigCPtr, SWIGTYPE_p_void.getCPtr(controlPointBuffer), VertexDeclaration.getCPtr(declaration), width, height, (int)pType, uMaxSubdivisionLevel, vMaxSubdivisionLevel, (int)visibleSide);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defineSurface(SWIGTYPE_p_void controlPointBuffer, VertexDeclaration declaration, uint width, uint height, PatchSurface.PatchSurfaceType pType, uint uMaxSubdivisionLevel, uint vMaxSubdivisionLevel) {
    OgrePINVOKE.PatchSurface_defineSurface__SWIG_1(swigCPtr, SWIGTYPE_p_void.getCPtr(controlPointBuffer), VertexDeclaration.getCPtr(declaration), width, height, (int)pType, uMaxSubdivisionLevel, vMaxSubdivisionLevel);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defineSurface(SWIGTYPE_p_void controlPointBuffer, VertexDeclaration declaration, uint width, uint height, PatchSurface.PatchSurfaceType pType, uint uMaxSubdivisionLevel) {
    OgrePINVOKE.PatchSurface_defineSurface__SWIG_2(swigCPtr, SWIGTYPE_p_void.getCPtr(controlPointBuffer), VertexDeclaration.getCPtr(declaration), width, height, (int)pType, uMaxSubdivisionLevel);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defineSurface(SWIGTYPE_p_void controlPointBuffer, VertexDeclaration declaration, uint width, uint height, PatchSurface.PatchSurfaceType pType) {
    OgrePINVOKE.PatchSurface_defineSurface__SWIG_3(swigCPtr, SWIGTYPE_p_void.getCPtr(controlPointBuffer), VertexDeclaration.getCPtr(declaration), width, height, (int)pType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defineSurface(SWIGTYPE_p_void controlPointBuffer, VertexDeclaration declaration, uint width, uint height) {
    OgrePINVOKE.PatchSurface_defineSurface__SWIG_4(swigCPtr, SWIGTYPE_p_void.getCPtr(controlPointBuffer), VertexDeclaration.getCPtr(declaration), width, height);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getRequiredVertexCount() {
    uint ret = OgrePINVOKE.PatchSurface_getRequiredVertexCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getRequiredIndexCount() {
    uint ret = OgrePINVOKE.PatchSurface_getRequiredIndexCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getCurrentIndexCount() {
    uint ret = OgrePINVOKE.PatchSurface_getCurrentIndexCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getIndexOffset() {
    uint ret = OgrePINVOKE.PatchSurface_getIndexOffset(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getVertexOffset() {
    uint ret = OgrePINVOKE.PatchSurface_getVertexOffset(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AxisAlignedBox getBounds() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.PatchSurface_getBounds(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getBoundingSphereRadius() {
    float ret = OgrePINVOKE.PatchSurface_getBoundingSphereRadius(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void build(HardwareVertexBufferPtr destVertexBuffer, uint vertexStart, HardwareIndexBufferPtr destIndexBuffer, uint indexStart) {
    OgrePINVOKE.PatchSurface_build(swigCPtr, HardwareVertexBufferPtr.getCPtr(destVertexBuffer), vertexStart, HardwareIndexBufferPtr.getCPtr(destIndexBuffer), indexStart);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSubdivisionFactor(float factor) {
    OgrePINVOKE.PatchSurface_setSubdivisionFactor(swigCPtr, factor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getSubdivisionFactor() {
    float ret = OgrePINVOKE.PatchSurface_getSubdivisionFactor(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void getControlPointBuffer() {
    global::System.IntPtr cPtr = OgrePINVOKE.PatchSurface_getControlPointBuffer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void notifyControlPointBufferDeallocated() {
    OgrePINVOKE.PatchSurface_notifyControlPointBufferDeallocated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum PatchSurfaceType {
    PST_BEZIER
  }

  public static readonly int AUTO_LEVEL = OgrePINVOKE.PatchSurface_AUTO_LEVEL_get();

  public enum VisibleSide {
    VS_FRONT,
    VS_BACK,
    VS_BOTH
  }

}

}
