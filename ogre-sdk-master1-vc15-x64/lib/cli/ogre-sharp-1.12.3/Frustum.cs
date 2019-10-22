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

public class Frustum : MovableObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Frustum(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Frustum_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Frustum obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Frustum() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Frustum(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Frustum(string name) : this(OgrePINVOKE.new_Frustum__SWIG_0(name), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Frustum() : this(OgrePINVOKE.new_Frustum__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFOVy(Radian fovy) {
    OgrePINVOKE.Frustum_setFOVy(swigCPtr, Radian.getCPtr(fovy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Radian getFOVy() {
    Radian ret = new Radian(OgrePINVOKE.Frustum_getFOVy(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNearClipDistance(float nearDist) {
    OgrePINVOKE.Frustum_setNearClipDistance(swigCPtr, nearDist);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getNearClipDistance() {
    float ret = OgrePINVOKE.Frustum_getNearClipDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFarClipDistance(float farDist) {
    OgrePINVOKE.Frustum_setFarClipDistance(swigCPtr, farDist);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getFarClipDistance() {
    float ret = OgrePINVOKE.Frustum_getFarClipDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAspectRatio(float ratio) {
    OgrePINVOKE.Frustum_setAspectRatio(swigCPtr, ratio);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getAspectRatio() {
    float ret = OgrePINVOKE.Frustum_getAspectRatio(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFrustumOffset(Vector2 offset) {
    OgrePINVOKE.Frustum_setFrustumOffset__SWIG_0(swigCPtr, Vector2.getCPtr(offset));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFrustumOffset(float horizontal, float vertical) {
    OgrePINVOKE.Frustum_setFrustumOffset__SWIG_1(swigCPtr, horizontal, vertical);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFrustumOffset(float horizontal) {
    OgrePINVOKE.Frustum_setFrustumOffset__SWIG_2(swigCPtr, horizontal);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFrustumOffset() {
    OgrePINVOKE.Frustum_setFrustumOffset__SWIG_3(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 getFrustumOffset() {
    Vector2 ret = new Vector2(OgrePINVOKE.Frustum_getFrustumOffset(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFocalLength(float focalLength) {
    OgrePINVOKE.Frustum_setFocalLength__SWIG_0(swigCPtr, focalLength);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFocalLength() {
    OgrePINVOKE.Frustum_setFocalLength__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getFocalLength() {
    float ret = OgrePINVOKE.Frustum_getFocalLength(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFrustumExtents(float left, float right, float top, float bottom) {
    OgrePINVOKE.Frustum_setFrustumExtents(swigCPtr, left, right, top, bottom);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetFrustumExtents() {
    OgrePINVOKE.Frustum_resetFrustumExtents(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatRect getFrustumExtents() {
    FloatRect ret = new FloatRect(OgrePINVOKE.Frustum_getFrustumExtents(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 getProjectionMatrixRS() {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Frustum_getProjectionMatrixRS(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 getProjectionMatrixWithRSDepth() {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Frustum_getProjectionMatrixWithRSDepth(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 getProjectionMatrix() {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Frustum_getProjectionMatrix(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Affine3 getViewMatrix() {
    Affine3 ret = new Affine3(OgrePINVOKE.Frustum_getViewMatrix(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void calcViewMatrixRelative(Vector3 relPos, Matrix4 matToUpdate) {
    OgrePINVOKE.Frustum_calcViewMatrixRelative(swigCPtr, Vector3.getCPtr(relPos), Matrix4.getCPtr(matToUpdate));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCustomViewMatrix(bool enable, Affine3 viewMatrix) {
    OgrePINVOKE.Frustum_setCustomViewMatrix__SWIG_0(swigCPtr, enable, Affine3.getCPtr(viewMatrix));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCustomViewMatrix(bool enable) {
    OgrePINVOKE.Frustum_setCustomViewMatrix__SWIG_1(swigCPtr, enable);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isCustomViewMatrixEnabled() {
    bool ret = OgrePINVOKE.Frustum_isCustomViewMatrixEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCustomProjectionMatrix(bool enable, Matrix4 projectionMatrix) {
    OgrePINVOKE.Frustum_setCustomProjectionMatrix__SWIG_0(swigCPtr, enable, Matrix4.getCPtr(projectionMatrix));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCustomProjectionMatrix(bool enable) {
    OgrePINVOKE.Frustum_setCustomProjectionMatrix__SWIG_1(swigCPtr, enable);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isCustomProjectionMatrixEnabled() {
    bool ret = OgrePINVOKE.Frustum_isCustomProjectionMatrixEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Plane getFrustumPlanes() {
    global::System.IntPtr cPtr = OgrePINVOKE.Frustum_getFrustumPlanes(swigCPtr);
    Plane ret = (cPtr == global::System.IntPtr.Zero) ? null : new Plane(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Plane getFrustumPlane(ushort plane) {
    Plane ret = new Plane(OgrePINVOKE.Frustum_getFrustumPlane(swigCPtr, plane), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isVisible() {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_0_0(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(AxisAlignedBox bound, SWIGTYPE_p_Ogre__FrustumPlane culledBy) {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_1(swigCPtr, AxisAlignedBox.getCPtr(bound), SWIGTYPE_p_Ogre__FrustumPlane.getCPtr(culledBy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(AxisAlignedBox bound) {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_2(swigCPtr, AxisAlignedBox.getCPtr(bound));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(Sphere bound, SWIGTYPE_p_Ogre__FrustumPlane culledBy) {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_3(swigCPtr, Sphere.getCPtr(bound), SWIGTYPE_p_Ogre__FrustumPlane.getCPtr(culledBy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(Sphere bound) {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_4(swigCPtr, Sphere.getCPtr(bound));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(Vector3 vert, SWIGTYPE_p_Ogre__FrustumPlane culledBy) {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_5(swigCPtr, Vector3.getCPtr(vert), SWIGTYPE_p_Ogre__FrustumPlane.getCPtr(culledBy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(Vector3 vert) {
    bool ret = OgrePINVOKE.Frustum_isVisible__SWIG_6(swigCPtr, Vector3.getCPtr(vert));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTypeFlags() {
    uint ret = OgrePINVOKE.Frustum_getTypeFlags(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AxisAlignedBox getBoundingBox() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.Frustum_getBoundingBox(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getBoundingRadius() {
    float ret = OgrePINVOKE.Frustum_getBoundingRadius(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _updateRenderQueue(RenderQueue queue) {
    OgrePINVOKE.Frustum__updateRenderQueue(swigCPtr, RenderQueue.getCPtr(queue));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getMovableType() {
    string ret = OgrePINVOKE.Frustum_getMovableType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyCurrentCamera(Camera cam) {
    OgrePINVOKE.Frustum__notifyCurrentCamera(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterial(MaterialPtr mat) {
    OgrePINVOKE.Frustum_setMaterial(swigCPtr, MaterialPtr.getCPtr(mat));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public MaterialPtr getMaterial() {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.Frustum_getMaterial(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getRenderOperation(RenderOperation op) {
    OgrePINVOKE.Frustum_getRenderOperation(swigCPtr, RenderOperation.getCPtr(op));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getWorldTransforms(Matrix4 xform) {
    OgrePINVOKE.Frustum_getWorldTransforms(swigCPtr, Matrix4.getCPtr(xform));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getSquaredViewDepth(Camera cam) {
    float ret = OgrePINVOKE.Frustum_getSquaredViewDepth(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t getLights() {
    SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t ret = new SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t(OgrePINVOKE.Frustum_getLights(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Vector3 getWorldSpaceCorners() {
    global::System.IntPtr cPtr = OgrePINVOKE.Frustum_getWorldSpaceCorners(swigCPtr);
    Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setProjectionType(ProjectionType pt) {
    OgrePINVOKE.Frustum_setProjectionType(swigCPtr, (int)pt);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ProjectionType getProjectionType() {
    ProjectionType ret = (ProjectionType)OgrePINVOKE.Frustum_getProjectionType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setOrthoWindow(float w, float h) {
    OgrePINVOKE.Frustum_setOrthoWindow(swigCPtr, w, h);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOrthoWindowHeight(float h) {
    OgrePINVOKE.Frustum_setOrthoWindowHeight(swigCPtr, h);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOrthoWindowWidth(float w) {
    OgrePINVOKE.Frustum_setOrthoWindowWidth(swigCPtr, w);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getOrthoWindowHeight() {
    float ret = OgrePINVOKE.Frustum_getOrthoWindowHeight(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getOrthoWindowWidth() {
    float ret = OgrePINVOKE.Frustum_getOrthoWindowWidth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableReflection(Plane p) {
    OgrePINVOKE.Frustum_enableReflection__SWIG_0(swigCPtr, Plane.getCPtr(p));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableReflection(MovablePlane p) {
    OgrePINVOKE.Frustum_enableReflection__SWIG_1(swigCPtr, MovablePlane.getCPtr(p));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableReflection() {
    OgrePINVOKE.Frustum_disableReflection(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isReflected() {
    bool ret = OgrePINVOKE.Frustum_isReflected(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Affine3 getReflectionMatrix() {
    Affine3 ret = new Affine3(OgrePINVOKE.Frustum_getReflectionMatrix(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Plane getReflectionPlane() {
    Plane ret = new Plane(OgrePINVOKE.Frustum_getReflectionPlane(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool projectSphere(Sphere sphere, SWIGTYPE_p_float left, SWIGTYPE_p_float top, SWIGTYPE_p_float right, SWIGTYPE_p_float bottom) {
    bool ret = OgrePINVOKE.Frustum_projectSphere(swigCPtr, Sphere.getCPtr(sphere), SWIGTYPE_p_float.getCPtr(left), SWIGTYPE_p_float.getCPtr(top), SWIGTYPE_p_float.getCPtr(right), SWIGTYPE_p_float.getCPtr(bottom));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableCustomNearClipPlane(MovablePlane plane) {
    OgrePINVOKE.Frustum_enableCustomNearClipPlane__SWIG_0(swigCPtr, MovablePlane.getCPtr(plane));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableCustomNearClipPlane(Plane plane) {
    OgrePINVOKE.Frustum_enableCustomNearClipPlane__SWIG_1(swigCPtr, Plane.getCPtr(plane));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableCustomNearClipPlane() {
    OgrePINVOKE.Frustum_disableCustomNearClipPlane(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isCustomNearClipPlaneEnabled() {
    bool ret = OgrePINVOKE.Frustum_isCustomNearClipPlaneEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void visitRenderables(Renderable.Visitor visitor, bool debugRenderables) {
    OgrePINVOKE.Frustum_visitRenderables__SWIG_0(swigCPtr, Renderable.Visitor.getCPtr(visitor), debugRenderables);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor) {
    OgrePINVOKE.Frustum_visitRenderables__SWIG_1(swigCPtr, Renderable.Visitor.getCPtr(visitor));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static float INFINITE_FAR_PLANE_ADJUST {
    get {
      float ret = OgrePINVOKE.Frustum_INFINITE_FAR_PLANE_ADJUST_get();
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public virtual Vector3 getPositionForViewUpdate() {
    Vector3 ret = new Vector3(OgrePINVOKE.Frustum_getPositionForViewUpdate(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Quaternion getOrientationForViewUpdate() {
    Quaternion ret = new Quaternion(OgrePINVOKE.Frustum_getOrientationForViewUpdate(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlaneBoundedVolume getPlaneBoundedVolume() {
    PlaneBoundedVolume ret = new PlaneBoundedVolume(OgrePINVOKE.Frustum_getPlaneBoundedVolume(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setOrientationMode(OrientationMode orientationMode) {
    OgrePINVOKE.Frustum_setOrientationMode(swigCPtr, (int)orientationMode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public OrientationMode getOrientationMode() {
    OrientationMode ret = (OrientationMode)OgrePINVOKE.Frustum_getOrientationMode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
